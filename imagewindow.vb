Public Class imagewindow
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Picture.Click
        Close()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

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

    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005

    Private Sub Form_MouseWheel(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseWheel

        'if very sensitive mouse, change 0.00005 to something even smaller   
        _scaleDelta = Math.Sqrt(Picture.Width * Picture.Height) * 0.00005

        If e.Delta < 0 Then
            _scale -= _scaleDelta
        ElseIf e.Delta > 0 Then
            _scale += _scaleDelta
        End If

        If e.Delta <> 0 Then _
        Picture.Size = New Size(CInt(Math.Round(_originalSize.Width * _scale)),
                                    CInt(Math.Round(_originalSize.Height * _scale)))

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor

        Picture.SizeMode = PictureBoxSizeMode.StretchImage

        'init this from here or a method depending on your needs
        If Picture.Image IsNot Nothing Then
            Picture.Size = Panel1.Size
            _originalSize = Panel1.Size
        End If

    End Sub
End Class