Public Class quandoaggiorna
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

    Private Sub quandoaggiorna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chiudisino = False
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor

        ComboBox1.SelectedItem = "5 Minuti"
        Button1.Location = New Point(Button1.Location.X, panelgoto.Height + Button1.Height)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MAI
        '2 Minuti
        '5 Minuti
        '10 Minuti
        '15 Minuti
        '30 Minuti
        chiudisino = True
        If ComboBox1.Text = "MAI" Then
            Close()
        ElseIf ComboBox1.Text = "2 Minuti" Then
            impostaaggiornamento.Timer1.Interval = 120000
            impostaaggiornamento.Timer1.Start()
            Close()
        ElseIf ComboBox1.Text = "5 Minuti" Then
            impostaaggiornamento.Timer1.Interval = 300000
            impostaaggiornamento.Timer1.Start()
            Close()
        ElseIf ComboBox1.Text = "10 Minuti" Then
            impostaaggiornamento.Timer1.Interval = 600000
            impostaaggiornamento.Timer1.Start()
            Close()
        ElseIf ComboBox1.Text = "15 Minuti" Then
            impostaaggiornamento.Timer1.Interval = 900000
            impostaaggiornamento.Timer1.Start()
            Close()
        ElseIf ComboBox1.Text = "30 Minuti" Then
            impostaaggiornamento.Timer1.Interval = 1800000
            impostaaggiornamento.Timer1.Start()
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Button1.Location.Y <= 11 Then
            Button1.Location = New Point(Button1.Location.X, Button1.Location.Y - 5)
        Else
            Timer1.Stop()
        End If
    End Sub
End Class