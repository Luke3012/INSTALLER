Imports System.IO
Imports System.Net

Public Class nuovoaggiornamento
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Panel2.MouseDown, formicon.MouseDown, TitleText.MouseDown, Me.MouseDown, updatingpanel.MouseDown, donepanel.MouseDown, Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Panel2.MouseMove, formicon.MouseMove, TitleText.MouseMove, Me.MouseMove, updatingpanel.MouseMove, donepanel.MouseMove, Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Panel2.MouseUp, formicon.MouseUp, TitleText.MouseUp, Me.MouseUp, updatingpanel.MouseUp, donepanel.MouseUp, Panel1.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub nuovoaggiornamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor

        'Per animazione
        labelversion.Text = "Versione " & impostaaggiornamento.determinaversione(newinstallerversion)
        Label1.Text = labelversion.Text
        p2 = Panel2.Height
        pgt = panelgoto.Height

        If silent = False Then
            Panel2.Height = 0
            panelgoto.Height = 0
            Timer1.Start()
        Else
            'updatebtn.PerformClick()
        End If
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        quandoaggiorna.Close()
        quandoaggiorna.ShowDialog()
        chiudisino = True
        Close()
    End Sub

    Private changelogread As Boolean = False
    Public newinstallerversion As Integer
    Public Async Sub updateinstaller()
        chiudisino = False
        Dim errore As Boolean = False

        If silent = False Then
            Dim taskcheck As New Task(Sub()
                                          Try
                                              My.Computer.Network.Ping("google.com")
                                          Catch
                                              errore = True
                                          End Try
                                      End Sub)
            taskcheck.Start()
            Await taskcheck

            If errore = True Then
                MsgBox("Si è verificato un errore durante il collegamento a Internet, riprova.", MsgBoxStyle.Exclamation, "Aggiornamento fallito")
                iferror()
                Exit Sub
            End If
        End If

        stato.Text = "Recupero informazioni link ..."
        Dim link As String = ""
        Dim tasklink As New Task(Sub()
                                     Try
                                         Dim client As WebClient = New WebClient
                                         link = client.DownloadString(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gqo2QYV0w6leoIksww/root/content"))
                                     Catch
                                     End Try
                                 End Sub)
        tasklink.Start()
        Await tasklink
        'Link di BACKUP
        If link = "" Then link = "https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gpNZLbwBWTHpjPZ85w/root/content"

        stato.Text = "Download in Corso ..."
        Dim task As New Task(Sub()
                                 Try
                                     Dim client As WebClient = New WebClient
                                     client.DownloadFile(New Uri(link), Application.StartupPath & "\INSTALLERupdate")
                                 Catch
                                     errore = True
                                 End Try
                             End Sub)
        task.Start()
        Await task

        Dim myFile As New FileInfo(Application.StartupPath & "\INSTALLERupdate")

        If errore = True Or myFile.Length < 1000 Then
            If silent = False Then MsgBox("Si è verificato un errore durante il download di INSTALLER! Riprova più tardi.", MsgBoxStyle.Critical, "Errore")
            If File.Exists(Application.StartupPath & "\INSTALLERupdate") Then File.Delete(Application.StartupPath & "\INSTALLERupdate")
            iferror()
            Exit Sub
        End If

        If Welcome16.Visible = True Then changelogread = True
        Dim versioncodebackup As String = impostaaggiornamento.LeggiOpzione("", "versionbefore")

        Dim taskf As New Task(Sub()
                                  Try
                                      impostaaggiornamento.SalvaOpzione("", "versionbefore", impostaaggiornamento.versioncode, False)
                                      If changelogread = False Then impostaaggiornamento.SalvaOpzione("", "changelogread", "true", False)
                                      File.WriteAllText(Application.StartupPath & "\updateinstaller.bat", "taskkill /F /IM """ & Path.GetFileName(Application.ExecutablePath) & """ & if exist INSTALLERupdate del """ & Path.GetFileName(Application.ExecutablePath) & """ & rename INSTALLERupdate """ & Path.GetFileName(Application.ExecutablePath) & """ & start """" """ & Path.GetFileName(Application.ExecutablePath) & """", System.Text.Encoding.Default)
                                  Catch
                                      errore = True
                                  End Try
                              End Sub)
        taskf.Start()
        Await taskf

        If errore = True Then
            If silent = False Then MsgBox("Si è verificato un errore durante la scrittura dei file di aggiornamento. Per favore, prova a forzare lo scaricamento del database dalle Impostazioni e riprova. ", MsgBoxStyle.Exclamation, "Aggiornamento fallito")
            If File.Exists(Application.StartupPath & "\INSTALLERupdate") Then File.Delete(Application.StartupPath & "\INSTALLERupdate")
            impostaaggiornamento.SalvaOpzione("", "versionbefore", "", True)
            If changelogread = False Then impostaaggiornamento.SalvaOpzione("", "changelogread", "", True)
            If versioncodebackup <> "" Then impostaaggiornamento.SalvaOpzione("", "versionbefore", versioncodebackup, False)
            iferror()
            Exit Sub
        End If

        chiudisino = True

        If silent = False Then
            donepanel.Visible = True
            Panel2.Visible = False
            updatingpanel.Visible = False
        Else
            'codice per welcome
            impostaaggiornamento.modalita(2)
        End If

        aspetta.Start()
    End Sub

    Private Sub iferror()
        chiudisino = True

        If silent = False Then
            Try
                Dim frm As Form
                For Each frm In visibleforms
                    frm.Visible = True
                Next
            Catch
            End Try

            mode = 0
            updatingpanel.Visible = False
            Panel1.Visible = True
            Timer1.Start()
        Else
            impostaaggiornamento.modalita(1)
            Close()
        End If
    End Sub

    Private Sub updatebtn_MouseLeave() Handles updatebtn.MouseLeave
        updatelbl.Font = New Font(updatelbl.Font, FontStyle.Regular)
    End Sub
    Private Sub updatebtn_MouseEnter() Handles updatebtn.MouseEnter
        updatelbl.Font = New Font(updatelbl.Font, FontStyle.Bold)
    End Sub

    Dim visibleforms As New List(Of Form)
    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            visibleforms.Clear()
        Catch
        End Try

        Dim frm As Form
        For Each frm In Application.OpenForms
            If frm.Name <> Name Then
                If frm.Visible = True Then
                    visibleforms.Add(frm)
                    frm.Visible = False
                End If
            End If
        Next

        closebutton.Enabled = False
        updatebtn.Enabled = False
        whatchangebtn.Enabled = False
        mode = 1
        stato.Text = "Aggiornamento in corso..."
        updatingpanel.Visible = True
        Panel1.Visible = False
        Timer1.Start()

        updateinstaller()
    End Sub

    Dim p2 As Integer
    Dim pgt As Integer
    Dim mode As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mode = 0 Then
            If panelgoto.Height < pgt Or Panel2.Height < p2 Then
                If panelgoto.Height < pgt Then panelgoto.Height += 5
                If Panel2.Height < p2 Then Panel2.Height += 5
                Return
            End If

            Panel2.Height = p2
            panelgoto.Height = pgt
            updatebtn.Enabled = True
            whatchangebtn.Enabled = True
            closebutton.Enabled = True
            Timer1.Stop()
        ElseIf mode = 1 Then
            If panelgoto.Height > 0 Or Panel2.Height > 0 Then
                If panelgoto.Height > 0 Then panelgoto.Height -= 5
                Return
            End If

            panelgoto.Height = 0
            Timer1.Stop()
        End If
    End Sub

    Public silent As Boolean = False

    Private Sub whatchangebtn_Click(sender As Object, e As EventArgs) Handles whatchangebtn.Click
        changelogread = True
        My.MyProject.Forms.whatchange.Close()
        My.MyProject.Forms.whatchange.oldv = impostaaggiornamento.versioncode
        My.MyProject.Forms.whatchange.newv = newinstallerversion
        My.MyProject.Forms.whatchange.ShowDialog()
    End Sub

    Private Sub whatchange_MouseLeave() Handles whatchangebtn.MouseLeave
        whatchange.Font = New Font(whatchange.Font, FontStyle.Regular)
    End Sub
    Private Sub gotoapp_MouseEnter() Handles whatchangebtn.MouseEnter
        whatchange.Font = New Font(whatchange.Font, FontStyle.Bold)
    End Sub

    Private Sub aspetta_Tick(sender As Object, e As EventArgs) Handles aspetta.Tick
        aspetta.Stop()

        Try
            Dim p As New Process
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.FileName = ("updateinstaller.bat")
            p.StartInfo.WorkingDirectory = Loading.loadedwhere
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.Start()

            INIZIO.Close()
        Catch
        End Try
    End Sub
End Class