Imports System.IO
Imports System.Net

Public Class impostaaggiornamento

#Region "Aggiornamenti"
    Public Shared versione As String = "5.7.1"
    Public Shared versioncode As String = "571"

    Public Shared already As Boolean = False
    Public Shared WithEvents Timer1 As New Timer
    Public Shared installasilenzioso As Boolean = False
    Public Shared welcomemode As Boolean = False
    Public Shared Async Sub verificaaggiornamento()
        If already = True Then
            Exit Sub
        Else
            already = True
        End If

        Try
            Timer1.Stop()
        Catch
        End Try
        nuovoaggiornamento.Close()

        Dim nv As String = versioncode

        Dim task As New Task(Sub()
                                 Try
                                     Dim client As WebClient = New WebClient
                                     nv = client.DownloadString(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gqodFraaQh8Fq3THCA/root/content"))
                                 Catch
                                 End Try
                             End Sub)
        task.Start()
        Await task

        HELPING.PictureBox4.Hide()
        HELPING.Button5.Enabled = True

        If nv > versioncode Then
            nuovoaggiornamento.newinstallerversion = nv

            'Scarica il Changelog - se non presente
            If File.Exists(Application.StartupPath & "\Fondamental\Settings\Changelog\" & determinaversione(nv) & ".txt") = False Then
                Dim change As New Task(Sub()
                                           Try
                                               Dim client As WebClient = New WebClient
                                               Dim ii As String = ""
                                               ii = client.DownloadString(New Uri("https://api.onedrive.com/v1.0/shares/s!AgnIj48L3IE3gqwSniJae2mlCHzpFQ/root/content"))
                                               If ii <> "" Then File.WriteAllText(Application.StartupPath & "\Fondamental\Settings\Changelog\" & determinaversione(nv) & ".txt", ii, System.Text.Encoding.Default)
                                           Catch
                                           End Try
                                       End Sub)
                change.Start()
                Await change
            End If

            If welcomemode Or installasilenzioso Then
                    If welcomemode Then Welcome16.valore(11)
                    If installasilenzioso Then INIZIO.aggiornamentovalore(2)
                    nuovoaggiornamento.silent = True
                    nuovoaggiornamento.updateinstaller()
                Else
                    HELPING.Label7.Text = "Aggiornamento disponibile!"
                    decidi()
                End If
            Else
                If welcomemode Or installasilenzioso Then
                If welcomemode Then Welcome16.valore(5)
                If installasilenzioso Then INIZIO.aggiornamentovalore(4)

                installasilenzioso = False
                welcomemode = False
            Else
                HELPING.Label7.Text = "Verifica aggiornamenti"
            End If
        End If

        already = False
    End Sub

    Private Shared Sub decidi()
        If Haifinito.Visible = True Or downloader.Visible = True And downloader.number > 0 Or downloader.installall = True Then
            Timer1.Interval = 10000
            Timer1.Start()
        Else
            nuovoaggiornamento.silent = False
            nuovoaggiornamento.ShowDialog()
        End If
    End Sub
    Private Shared Sub avviaagg()
        Timer1.Stop()
        decidi()
    End Sub

    Private Shared Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        avviaagg()
    End Sub

    Public Shared Sub modalita(mode As Integer)
        If welcomemode Then
            If mode = 1 Then Welcome16.valore(4)
            If mode = 2 Then Welcome16.valore(3)
        ElseIf installasilenzioso Then
            If mode = 1 Then INIZIO.aggiornamentovalore(4)
            If mode = 2 Then INIZIO.aggiornamentovalore(3)
        End If

        installasilenzioso = False
        welcomemode = False
    End Sub
#End Region

#Region "Codici"
    Public Shared Sub after()
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
            Loading.loadedwhere = Application.StartupPath & "\"
        Catch
            Loading.loadedwhere = Application.StartupPath
        End Try

        Try
            File.Delete(Application.StartupPath & "\ok.bat")
        Catch
        End Try
    End Sub

    Public Shared Function determinaversione(numero As String)
        numero = numero.Insert(1, ".")

        If numero(numero.Length - 1) = "0" Then
            numero = numero.Substring(0, numero.Length - 1)
        Else
            numero = numero.Insert(3, ".")
        End If

        Return numero
    End Function

    Public Shared Function codificaversione(numero As String)
        numero = numero.ToLower.Replace("versione", "").Replace(" ", "").Replace(".", "")
        If numero.Length < 3 Then numero = numero & "0"

        Return numero
    End Function

    Public Shared Function LeggiOpzione(settingfile As String, chiave As String)
        If Equals(settingfile, "") Then settingfile = Application.StartupPath & "\Fondamental\Settings\impostazioni.ini"

        Try
            If File.Exists(settingfile) Then
                Dim sw As List(Of String) = New List(Of String)(File.ReadAllLines(settingfile))

                For i As Integer = 0 To sw.Count - 1
                    Dim lettura As String = sw(i)

                    If lettura.Contains(chiave & "=") Then
                        Return lettura.Replace(chiave & "=", "")
                    End If
                Next
            End If
        Catch
        End Try

        Return ""
    End Function

    Public Shared Sub SalvaOpzione(settingfile As String, chiave As String, valore As String, darimuovere As Boolean)
        If Equals(settingfile, "") Then
            settingfile = Application.StartupPath & "\Fondamental\Settings\impostazioni.ini"
        Else
            Dim a As List(Of String) = New List(Of String)(settingfile.Split("\"c).ToList())

            If a.Count - 2 > 0 Then
                Dim eccola As String = ""

                For i As Integer = 0 To a.Count - 2
                    eccola = eccola & a(i) & "\"
                Next

                If Directory.Exists(eccola) = False Then
                    Try
                        Directory.CreateDirectory(eccola)
                    Catch
                    End Try
                End If
            End If
        End If

        Dim ueue As List(Of String) = New List(Of String)()

        If File.Exists(settingfile) Then
            ueue = New List(Of String)(File.ReadAllLines(settingfile))

            For i As Integer = 0 To ueue.Count - 1
                Dim lettura As String = ueue(i)

                If lettura.Contains(chiave & "=") Then
                    ueue.RemoveAt(i)
                    If darimuovere = True Then Exit For
                    ueue.Insert(i, chiave & "=" & valore)
                    File.WriteAllLines(settingfile, ueue)
                    Return
                End If
            Next
        End If

        If darimuovere = False Then ueue.Add(chiave & "=" & valore)
        File.WriteAllLines(settingfile, ueue)
    End Sub
#End Region
End Class
