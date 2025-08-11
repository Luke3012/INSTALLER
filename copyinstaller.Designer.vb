<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class copyinstaller
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.selectconfig = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelall = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelthat = New System.Windows.Forms.Panel()
        Me.panelcopy = New System.Windows.Forms.Panel()
        Me.copybtn = New System.Windows.Forms.Button()
        Me.selectedtitle = New System.Windows.Forms.Label()
        Me.selectedpic = New System.Windows.Forms.PictureBox()
        Me.panelselect = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelthis = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelgoto.SuspendLayout()
        Me.panelall.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelthat.SuspendLayout()
        Me.panelcopy.SuspendLayout()
        CType(Me.selectedpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelselect.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelthis.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Controls.Add(Me.closebutton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(879, 85)
        Me.Panel2.TabIndex = 56
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(87, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(524, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Collegati a un'altra configurazione"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.goinstall
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'closebutton
        '
        Me.closebutton.AutoSize = True
        Me.closebutton.BackgroundImage = Global.INSTALLER.My.Resources.Resources.close_window
        Me.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Location = New System.Drawing.Point(797, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 357)
        Me.Panel1.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.INSTALLER.My.Resources.Resources.zip
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(304, 96)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 182)
        Me.Button2.TabIndex = 62
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(637, 40)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Premi qui per selezionare una configurazione valida"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.Button1)
        Me.panelgoto.Controls.Add(Me.Label1)
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 458)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(879, 150)
        Me.panelgoto.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.retry
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 105)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Cambia configurazione"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vai
        '
        Me.vai.BackColor = System.Drawing.Color.Transparent
        Me.vai.BackgroundImage = Global.INSTALLER.My.Resources.Resources.shipping_and_delivery
        Me.vai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.vai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vai.Enabled = False
        Me.vai.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.vai.FlatAppearance.BorderSize = 0
        Me.vai.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vai.Location = New System.Drawing.Point(555, 5)
        Me.vai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.vai.Name = "vai"
        Me.vai.Size = New System.Drawing.Size(134, 105)
        Me.vai.TabIndex = 60
        Me.vai.UseVisualStyleBackColor = False
        '
        'vailbl
        '
        Me.vailbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.vailbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vailbl.Location = New System.Drawing.Point(489, 115)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(267, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Trasferisci tutto"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectconfig
        '
        Me.selectconfig.Description = "Seleziona la cartella ""Fondamental"" desiderata"
        Me.selectconfig.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.selectconfig.ShowNewFolderButton = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'panelall
        '
        Me.panelall.Controls.Add(Me.PictureBox1)
        Me.panelall.Controls.Add(Me.panelthat)
        Me.panelall.Controls.Add(Me.panelthis)
        Me.panelall.Location = New System.Drawing.Point(12, 93)
        Me.panelall.Name = "panelall"
        Me.panelall.Size = New System.Drawing.Size(855, 357)
        Me.panelall.TabIndex = 67
        Me.panelall.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.double_chevron
        Me.PictureBox1.Location = New System.Drawing.Point(365, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panelthat
        '
        Me.panelthat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelthat.Controls.Add(Me.panelcopy)
        Me.panelthat.Controls.Add(Me.panelselect)
        Me.panelthat.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelthat.Location = New System.Drawing.Point(505, 0)
        Me.panelthat.Name = "panelthat"
        Me.panelthat.Size = New System.Drawing.Size(350, 357)
        Me.panelthat.TabIndex = 1
        '
        'panelcopy
        '
        Me.panelcopy.Controls.Add(Me.copybtn)
        Me.panelcopy.Controls.Add(Me.selectedtitle)
        Me.panelcopy.Controls.Add(Me.selectedpic)
        Me.panelcopy.Location = New System.Drawing.Point(4, 3)
        Me.panelcopy.Name = "panelcopy"
        Me.panelcopy.Size = New System.Drawing.Size(341, 349)
        Me.panelcopy.TabIndex = 1
        Me.panelcopy.Visible = False
        '
        'copybtn
        '
        Me.copybtn.BackColor = System.Drawing.Color.Transparent
        Me.copybtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.go1
        Me.copybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.copybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.copybtn.FlatAppearance.BorderSize = 0
        Me.copybtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.copybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copybtn.Location = New System.Drawing.Point(103, 236)
        Me.copybtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.copybtn.Name = "copybtn"
        Me.copybtn.Size = New System.Drawing.Size(134, 105)
        Me.copybtn.TabIndex = 62
        Me.copybtn.UseVisualStyleBackColor = False
        '
        'selectedtitle
        '
        Me.selectedtitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedtitle.Location = New System.Drawing.Point(3, 169)
        Me.selectedtitle.Name = "selectedtitle"
        Me.selectedtitle.Size = New System.Drawing.Size(335, 66)
        Me.selectedtitle.TabIndex = 5
        Me.selectedtitle.Text = "Vuoi copiare 'nome applicazione' ?"
        Me.selectedtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'selectedpic
        '
        Me.selectedpic.Location = New System.Drawing.Point(84, 18)
        Me.selectedpic.Name = "selectedpic"
        Me.selectedpic.Size = New System.Drawing.Size(172, 143)
        Me.selectedpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.selectedpic.TabIndex = 3
        Me.selectedpic.TabStop = False
        '
        'panelselect
        '
        Me.panelselect.Controls.Add(Me.Label5)
        Me.panelselect.Controls.Add(Me.PictureBox3)
        Me.panelselect.Location = New System.Drawing.Point(25, 21)
        Me.panelselect.Name = "panelselect"
        Me.panelselect.Size = New System.Drawing.Size(299, 312)
        Me.panelselect.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 66)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seleziona qualcosa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INSTALLER.My.Resources.Resources.feelings
        Me.PictureBox3.Location = New System.Drawing.Point(43, 52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(213, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'panelthis
        '
        Me.panelthis.AutoScroll = True
        Me.panelthis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelthis.Controls.Add(Me.Panel3)
        Me.panelthis.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelthis.Location = New System.Drawing.Point(0, 0)
        Me.panelthis.Name = "panelthis"
        Me.panelthis.Size = New System.Drawing.Size(350, 357)
        Me.panelthis.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 100)
        Me.Panel3.TabIndex = 0
        Me.Panel3.Visible = False
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 50)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Office 2019 l'applicazione più bella"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 44)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "2,21 GB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.INSTALLER.My.Resources.Resources.changelog
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'copyinstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelall)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "copyinstaller"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia dati"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panelgoto.ResumeLayout(False)
        Me.panelall.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelthat.ResumeLayout(False)
        Me.panelcopy.ResumeLayout(False)
        CType(Me.selectedpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelselect.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelthis.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents closebutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelgoto As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents selectconfig As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelall As Panel
    Friend WithEvents panelthat As Panel
    Friend WithEvents panelthis As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelselect As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents panelcopy As Panel
    Friend WithEvents copybtn As Button
    Friend WithEvents selectedtitle As Label
    Friend WithEvents selectedpic As PictureBox
End Class
