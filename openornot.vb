Public Class openornot
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, labeltitle.MouseDown, image.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, labeltitle.MouseMove, image.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, labeltitle.MouseUp, image.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Public name As String = ""
    Private Sub openornot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor

        If name <> "" Then labeltitle.Text = "Installare '" & name & "' ?"
    End Sub

    Private Sub gotolist_Click(sender As Object, e As EventArgs) Handles gotolist.Click
        INIZIO.checkclose()
        INIZIO.Hide()
        installa.toopen = name
        installa.Show()
        Close()
    End Sub
    Private Sub gotolist_MouseLeave() Handles gotolist.MouseLeave
        listlbl.Font = New Font(listlbl.Font, FontStyle.Regular)
    End Sub
    Private Sub gotolist_MouseEnter() Handles gotolist.MouseEnter
        listlbl.Font = New Font(listlbl.Font, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub
    Private Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub
End Class