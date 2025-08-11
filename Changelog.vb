Imports System.IO
Public Class Changelog
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Dim strOrig As String
            Dim rightString As String
            strOrig = ListBox1.SelectedItem
            rightString = Split(ListBox1.SelectedItem, " ")(1)
            Dim changelog As String = File.ReadAllText(Application.StartupPath & "\Fondamental\Settings\Changelog\" & rightString & ".txt", System.Text.Encoding.Default)
            RichTextBox1.Text = changelog
        Catch
            RichTextBox1.Text = "Errore ottenimento informazioni changelog! Contatta lo sviluppatore dal centro segnalazione errori oppure ripristina il programma alle impostazioni originali!"
        End Try
    End Sub

    Private Sub Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        ListBox1.BackColor = INIZIO.panelgoto.BackColor
        RichTextBox1.BackColor = ListBox1.BackColor
        RichTextBox1.ForeColor = ForeColor
        ListBox1.ForeColor = ForeColor

        ListBox1.Items.AddRange(lista)
        ListBox1.SelectedItem = "Versione " & impostaaggiornamento.versione
    End Sub

    Public Function lista()
        Dim files() As String = Directory.GetFiles(Application.StartupPath & "\Fondamental\Settings\Changelog\")
        Dim myLBitems As New List(Of String)
        For Each file As String In files
            Dim nome As String = IO.Path.GetFileName(file)
            nome = nome.Substring(0, nome.IndexOf(".txt"))
            myLBitems.Add("Versione " & nome)
        Next
        ListBox1.Items.Clear()
        myLBitems.Sort()
        'myLBitems.Reverse()

        Return myLBitems.ToArray
    End Function

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub
End Class