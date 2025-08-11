Imports System.IO
Public Class othersettings
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

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Sicuro di voler scaricare l'ultima versione del Database? Tutti i programmi già scaricati in precedenza NON verranno eliminati.", "Conferma?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                impostaaggiornamento.SalvaOpzione("", "forcedb", "true", False)
                System.Windows.Forms.Application.Restart()
            Catch
                MessageBox.Show("C'è stato un errore durante l'applicazione dell'opzione, cartella danneggiata.", "Impossibile eseguire l'operazione.", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub downloadinstaller_Click(sender As Object, e As EventArgs) Handles downloadinstaller.Click
        If MessageBox.Show("Vuoi riscaricare l'ultima versione di INSTALLER? Per farlo, dovrò chiudere il programma.", "Conferma?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                File.WriteAllText(Application.StartupPath & "\Fondamental\Settings\Downloader\path", Application.StartupPath)
                Dim downloader As New Process
                With downloader.StartInfo
                    .FileName = ("INSTALLER Downloader.exe")
                    .WorkingDirectory = Loading.loadedwhere & "Fondamental\Settings\Downloader\"
                End With
                downloader.Start()
                INIZIO.Close()
            Catch
                MsgBox("Errore avvio del programma esterno, prova a riscaricare il Database!", MsgBoxStyle.Critical, "Errore!")
            End Try
        End If
    End Sub

    Private Sub othersettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Vuoi pulire la cronologia installazioni?", "Pulire la cronologia?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            impostaaggiornamento.SalvaOpzione("", "recente1", "", True)
            impostaaggiornamento.SalvaOpzione("", "recente2", "", True)
            impostaaggiornamento.SalvaOpzione("", "recente3", "", True)
            INIZIO.updatesmart()
        End If
    End Sub
End Class