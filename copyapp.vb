Public Class copyapp
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Label5.Click

    End Sub
    Public Sub Button4_MouseLeave() Handles Button4.MouseLeave, Label5.MouseLeave
        Label5.Font = New Font(Label5.Font, FontStyle.Regular)
    End Sub
    Public Sub Button4_MouseEnter() Handles Button4.MouseEnter, Label5.MouseEnter
        Label5.Font = New Font(Label5.Font, FontStyle.Bold)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Label3.Click

    End Sub
    Public Sub Button3_MouseLeave() Handles Button3.MouseLeave, Label3.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
    End Sub
    Public Sub Button3_MouseEnter() Handles Button3.MouseEnter, Label3.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
    End Sub

    Private Sub copyapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class