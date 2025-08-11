Imports System.IO

Public Class installa
    Public outputfolder As String = Loading.loadedwhere & "Fondamental\"
    Dim searchlist As String()
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

    Public chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Private Sub installa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        waiting.ForeColor = INIZIO.ForeColor
        BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        ForeColor = INIZIO.ForeColor
        If ForeColor <> Color.Black Then ComboBox1.BackColor = panelgoto.BackColor
        ComboBox1.ForeColor = ForeColor

        disabilita(False)
        waiting.Close()
        waiting.Show()
        wait.Start()
    End Sub

    Public toopen As String = ""
    Private Sub after()
        wait.Stop()
        Panel1.Controls.Clear()
        lista.Items.Clear()
        Dim number As Integer = 6
        Dim number2 As Integer = 1
        Dim number3 As Integer = 0
        Dim lal As Button
        Dim lals As Label

        For Each folder In Directory.GetDirectories(outputfolder)
            If Not Path.GetFileName(folder) = "Settings" And Not Path.GetFileName(folder) = "Updater" Then lista.Items.Add(folder)
        Next


        For Each folder In lista.Items
            If Not Path.GetFileName(folder) = "Settings" And Not Path.GetFileName(folder) = "Updater" Then
                number3 += 1
                lal = New Button
                lals = New Label
                lal.Name = "program" & number3
                lal.Width = 169.5
                lal.Height = 120
                lals.Width = lal.Width
                lals.Height = 20
                If number >= Panel1.Width - lal.Width Then
                    number = 6
                    number2 += lal.Height + lals.Height + 15
                End If
                lal.Location = New Point(number, number2)
                lals.Location = New Point(number, number2 + lal.Height)
                lal.Cursor = Cursors.Hand
                lals.Text = Path.GetFileName(folder)
                lals.TextAlign = ContentAlignment.TopCenter
                lal.BackgroundImageLayout = ImageLayout.Zoom
                lal.FlatStyle = FlatStyle.Flat
                lal.BackColor = panelgoto.BackColor
                lal.FlatAppearance.BorderSize = 0
                lal.Tag = lals.Text
                lals.Font = New Font("Microsoft YaHei UI", 9, System.Drawing.FontStyle.Regular)
                Try
                    lal.BackgroundImage = Image.FromFile(outputfolder & lals.Text & "\image")
                Catch
                    lal.BackgroundImage = My.Resources.ResourceManager.GetObject("no-image-box")
                End Try
                AddHandler lal.Click, AddressOf hah
                'AddHandler lal.MouseLeave, AddressOf hahout
                'AddHandler lal.MouseEnter, AddressOf hahin
                Panel1.Controls.Add(lal)
                Panel1.Controls.Add(lals)
                ComboBox1.Items.Add(lals.Text)
                number = number + 195
            End If
        Next

        If downloader.Visible = False Then downloader.Close()
        downloadersmall.Close()
        downloader.Show()
        waiting.Close()
        disabilita(True)

        ComboBox1.Select()

        If toopen <> "" Then
            genericwindow.Close()
            genericwindow.appname = toopen
            genericwindow.percorso = outputfolder & toopen & "\"
            toopen = ""
            genericwindow.Show()
        End If
    End Sub

    'Private Sub hahout(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    sender.FlatAppearance.BorderSize = 0
    'End Sub
    'Private Sub hahin(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    sender.FlatAppearance.BorderSize = 1
    'End Sub

    Private Sub hah(ByVal sender As System.Object, ByVal e As System.EventArgs)
        genericwindow.Close()
        genericwindow.appname = sender.tag
        genericwindow.percorso = outputfolder & sender.tag & "\"
        genericwindow.Show()
    End Sub

    'Private Sub change() Handles MyBase.Resize
    '    Dim number As Integer = 1
    '    Dim number2 As Integer = 1
    '    Dim number3 As Integer = 0
    '    For Each button As Button In Panel1.Controls
    '        If number >= Panel1.Width - button.Width Then
    '            number = 1
    '            number2 += button.Height + 10
    '        End If
    '        button.Location = New Point(number, number2)
    '        number = number + 180
    '    Next
    'End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        deleteappsnew.Close()
        deleteappsnew.Show()
    End Sub
    Public Sub Button12_MouseLeave() Handles Button12.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub
    Public Sub Button12_MouseEnter() Handles Button12.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub

    Public Sub rebootdownloader()
        If Not MessageBox.Show("Sei sicuro/a di voler effettuare il riavvio forzato di Downloader?", "Riavvio?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Exit Sub
        End If
        If downloader.number > 0 Then
            If Not MessageBox.Show("Attualmente ci sono una o più operazioni in esecuzione! Sei sicuro/a di voler forzare il riavvio di Downloader? Troverai errori se stai eseguendo l'estrazione di uno o più download!", "Attenzione!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Exit Sub
            End If
        End If
        downloadersmall.Close()
        downloader.cancellall()
        downloader.Close()
        downloader.Dispose()
        downloader.Show()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        nameapp.Close()
        nameapp.ShowDialog()
    End Sub
    Public Sub Button23_MouseLeave() Handles Button23.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
    End Sub
    Public Sub Button23_MouseEnter() Handles Button23.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        genericwindow.Close()
        genericwindow.appname = ComboBox1.Text
        genericwindow.percorso = outputfolder & ComboBox1.Text & "\"
        genericwindow.Show()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        For Each item In ComboBox1.Items
            If item.ToString.ToUpper = ComboBox1.Text.ToUpper Then
                ComboBox1.SelectedItem = item
                Exit Sub
            End If
        Next

        Dim selStart As Integer = ComboBox1.SelectionStart
        ComboBox1.SelectionStart = selStart
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        If downloader.number > 0 Then
            MsgBox("Assicurati di aver concluso tutte le operazioni prima di procedere!", MsgBoxStyle.Exclamation, "Download in esecuzione")
            Exit Sub
        End If

        INIZIO.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If downloader.number > 0 Then
            MsgBox("Assicurati di aver concluso tutte le operazioni prima di procedere!", MsgBoxStyle.Exclamation, "Download in esecuzione")
            Exit Sub
        End If
        deleteappsnew.Close()
        downloader.Close()
        downloadersmall.Close()
        genericwindow.Close()
        chiudisino = True
        INIZIO.updatesmart()
        Close()

        INIZIO.Show()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        If downloader.number > 0 Or downloadersmall.Visible Then
            WindowState = FormWindowState.Minimized
            genericwindow.Close()
        End If

        If downloadersmall.Visible = False Then
            downloadersmall.StartPosition = FormStartPosition.Manual
            downloadersmall.Show()
        End If
    End Sub

    Private Sub wait_Tick(sender As Object, e As EventArgs) Handles wait.Tick
        after()
    End Sub

    Sub disabilita(valore As Boolean)
        Button12.Enabled = valore
        'Button1.Enabled = valore
        'Button23.Enabled = valore
        ComboBox1.Enabled = valore
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        copyinstaller.Close()
        copyinstaller.ShowDialog()
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
    End Sub
End Class