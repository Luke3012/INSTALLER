Public Class Welcome2
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, pic.MouseDown, Label1.MouseDown, Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, pic.MouseMove, Label1.MouseMove, Label2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, pic.MouseUp, Label1.MouseUp, Label2.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Dim pg As Integer
    Dim v As Integer
    Dim p As Integer
    Dim str As String = "Ma ora passiamo alle cose serie."
    Private Sub Welcome3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pg = panelgoto.Height
        p = pic.Location.Y
        pic.Location = New Point(pic.Location.X, 0 - pic.Height)
        v = vai.Location.Y
        vai.Location = New Point(vai.Location.X, pg + vai.Height)
        help.Location = New Point(help.Location.X, vai.Location.Y)
        panelgoto.Height = 0
        Label2.Text = ""

        Timer1.Start()
    End Sub

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        chiudisino = True
        Close()

        System.Windows.Forms.Application.Restart()
    End Sub
    Private Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        INIZIO.BackColor = BackColor
        INIZIO.ForeColor = ForeColor
        INIZIO.panelgoto.BackColor = panelgoto.BackColor
        AboutBox1.ShowDialog()
    End Sub
    Private Sub help_MouseLeave() Handles help.MouseLeave
        helplbl.Font = New Font(helplbl.Font, FontStyle.Regular)
    End Sub
    Private Sub help_MouseEnter() Handles help.MouseEnter
        helplbl.Font = New Font(helplbl.Font, FontStyle.Bold)
    End Sub

    Dim count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case count
            Case 0
                count = 1
                Timer1.Interval = 30
            Case 1
                If Label2.Text.Length = str.Length Then
                    Timer1.Interval = 500
                    count = 11
                    Exit Sub
                End If
                Label2.Text = str.Substring(0, Label2.Text.Length + 1)
            Case 11
                Timer1.Interval = 10
                count = 2
            Case 2
                If panelgoto.Height < pg Then
                    panelgoto.Height += 5
                Else
                    panelgoto.Height = pg
                End If

                If pic.Location.Y < p Then
                    pic.Location = New Point(pic.Location.X, pic.Location.Y + 5)
                Else
                    pic.Location = New Point(pic.Location.X, p)
                End If

                If pic.Location.Y = p And panelgoto.Height = pg Then count = 3
            Case 3
                If vai.Location.Y > v Then
                    vai.Location = New Point(vai.Location.X, vai.Location.Y - 5)
                    help.Location = New Point(help.Location.X, vai.Location.Y)
                Else
                    Timer1.Stop()
                    vai.Location = New Point(vai.Location.X, v)
                    help.Location = New Point(help.Location.X, v)
                    vai.Enabled = True
                    help.Enabled = True
                    vailbl.Visible = True
                    helplbl.Visible = True
                End If
        End Select
    End Sub
End Class