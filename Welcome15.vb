Imports System.IO
Imports System.Net

Public Class Welcome15
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel1.Location.Y > punto Then
            Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y - 5)
            Exit Sub
        ElseIf panelgoto.Height < pg Then
            panelgoto.Height += 5
            Exit Sub
        End If

        Panel1.Location = New Point(Panel1.Location.X, punto)
        panelgoto.Height = pg
        vai.Enabled = True
        help.Enabled = True
        Timer1.Stop()
    End Sub

    Dim punto As Integer
    Dim pg As Integer
    Private Sub Welcome15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        punto = Panel1.Location.Y
        Panel1.Location = New Point(Panel1.Location.X, Height)
        pg = panelgoto.Height
        panelgoto.Height = 0
        Timer1.Start()
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        infohelp.Close()

        If MessageBox.Show("Sei sicuro/a di voler chiudere INSTALLER? Alla prossima apertura del programma riprenderai la configurazione a partire dalla fase successiva.", "Chiusura INSTALLER", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            INIZIO.Close()
        End If
    End Sub

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        infohelp.Close()
        Welcome16.Close()
        Welcome16.Show()
        chiudisino = True
        Close()
    End Sub
    Private Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        If File.Exists(Application.StartupPath & "\Fondamental\help.txt") Then File.Delete(Application.StartupPath & "\Fondamental\help.txt")
        If My.Computer.Network.IsAvailable = True Then
            Try
                helplbl.Text = "Attendi ..."
                help.Enabled = False
                vai.Enabled = False
                Dim client As WebClient = New WebClient
                AddHandler client.DownloadFileCompleted, AddressOf informazioniprese
                client.DownloadFileAsync(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE32hPzTL19JzLbhN0F/root/content"), Application.StartupPath & "\Fondamental\help.txt")
            Catch
                helplbl.Text = "Impossibile scaricare!"
                help.Enabled = True
                vai.Enabled = True
            End Try
        End If
    End Sub
    Private Sub help_MouseLeave() Handles help.MouseLeave
        helplbl.Font = New Font(helplbl.Font, FontStyle.Regular)
    End Sub
    Private Sub help_MouseEnter() Handles help.MouseEnter
        helplbl.Font = New Font(helplbl.Font, FontStyle.Bold)
    End Sub

    Private Sub informazioniprese()
        help.Enabled = True
        vai.Enabled = True
        helplbl.Text = "Leggi il ""Blog"""
        infohelp.Close()
        Dim ue As Integer = infohelp.panelgoto.Top
        infohelp.panelgoto.Height = 0
        infohelp.Height = ue
        infohelp.ShowDialog()
    End Sub
End Class