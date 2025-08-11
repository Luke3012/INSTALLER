Imports System.IO

Public Class Liste
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Panel2.MouseDown, formicon.MouseDown, TitleText.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Panel2.MouseMove, formicon.MouseMove, TitleText.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Panel2.MouseUp, formicon.MouseUp, TitleText.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Public chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        INIZIO.updatesmart()
        INIZIO.Show()
        chiudisino = True
        Close()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        chiudisino = True
        INIZIO.Close()
    End Sub

    Private Sub Liste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        ForeColor = INIZIO.ForeColor
        GroupBox2.ForeColor = ForeColor
        GroupBox3.ForeColor = ForeColor
        image1.BackColor = panelgoto.BackColor
        image2.BackColor = panelgoto.BackColor
        image3.BackColor = panelgoto.BackColor

        If Not Directory.Exists(installa.outputfolder & "Settings\Lists") Then Directory.CreateDirectory(installa.outputfolder & "Settings\Lists")
        favlista = impostaaggiornamento.LeggiOpzione("", "favlist")

        updatedata()
    End Sub

    Public diretto As Boolean = False
    Public namelist
    Dim already As Boolean = False
    Private Sub updatedata()
        waiting.Close()
        waiting.formicon.Image = My.Resources.ResourceManager.GetObject("lists")
        waiting.PictureBox1.Image = My.Resources.ResourceManager.GetObject("go1")
        waiting.Label1.Text = "Aggiorno la lista"
        waiting.Show()
        wait.Start()
    End Sub

    Dim favlista As String = ""
    Private Sub calcoladata()
        wait.Stop()

        If already = True Then
            Exit Sub
        Else
            already = True
        End If
        tempbtn = Nothing
        deletelist.Enabled = False
        editlist.Enabled = False
        goinstall.Enabled = False
        deletelist.Visible = False
        deletelistlbl.Visible = False
        editlist.Visible = False
        editlistlbl.Visible = False
        goinstall.Visible = False
        goinstalllbl.Visible = False
        favouritelist.Visible = False
        favouritelistlbl.Visible = False
        favouritelist.Enabled = False
        GroupBox3.Text = "Panoramica"
        image1.Image = Nothing
        image2.Image = Nothing
        image3.Image = Nothing
        Panel1.Controls.Clear()

        'Fai un piccolo controllo delle liste, essenzialmente controlla se i programmi ci sono
        For Each list In Directory.GetFiles(installa.outputfolder & "Settings\Lists\")
            namelist = Path.GetFileName(list)
            checkprograms()
        Next

        Dim number As Integer = 0
        Dim number2 As Integer = 0
        Dim first As Boolean = False
        Dim lal As Button
        Dim pref As Boolean = False
        For Each list In Directory.GetFiles(installa.outputfolder & "Settings\Lists\")
            lal = New Button
            lal.Width = Panel1.Width - 20
            lal.Height = 47
            lal.Location = New Point(number, number2)
            lal.Cursor = Cursors.Hand
            lal.Text = Path.GetFileName(list)
            lal.ForeColor = Color.Black
            lal.BackColor = Color.Gainsboro
            lal.FlatStyle = FlatStyle.Flat
            lal.FlatAppearance.BorderSize = 1
            AddHandler lal.Click, AddressOf hah
            AddHandler lal.MouseLeave, AddressOf hahout
            AddHandler lal.MouseEnter, AddressOf hahin
            Panel1.Controls.Add(lal)
            number2 += lal.Height + 1
            If first = False Then
                first = True
                tempbtn = lal
            End If
            If latestbtn = lal.Text Then tempbtn = lal
            If lal.Text = favlista Then
                lal.Text = lal.Text & " (pref.)"
                pref = True
            End If
        Next

        'Se non trova il preferito
        If favlista <> "" And pref = False Then
            impostaaggiornamento.SalvaOpzione("", "favlist", "", True)
            favlista = ""
        End If

        'Disabilita lo scroll orizzontale
        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = False
        Panel1.VerticalScroll.Visible = False
        Panel1.AutoScroll = True

        Try
            tempbtn.PerformClick()
        Catch
        End Try
        already = False

        waiting.Close()

        If diretto = True And favlista <> "" Then
            diretto = False
            goinstall.PerformClick()
        End If
    End Sub

    Private Sub hahout(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub hahin(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.FlatAppearance.BorderSize = 0
    End Sub

    Public latestbtn As String
    Dim tempbtn As Button = Nothing
    Private Sub hah(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            tempbtn.BackColor = Color.Gainsboro
        Catch
        End Try
        namelist = sender.text.Replace(" (pref.)", "")
        goinstall.Enabled = True
        editlist.Enabled = True
        deletelist.Enabled = True
        goinstall.Visible = True
        goinstalllbl.Visible = True
        editlist.Visible = True
        editlistlbl.Visible = True
        deletelist.Visible = True
        deletelistlbl.Visible = True
        favouritelist.Enabled = True
        favouritelist.Visible = True
        favouritelistlbl.Visible = True
        sender.backcolor = Color.White
        tempbtn = sender
        GroupBox3.Text = "Panoramica '" & namelist & "'"
        checkprograms()
        If go = True Then updateimage()

        latestbtn = sender.Text.ToString.Replace(" (pref.)", "")

        favouritelist.BackgroundImage.Dispose()
        If favlista = namelist Then
            favouritelist.BackgroundImage = My.Resources.favourite
            favouritelistlbl.Text = "Togli preferito"
        Else
            favouritelist.BackgroundImage = My.Resources.addfavourite
            favouritelistlbl.Text = "Rendi preferita"
        End If
    End Sub

    Dim go As Boolean = True
    Private Sub checkprograms()
        For Each line As String In File.ReadAllLines(installa.outputfolder & "Settings\Lists\" & namelist)
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            If Not File.Exists(installa.outputfolder & parts(0)) Then
                Dim line2 As String
                Dim Input As StreamReader
                Dim PolicyIdCode As String
                Dim strFile As New ArrayList
                PolicyIdCode = line
                Input = File.OpenText(installa.outputfolder & "Settings\Lists\" & namelist)
                While Input.Peek <> -1
                    line2 = Input.ReadLine
                    If Not line2 = PolicyIdCode Then
                        strFile.Add(line2)
                    End If
                End While
                Input.Close()
                If File.Exists(installa.outputfolder & "Settings\Lists\" & namelist) Then
                    File.Delete(installa.outputfolder & "Settings\Lists\" & namelist)
                End If
                Dim objWriter As New System.IO.StreamWriter(installa.outputfolder & "Settings\Lists\" & namelist, True)
                For Each item As String In strFile
                    objWriter.WriteLine(item)
                Next
                objWriter.Flush()
                objWriter.Close()
            End If
        Next

        'Conta le linee
        Dim conta As Integer = 0
        For Each line As String In File.ReadAllLines(installa.outputfolder & "Settings\Lists\" & namelist)
            conta += 1
            go = True
        Next
        If conta = 0 Then
            File.Delete(installa.outputfolder & "Settings\Lists\" & namelist)
            go = False
            updatedata()
        End If
    End Sub

    Private Sub updateimage()
        image1.Image = Nothing
        image2.Image = Nothing
        image3.Image = Nothing
        Dim count As Integer = 1
        Dim temp As String
        For Each line As String In File.ReadAllLines(installa.outputfolder & "Settings\Lists\" & namelist)
            If count = 1 Then
                Try
                    Dim parts() As String = line.Split(New Char() {"="}, 2)
                    image1.Image = Image.FromFile(installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\image")
                    temp = Path.GetDirectoryName(parts(0))
                Catch
                    count -= 1
                End Try
            End If
            If count = 2 Then
                Try
                    Dim parts() As String = line.Split(New Char() {"="}, 2)
                    If Not Path.GetDirectoryName(parts(0)) = temp Then
                        image2.Image = Image.FromFile(installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\image")
                        temp = Path.GetDirectoryName(parts(0))
                    Else
                        count -= 1
                    End If
                Catch
                    count -= 1
                End Try
            End If
            If count = 3 Then
                Try
                    Dim parts() As String = line.Split(New Char() {"="}, 2)
                    If Not Path.GetDirectoryName(parts(0)) = temp Then
                        image3.Image = Image.FromFile(installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\image")
                    Else
                        count -= 1
                    End If
                Catch
                    count -= 1
                End Try
            End If
            If count > 3 Then
                Exit For
            End If
            count += 1
        Next
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        editlista.Close()
        chiudisino = True
        Close()
        editlista.create()
        updatedata()
    End Sub
    Public Sub create_MouseLeave() Handles create.MouseLeave
        createlbl.Font = New Font(createlbl.Font, FontStyle.Regular)
    End Sub
    Public Sub create_MouseEnter() Handles create.MouseEnter
        createlbl.Font = New Font(createlbl.Font, FontStyle.Bold)
    End Sub

    Private Sub editlist_Click(sender As Object, e As EventArgs) Handles editlist.Click
        editlista.Close()
        editlista.namelist = namelist
        editlista.Show()
        chiudisino = True
        Close()
    End Sub
    Public Sub editlist_MouseLeave() Handles editlist.MouseLeave
        editlistlbl.Font = New Font(editlistlbl.Font, FontStyle.Regular)
    End Sub
    Public Sub editlist_MouseEnter() Handles editlist.MouseEnter
        editlistlbl.Font = New Font(editlistlbl.Font, FontStyle.Bold)
    End Sub

    Private Sub deletelist_Click(sender As Object, e As EventArgs) Handles deletelist.Click
        If MessageBox.Show("Sicuro di voler eliminare la lista selezionata?", "'" & namelist & "'", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                File.Delete(installa.outputfolder & "Settings\Lists\" & namelist)
                latestbtn = ""
            Catch
                MsgBox("Errore eliminazione!", MsgBoxStyle.Critical, "Errore!")
            End Try
            updatedata()
        End If
    End Sub
    Public Sub deletelist_MouseLeave() Handles deletelist.MouseLeave
        deletelistlbl.Font = New Font(deletelistlbl.Font, FontStyle.Regular)
    End Sub
    Public Sub deletelist_MouseEnter() Handles deletelist.MouseEnter
        deletelistlbl.Font = New Font(deletelistlbl.Font, FontStyle.Bold)
    End Sub

    Private Sub goinstall_Click(sender As Object, e As EventArgs) Handles goinstall.Click
        listeinstall.Close()
        listeinstall.namelist = namelist
        listeinstall.Show()
        chiudisino = True
        Close()
    End Sub
    Private Sub goinstall_MouseLeave() Handles goinstall.MouseLeave
        goinstalllbl.Font = New Font(goinstalllbl.Font, FontStyle.Regular)
    End Sub
    Private Sub goinstall_MouseEnter() Handles goinstall.MouseEnter
        goinstalllbl.Font = New Font(goinstalllbl.Font, FontStyle.Bold)
    End Sub

    Private Sub wait_Tick(sender As Object, e As EventArgs) Handles wait.Tick
        calcoladata()
        wait.Stop()
    End Sub

    Private Sub favouritelist_MouseLeave() Handles favouritelist.MouseLeave
        favouritelistlbl.Font = New Font(favouritelistlbl.Font, FontStyle.Regular)
    End Sub
    Private Sub favouritelist_MouseEnter() Handles favouritelist.MouseEnter
        favouritelistlbl.Font = New Font(favouritelistlbl.Font, FontStyle.Bold)
    End Sub
    Private Sub favouritelist_Click(sender As Object, e As EventArgs) Handles favouritelist.Click
        If favouritelistlbl.Text.Contains("Rendi") Then
            favouritelist.BackgroundImage = My.Resources.favourite
            favouritelistlbl.Text = "Togli preferito"
            tempbtn.Text = tempbtn.Text & " (pref.)"
            impostaaggiornamento.SalvaOpzione("", "favlist", namelist, False)
            favlista = namelist
            updatedata()
        Else
            favouritelist.BackgroundImage = My.Resources.addfavourite
            favouritelistlbl.Text = "Rendi preferita"
            tempbtn.Text = tempbtn.Text.Replace(" (pref.)", "")
            impostaaggiornamento.SalvaOpzione("", "favlist", "", True)
            favlista = ""
        End If
    End Sub
End Class