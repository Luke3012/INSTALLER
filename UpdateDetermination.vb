Imports System.IO

Public Class UpdateDetermination
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

    Private Sub UpdateDetermination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        descriptionlabel.BackColor = INIZIO.panelgoto.BackColor
        If impostaaggiornamento.LeggiOpzione("", "checkup") = "true" Then
            switchbox.Image = My.Resources.switchon
            testo(True)
        Else
            switchbox.Image = My.Resources.switchoff
            testo(False)
        End If
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Sub testo(valore As Boolean)
        If valore = False Then
            titlelabel.Text = "Aggiornamento automatico di INSTALLER disabilitato"
            descriptionlabel.Text = "All'avvio di INSTALLER verrà effettuato un controllo aggiornamenti. Tuttavia, sarà aggiornato in maniera automatica soltanto il Database."
        Else
            titlelabel.Text = "Aggiornamento automatico di INSTALLER abilitato"
            descriptionlabel.Text = "All'avvio di INSTALLER verrà effettuato un controllo aggiornamenti. Tutti gli aggiornamenti saranno applicati in maniera automatica."
        End If
    End Sub

    Private Sub switchbox_Click(sender As Object, e As EventArgs) Handles switchbox.Click
        If titlelabel.Text.Contains("disabilitato") Then
            impostaaggiornamento.SalvaOpzione("", "checkup", "true", False)
            switchbox.Image = My.Resources.switchon
            testo(True)
            HELPING.Label7.Text = "Verifico aggiornamenti..."
            HELPING.Button5.Enabled = False
            HELPING.PictureBox4.Show()
            impostaaggiornamento.verificaaggiornamento()
        Else
            impostaaggiornamento.SalvaOpzione("", "checkup", "false", False)
            switchbox.Image = My.Resources.switchoff
            testo(False)
        End If
    End Sub
End Class