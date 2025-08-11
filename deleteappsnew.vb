Imports System.IO

Public Class deleteappsnew
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Panel1.MouseDown, formicon.MouseDown, TitleText.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Panel1.MouseMove, formicon.MouseMove, TitleText.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Panel1.MouseUp, formicon.MouseUp, TitleText.MouseUp
        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello

    Dim pg As Integer
    Private Sub deleteappsnew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pg = panelgoto.Height
        panelgoto.Height = 0

        Panel1.BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.BackColor
        BackColor = INIZIO.BackColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        ForeColor = INIZIO.ForeColor
        waiting.Close()
        waiting.formicon.Image = My.Resources.ResourceManager.GetObject("apps")
        waiting.PictureBox1.Image = My.Resources.ResourceManager.GetObject("System-recycling-bin-empty-icon")
        waiting.Label1.Text = "Aggiorno la lista ..."
        waiting.Show()
        wait.Start()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        MyBase.Close()
    End Sub


    Dim namei As String
    Dim percorso As String
    Dim percorso2 As String
    Dim image As String
    Dim inutili As New List(Of String)
    Dim daeliminare As New List(Of String)

    Public Async Sub checkdownloaded(silent As Boolean)
        If processdelete.Visible = True Then Exit Sub

        Panel4.Visible = False
        fileinutilibtn.Visible = False
        fileinutilibtn.BackColor = Color.Silver

        panelgoto.Height = 0
        inutili.Clear()
        daeliminare.Clear()
        wait.Stop()
        Panel2.Controls.Clear()
        lista.Items.Clear()
        elementname.Text = "Seleziona qualcosa"
        elementspace.Text = "0,00 MB"
        number = 1
        number2 = 1
        number3 = 0
        Dim quaninutile As Double = 0

        For Each folder In Directory.GetDirectories(installa.outputfolder)
            If Not Path.GetFileName(folder) = "Settings" And Not Path.GetFileName(folder) = "Updater" Then lista.Items.Add(folder)

            'Qui controlla se ci sono cartelle d'eccesso
            Dim trovato As Boolean = False
            For Each line In File.ReadAllLines(installa.outputfolder & "contents")
                If Path.GetFileName(folder) = line Then trovato = True
            Next
            If trovato = False Then daeliminare.Add(folder)
        Next

        'Qui controlla se ci sono file d'eccesso
        For Each file In Directory.GetFiles(installa.outputfolder)
            If Path.GetFileName(file) <> "contents" And Path.GetFileName(file) <> "help.txt" Then
                daeliminare.Add(file)
                Dim fileinfo As New FileInfo(file)
                Dim filesize As Long = fileinfo.Length
                Dim num As Double = filesize / 1048576
                quaninutile += num
            End If
        Next

        Dim lines As String()
        Dim listanomitemp As New List(Of String)
        ' Ottiene le Cartelle di tutti i programmi
        For Each folder In lista.Items
            ' Ottiene ciascun file della cartella del programma cercata
            For Each file As String In Directory.GetFiles(folder & "\")
                If Path.GetFileName(file).Contains(".ini") Then
                    inutili.Add(file)

                    lines = IO.File.ReadAllLines(Path.GetFullPath(file))
                    percorso = ""
                    percorso2 = ""
                    Dim temp As String = ""
                    image = ""
                    For Each line As String In lines
                        Dim parts() As String = line.Split(New Char() {"="}, 2)
                        If parts(0) = "downloader.genericn" Then
                            namei = parts(1)
                        End If
                        If parts(0) = "downloader.genericp" Then
                            If IO.File.Exists(folder & "\" & parts(1)) Then
                                percorso = folder & "\" & parts(1)
                                temp = percorso
                                image = folder & "\image"
                            Else
                                temp = folder & "\" & parts(1)
                            End If
                        End If
                        If parts(0) = "downloader.genericdel" Then
                            If IO.File.Exists(folder & "\" & parts(1)) Or Directory.Exists(folder & "\" & parts(1)) Then
                                percorso = temp
                                percorso2 = folder & "\" & parts(1)
                                image = folder & "\image"
                            End If
                        End If
                    Next

                    If (percorso <> "" Or percorso2 <> "") And silent = False And (inutili.Contains(percorso) = False Or listanomitemp.Contains(namei) = False) Then addbutton()

                    If percorso <> "" Then
                        inutili.Add(percorso)
                        listanomitemp.Add(namei)
                    End If
                    If percorso2 <> "" Then inutili.Add(percorso2)
                End If
            Next
        Next

        If silent Then Exit Sub

        'Adesso calcola le cose inutili
        For Each folder In lista.Items
            For Each file As String In Directory.GetFiles(folder & "\")
                If inutili.Contains(file) Or file.Contains(".") = False Or file.Contains(".version") Then Continue For

                daeliminare.Add(Application.StartupPath & "\" & file)
                Dim fileinfo As New FileInfo(file)
                Dim filesize As Long = fileinfo.Length
                Dim num As Double = filesize / 1048576
                quaninutile += num
            Next

            For Each folder2 As String In Directory.GetDirectories(folder & "\")
                If inutili.Contains(folder2) Then Continue For

                daeliminare.Add(Application.StartupPath & "\" & folder2)
                Dim task As New Task(Sub()
                                         Try
                                             quantita2(folder2)
                                             quaninutile += outputsize
                                         Catch
                                         End Try
                                     End Sub)
                task.Start()
                Await task
            Next
        Next

        If daeliminare.Count > 0 Then
            quan = quaninutile.ToString("n")
            If quaninutile >= 1024 Then
                quaninutile = (quaninutile * 1048576) / 1073741824
                quan = quaninutile.ToString("n") & " GB"
            Else
                quan = quan & " MB"
            End If

            If silent = False Then
                fileinutilibtn.Text = "File Inutili" & vbCrLf & quan
                fileinutilibtn.Visible = True

                quan = "File Inutili " & quan
                image = My.Resources.goinstall.ToString
                percorso = "cache"
                percorso2 = ""
                namei = quan
                addbutton()
            End If
        End If

        selectlbl.Visible = True
        emptypanel.Visible = False
        Panel2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True

        If silent = False And Panel2.Controls.Count = 0 Then
            emptypanel.Visible = True
            selectlbl.Visible = False
            Panel2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
        End If

        waiting.Close()
        Refresh()
    End Sub

    Dim number As Integer
    Dim number2 As Integer
    Dim number3 As Integer
    Private Sub addbutton()

        Dim lal As Button
        Dim lals As Label

        number3 += 1
        lal = New Button
        lals = New Label
        lal.Name = "program" & number3
        lal.Width = 169.5
        lal.Height = 120
        lals.Width = lal.Width
        lals.Height = 20
        If number >= Panel2.Width - lal.Width Then
            number = 1
            number2 += lal.Height + lals.Height + 10
        End If
        lal.Location = New Point(number, number2)
        lals.Location = New Point(number, number2 + lal.Height)
        lal.Cursor = Cursors.Hand
        lals.Text = namei
        lal.Tag = lals.Text
        lal.FlatStyle = FlatStyle.Flat
        lal.FlatAppearance.BorderSize = 0
        lals.TextAlign = ContentAlignment.TopCenter
        lal.BackgroundImageLayout = ImageLayout.Zoom
        lal.BackColor = panelgoto.BackColor
        lals.Font = New Font("Microsoft YaHei UI", 9, System.Drawing.FontStyle.Regular)
        If percorso = "cache" Then
            lal.BackgroundImage = My.Resources.ResourceManager.GetObject("broom_128px")
        Else
            Try
                lal.BackgroundImage = Drawing.Image.FromFile(image)
            Catch
                lal.BackgroundImage = My.Resources.ResourceManager.GetObject("no-image-box")
            End Try
        End If
        lal.AccessibleDescription = percorso
        lal.AccessibleName = percorso2
        AddHandler lal.Click, AddressOf hah

        'Controlla se è presente in Downloader il Download...
        If (percorso = downloader.p1 And downloader.occ1 = True) Or (percorso = downloader.p2 And downloader.occ2 = True) Or (percorso = downloader.p3 And downloader.occ3 = True) Then
            lal.Enabled = False
            lals.Text = "Download in Corso ..."
        End If

        Panel2.Controls.Add(lal)
        Panel2.Controls.Add(lals)
        number = number + 180
    End Sub

    Private Async Sub hah(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fileinutilibtn.BackColor <> Color.Silver Then fileinutilibtn.BackColor = Color.Silver

        Try
            tempbtn.BackColor = panelgoto.BackColor
        Catch
        End Try
        uno = sender.AccessibleDescription
        due = sender.AccessibleName
        sender.backcolor = Color.Red
        tempbtn = sender
        elementname.Text = sender.tag
        elementspace.Text = "Calcolo in Corso ..."

        If uno = "cache" Then
            quan = sender.Tag.ToString.Replace("File Inutili ", "")
            elementname.Text = "File Inutili"
        Else
            Await quantita()
        End If

        elementspace.Text = quan
        Panel4.Visible = True

        If panelgoto.Height = 0 Then
            selectlbl.Visible = False
            anim.Start()
        End If
    End Sub

    Dim uno As String
    Dim due As String
    Dim tempbtn As Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, eliminalbl.Click
        downloader.number += 1
        downloader.processdel = True
        processdelete.Close()

        'Se si sta eliminando la cache fai questo
        If uno = "cache" Then
            uno = ""
            due = ""
            For i = 0 To daeliminare.Count - 1
                processdelete.listz.Add(daeliminare.Item(i))
            Next
        End If

        processdelete.filez = ""
        processdelete.folderz = ""
        If Not uno = "" Then
            processdelete.filez = uno
        End If
        If Not due = "" Then
            processdelete.folderz = due
        End If
        processdelete.ShowDialog()
        downloader.number -= 1
        downloader.processdel = False

        checkdownloaded(False)
        Panel4.Visible = False
    End Sub

    Dim quan As String
    Private Async Function quantita() As Task
        quan = ""
        sizetemp = 0
        If Not due = "" Then
            Dim task As New Task(Sub()
                                     Try
                                         quantita2(due)
                                     Catch
                                         quan = "Errore Calcolo"
                                     End Try
                                 End Sub)
            task.Start()
            Await task
        Else
            Dim fileinfo As New FileInfo(uno)
            Dim filesize As Long = fileinfo.Length
            Dim num As Double = filesize / 1048576
            outputsize = num
            quan = num.ToString("n")
            If num >= 1024 Then
                num = filesize / 1073741824
                quan = num.ToString("n") & " GB"
            Else
                quan = quan & " MB"
            End If
        End If
    End Function

    Dim outputsize As Double
    Dim sizetemp As Long
    Private Sub quantita2(ByVal sourceFolder As String)
        Dim drInfo As New DirectoryInfo(sourceFolder)
        Dim filesInfo() As FileInfo = drInfo.GetFiles("*.*")
        Dim fileSize As Long = 0
        For Each fileInfo As FileInfo In filesInfo
            fileSize += fileInfo.Length
        Next
        sizetemp += fileSize

        Dim folders As String() = Directory.GetDirectories(sourceFolder)
        For Each folder As String In folders
            Try
                Dim namei As String = Path.GetFileName(folder)
                quantita2(folder)
            Catch
            End Try
        Next

        Dim num As Double = sizetemp / 1048576
        outputsize = num
        quan = num.ToString("n")
        If num >= 1024 Then
            num = sizetemp / 1073741824
            quan = num.ToString("n") & " GB"
        Else
            quan = quan & " MB"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles wait.Tick
        checkdownloaded(False)
    End Sub

    Public Function GetFileSize(TheSize As Long) As String
        Dim DoubleBytes As Double
        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Private Sub deleteappsnew_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Label3.Visible Then DrawProgress(e.Graphics, New Rectangle(PanelCirc.Location.X, PanelCirc.Location.Y, PanelCirc.Width, PanelCirc.Height))

    End Sub

    Private Sub DrawProgress(g As Graphics, rect As Rectangle)
        'Codice MIIO
        Dim d As DriveInfo
        Dim bho As String = ""
        Dim percentage As Single
        For Each d In DriveInfo.GetDrives()
            If d.IsReady = True Then
                If d.Name = Path.GetPathRoot(Application.StartupPath) Then
                    percentage = Math.Truncate(((d.TotalSize - d.TotalFreeSpace) / d.TotalSize) * 100)
                    bho = GetFileSize(d.TotalSize - d.TotalFreeSpace)
                    Label5.Text = GetFileSize(d.TotalFreeSpace)
                End If
            End If
        Next



        'work out the angles for each arc
        Dim progressAngle = CSng(360 / 100 * percentage)
        Dim remainderAngle = 360 - progressAngle

        'create pens to use for the arcs
        Using progressPen As New Pen(Color.LightSeaGreen, 2), remainderPen As New Pen(Color.LightGray, 2)
            'set the smoothing to high quality for better output
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            'draw the blue and white arcs
            g.DrawArc(progressPen, rect, -90, progressAngle)
            g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle)
        End Using

        'draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
        Using fnt As New Font(Me.Font.FontFamily, 14)
            Dim text As String = percentage.ToString + "%" & vbNewLine & bho
            Dim textSize = g.MeasureString(text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            'now we have all the values draw the text
            g.DrawString(text, fnt, Brushes.LightSeaGreen, textPoint)
        End Using
    End Sub

    Private Sub Fileinutilibtn_Click(sender As Object, e As EventArgs) Handles fileinutilibtn.Click
        fileinutilibtn.BackColor = Color.IndianRed
        Try
            tempbtn.BackColor = panelgoto.BackColor
        Catch
        End Try

        quan = fileinutilibtn.Text.Replace("File Inutili" & vbCrLf, "")
        elementname.Text = "File Inutili"
        uno = "cache"

        elementspace.Text = quan
        Panel4.Visible = True

        If panelgoto.Height = 0 Then
            selectlbl.Visible = False
            anim.Start()
        End If
    End Sub

    Private Sub EnterElimina(sender As Object, e As EventArgs) Handles Button1.MouseEnter, eliminalbl.MouseEnter
        Panel4.BackColor = Color.Silver
    End Sub

    Private Sub LeaveElimina(sender As Object, e As EventArgs) Handles Button1.MouseLeave, eliminalbl.MouseLeave
        Panel4.BackColor = panelgoto.BackColor
    End Sub

    Private Sub anim_Tick(sender As Object, e As EventArgs) Handles anim.Tick
        If panelgoto.Height < pg Then
            panelgoto.Height += 5
            Exit Sub
        End If

        panelgoto.Height = pg
        anim.Stop()
    End Sub
End Class