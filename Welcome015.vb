Imports System.IO

Public Class Welcome015
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

    Public max As Integer = 0
    Public min As Integer = 0
    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub Welcome015_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelfinito.Hide()
        Button2.Hide()
        b = barra.Width
        barra.Width = 0

        downloadfondamental()
    End Sub

    Dim b As Integer
    Private Sub downloadfondamental()
        Loading.welcomemode = True
        avanza.Start()
        Loading.updatefondamental()
    End Sub

    Public Sub seerrore()
        avanza.Stop()
        Button2.Visible = True
        vailbl.Visible = True
        barra.Width = 0
        Label2.Text = "C'è stato un errore."
        Label1.Text = "Ma non demordere, controlla la tua connessione e riprova!"
        PictureBox3.Image = My.Resources.smileys
    End Sub

    Public Sub sefatto()
        avanza.Stop()

        'Imposta le impostazioni predefinite
        impostaaggiornamento.SalvaOpzione("", "checkup", "false", False)
        impostaaggiornamento.SalvaOpzione("", "updating", "true", False)

        panelgoto.Visible = False
        principale.Visible = False
        panelfinito.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome.redownload()
    End Sub
    Private Sub Button2_MouseLeave() Handles Button2.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseEnter() Handles Button2.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        Welcome.Show()
        chiudisino = True
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Welcome15.Show()
        chiudisino = True
        Close()
    End Sub

    Private Sub avanza_Tick(sender As Object, e As EventArgs) Handles avanza.Tick
        If barra.Width < min Then
            barra.Width += 5
        ElseIf barra.Width < max And barra.Width >= min Then
            barra.Width += 2
        ElseIf barra.Width > max Then
            barra.Width = max
        End If
    End Sub

    Public Sub valore(fase As Integer)
        Select Case fase
            Case 1
                min = 0
                max = (b / 3)
            Case 2
                Label2.Text = "Sto estraendo il database ..."
                Label1.Text = "Il grosso è stato fatto, adesso ci siamo quasi!"
                PictureBox3.Image = My.Resources.zip
                min = max
                max = max + (b / 2)
            Case 3
                Label2.Text = "Quasi fatto ..."
                Label1.Text = "Mancano pochi secondi."
                PictureBox3.Image = My.Resources.operation
                min = max
                max = b
        End Select
    End Sub
End Class