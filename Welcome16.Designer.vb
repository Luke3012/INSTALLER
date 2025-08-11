<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome16
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome16))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.retry = New System.Windows.Forms.Button()
        Me.retrylbl = New System.Windows.Forms.Label()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 66)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Controllo gli aggiornamenti ..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 48)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Così dopo risparmi la fatica!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.giphy1
        Me.PictureBox1.Location = New System.Drawing.Point(202, 237)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.back)
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 85)
        Me.Panel2.TabIndex = 62
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Dock = System.Windows.Forms.DockStyle.Right
        Me.back.Enabled = False
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(599, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(82, 85)
        Me.back.TabIndex = 3
        Me.back.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(470, 85)
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
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.retry)
        Me.panelgoto.Controls.Add(Me.retrylbl)
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 523)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(681, 149)
        Me.panelgoto.TabIndex = 67
        '
        'retry
        '
        Me.retry.BackColor = System.Drawing.Color.Transparent
        Me.retry.BackgroundImage = Global.INSTALLER.My.Resources.Resources.retry
        Me.retry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.retry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retry.Enabled = False
        Me.retry.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.retry.FlatAppearance.BorderSize = 0
        Me.retry.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.retry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.retry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retry.Location = New System.Drawing.Point(138, 9)
        Me.retry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.retry.Name = "retry"
        Me.retry.Size = New System.Drawing.Size(134, 105)
        Me.retry.TabIndex = 62
        Me.retry.UseVisualStyleBackColor = False
        '
        'retrylbl
        '
        Me.retrylbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.retrylbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retrylbl.Location = New System.Drawing.Point(123, 114)
        Me.retrylbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.retrylbl.Name = "retrylbl"
        Me.retrylbl.Size = New System.Drawing.Size(164, 29)
        Me.retrylbl.TabIndex = 63
        Me.retrylbl.Text = "Riprova"
        Me.retrylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.vai.Location = New System.Drawing.Point(405, 9)
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
        Me.vailbl.Location = New System.Drawing.Point(384, 114)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(174, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Prosegui"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Welcome16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(681, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome16"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione di Installer"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents back As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents panelgoto As Panel
    Friend WithEvents retry As Button
    Friend WithEvents retrylbl As Label
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents Timer2 As Timer
End Class
