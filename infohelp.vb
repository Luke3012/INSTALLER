Public Class infohelp
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
    Private Sub infohelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        RichTextBox1.BackColor = BackColor
        RichTextBox1.ForeColor = ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor

        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Fondamental\help.txt", System.Text.Encoding.Default).Trim
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Private Sub whatchangebtn_Click(sender As Object, e As EventArgs) Handles whatchangebtn.Click
        My.MyProject.Forms.whatchange.Close()
        My.MyProject.Forms.whatchange.oldv = impostaaggiornamento.LeggiOpzione("", "versionbefore")
        My.MyProject.Forms.whatchange.newv = impostaaggiornamento.versioncode
        My.MyProject.Forms.whatchange.ShowDialog()
    End Sub

    Private Sub whatchange_MouseLeave() Handles whatchangebtn.MouseLeave
        whatchange.Font = New Font(whatchange.Font, FontStyle.Regular)
    End Sub
    Private Sub gotoapp_MouseEnter() Handles whatchangebtn.MouseEnter
        whatchange.Font = New Font(whatchange.Font, FontStyle.Bold)
    End Sub
End Class