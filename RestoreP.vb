Imports System.IO
Imports System.Security
Public Class RestoreP
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

    Public secondtry As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        secondtry = False
        Label2.Hide()
        Timer1.Start()
    End Sub
    Private Sub Button2_MouseLeave() Handles Button2.MouseLeave
        Label2.Font = New Font(Label2.Font, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseEnter() Handles Button2.MouseEnter
        Label2.Font = New Font(Label2.Font, FontStyle.Bold)
    End Sub

    Private Sub RestoreP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INIZIO.Hide()
        HELPING.Hide()
        AboutBox1.Close()
        deleteappsnew.Close()
        UpdateDetermination.Close()
        othersettings.Close()
        Changelog.Close()
        'INIZIO.freememory()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Try
            impostaaggiornamento.SalvaOpzione("", "restore", "", True)
        Catch
        End Try
        chiudisino = True

        INIZIO.riavvio = True
        Close()
    End Sub

    Private Async Sub after()
        Timer1.Stop()
        Label1.Text = "Eliminazione in Corso ..."
        If secondtry = True Then
            Label1.Text = "Primo tentativo di Eliminazione fallito, Riprovo ..."
        End If
        Label2.Hide()
        back.Hide()
        Dim errore As Boolean = False

        Dim task As New Task(Sub()
                                 Try
                                     File.Delete(Application.StartupPath & "\Fondamental.zip")
                                 Catch
                                 End Try
                                 Try
                                     Directory.Delete(Application.StartupPath & "\Fondamental", True)
                                 Catch
                                     errore = True
                                 End Try
                             End Sub)
        task.Start()
        Await task
        If errore = False Then
            Hide()
            If MessageBox.Show("Eliminazione effettuata con successo! Vuoi riavviare INSTALLER?", "Fatto!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                INIZIO.riavvio = True
                Close()
            End If

            Close()
        Else
            If secondtry = True Then
                MsgBox("Errore Eliminazione Directory FONDAMENTAL! Riprova.", MsgBoxStyle.Critical, "Errore!")
                Button2.FlatAppearance.BorderSize = 1
                Button2.Location = New Point(Button2.Location.X, 156)
                Label1.Text = "Sei sicuro di voler ripristinare il programma" & vbNewLine & "alle impostazioni iniziali?"
                Label2.Show()
                back.Show()
            Else
                secondtry = True
                after()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Button2.Location.Y >= Height + Button2.Height Then
            Button2.FlatAppearance.BorderSize = 0
            Button2.Location = New Point(Button2.Location.X, Button2.Location.Y + 5)
        Else
            after()
        End If
    End Sub
End Class