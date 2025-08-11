Imports System.IO
Imports System.Threading

Public Class HELPING
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label7.Text = "Verifico aggiornamenti..."
        Button5.Enabled = False
        PictureBox4.Show()

        impostaaggiornamento.verificaaggiornamento()
    End Sub

    Private Sub Button6_MouseEnter() Handles Button6.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        Button6.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button6_MouseLeave() Handles Button6.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
        Button6.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub Button2_MouseEnter() Handles Button2.MouseEnter
        Label4.Font = New Font(Label4.Font, FontStyle.Bold)
        Button2.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button2_MouseLeave() Handles Button2.MouseLeave
        Label4.Font = New Font(Label4.Font, FontStyle.Regular)
        Button2.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub Button9_MouseEnter() Handles Button9.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
        Button9.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub Button9_MouseLeave() Handles Button9.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
        Button9.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        othersettings.Close()
        othersettings.ShowDialog()
    End Sub

    Private Sub HELPING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Hide()
        tema()

        If impostaaggiornamento.already = True Then
            Label7.Text = "Verifico aggiornamenti..."
            Button5.Enabled = False
            PictureBox4.Show()
        End If
    End Sub

    Public Sub tema()
        If Loading.theme = "light" Then
            BackColor = Color.WhiteSmoke
            panelgoto.BackColor = Color.Gainsboro
            ForeColor = Color.Black
        Else
            BackColor = Color.DimGray
            panelgoto.BackColor = Color.FromArgb(255, 75, 75, 75)
            ForeColor = Color.White
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Close()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Sei sicuro/a di voler procedere? Chiuderò INSTALLER.", "RIPRISTINO", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            impostaaggiornamento.SalvaOpzione("", "restore", "true", False)
            System.Windows.Forms.Application.Restart()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateDetermination.Close()
        UpdateDetermination.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        deleteappsnew.Close()
        deleteappsnew.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome17.Close()
        Welcome17.formicon.Image = My.Resources.Ryb_colorwheel_svg
        Welcome17.Text = "Modifica il Tema"
        Welcome17.TitleText.Text = "Modifica il Tema"
        Welcome17.ShowDialog()
    End Sub
End Class