Public Class nameapp
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, Label1.MouseDown, Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, Label1.MouseMove, Label2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, Label1.MouseUp, Label2.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IO.Directory.Exists(installa.outputfolder & appname.Text) Then
            MsgBox("L'applicazione """ & appname.Text & """ già esiste! Scegli un altro nome.", MsgBoxStyle.Exclamation, "Nome già esistente!")
        ElseIf appname.Text.Replace(" ", "") = "" Then
            MsgBox("Non puoi inserire un nome vuoto! :c", MsgBoxStyle.Exclamation, "Attenzione!")
        Else
            'continua...
            If editmode = False Then createapp.Close()
            createapp.appname = appname.Text
            Hide()
            copyapp.ShowDialog()
            createapp.Show()
            Close()
        End If
    End Sub
    Public Sub Button2_MouseLeave() Handles Button2.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Public Sub Button2_MouseEnter() Handles Button2.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Dim editmode As Boolean = True
    Private Sub nameapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        ForeColor = INIZIO.ForeColor
        If ForeColor <> Color.Black Then appname.BackColor = panelgoto.BackColor
        appname.ForeColor = ForeColor
        Button2.FlatAppearance.BorderColor = panelgoto.BackColor
        Button1.FlatAppearance.BorderColor = panelgoto.BackColor

        If appname.Text = "" Then
            editmode = False

            Dim num As Integer = 1
            For Each file In IO.Directory.GetFiles(installa.outputfolder)
                If IO.File.Exists(installa.outputfolder & "Applicazione " & num) Then
                    num += 1
                Else
                    Exit For
                End If
            Next
            appname.Text = "Applicazione " & num
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
    End Sub

    Private Sub appname_TextChanged(sender As Object, e As EventArgs) Handles appname.TextChanged
        If appname.Text.Replace(" ", "") = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
End Class