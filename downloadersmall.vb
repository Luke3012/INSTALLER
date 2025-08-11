Imports Microsoft.VisualBasic.Devices

Public Class downloadersmall
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Panel2.MouseDown, formicon.MouseDown, TitleText.MouseDown, labelprogress.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Panel2.MouseMove, formicon.MouseMove, TitleText.MouseMove, labelprogress.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Panel2.MouseUp, formicon.MouseUp, TitleText.MouseUp, labelprogress.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Public dove As Point = Nothing
    Private task As String = "Task in corso: 0"
    Public install As String = "---Sto installando alcune applicazioni---"
    Private Sub downloadersmall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dove = Nothing Then
            Location = New Point(downloader.Left + downloader.Width - Width, downloader.Top + downloader.Height - Height)
        Else
            Location = dove
        End If
        If Top < 0 Then Top = 0
        If Top > Screen.PrimaryScreen.WorkingArea.Height Then Top = Screen.PrimaryScreen.WorkingArea.Height - Height

        downloader.Hide()

        BackColor = downloader.BackColor
        ForeColor = downloader.ForeColor

        tasky(downloader.status.Text)
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        If installa.WindowState = FormWindowState.Minimized Then installa.WindowState = FormWindowState.Normal
        If listeinstall.WindowState = FormWindowState.Minimized Then
            listeinstall.WindowState = FormWindowState.Normal
            listeinstall.ShowInTaskbar = True
        End If

        downloader.Show()
        If installa.Visible = True Then
            downloader.Location = New Point(Left + Width - downloader.Width, Top + Height - downloader.Height)
            If downloader.Top < 0 Then downloader.Top = 0
        End If

        Close()
    End Sub

    Public Sub tasky(testo As String)
        task = testo

        If install <> downloader.status1.Text And install <> downloader.status2.Text And install <> downloader.status3.Text And downloader.listmode = False And downloader.number = 0 Then install = "---Nessuna installazione in corso---"
        If task = "Task in corso: 0" And downloader.listmode = False Then install = "---Nessuna installazione in corso---"

        If mousesopra Then
            labelprogress.Text = install
        Else
            labelprogress.Text = task
        End If
    End Sub

    Private warningmode As Boolean = False
    Private mousesopra As Boolean = False
    Public Sub warning(testo As String)
        Try
            Timer1.Stop()
        Catch
        End Try

        warningmode = True
        labelprogress.Text = testo
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        warningmode = False

        If mousesopra Then
            labelprogress.Text = install
        Else
            labelprogress.Text = task
        End If
    End Sub

    Private Sub labelprogress_MouseLeave() Handles labelprogress.MouseLeave
        mousesopra = False
        If warningmode = False Then Timer1.Start()
    End Sub
    Private Sub labelprogress_MouseEnter() Handles labelprogress.MouseEnter
        Try
            If warningmode = False Then
                Timer1.Stop()
                labelprogress.Text = install
            End If
        Catch
        End Try

        mousesopra = True
    End Sub
End Class