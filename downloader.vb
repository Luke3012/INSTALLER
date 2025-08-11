Imports System.IO
Imports System.Net
Imports System.IO.Compression

Public Class downloader
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Panel2.MouseDown, formicon.MouseDown, TitleText.MouseDown, status.MouseDown, panelsettings.MouseDown
        If installall Then Exit Sub

        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Panel2.MouseMove, formicon.MouseMove, TitleText.MouseMove, status.MouseMove, panelsettings.MouseMove
        If installall Then Exit Sub

        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Panel2.MouseUp, formicon.MouseUp, TitleText.MouseUp, status.MouseUp, panelsettings.MouseUp
        If installall Then Exit Sub

        drag = False
        Cursor = Cursors.Default
    End Sub
    ' Fine cose per il pannello


    'Questi sono per deleteapps
    Public processdel As Boolean = False

    'Questi sono per InstallALL
    Public installall As Boolean

    Public number As Integer
    'btnname sarebbe il nome del bottone per far capire che non deve scaricarlo
    Public genericbtnname As String
    Public genericd As String = "0"
    Public genericp As String = "0"
    Public genericz As String = "0"
    Public genericn As String = "0"
    Public genericpz As String = "0"
    Public genericdel As String = "0"
    Public genericv As Integer = 0
    Public genericsil As String = ""
    Public genericsp As Long = 0
    Public genericcon As String = ""
    Public genericnoboot As Boolean = False
    Public d1 As String
    Public d2 As String
    Public d3 As String
    Public p1 As String
    Public p2 As String
    Public p3 As String
    Public image As String
    Dim pz1 As String
    Dim pz2 As String
    Dim pz3 As String
    Public z1 As String = "0"
    Public z2 As String = "0"
    Public z3 As String = "0"
    Dim n1 As String
    Dim n2 As String
    Dim n3 As String
    Public occ1 As Boolean = False
    Public occ2 As Boolean = False
    Public occ3 As Boolean = False
    Dim del1 As String
    Dim del2 As String
    Dim del3 As String
    Dim v1 As Integer
    Dim v2 As Integer
    Dim v3 As Integer
    Dim sil1 As String
    Dim sil2 As String
    Dim sil3 As String
    Dim sp1 As Long = 0
    Dim sp2 As Long = 0
    Dim sp3 As Long = 0
    Dim con1 As String
    Dim con2 As String
    Dim con3 As String
    Dim image1 As String
    Dim image2 As String
    Dim image3 As String
    Dim SW1 As Stopwatch
    Dim SW2 As Stopwatch
    Dim SW3 As Stopwatch
    Dim cur1 As Integer
    Dim cur2 As Integer
    Dim cur3 As Integer
    Dim force1 As Boolean = False
    Dim force2 As Boolean = False
    Dim force3 As Boolean = False
    Dim noboot1 As Boolean = False
    Dim noboot2 As Boolean = False
    Dim noboot3 As Boolean = False
    Dim btnname1 As String
    Dim btnname2 As String
    Dim btnname3 As String

    Dim automode2 As Boolean = True

    Public listmode As Boolean = False
    Private Sub downloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        task1.ForeColor = ForeColor
        task2.ForeColor = ForeColor
        task3.ForeColor = ForeColor
        pic1.BackColor = INIZIO.panelgoto.BackColor
        pic2.BackColor = pic1.BackColor
        pic3.BackColor = pic2.BackColor
        settingsbtn.FlatAppearance.BorderColor = BackColor

        If listmode = False Then
            Height = task2.Top
            Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        End If
        retry1.Hide()
        retry2.Hide()
        retry3.Hide()
        speed1.Hide()
        speed2.Hide()
        speed3.Hide()
    End Sub

    Public Sub decidi()
        If genericbtnname = btnname1 And occ1 = True Then
            resetgeneric()
            MsgBox("Task già in corso!", MsgBoxStyle.Exclamation, "[TASK 1]")
            Exit Sub
        End If
        If genericbtnname = btnname2 And occ2 = True Then
            resetgeneric()
            MsgBox("Task già in corso!", MsgBoxStyle.Exclamation, "[TASK 2]")
            Exit Sub
        End If
        If genericbtnname = btnname3 And occ3 = True Then
            resetgeneric()
            MsgBox("Task già in corso!", MsgBoxStyle.Exclamation, "[TASK 3]")
            Exit Sub
        End If

        'Decidi cosa deve partire
        Dim vai_a As Integer = 0
        If occ3 = False Then vai_a = 3
        If occ2 = False Then vai_a = 2
        If occ1 = False Then vai_a = 1
        If force1 = True And image1 = image Then vai_a = 1
        If force2 = True And image2 = image Then vai_a = 2
        If force3 = True And image3 = image Then vai_a = 3

        If vai_a = 1 Then
            retry1.Hide()
            If force1 = True Then
                force1 = False
            Else
                cur1 = 0
            End If
            z1 = "0"
            btnname1 = genericbtnname
            d1 = genericd
            p1 = genericp
            z1 = genericz
            n1 = genericn
            pz1 = genericpz
            del1 = genericdel
            v1 = genericv
            sil1 = genericsil
            sp1 = genericsp
            con1 = genericcon
            noboot1 = genericnoboot
            image1 = image
            resetgeneric()
            number = number + 1
            occ1 = True
            numbertext()
            download1()
            Exit Sub
        End If
        If vai_a = 2 Then
            retry2.Hide()
            If force2 = True Then
                force2 = False
            Else
                cur2 = 0
            End If
            z2 = "0"
            btnname2 = genericbtnname
            d2 = genericd
            p2 = genericp
            z2 = genericz
            n2 = genericn
            pz2 = genericpz
            del2 = genericdel
            v2 = genericv
            sil2 = genericsil
            sp2 = genericsp
            con2 = genericcon
            noboot2 = genericnoboot
            image2 = image
            resetgeneric()
            number = number + 1
            occ2 = True
            numbertext()
            download2()
            Exit Sub
        End If
        If vai_a = 3 Then
            retry3.Hide()
            If force3 = True Then
                force3 = False
            Else
                cur3 = 0
            End If
            z3 = "0"
            btnname3 = genericbtnname
            d3 = genericd
            p3 = genericp
            z3 = genericz
            n3 = genericn
            pz3 = genericpz
            del3 = genericdel
            v3 = genericv
            sil3 = genericsil
            sp3 = genericsp
            con3 = genericcon
            noboot3 = genericnoboot
            image3 = image
            resetgeneric()
            number = number + 1
            occ3 = True
            numbertext()
            download3()
            Exit Sub
        End If
        MsgBox("Tutti i Task sono occupati!", MsgBoxStyle.Information, "Non puoi eseguire il Download")
    End Sub

    Private Sub resetgeneric()
        genericbtnname = ""
        genericd = "0"
        genericp = "0"
        genericz = "0"
        genericn = "0"
        genericpz = "0"
        genericdel = "0"
        genericv = 0
        genericsil = ""
        image = ""
        genericcon = ""
        genericsp = 0
        genericnoboot = False
    End Sub

    Dim numbercresce As Integer = 1
    Private Sub numbertext()
        If processdel = False Then
            status.Text = "Task in corso: " & number
        Else
            status.Text = "Task in corso: " & number - 1
        End If

        If downloadersmall.Visible And listmode = False Then downloadersmall.tasky(status.Text)

        'Aggiorna alcuni contenuti
        If deleteappsnew.Visible = True Then deleteappsnew.checkdownloaded(False)

        If installall = True Then
            status.Text = listeinstall.tasktext
        Else
            Dim beforeh As Integer = Height
            numbercresce += 1
            If numbercresce = 2 And occ1 = False Then
                numbercresce -= 1
                Exit Sub
            End If
            If numbercresce = 2 And occ2 = False Then
                numbercresce -= 1
                Exit Sub
            End If
            If numbercresce = 3 And occ2 = False Then
                numbercresce -= 1
                Exit Sub
            End If
            If numbercresce = 3 And occ1 = False Then
                numbercresce -= 1
                Exit Sub
            End If
            If numbercresce = 3 And occ3 = False Then
                numbercresce -= 1
                Exit Sub
            End If
            If numbercresce = 2 Then
                Height = task3.Top
            End If
            If numbercresce = 3 Then
                Height = task3.Top + task3.Height + (task1.Top - Panel2.Height)
            End If

            Location = New Point(Left, Top - (Height - beforeh))
            If Top < 0 Then Top = 0
        End If
    End Sub

    Private Sub Progresso1(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100
            ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        Catch
        End Try
        Try
            Dim cicc As String
            cicc = (e.BytesReceived / SW1.ElapsedMilliseconds).ToString
            speed1.Text = cicc.Substring(0, cicc.IndexOf(",")) & " kb/s"
        Catch
        End Try
    End Sub
    Private Sub Progresso2(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100
            ProgressBar2.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        Catch
        End Try
        Try
            Dim cicc As String
            cicc = (e.BytesReceived / SW2.ElapsedMilliseconds).ToString
            speed2.Text = cicc.Substring(0, cicc.IndexOf(",")) & " kb/s"
        Catch
        End Try
    End Sub
    Private Sub Progresso3(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100
            ProgressBar3.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        Catch
        End Try
        Try
            Dim cicc As String
            cicc = (e.BytesReceived / SW3.ElapsedMilliseconds).ToString
            speed3.Text = cicc.Substring(0, cicc.IndexOf(",")) & " kb/s"
        Catch
        End Try
    End Sub

    Public WithEvents client1 As WebClient
    Public WithEvents client2 As WebClient
    Public WithEvents client3 As WebClient
    Public cancel1 As Boolean
    Public cancel2 As Boolean
    Public cancel3 As Boolean
    Private Async Sub download1()
        cancel1 = False
        status1.Text = "--- Attendi ... ---"
        cur1 += 1
        SetTextCur(task1, cur1, con1)
        LoadImage(pic1, image1)
        Dim filetoboot As String
        If z1 = "0" Then
            filetoboot = p1
        Else
            filetoboot = pz1
        End If
        Dim checkl As Long = "0"

        ' Se il file eseguibie (exe) esiste, allora controlla se la grandezza è diversa da quella generata dal sito
        If File.Exists(p1) And filetoboot = p1 Then
            If z1 = "0" Then
                status1.Text = "--- Controllo alcune cose ... ---"
                Dim check As New Task(Sub()
                                          Try
                                              Dim obj As New WebClient
                                              Dim s As Stream
                                              s = obj.OpenRead(d1)
                                              checkl = Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
                                              obj.CancelAsync()
                                          Catch
                                              checkl = "0"
                                          End Try
                                      End Sub)
                check.Start()
                Await check
                If Not checkl = "0" Then
                    ' Adesso controlliamo se la grandezza del file generata da internet sia uguale a quella scaricata
                    Dim anfs As New FileInfo(p1)
                    Dim size As Long = anfs.Length
                    If Not size = checkl Then
                        If installall = True Then
                            Try
                                File.Delete(p1)
                            Catch
                            End Try
                        Else
                            If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n1 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 1]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Try
                                    File.Delete(p1)
                                Catch
                                    MsgBox("Errore eliminazione del file!", MsgBoxStyle.Critical, "[TASK 1]")
                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Try
            ' Controlla se c'è una nuova versione (solo se è una cartella)
            If Not v1 = 0 And File.Exists(pz1) Then
                If File.Exists(p1 & ".version") Then
                    Dim versionreader As New System.IO.StreamReader(p1 & ".version")
                    If versionreader.ReadLine < v1 Then
                        If installall = True Then
                            status1.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p1, del1)
                        Else
                            If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n1 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 1]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                status1.Text = "--- Attendi ... ---"
                                Await processdelete.deletesomething(p1, del1)
                            End If
                        End If
                    End If
                    versionreader.Close()
                Else
                    If v1 > 1 Then
                        If installall = True Then
                            status1.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p1, del1)
                        Else
                            If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n1 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 1]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                status1.Text = "---Attendi ...---"
                                Await processdelete.deletesomething(p1, del1)
                            End If
                        End If
                    End If
                End If
            End If
        Catch
        End Try


        If Not File.Exists(filetoboot) Then
            'Controlla lo spazio disponibile
            If checkl <> 0 Or sp1 <> 0 Then
                If checkl = 0 Then checkl = sp1
                Dim mess As String = ControllaSpazio(checkl)
                If mess <> "" Then
                    status1.Text = "---Non hai abbastanza spazio! (Mancano " & mess & ")---"
                    number = number - 1
                    occ1 = False
                    numbertext()
                    retry1.Text = "Riprova"
                    retry1.Show()
                    If installall = True Then
                        listeinstall.failed = listeinstall.failed & status1.Text.Replace("-", "") & " - " & n1 & vbNewLine
                        listeinstall.bordello()
                    End If
                    Exit Sub
                End If
            End If

            If My.Computer.Network.IsAvailable = True Then
                ProgressBar1.Value = 0
                retry1.Text = "Annulla"
                retry1.Show()
                speed1.Show()
                Try
                    status1.Text = "---Scarico " & n1 & "---"
                    If downloadersmall.Visible Then downloadersmall.install = status1.Text
                    client1 = New WebClient
                    AddHandler client1.DownloadProgressChanged, AddressOf Progresso1
                    AddHandler client1.DownloadFileCompleted, AddressOf afterdownload1
                    SW1 = Stopwatch.StartNew
                    client1.DownloadFileAsync(New Uri(d1), p1)
                Catch
                    status1.Text = "---Scaricamento non riuscito, riprova---"
                    cancel1 = True
                    retry1.Text = "Riprova"
                    afterdownload1()
                End Try
            Else
                status1.Text = "---Nessuna connessione ad Internet---"
                cancel1 = True
                retry1.Text = "Riprova"
                afterdownload1()
            End If
        Else
            afterdownload1()
        End If
    End Sub
    Private Async Sub download2()
        cancel2 = False
        status2.Text = "Attendi ..."
        cur2 += 1
        SetTextCur(task2, cur2, con2)
        LoadImage(pic2, image2)
        Dim filetoboot As String
        If z2 = "0" Then
            filetoboot = p2
        Else
            filetoboot = pz2
        End If

        Dim checkl As Long = "0"
        ' Se il file eseguibie (exe) esiste, allora controlla se la grandezza è diversa da quella generata dal sito
        If File.Exists(p2) And filetoboot = p2 Then
            If z2 = "0" Then
                status2.Text = "---Controllo alcune cose ...---"
                Dim check As New Task(Sub()
                                          Try
                                              Dim obj As New WebClient
                                              Dim s As Stream
                                              s = obj.OpenRead(d2)
                                              checkl = Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
                                              obj.CancelAsync()
                                          Catch
                                              checkl = "0"
                                          End Try
                                      End Sub)
                check.Start()
                Await check
                If Not checkl = "0" Then
                    ' Adesso controlliamo se la grandezza del file generata da internet sia uguale a quella scaricata
                    Dim anfs As New FileInfo(p2)
                    Dim size As Long = anfs.Length
                    If Not size = checkl Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n2 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 2]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            Try
                                File.Delete(p2)
                            Catch
                                MsgBox("Errore eliminazione del file!", MsgBoxStyle.Critical, "[TASK 2]")
                            End Try
                        End If
                    End If
                End If
            End If
        End If

        Try
            ' Controlla se c'è una nuova versione (solo se è una cartella)
            If Not v2 = 0 And File.Exists(pz2) Then
                If File.Exists(p2 & ".version") Then
                    Dim versionreader As New System.IO.StreamReader(p2 & ".version")
                    If versionreader.ReadLine < v2 Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n2 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 2]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            status2.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p2, del2)
                        End If
                    End If
                    versionreader.Close()
                Else
                    If v2 > 1 Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n2 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 2]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            status2.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p2, del2)
                        End If
                    End If
                End If
            End If
        Catch
        End Try

        If Not File.Exists(filetoboot) Then
            'Controlla lo spazio disponibile
            If checkl <> 0 Or sp2 <> 0 Then
                If checkl = 0 Then checkl = sp2
                Dim mess As String = ControllaSpazio(checkl)
                If mess <> "" Then
                    status2.Text = "---Non hai abbastanza spazio! (Mancano " & mess & ")---"
                    number = number - 1
                    occ2 = False
                    numbertext()
                    retry2.Text = "Riprova"
                    retry2.Show()
                    Exit Sub
                End If
            End If

            If My.Computer.Network.IsAvailable = True Then
                ProgressBar2.Value = 0
                retry2.Text = "Annulla"
                retry2.Show()
                speed2.Show()

                Try
                    status2.Text = "---Scarico " & n2 & "---"
                    If downloadersmall.Visible Then downloadersmall.install = status2.Text
                    client2 = New WebClient
                    AddHandler client2.DownloadProgressChanged, AddressOf Progresso2
                    AddHandler client2.DownloadFileCompleted, AddressOf afterdownload2
                    SW2 = Stopwatch.StartNew
                    client2.DownloadFileAsync(New Uri(d2), p2)
                Catch
                    status2.Text = "---Scaricamento non riuscito, riprova---"
                    cancel2 = True
                    retry2.Text = "Riprova"
                    afterdownload2()
                End Try
            Else
                status2.Text = "---Nessuna connessione ad Internet---"
                cancel2 = True
                retry2.Text = "Riprova"
                afterdownload2()
            End If
        Else
            afterdownload2()
        End If
    End Sub
    Private Async Sub download3()
        cancel3 = False
        status3.Text = "Attendi ..."
        cur3 += 1
        SetTextCur(task3, cur3, con3)
        LoadImage(pic3, image3)
        Dim filetoboot As String
        If z3 = "0" Then
            filetoboot = p3
        Else
            filetoboot = pz3
        End If

        Dim checkl As Long = "0"
        ' Se il file eseguibie (exe) esiste, allora controlla se la grandezza è diversa da quella generata dal sito
        If File.Exists(p3) And filetoboot = p3 Then
            If z3 = "0" Then
                status3.Text = "---Controllo alcune cose ...---"
                Dim check As New Task(Sub()
                                          Try
                                              Dim obj As New WebClient
                                              Dim s As Stream
                                              s = obj.OpenRead(d3)
                                              checkl = Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
                                              obj.CancelAsync()
                                          Catch
                                              checkl = "0"
                                          End Try
                                      End Sub)
                check.Start()
                Await check
                If Not checkl = "0" Then
                    ' Adesso controlliamo se la grandezza del file generata da internet sia uguale a quella scaricata
                    Dim anfs As New FileInfo(p3)
                    Dim size As Long = anfs.Length
                    If Not size = checkl Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n3 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 3]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            Try
                                File.Delete(p3)
                            Catch
                                MsgBox("Errore eliminazione del file!", MsgBoxStyle.Critical, "[TASK 3]")
                            End Try
                        End If
                    End If
                End If
            End If
        End If

        Try
            ' Controlla se c'è una nuova versione (solo se è una cartella)
            If Not v3 = 0 And File.Exists(pz3) Then
                If File.Exists(p3 & ".version") Then
                    Dim versionreader As New System.IO.StreamReader(p3 & ".version")
                    If versionreader.ReadLine < v3 Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n3 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 3]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            status3.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p3, del3)
                        End If
                    End If
                    versionreader.Close()
                Else
                    If v3 > 1 Then
                        If MessageBox.Show("E' disponibile un nuovo aggiornamento dell'installazione di " & n3 & ". Vuoi scaricare la versione Aggiornata? [CONSIGLIATO!]", "[TASK 3]", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            status3.Text = "---Attendi ...---"
                            Await processdelete.deletesomething(p3, del3)
                        End If
                    End If
                End If
            End If
        Catch
        End Try


        If Not File.Exists(filetoboot) Then
            'Controlla lo spazio disponibile
            If checkl <> 0 Or sp3 <> 0 Then
                If checkl = 0 Then checkl = sp3
                Dim mess As String = ControllaSpazio(checkl)
                If mess <> "" Then
                    status3.Text = "---Non hai abbastanza spazio! (Mancano " & mess & ")---"
                    number = number - 1
                    occ3 = False
                    numbertext()
                    retry3.Text = "Riprova"
                    retry3.Show()
                    Exit Sub
                End If
            End If

            If My.Computer.Network.IsAvailable = True Then
                ProgressBar3.Value = 0
                retry3.Text = "Annulla"
                retry3.Show()
                speed3.Show()

                Try
                    status3.Text = "---Scarico " & n3 & "---"
                    If downloadersmall.Visible Then downloadersmall.install = status3.Text
                    client3 = New WebClient
                    AddHandler client3.DownloadProgressChanged, AddressOf Progresso3
                    AddHandler client3.DownloadFileCompleted, AddressOf afterdownload3
                    SW3 = Stopwatch.StartNew
                    client3.DownloadFileAsync(New Uri(d3), p3)
                Catch
                    status3.Text = "---Scaricamento non riuscito, riprova---"
                    cancel3 = True
                    retry3.Text = "Riprova"
                    afterdownload3()
                End Try
            Else
                status3.Text = "---Nessuna connessione ad Internet---"
                cancel3 = True
                retry3.Text = "Riprova"
                afterdownload3()
            End If
        Else
            afterdownload3()
        End If
    End Sub

    Private Async Sub afterdownload1()
        'Ferma lo StopWatch
        Try
            SW1.Stop()
            speed1.Hide()
            speed1.Text = "0 kb/s"
        Catch
        End Try
        'Controlla se bisogna annullare
        If cancel1 = True Then
            Try
                File.Delete(p1)
            Catch
            End Try
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 0
            number = number - 1
            occ1 = False
            numbertext()
            If Not status1.Text = "---Scaricamento non riuscito, riprova---" And Not status1.Text = "---Nessuna connessione ad Internet---" Then
                status1.Text = "Annullato..."
            End If
            If installall = True Then
                listeinstall.failed = listeinstall.failed & status1.Text.Replace("-", "") & " - " & n1 & vbNewLine
                listeinstall.bordello()
            End If
            task1.Text = "Task 1"
            Exit Sub
        End If

        retry1.Text = "Riprova"
        retry1.Hide()

        ProgressBar1.Style = ProgressBarStyle.Marquee
        If Not z1 = "0" And Not File.Exists(pz1) Then
            ' Se il file bisogna estrarlo
            status1.Text = "---Estraendo " & n1 & "---"
            If downloadersmall.Visible Then downloadersmall.install = status1.Text
            Dim estrazione As New Task(Sub()
                                           ExtractProcess(p1, z1, v1)
                                       End Sub)
            estrazione.Start()
            Await estrazione

        End If

        decideinstalltext("install", sil1, status1, n1)
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z1, p1, pz1, sil1, noboot1, con1)
                                End Sub)
        install.Start()
        Await install
        If done = True Then
            decideinstalltext("success", sil1, status1, n1)
        Else
            retry1.Show()
            decideinstalltext("fail", sil1, status1, n1)
            If installall = True Then
                listeinstall.failed = listeinstall.failed & status1.Text.Replace("-", "")
            End If
        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
        number = number - 1
        occ1 = False
        numbertext()

        'Parte riguardo al continuo
        If con1 <> "" And done = True Then
            Continuo(con1, 1)
            Exit Sub
        ElseIf con1 = "" And done = True Then
            task1.Text = "Task 1 - Installazione Completata"
        End If

        If installall = True Then
            listeinstall.bordello()
        End If
    End Sub

    Private Async Sub afterdownload2()
        Try
            SW2.Stop()
            speed2.Hide()
            speed2.Text = "0 kb/s"
        Catch
        End Try
        If cancel2 = True Then
            Try
                File.Delete(p2)
            Catch
            End Try
            ProgressBar2.Style = ProgressBarStyle.Blocks
            ProgressBar2.Value = 0
            number = number - 1
            occ2 = False
            numbertext()
            If Not status2.Text = "---Scaricamento non riuscito, riprova---" And Not status2.Text = "---Nessuna connessione ad Internet---" Then
                status2.Text = "Annullato..."
            End If
            task2.Text = "Task 2"
            Exit Sub
        End If

        retry2.Text = "Riprova"
        retry2.Hide()

        ProgressBar2.Style = ProgressBarStyle.Marquee
        If Not z2 = "0" And Not File.Exists(pz2) Then
            ' Se il file bisogna estrarlo
            status2.Text = "---Estraendo " & n2 & "---"
            If downloadersmall.Visible Then downloadersmall.install = status2.Text
            Dim estrazione As New Task(Sub()
                                           ExtractProcess(p2, z2, v2)
                                       End Sub)
            estrazione.Start()
            Await estrazione
        End If

        decideinstalltext("install", sil2, status2, n2)
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z2, p2, pz2, sil2, noboot2, con2)
                                End Sub)
        install.Start()
        Await install
        If done = True Then
            decideinstalltext("success", sil2, status2, n2)
        Else
            retry2.Show()
            decideinstalltext("fail", sil2, status2, n2)
        End If
        ProgressBar2.Style = ProgressBarStyle.Blocks
        number = number - 1
        occ2 = False
        numbertext()

        'Parte riguardo al continuo
        If con2 <> "" And done = True Then
            Continuo(con2, 2)
            Exit Sub
        ElseIf con2 = "" And done = True Then
            task2.Text = "Task 2 - Installazione Completata"
        End If
    End Sub

    Private Async Sub afterdownload3()
        Try
            SW3.Stop()
            speed3.Hide()
            speed3.Text = "0 kb/s"
        Catch
        End Try
        If cancel3 = True Then
            Try
                File.Delete(p3)
            Catch
            End Try
            ProgressBar3.Style = ProgressBarStyle.Blocks
            ProgressBar3.Value = 0
            number = number - 1
            occ3 = False
            numbertext()
            If Not status3.Text = "---Scaricamento non riuscito, riprova---" And Not status3.Text = "---Nessuna connessione ad Internet---" Then
                status3.Text = "Annullato..."
            End If
            task3.Text = "Task 3"
            Exit Sub
        End If

        retry3.Text = "Riprova"
        retry3.Hide()

        ProgressBar3.Style = ProgressBarStyle.Marquee
        If Not z3 = "0" And Not File.Exists(pz3) Then
            ' Se il file bisogna estrarlo
            status3.Text = "---Estraendo " & n3 & "---"
            If downloadersmall.Visible Then downloadersmall.install = status3.Text
            Dim estrazione As New Task(Sub()
                                           ExtractProcess(p3, z3, v3)
                                       End Sub)
            estrazione.Start()
            Await estrazione
        End If

        decideinstalltext("install", sil3, status3, n3)
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z3, p3, pz3, sil3, noboot3, con3)
                                End Sub)
        install.Start()
        Await install
        If done = True Then
            decideinstalltext("success", sil3, status3, n3)
        Else
            retry3.Show()
            decideinstalltext("fail", sil3, status3, n3)
        End If
        ProgressBar3.Style = ProgressBarStyle.Blocks
        number = number - 1
        occ3 = False
        numbertext()

        'Parte riguardo al continuo
        If con3 <> "" And done = True Then
            Continuo(con3, 3)
            Exit Sub
        ElseIf con3 = "" And done = True Then
            task3.Text = "Task 3 - Installazione Completata"
        End If
    End Sub

    Public Async Sub retry1_Click(sender As Object, e As EventArgs) Handles retry1.Click
        retry1.Hide()
        If retry1.Text = "Annulla" Then
            status1.Text = "Annullo..."
            c1()
            Exit Sub
        End If
        number = number + 1
        occ1 = True
        numbertext()
        decideinstalltext("install", sil1, status1, n1)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z1, p1, pz1, sil1, noboot1, con1)
                                End Sub)
        install.Start()
        Await install
        ProgressBar1.Style = ProgressBarStyle.Blocks
        If done = True Then
            decideinstalltext("success", sil1, status1, n1)
            number = number - 1
            occ1 = False
            numbertext()
            If con1 <> "" Then
                Continuo(con1, 1)
                Exit Sub
            End If
        Else
            status1.Text = "--- Riavvio " & n1 & " ... ---"
            ProgressBar1.Style = ProgressBarStyle.Marquee
            Await processdelete.deletesomething(p1, del1)
            ProgressBar1.Style = ProgressBarStyle.Blocks
            cur1 -= 1
            download1()
        End If
    End Sub

    Public Async Sub retry2_Click(sender As Object, e As EventArgs) Handles retry2.Click
        retry2.Hide()
        If retry2.Text = "Annulla" Then
            status2.Text = "Annullo..."
            c2()
            Exit Sub
        End If
        number = number + 1
        occ2 = True
        numbertext()
        decideinstalltext("install", sil2, status2, n2)
        ProgressBar2.Style = ProgressBarStyle.Marquee
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z2, p2, pz2, sil2, noboot2, con2)
                                End Sub)
        install.Start()
        Await install
        ProgressBar2.Style = ProgressBarStyle.Blocks
        If done = True Then
            decideinstalltext("success", sil2, status2, n2)
            number = number - 1
            occ2 = False
            numbertext()
            If con2 <> "" Then
                Continuo(con2, 2)
                Exit Sub
            End If
        Else
            status2.Text = "--- Riavvio " & n2 & " ... ---"
            ProgressBar2.Style = ProgressBarStyle.Marquee
            Await processdelete.deletesomething(p2, del2)
            ProgressBar2.Style = ProgressBarStyle.Blocks
            cur2 -= 1
            download2()
        End If
    End Sub

    Public Async Sub retry3_Click(sender As Object, e As EventArgs) Handles retry3.Click
        retry3.Hide()
        If retry3.Text = "Annulla" Then
            status3.Text = "Annullo..."
            c3()
            Exit Sub
        End If
        number = number + 1
        occ3 = True
        numbertext()
        decideinstalltext("install", sil3, status3, n3)
        ProgressBar3.Style = ProgressBarStyle.Marquee
        Dim done As Boolean
        Dim install As New Task(Sub()
                                    done = InstallProcess(z3, p3, pz3, sil3, noboot3, con3)
                                End Sub)
        install.Start()
        Await install
        ProgressBar3.Style = ProgressBarStyle.Blocks
        If done = True Then
            decideinstalltext("success", sil3, status3, n3)
            number = number - 1
            occ3 = False
            numbertext()
            If con3 <> "" Then
                Continuo(con3, 3)
                Exit Sub
            End If
        Else
            status3.Text = "--- Riavvio " & n3 & " ... ---"
            ProgressBar3.Style = ProgressBarStyle.Marquee
            Await processdelete.deletesomething(p3, del3)
            ProgressBar3.Style = ProgressBarStyle.Blocks
            cur3 -= 1
            download3()
        End If
    End Sub

    Public Sub c1()
        cancel1 = True
        client1.CancelAsync()
    End Sub
    Public Sub c2()
        cancel2 = True
        client2.CancelAsync()
    End Sub
    Public Sub c3()
        cancel3 = True
        client3.CancelAsync()
    End Sub

    Public Sub cancellall()
        Try
            c1()
        Catch
        End Try
        Try
            c2()
        Catch
        End Try
        Try
            c3()
        Catch
        End Try
    End Sub

    Private Sub automode_CheckedChanged(sender As Object, e As EventArgs) Handles automode.CheckedChanged
        automode2 = automode.Checked

        If automode.Checked Then
            automode.BackgroundImage = My.Resources.switchon
        Else
            automode.BackgroundImage = My.Resources.switchoff
        End If

        closesettings.Stop()
        closesettings.Interval = 5000
        closesettings.Start()
    End Sub

    Private Sub LoadImage(PicBox As PictureBox, perc As String)
        PicBox.Image = System.Drawing.Image.FromFile(perc)
    End Sub

    Private Async Sub SetTextCur(GroupBox As GroupBox, Cur As Integer, CurFileIni As String)
        Dim maxvalue As String = 1
        If Cur = 1 Then
            Dim task As New Task(Sub()
                                     Dim FileCorrente As String = CurFileIni
                                     If CurFileIni <> "" Then
                                         maxvalue += 1
                                         Dim basta As Boolean = False
                                         While basta = False
                                             If File.ReadAllText(FileCorrente).Contains("downloader.genericcon") = False Then basta = True
                                             For Each Line In File.ReadAllLines(FileCorrente)
                                                 Dim parts() As String = Line.Split(New Char() {"="}, 2)
                                                 If parts(0) = "downloader.genericcon" Then
                                                     Dim fi As New IO.FileInfo(FileCorrente)
                                                     FileCorrente = fi.DirectoryName & "\" & parts(1) & ".ini"
                                                     maxvalue += 1
                                                 End If
                                             Next
                                         End While

                                     End If
                                 End Sub)
            task.Start()
            Await task
        Else
            Dim temp1 As String() = GroupBox.Text.Split(New Char() {" di "})
            maxvalue = temp1(temp1.Length - 1)
        End If
        Dim test As String = "Task"
        If GroupBox.Name = task1.Name Then test = "Task 1"
        If GroupBox.Name = task2.Name Then test = "Task 2"
        If GroupBox.Name = task3.Name Then test = "Task 3"
        GroupBox.Text = test & " - " & "Installazione " & Cur & " di " & maxvalue
    End Sub

    Private Sub Continuo(con As String, numero As Integer)
        Select Case numero
            Case 1
                force1 = True
            Case 2
                force2 = True
            Case 3
                force3 = True
        End Select

        genericwindow.lines = File.ReadAllLines(con)
        Dim fi As New IO.FileInfo(con)
        genericwindow.percorso2 = fi.DirectoryName & "\"
        genericwindow.readanddownload()
    End Sub

    Private Sub decideinstalltext(value As String, sil As String, status As Label, n As String)
        Select Case value
            Case "install"
                If sil = "" Or automode.Checked = False Then
                    status.Text = "---Tentativo di avvio---"
                    If installall = True Then status.Text = "---Attendo " & n & "---"
                Else
                    status.Text = "---Installo " & n & "---"
                End If

                If downloadersmall.Visible Then downloadersmall.install = status.Text
            Case "success"
                If sil = "" Or automode.Checked = False Then
                    status.Text = "---" & n & " avviato---"
                Else
                    status.Text = "---Installazione di " & n & " completata---"
                End If

                If downloadersmall.Visible And listmode = False Then downloadersmall.warning(status.Text)
            Case "fail"
                If (sil = "" Or automode.Checked = False) And installall = True Then
                    status.Text = "---Avvio di " & n & " fallito!---"
                Else
                    status.Text = "---Installazione di " & n & " fallita!---"
                End If

                If downloadersmall.Visible Then downloadersmall.warning(status.Text)
        End Select
    End Sub

    Private Function ExtractProcess(p As String, z As String, v As Integer) As Boolean
        Dim done As Boolean = True
        Dim extract As String = p
        Dim where As String = z
        Try
            Directory.Delete(where, True)
        Catch
        End Try
        Try
            Directory.CreateDirectory(where)
        Catch
        End Try
        Try
            ZipFile.ExtractToDirectory(extract, where)
        Catch ep As Exception
            done = False
            If listmode = False Then MsgBox("Errore estrazione:" & vbCrLf & ep.Message, MsgBoxStyle.Critical, "Errore")
        End Try
        Try
            File.Delete(p)
        Catch
        End Try
        Try
            If Not v = 0 Then
                Dim writer As New StreamWriter(p & ".version")
                writer.Write(v)
                writer.Close()
            End If
        Catch
        End Try

        Return done
    End Function

    Private Function InstallProcess(z As String, p As String, pz As String, sil As String, noboot As Boolean, con As String) As Boolean
        Dim done As Boolean
        If noboot = True Then Return True
        Dim filetoboot As String
        If z = "0" Then
            filetoboot = p
        Else
            filetoboot = pz
        End If
        Try
            done = True
            If automode2 = False Then sil = ""

            Dim anfs As New FileInfo(filetoboot)
            Dim downloader As New Process
            With downloader.StartInfo
                .FileName = (anfs.Name)
                .WorkingDirectory = anfs.DirectoryName & "\"
                .Arguments = sil
                If sil.Contains("/Silent") Then .WindowStyle = ProcessWindowStyle.Hidden
            End With
            downloader.Start()
            If sil.Replace(" ", "") <> "" Or con.Replace(" ", "") <> "" Or installall = True Then
                downloader.WaitForExit()
                If downloader.ExitCode <> 0 Then done = False
            End If
        Catch
            done = False
        End Try

        Return done
    End Function

    Private Function ControllaSpazio(sp As Long) As String
        Dim messaggio As String = ""
        Dim d As DriveInfo
        For Each d In DriveInfo.GetDrives()
            If d.IsReady = True Then
                If d.Name = Path.GetPathRoot(Application.StartupPath) Then
                    If d.TotalFreeSpace < sp Then
                        messaggio = deleteappsnew.GetFileSize(sp - d.TotalFreeSpace)
                    End If
                End If
            End If
        Next
        Return messaggio
    End Function

    Private Sub closesettings_Tick(sender As Object, e As EventArgs) Handles closesettings.Tick
        closesettingsbtn.PerformClick()
    End Sub

    Private Sub closesettingsbtn_Click(sender As Object, e As EventArgs) Handles closesettingsbtn.Click, Label1.Click
        closesettings.Stop()
        panelsettings.Visible = False
    End Sub

    Private Sub settingsbtn_Click(sender As Object, e As EventArgs) Handles settingsbtn.Click
        panelsettings.BringToFront()
        panelsettings.Visible = True
        closesettings.Interval = 10000
        closesettings.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        installa.rebootdownloader()
        closesettingsbtn.PerformClick()
    End Sub
End Class