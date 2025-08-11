Imports System.IO

Public Class Welcome
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
        If chiudisino = False Then e.Cancel = True
    End Sub

    Dim str1 = "Benvenuto"
    Dim str2 = "in"
    Dim str3 = "INSTALLER"
    Dim str4 = "Benvenuto in"
    Dim count As Integer = 0
    Dim fase As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If INIZIO.Visible = True Then
            INIZIO.Visible = False
        Else
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chiudisino = False
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        ph = panelgoto.Height
        panelgoto.Height = 0
        p2 = Panel2.Height
        Panel2.Height = 0
        ip = installerpic.Location.Y
        installerpic.Location = New Point(installerpic.Location.X, 0 - installerpic.Height)
        Timer1.Start()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        INIZIO.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If fase = 0 Then
            If Label1.Text.Length = str1.Length Then
                Timer2.Interval = 250
                count = 0
                fase = 1
                Exit Sub
            End If
            Label1.Text = str1.Substring(0, count)
        ElseIf fase = 1 Then
            Timer2.Interval = 50
            If Label2.Text.Length = str2.Length Then
                Timer2.Interval = 250
                count = 0
                fase = 2
                Exit Sub
            End If
            Label2.Text = str2.Substring(0, count)
        ElseIf fase = 2 Then
            Timer2.Interval = 50
            If Label3.Text.Length = str3.Length Then
                Timer2.Interval = 250
                count = 0
                fase = 3
                Exit Sub
            End If
            Label3.Text = str3.Substring(0, count)
        ElseIf fase = 3 Then
            Timer2.Interval = 50
            If Label2.Text.Length > 0 Then Label2.Text = Label2.Text.Substring(0, Label2.Text.Length - 1)
            If Label1.Text.Length > 0 Then Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 1)
            If Label4.Text.Length = str4.Length Then
                count = 0
                fase = 4
                Timer2.Stop()
                Timer3.Start()
                Exit Sub
            End If
            Label4.Text = str4.Substring(0, count)
        End If

        count = count + 1
    End Sub

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        chiudisino = False
        vai.Enabled = False
        closebutton.Enabled = False
        panelcheck.BringToFront()
        panelcheck.Visible = True
        Cursor = Cursors.WaitCursor
        internetanimation = True
        Timer3.Start()
    End Sub
    Private Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Dim ph As Integer
    Dim p2 As Integer
    Dim ip As Integer
    Dim internetanimation As Boolean = False
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If internetanimation = False Then
            If panelgoto.Height < ph And installerpic.Location.Y = ip Then
                panelgoto.Height += 5
            ElseIf installerpic.Location.Y = ip Then
                panelgoto.Height = ph
            End If

            If Panel2.Height < p2 And installerpic.Location.Y = ip Then
                Panel2.Height += 5
            ElseIf installerpic.Location.Y = ip Then
                Panel2.Height = p2
            End If

            If installerpic.Location.Y < ip Then
                installerpic.Location = New Point(installerpic.Location.X, installerpic.Location.Y + 5)
            Else
                installerpic.Location = New Point(installerpic.Location.X, ip)
            End If

            If panelgoto.Height = ph And Panel2.Height = p2 And installerpic.Location.Y = ip Then
                vai.Enabled = True
                closebutton.Enabled = True
                chiudisino = True
                TopMost = False
                Timer3.Stop()
            End If
        Else
            If panelgoto.Height >= 0 Then
                panelgoto.Height -= 5
            Else
                panelgoto.Height = 0
            End If

            If Panel2.Height >= 0 Then
                Panel2.Height -= 5
            Else
                Panel2.Height = 0
            End If

            If panelgoto.Height = 0 And Panel2.Height = 0 Then
                Timer3.Stop()
                checkinternet()
            End If
        End If
    End Sub

    Private Async Sub checkinternet()
        Dim errore As Boolean = False
        Dim taskcheck As New Task(Sub()
                                      Try
                                          If Directory.Exists(Application.StartupPath & "\Fondamental\Settings\Backup") Then
                                              Directory.Delete(Application.StartupPath & "\Fondamental\Settings\Backup", True)
                                          End If
                                      Catch
                                      End Try
                                      Try
                                          My.Computer.Network.Ping("google.com")
                                      Catch
                                          errore = True
                                      End Try
                                  End Sub)
        taskcheck.Start()
        Await taskcheck

        Cursor = Cursors.Default

        If errore Then
            MsgBox("Si è verificato un errore durante il tentativo di collegamento a Internet.", MsgBoxStyle.Exclamation, "Controlla il collegamento.")
            internetanimation = False
            panelcheck.Visible = False
            Timer3.Start()
        Else
            Welcome015.Show()
            chiudisino = True
            Close()
        End If
    End Sub

    Public Sub redownload()
        Welcome015.Close()
        Welcome015.Show()
        chiudisino = True
        Close()
    End Sub
End Class