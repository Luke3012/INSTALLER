Imports System.IO

Public Class addlist
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

    Private Sub addlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        custom.BackColor = INIZIO.panelgoto.BackColor
        trentadue.BackColor = INIZIO.panelgoto.BackColor
        sessantaquattro.BackColor = INIZIO.panelgoto.BackColor
        GroupBox1.ForeColor = ForeColor
        GroupBox2.ForeColor = ForeColor
        imagebox.BackColor = custom.BackColor

        For Each folder In Directory.GetDirectories(installa.outputfolder)
            If Not Path.GetFileName(folder) = "Settings" And Not Path.GetFileName(folder) = "Updater" Then
                ListBox1.Items.Add(Path.GetFileName(folder))
            End If
        Next
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        chiudisino = True
        Close()
    End Sub

    Dim percorso As String
    Dim lines() As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        trentadue.Location = New Point(trentadue.Location.X, custom.Location.Y + custom.Height + 5)
        sessantaquattro.Location = New Point(sessantaquattro.Location.X, trentadue.Location.Y)
        custom.Visible = False
        trentadue.Visible = False
        sessantaquattro.Visible = False
        custom.Enabled = True
        trentadue.Enabled = True
        sessantaquattro.Enabled = True
        percorso = installa.outputfolder & ListBox1.SelectedItem & "\"
        'Controlliamo
        If File.Exists(percorso & "downloadercustom.ini") Then
            lines = File.ReadAllLines(percorso & "downloadercustom.ini")
            For Each line As String In lines
                Dim parts() As String = line.Split("=")
                If parts(0) = "name" Then
                    custom.Text = parts(1)
                End If
            Next
            custom.Visible = True
        End If
        trentadue.Enabled = False
        If File.Exists(percorso & "downloader32.ini") Then
            lines = File.ReadAllLines(percorso & "downloader32.ini")
            For Each line As String In lines
                Dim parts() As String = line.Split("=")
                If parts(0) = "name" Then
                    trentadue.Text = parts(1)
                End If
            Next
            trentadue.Visible = True
            trentadue.Enabled = True
            sessantaquattro.Visible = True
        End If
        sessantaquattro.Enabled = False
        If File.Exists(percorso & "downloader64.ini") Then
            lines = File.ReadAllLines(percorso & "downloader64.ini")
            For Each line As String In lines
                Dim parts() As String = line.Split("=")
                If parts(0) = "name" Then
                    sessantaquattro.Text = parts(1)
                End If
            Next
            sessantaquattro.Visible = True
            trentadue.Visible = True
            sessantaquattro.Enabled = True
        End If

        Try
            imagebox.Image = Image.FromFile(percorso & "image")
        Catch
            imagebox.Image = My.Resources.ResourceManager.GetObject("no-image-box")
        End Try

        GroupBox1.Visible = True
        If custom.Visible = False Then
            trentadue.Location = New Point(trentadue.Location.X, custom.Location.Y)
            sessantaquattro.Location = New Point(sessantaquattro.Location.X, custom.Location.Y)
        End If

        checkifthereis()

    End Sub

    Private Sub checkifthereis()
        'controlla se è stato già aggiunto alla lista
        If editmode = True Then
            For i As Integer = 0 To editlista.ListBox1.Items.Count - 1
                Dim parts() As String = editlista.ListBox1.Items(i).ToString.Split(New Char() {"="}, 2)
                If installa.outputfolder & parts(0) = percorso & "downloadercustom.ini" Then
                    If custom.Visible = True Then
                        custom.Enabled = False
                        custom.Text = custom.Text & " (Già aggiunto)"
                    End If
                End If
                If installa.outputfolder & parts(0) = percorso & "downloader32.ini" Then
                    If trentadue.Visible = True Then
                        trentadue.Enabled = False
                        trentadue.Text = trentadue.Text & " (Già aggiunto)"
                    End If
                End If
                If installa.outputfolder & parts(0) = percorso & "downloader64.ini" Then
                    If sessantaquattro.Visible = True Then
                        sessantaquattro.Enabled = False
                        sessantaquattro.Text = sessantaquattro.Text & " (Già aggiunto)"
                    End If
                End If
            Next
        End If
    End Sub

    Public selected As String
    Private Sub custom_Click(sender As Object, e As EventArgs) Handles custom.Click
        lines = File.ReadAllLines(percorso & "downloadercustom.ini")
        selected = "downloadercustom.ini"
        readanddownload()
    End Sub
    Public Sub custom_MouseLeave() Handles custom.MouseLeave
        custom.Font = New Font(custom.Font, FontStyle.Regular)
    End Sub
    Public Sub custom_MouseEnter() Handles custom.MouseEnter
        custom.Font = New Font(custom.Font, FontStyle.Bold)
    End Sub

    Private Sub trentadue_Click(sender As Object, e As EventArgs) Handles trentadue.Click
        lines = File.ReadAllLines(percorso & "downloader32.ini")
        selected = "downloader32.ini"
        readanddownload()
    End Sub
    Public Sub trentadue_MouseLeave() Handles trentadue.MouseLeave
        trentadue.Font = New Font(trentadue.Font, FontStyle.Regular)
    End Sub
    Public Sub trentadue_MouseEnter() Handles trentadue.MouseEnter
        trentadue.Font = New Font(trentadue.Font, FontStyle.Bold)
    End Sub

    Private Sub sessantaquattro_Click(sender As Object, e As EventArgs) Handles sessantaquattro.Click
        lines = File.ReadAllLines(percorso & "downloader64.ini")
        selected = "downloader64.ini"
        readanddownload()
    End Sub
    Public Sub sessantaquattro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sessantaquattro.MouseLeave, Button1.MouseLeave
        sender.Font = New Font(sessantaquattro.Font, FontStyle.Regular)
    End Sub
    Public Sub sessantaquattro_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sessantaquattro.MouseEnter, Button1.MouseEnter
        sender.Font = New Font(sessantaquattro.Font, FontStyle.Bold)
    End Sub

    Dim name As String
    Private Sub readanddownload()
        For Each line As String In lines
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            If parts(0) = "downloader.genericn" Then
                name = parts(1)
            End If
        Next

        TextBox1.Text = name
        GroupBox2.Visible = True
    End Sub

    Public stringa As String = ""
    Public editmode As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = name
        End If
        stringa = ListBox1.SelectedItem & "\" & selected & "=" & TextBox1.Text
        If editmode = False Then
            'Qui i controlli se si è nella modalità crea
            ' Ok..Qui vediamo che nome scegliere
            Dim num As Integer = 1
            For Each file In Directory.GetFiles(installa.outputfolder & "Settings\Lists\")
                If IO.File.Exists(installa.outputfolder & "Settings\Lists\Lista" & num) Then
                    num += 1
                Else
                    Exit For
                End If
            Next
            editlista.namelist = "Lista" & num
        Else
            'Adesso i controlli se si è nella modalità modifica
        End If

        Dim writer As New StreamWriter(installa.outputfolder & "Settings\Lists\" & editlista.namelist, True, System.Text.Encoding.Default)
        writer.WriteLine(stringa)
        writer.Close()
        editlista.Show()
        chiudisino = True
        Close()
    End Sub
End Class