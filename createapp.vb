Public Class createapp
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

    Public appname As String = ""
    Private appdescription As String = ""
    Private Sub createapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        apppic.BackColor = INIZIO.panelgoto.BackColor
        ForeColor = INIZIO.ForeColor
        Button2.FlatAppearance.BorderColor = panelgoto.BackColor
        Button1.FlatAppearance.BorderColor = panelgoto.BackColor
        custom.BackColor = INIZIO.panelgoto.BackColor
        trentadue.BackColor = INIZIO.panelgoto.BackColor
        sessantaquattro.BackColor = INIZIO.panelgoto.BackColor

        TitleText.Text = "Gestisci " & appname
        labelappname.Text = appname
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Public Sub Button2_MouseLeave() Handles Button2.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Public Sub Button2_MouseEnter() Handles Button2.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub labelappname_Click(sender As Object, e As EventArgs) Handles labelappname.Click
        nameapp.Close()
        nameapp.appname.Text = labelappname.Text
        nameapp.ShowDialog()

        If appname <> labelappname.Text Then
            labelappname.Text = appname
            TitleText.Text = "Gestisci " & appname
        End If
    End Sub
    Public Sub labelappname_MouseLeave() Handles labelappname.MouseLeave
        labelappname.BackColor = BackColor
        labelappname.Text = appname
    End Sub
    Public Sub labelappname_MouseEnter() Handles labelappname.MouseEnter
        labelappname.BackColor = panelgoto.BackColor
        labelappname.Text = "[Clicca per modificare]"
    End Sub

    Private Sub apppic_Click(sender As Object, e As EventArgs) Handles apppic.Click
        If chooseimg.ShowDialog() = DialogResult.OK Then
            apppic.Image = Image.FromFile(chooseimg.FileName)
        End If
    End Sub

    Private Sub labelsteps_Click(sender As Object, e As EventArgs) Handles labelsteps.Click

    End Sub
    Public Sub labelsteps_MouseLeave() Handles labelsteps.MouseLeave
        labelsteps.BackColor = BackColor
        If appdescription.Replace(" ", "") <> "" Then labelsteps.Text = "[Clicca per modificare]"
    End Sub
    Public Sub labelsteps_MouseEnter() Handles labelsteps.MouseEnter
        labelsteps.BackColor = panelgoto.BackColor
        labelsteps.Text = "[Clicca per modificare]"
    End Sub

    Private Sub custom_Click(sender As Object, e As EventArgs) Handles custom.Click
        editmode(0)
    End Sub

    Private Sub trentadue_Click(sender As Object, e As EventArgs) Handles trentadue.Click
        editmode(1)
    End Sub

    Private Sub sessantaquattro_Click(sender As Object, e As EventArgs) Handles sessantaquattro.Click
        editmode(2)
    End Sub

    Private Sub editmode(number As Integer)

    End Sub
End Class