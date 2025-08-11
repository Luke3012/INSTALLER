Imports System.IO

Public Class genericwindow
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



    Public appname As String
    Public lines As String()
    Public percorso As String
    Public percorso2 As String = ""
    Public genericd As String
    Public genericp As String
    Public genericn As String

    Private Sub genericwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        custom.BackColor = INIZIO.panelgoto.BackColor
        trentadue.BackColor = INIZIO.panelgoto.BackColor
        sessantaquattro.BackColor = INIZIO.panelgoto.BackColor
        description.BackColor = custom.BackColor
        description.ForeColor = ForeColor
        imagebox.BackColor = INIZIO.panelgoto.BackColor
        Text = appname
        TitleText.Text = appname
        Try
            formicon.Image = Image.FromFile(percorso & "image")
        Catch
        End Try

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

        If trentadue.Visible = False And sessantaquattro.Visible = False Then
            Height = Height - 70
            description.Height = description.Height - 70
        End If
        If custom.Visible = False Then
            trentadue.Location = New Point(trentadue.Location.X, custom.Location.Y)
            sessantaquattro.Location = New Point(sessantaquattro.Location.X, custom.Location.Y)
            Height = Height - 62
            description.Height = description.Height - 62
        End If
        If Not File.Exists(percorso & "description") Then
            Width -= description.Width
        Else
            description.Visible = True
            description.Text = File.ReadAllText(percorso & "description", System.Text.Encoding.Default)
        End If


        CenterToScreen()
        loadimages()
    End Sub

    Private Sub custom_Click(sender As Object, e As EventArgs) Handles custom.Click
        lines = File.ReadAllLines(percorso & "downloadercustom.ini")
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
        readanddownload()
    End Sub
    Public Sub sessantaquattro_MouseLeave() Handles sessantaquattro.MouseLeave
        sessantaquattro.Font = New Font(sessantaquattro.Font, FontStyle.Regular)
    End Sub
    Public Sub sessantaquattro_MouseEnter() Handles sessantaquattro.MouseEnter
        sessantaquattro.Font = New Font(sessantaquattro.Font, FontStyle.Bold)
    End Sub

    Public Sub readanddownload()
        aggiungirecente(appname)
        appname = ""

        Dim backuppercorso As String = percorso
        If percorso2 <> "" Then
            percorso = percorso2
        End If
        For Each line As String In lines
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            If parts(0) = "name" Then
                downloader.genericbtnname = parts(1)
            End If
            If parts(0) = "downloader.genericd" Then
                downloader.genericd = parts(1)
            End If
            If parts(0) = "downloader.genericp" Then
                downloader.genericp = percorso & parts(1)
            End If
            If parts(0) = "downloader.genericn" Then
                downloader.genericn = parts(1)
            End If
            If parts(0) = "downloader.genericz" Then
                Try
                    downloader.genericz = percorso.Substring(0, percorso.Length - 1) & parts(1)
                Catch
                    downloader.genericz = percorso.Substring(0, percorso.Length - 1)
                End Try
            End If
            If parts(0) = "downloader.genericpz" Then
                downloader.genericpz = percorso & parts(1)
            End If
            If parts(0) = "downloader.genericdel" Then
                downloader.genericdel = percorso & parts(1)
            End If
            If parts(0) = "downloader.genericv" Then
                downloader.genericv = parts(1)
            End If
            If parts(0) = "downloader.genericsp" Then
                downloader.genericsp = parts(1)
            End If
            If parts(0) = "downloader.genericcon" Then
                downloader.genericcon = percorso & parts(1) & ".ini"
            End If
            If parts(0) = "downloader.genericsil" Then
                If Not parts(1).Replace(" ", "") = "" Then
                    downloader.genericsil = parts(1)
                End If
            End If
            If parts(0) = "downloader.noboot" Then
                downloader.genericnoboot = True
            End If
        Next
        downloader.image = percorso & "image"
        downloader.decidi()
        If percorso2 <> "" Then
            percorso = backuppercorso
            percorso2 = ""
            Exit Sub
        End If

        Close()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Dim cur As Integer = 1
    Private Sub loadimages()
        back.Visible = True
        after.Visible = True
        Try
            imagebox.Image = Image.FromFile(percorso & "pic" & cur)
        Catch
        End Try
        If Not File.Exists(percorso & "pic" & cur - 1) Then
            back.Visible = False
        End If
        If Not File.Exists(percorso & "pic" & cur + 1) Then
            after.Visible = False
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        cur -= 1
        loadimages()
    End Sub

    Private Sub after_Click(sender As Object, e As EventArgs) Handles after.Click
        cur += 1
        loadimages()
    End Sub

    Private Sub imagebox_Click(sender As Object, e As EventArgs) Handles imagebox.Click
        imagewindow.Close()
        imagewindow.Picture.Image = imagebox.Image
        imagewindow.ShowDialog()
    End Sub

    Private Sub aggiungirecente(ueue As String)
        If ueue = "" Then Exit Sub

        Dim opzione1 As String = impostaaggiornamento.LeggiOpzione("", "recente1")
        Dim opzione2 As String = impostaaggiornamento.LeggiOpzione("", "recente2")
        Dim opzione3 As String = impostaaggiornamento.LeggiOpzione("", "recente3")

        If ueue = opzione1 Or ueue = opzione2 Then Exit Sub

        opzione3 = opzione2
        opzione2 = opzione1
        opzione1 = ueue

        impostaaggiornamento.SalvaOpzione("", "recente1", opzione1, False)
        impostaaggiornamento.SalvaOpzione("", "recente2", opzione2, False)
        impostaaggiornamento.SalvaOpzione("", "recente3", opzione3, False)
    End Sub

    Private Sub copyappbtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class