Imports System.IO

Public Class listeinstall
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

    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Public namelist
    Dim total As Integer
    Dim totalview As Integer

    Private Sub listeinstall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        Label1.BackColor = INIZIO.panelgoto.BackColor
        Label3.BackColor = Label1.BackColor
        Label4.BackColor = Label3.BackColor
        image1.BackColor = Label1.BackColor
        image2.BackColor = Label1.BackColor
        ListBox1.BackColor = Label1.BackColor
        ListBox1.ForeColor = ForeColor
        GroupBox1.ForeColor = ForeColor

        lines = File.ReadAllLines(installa.outputfolder & "Settings\Lists\" & namelist)
        For Each line As String In lines
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            ListBox1.Items.Add(parts(1))
        Next
        total = ListBox1.Items.Count
        totalview = total

        Label1.Text = namelist & " : " & totalview & " Task da eseguire"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Nessuna connessione ad Internet!", MsgBoxStyle.Exclamation, "Attenzione!")
        Else
            CheckBox1.Hide()
            Label2.Hide()
            Button1.FlatAppearance.BorderSize = 0
            Timer1.Start()
        End If
    End Sub
    Public Sub button1_MouseLeave() Handles Button1.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
    End Sub
    Public Sub button1_MouseEnter() Handles Button1.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Button1.Location.Y <= -140 Then
            Button1.FlatAppearance.BorderSize = 0
            Button1.Location = New Point(Button1.Location.X, Button1.Location.Y - 5)
        Else
            startinstall()
        End If
    End Sub

    Private Sub startinstall()
        Timer1.Stop()
        GroupBox1.Hide()
        back.Hide()
        Panel1.Visible = True
        Label1.Visible = True
        Panel3.Visible = True
        'Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        'Avvia istanza downloader
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        downloader.Close()
        downloadersmall.Close()
        downloader.Height = Panel1.Height
        downloader.Width = Panel1.Width
        downloader.task1.Left = (downloader.Width / 2) - (downloader.task1.Width / 2)
        downloader.TopLevel = False
        'downloader.movebutton.Hide()
        Panel1.Controls.Add(downloader)
        downloader.listmode = True
        downloader.settingsbtn.Visible = False

        'Ora inizia la pacchia...
        downloader.installall = True
        If CheckBox1.Checked = False Then downloader.automode.Checked = False
        downloader.pic1.Visible = False
        downloader.task2.Visible = False
        Dim diff As Integer = (downloader.pic1.Left + downloader.pic1.Width) - downloader.ProgressBar1.Width - (downloader.ProgressBar1.Left * 1.8)
        downloader.ProgressBar1.Width += diff
        downloader.retry1.Left += diff
        downloader.speed1.Left += diff
        downloader.status1.Width += diff

        downloader.Show()
        downloader.BackColor = Label1.BackColor
        Panel1.BackColor = Label1.BackColor
        minimize.Visible = True
        bordello()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Liste.latestbtn = namelist
        Liste.Show()
        chiudisino = True
        Close()
    End Sub

    Public Sub updatetext()
        Label1.Text = namelist & " : Installazione " & currentnumview & " di " & totalview
        tasktext = "Task " & currentnumview & " di " & totalview
        If downloadersmall.Visible Then downloadersmall.tasky(tasktext)

        Try
            image1.Image = Nothing
            Dim parts() As String = lines(currentnum).Split(New Char() {"="}, 2)
            image1.Image = Image.FromFile(installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\image")
            Label3.Text = parts(1)
        Catch
        End Try

        image2.Image = Nothing
        image2.BorderStyle = BorderStyle.None
        Label4.Text = ""
        Label4.BorderStyle = BorderStyle.None

        If currentnum < total - 1 Then
            Dim nextnum As Integer = currentnum + 1
            Do While disabledlist.Contains(lines(nextnum))
                If nextnum < total - 1 Then
                    nextnum += 1
                Else
                    Exit Sub
                End If
            Loop

            Try
                Dim parts() As String = lines(nextnum).Split(New Char() {"="}, 2)
                Label4.Text = parts(1)
                Label4.BorderStyle = BorderStyle.FixedSingle
                image2.Image = Image.FromFile(installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\image")
                image2.BorderStyle = BorderStyle.FixedSingle
            Catch
            End Try
        End If
    End Sub

    Dim lines() As String
    Dim currentnum As Integer = -1
    Dim currentnumview As Integer = 0
    Public failed As String
    Public tasktext As String
    Public Sub bordello()
        currentnum += 1

        If currentnum < total Then
            If disabledlist.Contains(lines(currentnum)) Then
                bordello()
                Exit Sub
            End If

            currentnumview += 1
            updatetext()
            Dim parts() As String = lines(currentnum).Split(New Char() {"="}, 2)
            genericwindow.lines = File.ReadAllLines(installa.outputfolder & parts(0))
            genericwindow.percorso = installa.outputfolder & Path.GetDirectoryName(parts(0)) & "\"
            genericwindow.appname = Path.GetDirectoryName(parts(0))
            genericwindow.readanddownload()
        Else
            If downloadersmall.Visible = True Then downloadersmall.Close()
            WindowState = FormWindowState.Normal
            CenterToScreen()
            Hide()
            Haifinito.Close()
            Haifinito.errors = failed
            Haifinito.ShowDialog()
            Liste.Show()
            chiudisino = True
            Close()
        End If
    End Sub

    Dim disabledlist As New List(Of String)
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex < 0 Then Exit Sub

        Dim index As Integer = ListBox1.SelectedIndex
        Dim item As String = ListBox1.SelectedItem

        If disabledlist.Contains(lines(index)) = False Then
            If disabledlist.Count = ListBox1.Items.Count - 1 Then
                MsgBox("Se vuoi installare la lista, non puoi disabilitare tutti gli elementi!", MsgBoxStyle.Exclamation, "Attenzione!")
                Exit Sub
            End If

            disabledlist.Add(lines(index))
            ListBox1.Items.Item(index) = "[Disabilitato] " & item
            totalview -= 1
        Else
            disabledlist.Remove(lines(index))
            Dim parts() As String = lines(index).Split(New Char() {"="}, 2)
            ListBox1.Items.Item(index) = parts(1)
            totalview += 1
        End If

        Label1.Text = namelist & " : " & totalview & " Task da eseguire"
        GroupBox1.Text = "Programmi inclusi"
    End Sub

    Private Sub ListBox1_MouseLeave(sender As Object, e As EventArgs) Handles ListBox1.MouseLeave
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        downloadersmall.formicon.Image = My.Resources.goinstall
        downloadersmall.TitleText.Text = TitleText.Text
        downloadersmall.StartPosition = FormStartPosition.Manual
        downloadersmall.dove = New Point(Left + Width - downloadersmall.Width, Top + Height - downloadersmall.Height)
        downloadersmall.install = downloader.status1.Text
        downloadersmall.Show()

        WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
    End Sub
End Class