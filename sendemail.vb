Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Threading
Public Class sendemail
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

    Dim testo As String
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        check()
    End Sub

    Private Sub sendemail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        BackColor = INIZIO.BackColor
        ForeColor = INIZIO.ForeColor
        panelgoto.BackColor = INIZIO.panelgoto.BackColor
        RichTextBox1.BackColor = panelgoto.BackColor
        RichTextBox1.ForeColor = ForeColor
        TextBox1.BackColor = panelgoto.BackColor
        TextBox2.BackColor = panelgoto.BackColor
        TextBox3.BackColor = panelgoto.BackColor
        TextBox1.ForeColor = ForeColor
        TextBox2.ForeColor = ForeColor
        TextBox3.ForeColor = ForeColor
        If ForeColor <> Color.Black Then ComboBox1.BackColor = panelgoto.BackColor
        ComboBox1.ForeColor = ForeColor

        RichTextBox1.Enabled = False
        TextBox2.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then
            TextBox3.Text = " "
        End If
        Label7.Text = "Invio il messaggio..."
        Button2.Enabled = False
        Button1.Enabled = False
        If My.Computer.Network.IsAvailable = True Then
            faitesto()
            segnalazione()
        Else
            MsgBox("Impossibile inviare la segnalazione, il computer non è connesso ad Internet!", MsgBoxStyle.Exclamation, "Attenzione")
            Button1.Enabled = True
            Label7.Text = "Invia il Messaggio!"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        If ComboBox1.Text = "Personalizzato" Then
            TextBox1.Enabled = True
            TextBox1.Text = ""
            TextBox1.Select()
        Else
            TextBox1.Text = "Se hai cliccato su 'Personalizzato', scrivi qui dove accade il Problema."
            TextBox1.Enabled = False
            check()
        End If
    End Sub

    Private Sub faitesto()
        Dim problem As String
        If ComboBox1.Text = "Personalizzato" Then
            problem = TextBox1.Text
        Else
            problem = ComboBox1.Text
        End If
        testo = "Segnalazione Errori / Suggerimenti PROGRAM INSTALLER" & vbNewLine &
            "Nome = " & TextBox2.Text & vbNewLine &
            "Email = " & TextBox3.Text & vbNewLine &
            "Categoria = " & problem & vbNewLine &
            "Descrizione = " & RichTextBox1.Text
    End Sub

    Private Sub check()
        Button2.Enabled = True
        If ComboBox1.Text = "Personalizzato" Then
            If TextBox1.Text = "" Or TextBox1.Text = " " Then
                RichTextBox1.Enabled = False
                Button2.Enabled = False
            Else
                RichTextBox1.Enabled = True
            End If
        Else
            RichTextBox1.Enabled = True
        End If
        If TextBox2.Text = "" Or TextBox2.Text = " " Then
            Button2.Enabled = False
        End If
        If RichTextBox1.Text = "" Or RichTextBox1.Text = " " Then
            Button2.Enabled = False
        End If
    End Sub

    Private Async Sub segnalazione()
        Dim fatto As Boolean
        Dim task As New Task(Sub()
                                 Try
                                     Dim smtpServer As New SmtpClient()
                                     Dim mail As New MailMessage()
                                     smtpServer.Credentials = New Net.NetworkCredential("luca.tartaglia01@gmail.com", "dutftjkjinlakkvt")
                                     smtpServer.Port = 587
                                     smtpServer.Host = "smtp.gmail.com"
                                     smtpServer.EnableSsl = True
                                     mail = New MailMessage()
                                     mail.From = New MailAddress("luca.tartaglia01@gmail.com")
                                     mail.To.Add("luca.tartaglia01@gmail.com")
                                     mail.Subject = "PROGRAM INSTALLER BUG REPORTING"
                                     mail.Body = testo
                                     smtpServer.Send(mail)
                                     MsgBox("Il tuo Feedback è stato inviato con successo!", MsgBoxStyle.Information, "Fatto!")
                                     fatto = True
                                 Catch
                                     MsgBox("Si è verificato un errore durante l'invio della segnalazione!", MsgBoxStyle.Information, "Oh no...")
                                     fatto = False
                                 End Try
                             End Sub)
        task.Start()
        Await task

        Button1.Show()
        Label7.Text = "Invia il Messaggio!"
        Button2.Enabled = True

        If fatto = True Then Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        check()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        check()
    End Sub
End Class