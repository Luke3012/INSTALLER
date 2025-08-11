<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aftertool
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.gobtn = New System.Windows.Forms.Button()
        Me.golbl = New System.Windows.Forms.Label()
        Me.temabtn = New System.Windows.Forms.Button()
        Me.temalbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 442)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(639, 97)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "E' stato fatto tutto il lavoraccio per te:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la configurazione di INSTALLER è pron" &
    "ta!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.multimedia
        Me.PictureBox1.Location = New System.Drawing.Point(38, 121)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 85)
        Me.Panel2.TabIndex = 58
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(664, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Tutto Pronto!"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INSTALLER.My.Resources.Resources.double_chevron
        Me.PictureBox2.Location = New System.Drawing.Point(326, 171)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INSTALLER.My.Resources.Resources.test
        Me.PictureBox3.Location = New System.Drawing.Point(556, 121)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(257, 307)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.gobtn)
        Me.panelgoto.Controls.Add(Me.golbl)
        Me.panelgoto.Controls.Add(Me.temabtn)
        Me.panelgoto.Controls.Add(Me.temalbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 543)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(850, 149)
        Me.panelgoto.TabIndex = 68
        '
        'gobtn
        '
        Me.gobtn.BackColor = System.Drawing.Color.Transparent
        Me.gobtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources._next
        Me.gobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gobtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gobtn.Enabled = False
        Me.gobtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.gobtn.FlatAppearance.BorderSize = 0
        Me.gobtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.gobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gobtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gobtn.Location = New System.Drawing.Point(577, 7)
        Me.gobtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gobtn.Name = "gobtn"
        Me.gobtn.Size = New System.Drawing.Size(134, 105)
        Me.gobtn.TabIndex = 64
        Me.gobtn.UseVisualStyleBackColor = False
        '
        'golbl
        '
        Me.golbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.golbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.golbl.Location = New System.Drawing.Point(570, 112)
        Me.golbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.golbl.Name = "golbl"
        Me.golbl.Size = New System.Drawing.Size(148, 29)
        Me.golbl.TabIndex = 65
        Me.golbl.Text = "Procedi"
        Me.golbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'temabtn
        '
        Me.temabtn.BackColor = System.Drawing.Color.Transparent
        Me.temabtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.Ryb_colorwheel_svg
        Me.temabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.temabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.temabtn.Enabled = False
        Me.temabtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.temabtn.FlatAppearance.BorderSize = 0
        Me.temabtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.temabtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.temabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.temabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.temabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temabtn.Location = New System.Drawing.Point(153, 7)
        Me.temabtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.temabtn.Name = "temabtn"
        Me.temabtn.Size = New System.Drawing.Size(134, 105)
        Me.temabtn.TabIndex = 62
        Me.temabtn.UseVisualStyleBackColor = False
        '
        'temalbl
        '
        Me.temalbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.temalbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temalbl.Location = New System.Drawing.Point(133, 112)
        Me.temalbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.temalbl.Name = "temalbl"
        Me.temalbl.Size = New System.Drawing.Size(174, 29)
        Me.temalbl.TabIndex = 63
        Me.temalbl.Text = "Cambia il tema"
        Me.temalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'aftertool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(850, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aftertool"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Installazione Completata!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents panelgoto As Panel
    Friend WithEvents temabtn As Button
    Friend WithEvents temalbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gobtn As Button
    Friend WithEvents golbl As Label
End Class
