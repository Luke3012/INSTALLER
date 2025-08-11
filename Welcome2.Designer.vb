<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.helplbl = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 318)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bene, hai terminato!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vai
        '
        Me.vai.BackgroundImage = Global.INSTALLER.My.Resources.Resources.go2
        Me.vai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.vai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vai.Enabled = False
        Me.vai.FlatAppearance.BorderSize = 0
        Me.vai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vai.Location = New System.Drawing.Point(68, 18)
        Me.vai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.vai.Name = "vai"
        Me.vai.Size = New System.Drawing.Size(207, 177)
        Me.vai.TabIndex = 3
        Me.vai.UseVisualStyleBackColor = True
        '
        'vailbl
        '
        Me.vailbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vailbl.Location = New System.Drawing.Point(64, 200)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(213, 43)
        Me.vailbl.TabIndex = 64
        Me.vailbl.Text = "Avvia INSTALLER"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.vailbl.Visible = False
        '
        'pic
        '
        Me.pic.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.pic.Location = New System.Drawing.Point(200, 55)
        Me.pic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(276, 252)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 65
        Me.pic.TabStop = False
        '
        'helplbl
        '
        Me.helplbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helplbl.Location = New System.Drawing.Point(399, 200)
        Me.helplbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.helplbl.Name = "helplbl"
        Me.helplbl.Size = New System.Drawing.Size(213, 43)
        Me.helplbl.TabIndex = 67
        Me.helplbl.Text = "Informazioni"
        Me.helplbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.helplbl.Visible = False
        '
        'help
        '
        Me.help.BackgroundImage = Global.INSTALLER.My.Resources.Resources.help_icon
        Me.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.help.Enabled = False
        Me.help.FlatAppearance.BorderSize = 0
        Me.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help.Location = New System.Drawing.Point(402, 18)
        Me.help.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(207, 177)
        Me.help.TabIndex = 66
        Me.help.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.help)
        Me.panelgoto.Controls.Add(Me.helplbl)
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 443)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(675, 249)
        Me.panelgoto.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 369)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(564, 45)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Ma ora passiamo alle cose serie."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Welcome2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome2"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione Installer"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents helplbl As Label
    Friend WithEvents help As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelgoto As Panel
    Friend WithEvents Label2 As Label
End Class
