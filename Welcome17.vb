Imports System.Drawing.Text
Imports System.IO

Public Class Welcome17
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

    Dim chiudisino As Boolean = True
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub Welcome17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If INIZIO.Visible Or aftertool.Visible Then
            back.Hide()
            TitleText.Width += back.Width
        Else
            vai.Visible = True
            vailbl.Visible = True
            Label3.Visible = False
            chiudisino = False
        End If

        tema(Loading.theme)
    End Sub

    Private Sub tema(theme As String)
        lightmodelbl.Font = New Font(lightmodelbl.Font, FontStyle.Regular)
        nightmodelbl.Font = New Font(nightmodelbl.Font, FontStyle.Regular)

        If theme = "light" Then
            BackColor = Color.WhiteSmoke
            ForeColor = Color.Black
            panelgoto.BackColor = Color.Gainsboro
            lightmodelbl.Font = New Font(lightmodelbl.Font, FontStyle.Bold)
            R = 245
            G = 245
            B = 245
        Else
            BackColor = Color.DimGray
            ForeColor = Color.White
            panelgoto.BackColor = Color.FromArgb(255, 75, 75, 75)
            nightmodelbl.Font = New Font(nightmodelbl.Font, FontStyle.Bold)
            R = 105
            G = 105
            B = 105
        End If

        If INIZIO.Visible Or aftertool.Visible Then
            Dim back As String = Loading.theme
            Loading.theme = theme
            If INIZIO.Visible Then
                INIZIO.tema()
                HELPING.tema()
            End If
            If aftertool.Visible Then aftertool.tema()
            Loading.theme = back
            End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Welcome16.Close()
        Welcome16.Show()
        chiudisino = True
        Close()
    End Sub

    Private Sub lightmodebtn_Click(sender As Object, e As EventArgs) Handles lightmodebtn.Click
        impostaaggiornamento.SalvaOpzione("", "color", "light", False)
        Loading.theme = "light"
        lightmodelbl.Font = New Font(lightmodelbl.Font, FontStyle.Bold)
        nightmodelbl.Font = New Font(nightmodelbl.Font, FontStyle.Regular)

        If INIZIO.Visible Then
            INIZIO.tema()
            HELPING.tema()
            Close()
        End If
        If aftertool.Visible Then
            aftertool.tema()
            Close()
        End If
    End Sub
    Private Sub lightmodebtn_MouseLeave() Handles lightmodebtn.MouseLeave
        If Loading.theme = "light" Then Exit Sub
        hoveringon = Loading.theme
        TimerTema.Start()
    End Sub
    Private Sub lightmodebtn_MouseEnter() Handles lightmodebtn.MouseEnter
        If Loading.theme = "light" Then Exit Sub
        hoveringon = "light"
        TimerTema.Start()
    End Sub

    Private Sub nightmodebtn_Click(sender As Object, e As EventArgs) Handles nightmodebtn.Click
        impostaaggiornamento.SalvaOpzione("", "color", "night", False)
        Loading.theme = "night"
        nightmodelbl.Font = New Font(nightmodelbl.Font, FontStyle.Bold)
        lightmodelbl.Font = New Font(lightmodelbl.Font, FontStyle.Regular)

        If INIZIO.Visible Then
            INIZIO.tema()
            HELPING.tema()
            Close()
        End If
        If aftertool.Visible Then
            aftertool.tema()
            Close()
        End If
    End Sub
    Private Sub nightmodebtn_MouseLeave() Handles nightmodebtn.MouseLeave
        If Loading.theme = "night" Then Exit Sub
        hoveringon = Loading.theme
        TimerTema.Start()
    End Sub
    Private Sub nightmodebtn_MouseEnter() Handles nightmodebtn.MouseEnter
        If Loading.theme = "night" Then Exit Sub
        hoveringon = "night"
        TimerTema.Start()
    End Sub

    Dim change
    Dim hoveringon As String = ""
    Dim R, G, B As Integer

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        chiudisino = True
        Welcome2.BackColor = BackColor
        Welcome2.ForeColor = ForeColor
        Welcome2.panelgoto.BackColor = panelgoto.BackColor
        Welcome2.Show()
        Close()
    End Sub
    Private Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Private Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub TimerTema_Tick(sender As Object, e As EventArgs) Handles TimerTema.Tick
        If hoveringon = "" Then
            TimerTema.Stop()
            Exit Sub
        End If

        If hoveringon = "light" Then
            If R + 20 < 245 Then
                R += 20
                G += 20
                B += 20
            Else
                hoveringon = ""
                tema("light")
            End If
        ElseIf hoveringon = "night" Then
            If R - 20 > 105 Then
                R -= 20
                G -= 20
                B -= 20
            Else
                hoveringon = ""
                tema("night")
            End If
        End If

        If hoveringon <> "" Then
            BackColor = Color.FromArgb(255, R, G, B)
            ForeColor = Color.FromArgb(&HFFFFFF - RGB(R, G, B))
            panelgoto.BackColor = BackColor
        End If
        If (INIZIO.Visible = True Or aftertool.Visible = True) And hoveringon <> "" Then
            If INIZIO.Visible Then
                HELPING.BackColor = BackColor
                HELPING.ForeColor = ForeColor
                HELPING.panelgoto.BackColor = panelgoto.BackColor
                INIZIO.BackColor = BackColor
                INIZIO.ForeColor = ForeColor
                INIZIO.panelgoto.BackColor = panelgoto.BackColor
                INIZIO.image1.BackColor = panelgoto.BackColor
                INIZIO.image2.BackColor = panelgoto.BackColor
                INIZIO.image3.BackColor = panelgoto.BackColor
            End If
            If aftertool.Visible Then
                aftertool.BackColor = BackColor
                aftertool.ForeColor = ForeColor
                aftertool.panelgoto.BackColor = panelgoto.BackColor
            End If
        End If
    End Sub
End Class