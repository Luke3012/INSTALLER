Imports System.IO
Imports System.IO.Compression
Imports System.Net

Public Class Loading
    'Cose movimento
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, PictureBox1.MouseDown, Label1.MouseDown, Label2.MouseDown, stato.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, PictureBox1.MouseMove, Label1.MouseMove, Label2.MouseMove, stato.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, PictureBox1.MouseUp, Label1.MouseUp, Label2.MouseUp, stato.MouseUp
        drag = False
        Cursor = Cursors.WaitCursor
    End Sub
    'Fine cose movimento

    Dim chiudisino As Boolean = False
    Private Sub Chiusura(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not chiudisino Then e.Cancel = True
    End Sub

    Public loadedwhere As String
    Public theme As String = "light"

    Private current As Integer
    Private maximum As Integer
    Private str_ As String
    Private count_ As Integer
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = 26
        goon.Start()
        maximum = 190
        stato.Text = "Inizializzo ..."
        Label2.Hide()
        Label1.Text = ""
        count_ = 1
        str_ = "Carico INSTALLER ..."
        colors()
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Text.Length = str_.Length Then
            Timer1.Enabled = False
            due()
            Exit Sub
        End If
        Label1.Text = str_.Substring(0, count_)
        count_ = count_ + 1
    End Sub

    Private Sub due()
        Label2.Show()
        Label2.Text = ""
        count_ = 1
        str_ = "Versione " & impostaaggiornamento.versione & " - By Luke3012"
        current = 120
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label2.Text.Length = str_.Length Then
            Timer2.Enabled = False
            tre()
            Exit Sub
        End If
        Label2.Text = str_.Substring(0, count_)
        count_ = count_ + 1
    End Sub

    Private Sub tre()
        current = 190
        maximum = 240
        stato.Text = "Verifico Aggiornamenti ..."
        Timer3.Start()
    End Sub

    Dim ifinternet As Boolean = True
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        checkfondamental()
    End Sub

#Region "Fondamental"
    Private Async Sub checkfondamental()
        Timer3.Stop()
        Dim nv As Integer = 0
        Dim ov As Integer = 0

        'Vai!
        If impostaaggiornamento.LeggiOpzione("", "forcedb") <> "true" And File.Exists(Application.StartupPath & "\Fondamental\Settings\impostazioni.ini") Then
            Dim task As New Task(Sub()
                                     Try
                                         If File.Exists(Application.StartupPath & "\Fondamental\Settings\version.txt") Then ov = File.ReadAllText(Application.StartupPath & "\Fondamental\Settings\version.txt")
                                     Catch
                                     End Try

                                     Try
                                         Dim client As WebClient = New WebClient
                                         nv = client.DownloadString(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gqoa2tFWpFdFEowSrA/root/content"))
                                     Catch
                                     End Try
                                 End Sub)
            task.Start()
            Await task
        End If

        indownload = True
        If nv > ov Or impostaaggiornamento.LeggiOpzione("", "forcedb") = "true" Then Await updatefondamental()
        indownload = False

        quattro()
    End Sub

    Public indownload As Boolean = False
    Public welcomemode As Boolean = False
    Public Async Function updatefondamental() As Task
        Dim errore As Boolean = False
        'INIZIO.freememory()
        current = 30
        maximum = 30
        If welcomemode = False Then forcewidth = 30

        Dim taskcheck As New Task(Sub()
                                      Try
                                          My.Computer.Network.Ping("google.com")
                                      Catch
                                          errore = True
                                      End Try
                                  End Sub)
        If welcomemode = False Then
            taskcheck.Start()
            Await taskcheck
        End If

        If errore = True Then
            'MsgBox("Errore durante il Collegamento a Internet! Riprova.", MsgBoxStyle.Critical, "Errore")
            Exit Function
        End If

        If welcomemode = False Then
            current = 30
            maximum = 120
            stato.Text = "Download in Corso ..."
        Else
            Welcome015.valore(1)
        End If
        'updatedatabase.Label2.Text = "Percentuale Completamento: 10 %"

        Dim task As New Task(Sub()
                                 Try
                                     File.Delete(Application.StartupPath & "\Fondamental.zip")
                                 Catch
                                 End Try
                                 Try
                                     impostaaggiornamento.SalvaOpzione("", "forcedb", "", True)
                                 Catch
                                 End Try
                                 Try
                                     Dim client As WebClient = New WebClient
                                     client.DownloadFile(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gqob8yM1SRudWZfKig/root/content"), Application.StartupPath & "\Fondamental.zip")
                                 Catch
                                     errore = True
                                 End Try
                             End Sub)
        task.Start()
        Await task

        Dim myFile As New FileInfo(Application.StartupPath & "\Fondamental.zip")

        If errore = True Or myFile.Length = 0 Then
            If welcomemode Then
                MsgBox("Si è verificato un errore durante il download del database! Riprova più tardi.", MsgBoxStyle.Critical, "Oh no...")
                Welcome015.seerrore()
            End If
            Exit Function
        End If

        If welcomemode = False Then
            stato.Text = "Preparo l'Estrazione ..."
            'updatedatabase.Label2.Text = "Percentuale Completamento: 50 %"
            current = 120
            maximum = 180
        Else
            Welcome015.valore(2)
        End If
        Dim fold As String = installa.outputfolder
        Dim taskbho As New Task(Sub()
                                    Try
                                        For Each folder In Directory.GetDirectories(fold)
                                            If Not Path.GetFileName(folder) = "Settings" Then
                                                Dim di As New DirectoryInfo(folder)
                                                Dim fiArr As FileInfo() = di.GetFiles()
                                                Dim fri As FileInfo
                                                For Each fri In fiArr
                                                    If fri.Name.Contains(".ini") Then
                                                        Try
                                                            File.Delete(fri.FullName)
                                                        Catch
                                                        End Try
                                                    End If
                                                Next fri
                                            End If
                                        Next
                                    Catch
                                    End Try
                                End Sub)
        taskbho.Start()
        Await taskbho
        If welcomemode = False Then
            stato.Text = "Estrazione in Corso ..."
            'updatedatabase.Label2.Text = "Percentuale Completamento: 60 %"
            current = 180
            maximum = 280
        End If

        Dim task2 As New Task(Sub()
                                  Try
                                      Using archive As ZipArchive = ZipFile.OpenRead(Application.StartupPath & "\Fondamental.zip")
                                          For Each entry As ZipArchiveEntry In archive.Entries
                                              Dim entryFullname = Path.Combine(Application.StartupPath & "\", entry.FullName)
                                              Dim entryPath = Path.GetDirectoryName(entryFullname)
                                              If (Not (Directory.Exists(entryPath))) Then
                                                  Directory.CreateDirectory(entryPath)
                                              End If

                                              Dim entryFn = Path.GetFileName(entryFullname)
                                              If (Not String.IsNullOrEmpty(entryFn)) Then
                                                  Try
                                                      entry.ExtractToFile(entryFullname, True)
                                                  Catch
                                                  End Try
                                              End If
                                          Next
                                      End Using
                                  Catch
                                      errore = True
                                  End Try
                                  Try
                                      File.Delete(Application.StartupPath & "\Fondamental.zip")
                                  Catch
                                  End Try
                              End Sub)
        task2.Start()
        Await task2

        If errore = True Then
            If welcomemode Then
                MsgBox("Si è verificato un errore durante l'estrazione del database!", MsgBoxStyle.Critical, "Oh no...")
                Welcome015.seerrore()
            End If
            Exit Function
        End If

        If welcomemode = False Then
            stato.Text = "Finalizzazione in Corso ..."
            'updatedatabase.Label2.Text = "Percentuale Completamento: 90 %"
            current = 280
            maximum = 316
        Else
            Welcome015.valore(3)
        End If

        Dim task3 As New Task(Sub()
                                  Try
                                      For Each folder In Directory.GetDirectories(Application.StartupPath & "\Fondamental\")
                                          Dim trovato As Boolean = False
                                          For Each line In File.ReadAllLines(Application.StartupPath & "\Fondamental\" & "contents")
                                              If Path.GetFileName(folder) = line Then
                                                  trovato = True
                                              End If
                                          Next
                                          If trovato = False Then
                                              Try
                                                  Directory.Delete(Application.StartupPath & "\Fondamental\" & Path.GetFileName(folder), True)
                                              Catch
                                              End Try
                                          End If
                                      Next
                                  Catch
                                  End Try
                              End Sub)
        task3.Start()
        Await task3

        If welcomemode Then Welcome015.sefatto()
    End Function
#End Region

    Private Async Sub quattro()
        goon.Interval = 10
        current = 240
        maximum = 316

        stato.Text = "Verifico le funzionalità ..."
        Dim errore As Boolean = False
        Dim task As New Task(Sub()
                                 Try
                                     If File.Exists(Application.StartupPath & "\Fondamental.zip") Then File.Delete(Application.StartupPath & "\Fondamental.zip")
                                 Catch
                                 End Try

                                 Try
                                     Dim check As New StreamWriter(Application.StartupPath & "\ok.bat")
                                     check.WriteLine("echo File creato solo per fare un piccolo test...")
                                     check.Close()
                                     Dim checkok As New Process
                                     With checkok.StartInfo
                                         .FileName = ("ok.bat")
                                         .WorkingDirectory = Application.StartupPath & "\"
                                         .WindowStyle = ProcessWindowStyle.Hidden
                                     End With
                                     checkok.Start()
                                 Catch
                                     errore = True
                                 End Try

                                 Try
                                     If File.Exists(Application.StartupPath & "\ok.bat") Then File.Delete(Application.StartupPath & "\ok.bat")
                                 Catch
                                 End Try
                             End Sub)
        task.Start()
        Await task
        If errore = False Then
            loadedwhere = Application.StartupPath & "\"
        Else
            loadedwhere = Application.StartupPath
        End If

        Timer4.Start()
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If PictureBox1.Width < maximum Then Exit Sub
        fine()
    End Sub
    Private Sub fine()
        Timer4.Stop()
        goon.Stop()

        chiudisino = True
        Close()
    End Sub

    Private Sub colors()
        Try
            If impostaaggiornamento.LeggiOpzione("", "color") = "night" Then
                theme = "night"
                BackColor = Color.DimGray
                ForeColor = Color.White
                Exit Sub
            End If

            theme = "light"
            BackColor = Color.WhiteSmoke
            ForeColor = Color.Black
        Catch
            Welcome.Show()
            chiudisino = True
            Close()
        End Try
    End Sub

    Dim forcewidth As Integer = 0
    Private Sub goon_Tick(sender As Object, e As EventArgs) Handles goon.Tick
        If PictureBox1.Width < maximum And forcewidth = 0 Then
            If current > PictureBox1.Width Then
                PictureBox1.Width += 1.5
            Else
                PictureBox1.Width += 1
            End If
        ElseIf forcewidth <> 0 And PictureBox1.Width - 2 > forcewidth Then
            PictureBox1.Width -= 2
            If PictureBox1.Width - 2 <= forcewidth Then
                forcewidth = 0
                goon.Interval = 50
            End If
        ElseIf PictureBox1.Width > maximum Then
                PictureBox1.Width -= 1.5
        End If
    End Sub
End Class