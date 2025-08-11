Public Class aftertool
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

    Dim pg As Integer
    Dim p2 As Integer
    Dim p11 As Integer
    Dim p22 As Integer
    Dim p33 As Integer
    Dim lt As String = ""
    Private Sub aftertool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tema()

        p2 = Panel2.Height
        pg = panelgoto.Height
        Panel2.Height = 0
        panelgoto.Height = 0
        p11 = PictureBox1.Left
        PictureBox1.Left = 0 - PictureBox1.Width
        p22 = PictureBox2.Left
        PictureBox2.Left = p11 + PictureBox1.Width - PictureBox2.Width
        p33 = PictureBox3.Left
        PictureBox3.Left = Width + PictureBox3.Width
        lt = Label2.Text
        Label2.Text = ""

        Timer1.Start()
    End Sub

    Private Sub temabtn_Click(sender As Object, e As EventArgs) Handles temabtn.Click
        Welcome17.formicon.Image = My.Resources.Ryb_colorwheel_svg
        Welcome17.Text = "Modifica il Tema"
        Welcome17.TitleText.Text = "Modifica il Tema"
        Welcome17.ShowDialog()
    End Sub
    Private Sub tema_MouseLeave() Handles temabtn.MouseLeave
        temalbl.Font = New Font(temalbl.Font, FontStyle.Regular)
    End Sub
    Private Sub tema_MouseEnter() Handles temabtn.MouseEnter
        temalbl.Font = New Font(temalbl.Font, FontStyle.Bold)
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
    End Sub

    Dim count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case count
            Case 0
                If PictureBox1.Left < p11 Then PictureBox1.Left += 5
                If PictureBox3.Left > p33 Then PictureBox3.Left -= 5

                If PictureBox1.Left >= p11 And PictureBox3.Left <= p33 Then
                    PictureBox1.Left = p11
                    PictureBox3.Left = p33
                    PictureBox2.Visible = True
                    count = 1
                End If
            Case 1
                If PictureBox2.Left < p22 Then PictureBox2.Left += 5

                If PictureBox2.Left >= p22 Then
                    PictureBox2.Left = p22
                    Timer1.Interval = 5
                    count = 2
                End If
            Case 2
                If Label2.Text.Length = lt.Length Then
                    Timer1.Interval = 1000
                    count = 22
                    Exit Sub
                End If

                Label2.Text = lt.Substring(0, Label2.Text.Length + 1)
            Case 22
                Timer1.Interval = 10
                count = 3
            Case 3
                If Panel2.Height < p2 Then Panel2.Height += 5
                If panelgoto.Height < pg Then panelgoto.Height += 5

                If panelgoto.Height >= pg And Panel2.Height >= p2 Then
                    Timer1.Stop()
                    panelgoto.Height = pg
                    Panel2.Height = p2
                    temabtn.Enabled = True
                    gobtn.Enabled = True
                End If
        End Select
    End Sub

    Private Sub gobtn_Click(sender As Object, e As EventArgs) Handles gobtn.Click
        Close()
    End Sub
    Private Sub gobtn_MouseLeave() Handles gobtn.MouseLeave
        golbl.Font = New Font(golbl.Font, FontStyle.Regular)
    End Sub
    Private Sub gobtn_MouseEnter() Handles gobtn.MouseEnter
        golbl.Font = New Font(golbl.Font, FontStyle.Bold)
    End Sub
End Class