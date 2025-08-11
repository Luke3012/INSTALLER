Imports System.IO

Public Class editlista
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

    Public Sub create()
        addlist.Close()
        addlist.ShowDialog()
        If addlist.stringa = "" Then
            Liste.Show()
            chiudisino = True
            Close()
            Exit Sub
        End If
        additems()
        rename.Visible = False
    End Sub

    Private Sub editlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        GroupBox1.ForeColor = ForeColor
        GroupBox2.ForeColor = ForeColor
        ListBox2.BackColor = INIZIO.panelgoto.BackColor
        ListBox2.ForeColor = ForeColor
        TitleText.Text = "Modifica '" & namelist & "'"
        TextBox1.Text = namelist
        additems()
        rename.Visible = False
    End Sub

    Public namelist As String = "Lista"
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If rename.Visible = True Then rename.PerformClick()
        Liste.latestbtn = TextBox1.Text
        chiudisino = True
        Close()
        Liste.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        GroupBox1.Enabled = True
    End Sub

    Private Sub mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles up.MouseLeave, down.MouseLeave, del.MouseLeave, addp.MouseLeave, rename.MouseLeave
        sender.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub mouseenter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles up.MouseEnter, down.MouseEnter, del.MouseEnter, addp.MouseEnter, rename.MouseEnter
        sender.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub additems()
        GroupBox1.Enabled = False
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        For Each line As String In File.ReadAllLines(installa.outputfolder & "Settings\Lists\" & namelist)
            ListBox1.Items.Add(line)
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            ListBox2.Items.Add(parts(1))
        Next
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If MessageBox.Show("Rimuovo l'elemento selezionato?", "'" & ListBox2.SelectedItem & "'", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim line As String
            Dim Input As StreamReader
            Dim PolicyIdCode As String
            Dim strFile As New ArrayList
            PolicyIdCode = ListBox1.SelectedItem
            Input = File.OpenText(installa.outputfolder & "Settings\Lists\" & namelist)
            While Input.Peek <> -1
                line = Input.ReadLine
                If Not line.Contains(PolicyIdCode) Then
                    strFile.Add(line)
                End If
            End While
            Input.Close()
            If File.Exists(installa.outputfolder & "Settings\Lists\" & namelist) Then
                File.Delete(installa.outputfolder & "Settings\Lists\" & namelist)
            End If
            Dim objWriter As New System.IO.StreamWriter(installa.outputfolder & "Settings\Lists\" & namelist, True)
            For Each item As String In strFile
                objWriter.WriteLine(item)
            Next
            objWriter.Flush()
            objWriter.Close()
            additems()
        End If
        If ListBox1.Items.Count = 0 Then
            File.Delete(installa.outputfolder & "Settings\Lists\" & namelist)
            chiudisino = True
            Close()
            Liste.Show()
        End If
    End Sub

    Private Sub up_Click(sender As Object, e As EventArgs) Handles up.Click
        If ListBox1.SelectedIndex > 0 Then
            Dim F = ListBox1.SelectedIndex - 1
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F
            ListBox2.Items.Insert(F, ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            ListBox2.SelectedIndex = F
        End If
        Dim W As IO.StreamWriter
        Dim i As Integer
        W = New IO.StreamWriter(installa.outputfolder & "Settings\Lists\" & namelist)
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub

    Private Sub down_Click(sender As Object, e As EventArgs) Handles down.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            Dim F = ListBox1.SelectedIndex + 2
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F - 1
            ListBox2.Items.Insert(F, ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            ListBox2.SelectedIndex = F - 1
        End If
        Dim W As IO.StreamWriter
        Dim i As Integer
        W = New IO.StreamWriter(installa.outputfolder & "Settings\Lists\" & namelist)
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = namelist And Not TextBox1.Text = "" Then
            rename.Visible = True
            AcceptButton = rename
        Else
            rename.Visible = False
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex = -1 Then
            Exit Sub
        End If
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub addp_Click(sender As Object, e As EventArgs) Handles addp.Click
        addlist.Close()
        addlist.editmode = True
        addlist.ShowDialog()
        additems()
    End Sub

    Private Sub rename_Click(sender As Object, e As EventArgs) Handles rename.Click
        Try
            My.Computer.FileSystem.RenameFile(installa.outputfolder & "Settings\Lists\" & namelist, TextBox1.Text)
            namelist = TextBox1.Text
            TitleText.Text = "Modifica '" & namelist & "'"
        Catch
            MsgBox("Non puoi rinominare la lista col seguente nome : " & TextBox1.Text, MsgBoxStyle.Exclamation, "Impossibile rinominare")
            TextBox1.Text = namelist
        End Try
        rename.Visible = False
    End Sub
End Class