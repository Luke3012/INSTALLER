Public Class whatchange
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

    Public oldv As Integer
    Public newv As Integer
    Private Sub whatchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        updatetext.BackColor = INIZIO.panelgoto.BackColor
        updatetext.ForeColor = ForeColor

        If oldv = 0 Then oldv = newv

        Dim list As Array = Changelog.lista()
        Dim lastindex As Integer = 0
        For c = 0 To list.Length - 1
            Dim stringa As String = ""
            If impostaaggiornamento.codificaversione(list(c)) <= newv And impostaaggiornamento.codificaversione(list(c)) > oldv Then
                stringa = list(c)
            ElseIf impostaaggiornamento.codificaversione(list(c)) = newv And impostaaggiornamento.codificaversione(list(c)) = oldv And oldv = newv Then
                stringa = list(c)
                lastindex = c
            End If

            If stringa = "" Then Continue For
            If updatetext.Text <> "" Then updatetext.Text = updatetext.Text & vbCrLf & vbCrLf
            updatetext.Text = updatetext.Text & stringa & vbCrLf
            updatetext.Text = updatetext.Text & IO.File.ReadAllText(Application.StartupPath & "\Fondamental\Settings\Changelog\" & stringa.Replace("Versione ", "") & ".txt", System.Text.Encoding.Default).Replace("VERSIONE " & stringa.Replace("Versione ", ""), "")
        Next

        If updatetext.Text = "" Then
            Panel1.Visible = False
            panelnothing.Visible = True
        Else
            If oldv = newv Then
                oldversion.Text = list(lastindex - 1).Replace("Versione ", "")
            Else
                oldversion.Text = impostaaggiornamento.determinaversione(oldv)
            End If

            newversion.Text = impostaaggiornamento.determinaversione(newv)
        End If
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub
End Class