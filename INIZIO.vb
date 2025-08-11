Imports System.Security.Principal
Imports System.Threading
Imports System.IO
Imports System.Net
Imports Scripting

Public Class INIZIO
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles paneltitle.MouseDown, formicon.MouseDown, TitleText.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles paneltitle.MouseMove, formicon.MouseMove, TitleText.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles paneltitle.MouseUp, formicon.MouseUp, TitleText.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Public Sub freememory()
        Dim buttons() As Button = installa.Panel1.Controls.OfType(Of Button)().ToArray
        For i As Integer = buttons.Length - 1 To 0 Step -1
            buttons(i).Dispose()
        Next
        Dim buttons3() As PictureBox = Liste.GroupBox3.Controls.OfType(Of PictureBox)().ToArray
        For i As Integer = buttons3.Length - 1 To 0 Step -1
            buttons3(i).Image = Nothing
            buttons3(i).Dispose()
        Next
        Dim buttons4() As PictureBox = listeinstall.Panel3.Controls.OfType(Of PictureBox)().ToArray
        For i As Integer = buttons4.Length - 1 To 0 Step -1
            buttons4(i).Image = Nothing
            buttons4(i).Dispose()
        Next
        Dim buttons5() As PictureBox = addlist.GroupBox1.Controls.OfType(Of PictureBox)().ToArray
        For i As Integer = buttons5.Length - 1 To 0 Step -1
            buttons5(i).Image = Nothing
            buttons5(i).Dispose()
        Next
        Dim buttons2() As Button = deleteappsnew.Panel2.Controls.OfType(Of Button)().ToArray
        For i As Integer = buttons2.Length - 1 To 0 Step -1
            buttons2(i).Dispose()
        Next
        Dim buttons6() As PictureBox = genericwindow.Controls.OfType(Of PictureBox)().ToArray
        For i As Integer = buttons6.Length - 1 To 0 Step -1
            buttons6(i).Image = Nothing
            buttons6(i).Dispose()
        Next


        HELPING.Close()
        Hide()
        installa.chiudisino = True
        Liste.chiudisino = True
        installa.Close()
        Liste.Close()
    End Sub

    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If updatedatabase.Visible = True Then
        '    e.Cancel = True
        '    Exit Sub
        'End If
    End Sub

    Public Sub checkclose()
        HELPING.Close()
        AboutBox1.Close()
        UpdateDetermination.Close()
        Changelog.Close()
        othersettings.Close()
        infohelp.Close()
        deleteappsnew.Close()
        sendemail.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public riavvio As Boolean = False
    Private Sub INIZIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PerformAutoScale()

        Try
            If IO.File.Exists(Application.StartupPath & "\updateinstaller.bat") Then IO.File.Delete(Application.StartupPath & "\updateinstaller.bat")
            If IO.File.Exists(Application.StartupPath & "\INSTALLERupdate") Then IO.File.Delete(Application.StartupPath & "\INSTALLERupdate")

            If Directory.Exists(Application.StartupPath & "\Fondamental") = False Then
                Welcome.Show()
                Exit Sub
            Else
                'Verifica se bisogna entrare nella modalità Ripristino
                If impostaaggiornamento.LeggiOpzione("", "restore") <> "" Then
                    RestoreP.ShowDialog()
                    If riavvio Then System.Windows.Forms.Application.Restart()
                    If riavvio = False Then Close()
                    Exit Sub
                End If

                ' Verifica se bisogna tornare al Welcome Parte 7
                If impostaaggiornamento.LeggiOpzione("", "updating") <> "" Then
                    impostaaggiornamento.after()
                    Welcome16.Show()
                    Exit Sub
                Else
                    Loading.ShowDialog()
                End If
            End If
            If IO.File.Exists(Application.StartupPath & "\Fondamental\Settings\impostazioni.ini") = False Then
                Welcome.Show()
                Exit Sub
            Else
                'Applica i colori
                tema()

                'Importante, per il changelog
                If impostaaggiornamento.LeggiOpzione("", "versionbefore") = "" Then impostaaggiornamento.SalvaOpzione("", "versionbefore", "0", False)

                ' Verifica se è stato aggiornato il programma
                If impostaaggiornamento.LeggiOpzione("", "changelogread") <> "" Then
                    impostaaggiornamento.SalvaOpzione("", "changelogread", "", True)
                    whatchange.oldv = impostaaggiornamento.LeggiOpzione("", "versionbefore")
                    whatchange.newv = impostaaggiornamento.versioncode
                    whatchange.TopMost = True
                    whatchange.ShowDialog()
                End If

                'Controlla se hai usato INSTALLERTools per saltare il benvenuto
                If IO.File.Exists(Application.StartupPath & "\Fondamental\Settings\tool.txt") Then
                    Try
                        If IO.File.Exists(Application.StartupPath & "\Fondamental.zip") Then IO.File.Delete(Application.StartupPath & "\Fondamental.zip")
                        aftertool.ShowDialog()
                        IO.File.Delete(Application.StartupPath & "\Fondamental\Settings\tool.txt")
                    Catch
                    End Try

                End If

                Label1.Text = "Versione " & impostaaggiornamento.versione
            End If

            Dim daanimare As Boolean = False
            If impostaaggiornamento.LeggiOpzione("", "checkup") = "true" Then
                aggiornamentovalore(1)
                impostaaggiornamento.installasilenzioso = True
                impostaaggiornamento.verificaaggiornamento()
            Else
                impostaaggiornamento.verificaaggiornamento()
                daanimare = True
            End If

            AnimazioneIniziale(daanimare)
        Catch
            Welcome.Show()
        End Try
    End Sub

    Public Sub tema()
        If Loading.theme = "light" Then
            BackColor = Color.WhiteSmoke
            panelgoto.BackColor = Color.Gainsboro
            ForeColor = Color.Black
        Else
            ForeColor = Color.White
            BackColor = Color.DimGray
            panelgoto.BackColor = Color.FromArgb(255, 75, 75, 75)
        End If

        image1.BackColor = panelgoto.BackColor
        image2.BackColor = panelgoto.BackColor
        image3.BackColor = panelgoto.BackColor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        infohelp.Close()
        If IO.File.Exists(Application.StartupPath & "\Fondamental\help.txt") Then
            IO.File.Delete(Application.StartupPath & "\Fondamental\help.txt")
        End If
        If My.Computer.Network.IsAvailable = True Then
            Try
                Button7.Text = "Scarico Informazioni..."
                Button7.Enabled = False
                Dim client As WebClient = New WebClient
                AddHandler client.DownloadFileCompleted, AddressOf informazioniprese
                client.DownloadFileAsync(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE32hPzTL19JzLbhN0F/root/content"), Application.StartupPath & "\Fondamental\help.txt")
            Catch
                Button7.Text = "Impossibile scaricare! Riprova."
                Button7.Enabled = True
            End Try
        Else
            Button7.Text = "Nessuna connessione ad Internet."
        End If
    End Sub
    Private Sub Button7_MouseLeave() Handles Button7.MouseLeave
        helplbl.Font = New Font(helplbl.Font, FontStyle.Regular)
        TimerAvanza.Start()
    End Sub
    Private Sub Button7_MouseEnter() Handles Button7.MouseEnter
        resettaavanza(panelhelp)
        labeltitle.Text = "Note dallo sviluppatore"
        labelinfo.Text = "Visualizza le note pubblicate dallo sviluppatore."
        helplbl.Font = New Font(helplbl.Font, FontStyle.Bold)
    End Sub
    Private Sub informazioniprese()
        Button7.Enabled = True
        Button7.Text = ""
        If Visible = False Then Exit Sub

        infohelp.Close()
        infohelp.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sendemail.Close()
        sendemail.ShowDialog()
    End Sub
    Private Sub Button8_MouseLeave() Handles Button8.MouseLeave
        feedbacklbl.Font = New Font(feedbacklbl.Font, FontStyle.Regular)
        TimerAvanza.Start()
    End Sub
    Private Sub Button8_MouseEnter() Handles Button8.MouseEnter
        resettaavanza(panelfeedback)
        labeltitle.Text = "Problemi? Scrivi qui!"
        labelinfo.Text = "Hai bisogno di un app in particolare? Contattami."
        feedbacklbl.Font = New Font(feedbacklbl.Font, FontStyle.Bold)
    End Sub

    Private Sub label1_MouseLeave() Handles Label1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub
    Private Sub label1_MouseEnter() Handles Label1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        HELPING.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HELPING.ShowDialog()
    End Sub
    Private Sub Button9_MouseLeave() Handles Button9.MouseLeave
        settingslbl.Font = New Font(settingslbl.Font, FontStyle.Regular)
        TimerAvanza.Start()
    End Sub
    Private Sub Button9_MouseEnter() Handles Button9.MouseEnter
        resettaavanza(panelsettings)
        labeltitle.Text = "Entra nei settaggi"
        labelinfo.Text = "Facciamo ripartire alcuni ingranaggi."
        settingslbl.Font = New Font(settingslbl.Font, FontStyle.Bold)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Changelog.ShowDialog()
    End Sub

    Private Sub gotoapp_Click(sender As Object, e As EventArgs) Handles gotoapp.Click
        checkclose()
        Hide()
        installa.Show()
    End Sub
    Private Sub gotoapp_MouseLeave() Handles gotoapp.MouseLeave
        menulbl.Font = New Font(menulbl.Font, FontStyle.Regular)
        TimerAvanza.Start()
    End Sub
    Private Sub gotoapp_MouseEnter() Handles gotoapp.MouseEnter
        resettaavanza(panelmenu)
        labeltitle.Text = "Installa App essenziali"
        labelinfo.Text = "Scegli grazie a un ottimo menù semplificato quale app installare!"
        menulbl.Font = New Font(menulbl.Font, FontStyle.Bold)
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Private Sub gotolist_Click(sender As Object, e As EventArgs) Handles gotolist.Click
        Liste.Close()
        Hide()
        Liste.Show()
    End Sub
    Private Sub gotolist_MouseLeave() Handles gotolist.MouseLeave
        listlbl.Font = New Font(listlbl.Font, FontStyle.Regular)
        TimerAvanza.Start()
    End Sub
    Private Sub gotolist_MouseEnter() Handles gotolist.MouseEnter
        resettaavanza(panellist)
        labeltitle.Text = "Gestisci le Liste"
        labelinfo.Text = "Vai di fretta? Idea liste perfette per te e i tuoi pc!"
        listlbl.Font = New Font(listlbl.Font, FontStyle.Bold)
    End Sub

    Sub AnimazioneIniziale(animation As Boolean)
        disabilita(False)
        panelgoto.Height = 0
        panelinstaller.Top = panelinstaller.Height

        If animation Then TimerAnimation.Start()
    End Sub
    Dim animationphase As Integer = 0
    Private Sub TimerAnimation_Tick(sender As Object, e As EventArgs) Handles TimerAnimation.Tick
        If animationphase = 0 Then
            panelgoto.Height += 3

            If panelgoto.Height = 123 Then
                TimerAnimation.Stop()
                updatesmart()
                TimerAvanza.Start()
            End If
        End If

        If animationphase = 1 Then
            If panelinstaller.Top > 0 Then panelinstaller.Top -= 5

            If panelinstaller.Top <= 0 Then
                panelinstaller.Top = 0
                TimerAnimation.Stop()
            End If
        End If
    End Sub

    Dim latestpanel As Panel
    Private Sub TimerAvanza_Tick(sender As Object, e As EventArgs) Handles TimerAvanza.Tick
        If animationphase = 0 Then
            animationphase = 1
            panelwelcome.Visible = False
            panelinit.Visible = True
            latestpanel = panelinit
            labelinfo.Visible = True
            labeltitle.Visible = True
            disabilita(True)

            labeltitle.BringToFront()
            labelinfo.BringToFront()

            TimerAnimation.Start()
            TimerAvanza.Stop()
            TimerAvanza.Interval = 5000
        End If

        If animationphase = 1 Then
            labeltitle.Text = "Riprendi da qui"
            labelinfo.Text = "A cosa eravamo rimasti l'ultima volta?"
            resettaavanza(panelinit)
        End If
    End Sub

    Sub resettaavanza(latestpanell As Panel)
        TimerAvanza.Stop()
        latestpanel.Visible = False
        latestpanel = latestpanell

        latestpanel.Visible = True
        latestpanel.BringToFront()

        labeltitle.BringToFront()
        labelinfo.BringToFront()
    End Sub

    Sub disabilita(valore As Boolean)
        gotoapp.Enabled = valore
        gotolist.Enabled = valore
        Button7.Enabled = valore
        Button9.Enabled = valore
        Button8.Enabled = valore
    End Sub

    Dim favlista As String = ""
    Public Sub updatesmart()
        favlista = impostaaggiornamento.LeggiOpzione("", "favlist")
        If favlista <> "" Then
            labelfavlist.Text = "Clicca qui per andare alla lista '" & favlista & "'"
            favlist.Cursor = Cursors.Hand
            labelfavlist.Cursor = Cursors.Hand
        Else
            labelfavlist.Text = "Non hai nessuna lista preferita! :c"
            favlist.Cursor = Cursors.Default
            labelfavlist.Cursor = Cursors.Default
        End If

        Dim leggi1 As String = impostaaggiornamento.LeggiOpzione("", "recente1")
        Dim leggi2 As String = impostaaggiornamento.LeggiOpzione("", "recente2")
        Dim leggi3 As String = impostaaggiornamento.LeggiOpzione("", "recente3")

        If leggi1 <> "" And IO.File.Exists(installa.outputfolder & leggi1 & "\image") Then
            image1.BackgroundImage = Image.FromFile(installa.outputfolder & leggi1 & "\image")
            image1.Enabled = True
        Else
            image1.BackgroundImage = My.Resources.emptyapp
            image1.Enabled = False
        End If
        If leggi2 <> "" And IO.File.Exists(installa.outputfolder & leggi2 & "\image") Then
            image2.BackgroundImage = Image.FromFile(installa.outputfolder & leggi2 & "\image")
            image2.Enabled = True
        Else
            image2.BackgroundImage = My.Resources.emptyapp
            image2.Enabled = False
        End If
        If leggi3 <> "" And IO.File.Exists(installa.outputfolder & leggi3 & "\image") Then
            image3.BackgroundImage = Image.FromFile(installa.outputfolder & leggi3 & "\image")
            image3.Enabled = True
        Else
            image3.BackgroundImage = My.Resources.emptyapp
            image3.Enabled = False
        End If
    End Sub

    Private Sub favlist_Click(sender As Object, e As EventArgs) Handles favlist.Click, labelfavlist.Click
        If favlista <> "" Then
            Liste.Close()
            Liste.latestbtn = favlista
            Liste.diretto = True
            Hide()
            Liste.Show()
        End If
    End Sub

    Private Sub image_Click(sender As Object, e As EventArgs) Handles image1.Click, image2.Click, image3.Click
        Dim giggy As Button = sender
        Dim taggy As String = giggy.Tag
        Dim leggi As String = impostaaggiornamento.LeggiOpzione("", giggy.Tag)

        If leggi = "" Then Exit Sub

        openornot.Close()
        openornot.image.Image = giggy.BackgroundImage
        openornot.BackColor = BackColor
        openornot.name = leggi
        openornot.ShowDialog()
    End Sub

    Public Sub aggiornamentovalore(mode As Integer)
        labelupdate.Visible = True
        updatepic.Visible = True

        Select Case mode
            Case 1
                labelupdate.Text = "Controllo gli aggiornamenti ..."
                updatepic.Image = My.Resources.giphy1
            Case 2
                labelupdate.Text = "Scarico l'aggiornamento ..."
            Case 3
                labelupdate.Text = "Riavvio in corso ..."
                updatepic.Image = My.Resources.updatedone
            Case 4
                labelupdate.Visible = False
                updatepic.Image.Dispose()
                updatepic.Visible = False
                AnimazioneIniziale(True)
        End Select
    End Sub
End Class
