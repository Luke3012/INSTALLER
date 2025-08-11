Public Class copyinstaller
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

    Private Sub vai_Click(sender As Object, e As EventArgs) Handles vai.Click
        ' Codice per trasferire tutti i programmi dalla cartella selezionata a quella attuale
        If config <> "" Then
            For Each selectedItem As Object In lista.SelectedItems
                Dim sourceFolder As String = selectedItem.ToString()
                Dim destinationFolder As String = installa.outputfolder & "\" & IO.Path.GetFileName(sourceFolder)

                ' Copia il contenuto della cartella sorgente nella cartella di destinazione
                My.Computer.FileSystem.CopyDirectory(sourceFolder, destinationFolder, True)
            Next

            ' Aggiorna la lista dei programmi dopo il trasferimento
            addelements(panelthis, config)
        End If
    End Sub
    Public Sub vai_MouseLeave() Handles vai.MouseLeave
        vailbl.Font = New Font(vailbl.Font, FontStyle.Regular)
    End Sub
    Public Sub vai_MouseEnter() Handles vai.MouseEnter
        vailbl.Font = New Font(vailbl.Font, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showhide(False)
    End Sub
    Public Sub Button1_MouseLeave() Handles Button1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
    End Sub
    Public Sub Button1_MouseEnter() Handles Button1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Label2.Click
        changeconfig()
        If config <> "" Then showhide(True)
    End Sub
    Public Sub Button2_MouseLeave() Handles Button2.MouseLeave, Label2.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
    End Sub
    Public Sub Button2_MouseEnter() Handles Button2.MouseEnter, Label2.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub

    Dim pg As Integer
    Dim lefti As Integer
    Dim config As String = ""
    Private Sub copyinstaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pg = panelgoto.Height
        panelgoto.Height = 0
        lefti = Panel1.Left
        panelall.Left = Width
        lista.Sorted = True

        changeconfig()
        If config <> "" Then showhide(True)
    End Sub

    Dim timershow As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timershow Then
            If Panel1.Left + Panel1.Width > 0 Or panelall.Left > lefti Then
                If Panel1.Left + Panel1.Width > 0 Then Panel1.Location = New Point(Panel1.Location.X - 8, Panel1.Location.Y)
                If panelall.Left > lefti Then panelall.Location = New Point(panelall.Location.X - 8, panelall.Location.Y)
                Exit Sub
            End If

            If panelgoto.Height < pg Then
                panelgoto.Height += 5
                Exit Sub
            End If

            panelall.Left = lefti
            panelgoto.Height = pg
            Panel1.Left = 0 - Panel1.Width
            Button1.Enabled = True
            Timer1.Stop()
        Else
            If Panel1.Left < lefti Or panelall.Left < Width Or panelgoto.Height > 0 Then
                If Panel1.Left < lefti Then Panel1.Location = New Point(Panel1.Location.X + 8, Panel1.Location.Y)
                If panelall.Left < Width Then panelall.Location = New Point(panelall.Location.X + 8, panelall.Location.Y)
                If panelgoto.Height > 0 Then panelgoto.Height -= 5
                Exit Sub
            End If

            panelall.Left = Width
            panelgoto.Height = 0
            Panel1.Left = lefti
            Panel1.Enabled = True
            panelall.Visible = False
            Timer1.Stop()

            Button2.PerformClick()
        End If
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Private Sub changeconfig()
        config = ""

        If selectconfig.ShowDialog() = DialogResult.OK Then
            If IO.File.Exists(selectconfig.SelectedPath & "\Settings\impostazioni.ini") Then
                If selectconfig.SelectedPath & "\" <> installa.outputfolder Then
                    If IO.File.Exists(selectconfig.SelectedPath & "\Settings\Changelog\5.8.txt") Then
                        config = selectconfig.SelectedPath
                        'continuare qui...
                        addelements(panelthis, config)
                    Else
                        MsgBox("La configurazione selezionata è obsoleta! Assicurati di aver aggiornato INSTALLER all'ultima versione.", MsgBoxStyle.Exclamation, "Cartella non valida")
                    End If
                Else
                    MsgBox("Non puoi selezionare la configurazione attualmente in uso!", MsgBoxStyle.Exclamation, "Cartella non valida")
                End If
            Else
                MsgBox("Non hai selezionato una configurazione valida! Assicurati di selezionare la cartella 'Fondamental' desiderata!", MsgBoxStyle.Exclamation, "Cartella non valida")
            End If
        End If
    End Sub

    Private Sub showhide(mode As Boolean)
        If mode Then
            timershow = True
            vai.Enabled = False
            panelall.Visible = True
            Panel1.Enabled = False
            TitleText.Text = "Scegli cosa copiare"
            Timer1.Start()
        Else
            timershow = False
            Button1.Enabled = False
            vai.Enabled = False
            TitleText.Text = "Collegati a un'altra configurazione"
            Timer1.Start()
        End If
    End Sub

    Public lista As New ListBox
    Private Sub addelements(pannello As Panel, cartella As String)
        pannello.Controls.Clear()
        lista.Items.Clear()

        If IO.File.Exists(cartella & "\Settings\downloadedapps") = False Then IO.File.WriteAllText(cartella & "\Settings\downloadedapps", "")

        For Each folder In IO.Directory.GetDirectories(cartella)
            If IO.Path.GetFileName(folder) <> "Settings" And IO.Path.GetFileName(folder) <> "Updater" Then lista.Items.Add(folder)
        Next

        Dim number As Integer = 6

        Dim lines As String()
        Dim listanomitemp As New List(Of String)
        ' Ottiene le Cartelle di tutti i programmi
        For Each folder In lista.Items
            ' Ottiene ciascun file della cartella del programma cercata
            For Each file As String In IO.Directory.GetFiles(folder & "\")
                If IO.Path.GetFileName(file).Contains(".ini") Then
                    lines = IO.File.ReadAllLines(IO.Path.GetFullPath(file))
                    Dim namei As String = ""
                    Dim percorso As String = ""
                    Dim percorso2 As String = ""
                    Dim temp As String = ""
                    Dim Image As String = ""
                    For Each line As String In lines
                        Dim parts() As String = line.Split(New Char() {"="}, 2)
                        If parts(0) = "downloader.genericn" Then
                            namei = parts(1)
                        End If
                        If parts(0) = "downloader.genericp" Then
                            If IO.File.Exists(folder & "\" & parts(1)) Then
                                percorso = folder & "\" & parts(1)
                                temp = percorso
                                Image = folder & "\image"
                            Else
                                temp = folder & "\" & parts(1)
                            End If
                        End If
                        If parts(0) = "downloader.genericdel" Then
                            If IO.File.Exists(folder & "\" & parts(1)) Or IO.Directory.Exists(folder & "\" & parts(1)) Then
                                percorso = temp
                                percorso2 = folder & "\" & parts(1)
                                Image = folder & "\image"
                            End If
                        End If
                    Next

                    Dim uuu As String = "App scaricata"
                    If IO.File.ReadAllText(cartella & "\Settings\downloadedapps").Contains(namei) Then uuu = "App importata"
                    If (percorso <> "" Or percorso2 <> "") And listanomitemp.Contains(namei) = False Then
                        addelement(panelthis, number, namei, uuu, Image, IO.Path.GetFullPath(file))
                        number += 106
                    End If

                    If percorso <> "" Then listanomitemp.Add(namei)
                End If
            Next
        Next
    End Sub

    Private Sub addelement(pannello As Panel, altezza As Integer, titolo As String, quantita As String, immagine As String, percorso As String)
        Dim pal As New Panel
        Dim pical As New PictureBox
        Dim lal As New Label
        Dim lals As New Label

        pal.Tag = percorso
        pal.BackColor = panelgoto.BackColor
        pal.Location = New Point(3, altezza)
        pal.Size = New Size(pannello.Width - 31, 80)
        pal.Cursor = Cursors.Hand
        pannello.Controls.Add(pal)

        pical.Location = New Point(0, 0)
        pical.Size = New Size(pal.Height, pal.Height)
        pical.SizeMode = PictureBoxSizeMode.Zoom
        pical.Image = Bitmap.FromFile(immagine)
        pal.Controls.Add(pical)

        lal.Text = titolo
        pal.Controls.Add(lal)
        lal.Size = New Size(pal.Width - pical.Width, pical.Height / 2)
        lal.Location = New Point(pical.Width, 0)
        lal.Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)
        lal.TextAlign = ContentAlignment.BottomCenter

        lals.Text = quantita
        pal.Controls.Add(lals)
        lals.Size = lal.Size
        lals.Location = New Point(lal.Left, lal.Height - 2)
        lals.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Regular)
        lals.TextAlign = ContentAlignment.TopCenter

        AddHandler pal.Click, AddressOf hah
        AddHandler lal.Click, AddressOf hah
        AddHandler lals.Click, AddressOf hah
        AddHandler pical.Click, AddressOf hah
    End Sub

    Dim before As Panel
    Private Sub hah(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            before.BackColor = panelgoto.BackColor
        Catch
        End Try
        before = sender.parent

        before.BackColor = BackColor
        panelselect.Visible = False
        panelcopy.Visible = True

        Dim lines As String() = IO.File.ReadAllLines(before.Tag)
        Dim folder As String = IO.Path.GetDirectoryName(before.Tag)
        Dim namei As String = ""
        Dim percorso As String = ""
        Dim percorso2 As String = ""
        Dim temp As String = ""
        Dim Image As String = ""
        For Each line As String In lines
            Dim parts() As String = line.Split(New Char() {"="}, 2)
            If parts(0) = "downloader.genericn" Then
                namei = parts(1)
            End If
            If parts(0) = "downloader.genericp" Then
                If IO.File.Exists(folder & "\" & parts(1)) Then
                    percorso = folder & "\" & parts(1)
                    temp = percorso
                    Image = folder & "\image"
                Else
                    temp = folder & "\" & parts(1)
                End If
            End If
            If parts(0) = "downloader.genericdel" Then
                If IO.File.Exists(folder & "\" & parts(1)) Or IO.Directory.Exists(folder & "\" & parts(1)) Then
                    percorso = temp
                    percorso2 = folder & "\" & parts(1)
                    Image = folder & "\image"
                End If
            End If
        Next

        selectedpic.Image = Bitmap.FromFile(Image)
        selectedtitle.Text = "Vuoi copiare '" & namei & "' ?"
    End Sub

    Dim tocopy As String = ""
    Private Sub copybtn_Click(sender As Object, e As EventArgs) Handles copybtn.Click
        ' Codice per copiare il singolo programma selezionato dalla lista
        If before IsNot Nothing AndAlso config <> "" Then
            Dim sourceFolder As String = before.Tag
            Dim destinationFolder As String = installa.outputfolder & "\" & IO.Path.GetFileName(sourceFolder)

            ' Copia il contenuto della cartella sorgente nella cartella di destinazione
            My.Computer.FileSystem.CopyDirectory(sourceFolder, destinationFolder, True)

            ' Aggiorna la lista dei programmi dopo il trasferimento
            addelements(panelthis, config)
        End If
    End Sub
End Class