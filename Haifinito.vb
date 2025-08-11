Public Class Haifinito
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

    Public chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub Haifinito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chiudisino = False
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        Label4.BackColor = panelgoto.BackColor
        initpos = Button1.Location.Y
        Button1.Location = New Point(Button1.Location.X, panelgoto.Height + Button1.Height)

        If errors <> "" Then
            PictureBox1.Visible = False
            Label2.Text = "Ma sono stati trovati alcuni errori ..."
            Label4.Text = errors
        End If

        Timer1.Start()
    End Sub

    Public errors As String
    Private Sub back_Click(sender As Object, e As EventArgs)
        chiudisino = True
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Button1.Location.Y < initpos Then
            Button1.Location = New Point(Button1.Location.X, Button1.Location.Y - 5)
        Else
            after()
        End If
    End Sub

    Private initpos As Integer
    Private Sub after()
        Timer1.Stop()
        Label3.Visible = True
        Label2.Visible = True
        Button1.Enabled = True
        If errors <> "" Then
            Label4.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Label3.Visible = False
        Timer2.Start()
    End Sub
    Private Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
    End Sub
    Private Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Button1.Location.Y > (0 - Button1.Height - Button1.Height / 2) Then
            Button1.Location = New Point(Button1.Location.X, Button1.Location.Y - 5)
        Else
            chiudisino = True
            Close()
            Timer2.Stop()
        End If
    End Sub
End Class