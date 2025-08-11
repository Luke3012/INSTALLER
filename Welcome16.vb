Imports System.IO

Public Class Welcome16
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, Panel2.MouseDown, formicon.MouseDown, TitleText.MouseDown, Label1.MouseDown, Label2.MouseDown, PictureBox1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, Panel2.MouseMove, formicon.MouseMove, TitleText.MouseMove, Label1.MouseMove, Label2.MouseMove, PictureBox1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, Panel2.MouseUp, formicon.MouseUp, TitleText.MouseUp, Label1.MouseUp, Label2.MouseUp, PictureBox1.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Dim p2 As Integer
    Dim pg As Integer
    Private Sub Welcome16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        p2 = Panel2.Height
        pg = panelgoto.Height
        mode = False
        Timer2.Start()
        impostaaggiornamento.SalvaOpzione("", "updating", "true", False)

        impostaaggiornamento.welcomemode = True
        impostaaggiornamento.verificaaggiornamento()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If INIZIO.Visible = True Then
            INIZIO.Visible = False
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Welcome15.Show()
        chiudisino = True
        Close()
    End Sub

    Public Sub valore(fase As Integer)
        Select Case fase
            Case 1
                Label1.Text = "Controllo gli aggiornamenti ..."
                Label2.Text = "Ci riproviamo."
                PictureBox1.Image = My.Resources.giphy1
            Case 11
                Label1.Text = "Scarico l'aggiornamento ..."
                Label2.Text = "Sono stati trovati nuovi aggiornamenti."
            Case 3
                Label1.Text = "Aggiornamento scaricato."
                Label2.Text = "Sto per riavviare, tra tre secondi esatti ci rivedremo qui!"
                PictureBox1.Image = My.Resources.test
                chiudisino = True
            Case 4
                Label1.Text = "Oh no ..."
                Label2.Text = "Si è verificato un errore durante il controllo, ma non demordere! Controlla la tua connessione e riprova."
                PictureBox1.Image = My.Resources.smileys
                mode = True
                Timer2.Start()
            Case 5
                Label1.Text = "Nessun aggiornamento disponibile."
                Label2.Text = "Fantastico! Clicca su 'Prosegui' per procedere."
                PictureBox1.Image = My.Resources.updatedone
                mode = True
                Timer2.Start()
        End Select
    End Sub

    Dim mode As Boolean = False
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If mode Then
            If panelgoto.Height < pg Then
                panelgoto.Height += 5
            Else
                panelgoto.Height = pg
            End If

            If Panel2.Height < p2 Then
                Panel2.Height += 5
            Else
                Panel2.Height = p2
            End If

            If panelgoto.Height = pg And Panel2.Height = p2 Then
                TopMost = False
                Timer2.Stop()
                retry.Enabled = True
                vai.Enabled = True
                back.Enabled = True
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
                TopMost = False
                Timer2.Stop()
            End If
        End If
    End Sub

    Private Sub retry_Click(sender As Object, e As EventArgs) Handles retry.Click
        retry.Enabled = False
        vai.Enabled = False
        back.Enabled = False
        valore(1)
        mode = False
        Timer2.Start()

        impostaaggiornamento.welcomemode = True
        impostaaggiornamento.verificaaggiornamento()
    End Sub
    Private Sub retry_MouseLeave() Handles retry.MouseLeave
        retrylbl.Font = New Font(retrylbl.Font, FontStyle.Regular)
    End Sub
    Private Sub retry_MouseEnter() Handles retry.MouseEnter
        retrylbl.Font = New Font(retrylbl.Font, FontStyle.Bold)
    End Sub

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        Try
            impostaaggiornamento.SalvaOpzione("", "updating", "", True)
        Catch
        End Try
        Welcome17.Show()
        chiudisino = True
        Close()
    End Sub
    Private Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub
End Class