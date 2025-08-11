<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome15))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.help = New System.Windows.Forms.Button()
        Me.helplbl = New System.Windows.Forms.Label()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Avvertenze!"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(502, 240)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.closebutton)
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 85)
        Me.Panel2.TabIndex = 62
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
        Me.closebutton.Location = New System.Drawing.Point(530, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 3
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(430, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Configurazione di INSTALLER"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.welcome
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(18, 98)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 477)
        Me.Panel1.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(174, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.help)
        Me.panelgoto.Controls.Add(Me.helplbl)
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 585)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(612, 149)
        Me.panelgoto.TabIndex = 66
        '
        'help
        '
        Me.help.BackColor = System.Drawing.Color.Transparent
        Me.help.BackgroundImage = Global.INSTALLER.My.Resources.Resources.help_icon
        Me.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.help.Enabled = False
        Me.help.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.help.FlatAppearance.BorderSize = 0
        Me.help.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help.Location = New System.Drawing.Point(88, 9)
        Me.help.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(134, 105)
        Me.help.TabIndex = 62
        Me.help.UseVisualStyleBackColor = False
        '
        'helplbl
        '
        Me.helplbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.helplbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helplbl.Location = New System.Drawing.Point(4, 114)
        Me.helplbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.helplbl.Name = "helplbl"
        Me.helplbl.Size = New System.Drawing.Size(308, 29)
        Me.helplbl.TabIndex = 63
        Me.helplbl.Text = "Leggi il ""Blog"""
        Me.helplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vai
        '
        Me.vai.BackColor = System.Drawing.Color.Transparent
        Me.vai.BackgroundImage = Global.INSTALLER.My.Resources.Resources._next
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
        Me.vai.Location = New System.Drawing.Point(382, 9)
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
        Me.vailbl.Location = New System.Drawing.Point(321, 114)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(255, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Ho capito, prosegui!"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Welcome15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(612, 734)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome15"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione di Installer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents closebutton As Button
    Friend WithEvents panelgoto As Panel
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents help As Button
    Friend WithEvents helplbl As Label
End Class
