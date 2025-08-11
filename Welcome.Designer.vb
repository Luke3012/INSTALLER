<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.closebutton = New System.Windows.Forms.Button()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.installerpic = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.panelcheck = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.installerpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.panelcheck.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'closebutton
        '
        Me.closebutton.AutoSize = True
        Me.closebutton.BackgroundImage = Global.INSTALLER.My.Resources.Resources.close_window
        Me.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closebutton.Enabled = False
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Location = New System.Drawing.Point(628, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
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
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(528, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Configura INSTALLER"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel2.Size = New System.Drawing.Size(710, 85)
        Me.Panel2.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 78)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Benvenuto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 72)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "in"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 417)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 89)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "INSTALLER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'installerpic
        '
        Me.installerpic.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.installerpic.Location = New System.Drawing.Point(196, 105)
        Me.installerpic.Name = "installerpic"
        Me.installerpic.Size = New System.Drawing.Size(315, 278)
        Me.installerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.installerpic.TabIndex = 60
        Me.installerpic.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 380)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 45)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Benvenuto in"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 502)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(710, 149)
        Me.panelgoto.TabIndex = 65
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
        Me.vai.Location = New System.Drawing.Point(288, 5)
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
        Me.vailbl.Location = New System.Drawing.Point(148, 115)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(411, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Procedi con la configurazione"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'panelcheck
        '
        Me.panelcheck.Controls.Add(Me.PictureBox1)
        Me.panelcheck.Controls.Add(Me.Label5)
        Me.panelcheck.Location = New System.Drawing.Point(36, 105)
        Me.panelcheck.Name = "panelcheck"
        Me.panelcheck.Size = New System.Drawing.Size(638, 375)
        Me.panelcheck.TabIndex = 66
        Me.panelcheck.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.signal
        Me.PictureBox1.Location = New System.Drawing.Point(160, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 308)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(508, 45)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Controllo il collegamento a Internet..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(710, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.installerpic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panelcheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benvenuto"
        Me.TopMost = True
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.installerpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.panelcheck.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents closebutton As Button
    Friend WithEvents formicon As PictureBox
    Friend WithEvents TitleText As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents installerpic As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents panelgoto As Panel
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents panelcheck As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
