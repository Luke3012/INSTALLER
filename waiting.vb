Public Class waiting
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, PictureBox1.MouseDown, Label1.MouseDown, formicon.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, PictureBox1.MouseMove, Label1.MouseMove, formicon.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, PictureBox1.MouseUp, Label1.MouseUp, formicon.MouseUp
        drag = False
        Cursor = Cursors.WaitCursor
    End Sub
    ' Fine cose per il pannello
    Private Sub waiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
    End Sub
End Class