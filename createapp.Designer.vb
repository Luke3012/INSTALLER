<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createapp
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelappname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelsteps = New System.Windows.Forms.Label()
        Me.chooseimg = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sessantaquattro = New System.Windows.Forms.Button()
        Me.trentadue = New System.Windows.Forms.Button()
        Me.custom = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.apppic = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.apppic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 85)
        Me.Panel2.TabIndex = 58
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(832, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Gestisci [nome applicazione]"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.addapp
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
        Me.panelgoto.Controls.Add(Me.Button1)
        Me.panelgoto.Controls.Add(Me.Label3)
        Me.panelgoto.Controls.Add(Me.Button2)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 617)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(927, 132)
        Me.panelgoto.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.back2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Location = New System.Drawing.Point(188, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 92)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 29)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Annulla"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.INSTALLER.My.Resources.Resources.confirm
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Location = New System.Drawing.Point(616, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 92)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'vailbl
        '
        Me.vailbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.vailbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vailbl.Location = New System.Drawing.Point(616, 100)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(123, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Conferma"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 30)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Titolo applicazione"
        '
        'labelappname
        '
        Me.labelappname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelappname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelappname.Location = New System.Drawing.Point(324, 145)
        Me.labelappname.Name = "labelappname"
        Me.labelappname.Size = New System.Drawing.Size(543, 32)
        Me.labelappname.TabIndex = 74
        Me.labelappname.Text = "[Clicca qui per modificare]"
        Me.labelappname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 30)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Descrizione"
        '
        'labelsteps
        '
        Me.labelsteps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelsteps.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelsteps.Location = New System.Drawing.Point(324, 237)
        Me.labelsteps.Name = "labelsteps"
        Me.labelsteps.Size = New System.Drawing.Size(543, 83)
        Me.labelsteps.TabIndex = 76
        Me.labelsteps.Text = "[Clicca per modificare]"
        '
        'chooseimg
        '
        Me.chooseimg.Filter = "File immagine PNG|*.png"
        Me.chooseimg.Title = "Scegli l'immagine"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.sessantaquattro)
        Me.Panel1.Controls.Add(Me.trentadue)
        Me.Panel1.Controls.Add(Me.custom)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(24, 334)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 274)
        Me.Panel1.TabIndex = 77
        '
        'sessantaquattro
        '
        Me.sessantaquattro.BackColor = System.Drawing.Color.Gainsboro
        Me.sessantaquattro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sessantaquattro.Enabled = False
        Me.sessantaquattro.FlatAppearance.BorderSize = 0
        Me.sessantaquattro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sessantaquattro.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessantaquattro.Location = New System.Drawing.Point(443, 158)
        Me.sessantaquattro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sessantaquattro.Name = "sessantaquattro"
        Me.sessantaquattro.Size = New System.Drawing.Size(272, 98)
        Me.sessantaquattro.TabIndex = 72
        Me.sessantaquattro.Text = "Pacchetto di installazione terziario"
        Me.sessantaquattro.UseVisualStyleBackColor = False
        Me.sessantaquattro.Visible = False
        '
        'trentadue
        '
        Me.trentadue.BackColor = System.Drawing.Color.Gainsboro
        Me.trentadue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trentadue.Enabled = False
        Me.trentadue.FlatAppearance.BorderSize = 0
        Me.trentadue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trentadue.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trentadue.Location = New System.Drawing.Point(173, 158)
        Me.trentadue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trentadue.Name = "trentadue"
        Me.trentadue.Size = New System.Drawing.Size(261, 98)
        Me.trentadue.TabIndex = 71
        Me.trentadue.Text = "Pacchetto di installazione secondario"
        Me.trentadue.UseVisualStyleBackColor = False
        Me.trentadue.Visible = False
        '
        'custom
        '
        Me.custom.BackColor = System.Drawing.Color.Gainsboro
        Me.custom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custom.FlatAppearance.BorderSize = 0
        Me.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.custom.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custom.Location = New System.Drawing.Point(173, 64)
        Me.custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.custom.Name = "custom"
        Me.custom.Size = New System.Drawing.Size(542, 85)
        Me.custom.TabIndex = 70
        Me.custom.Text = "Pacchetto di installazione principale"
        Me.custom.UseVisualStyleBackColor = False
        Me.custom.Visible = False
        '
        'Label6
        '
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(201, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(477, 45)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Scegli cosa modificare"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'apppic
        '
        Me.apppic.BackColor = System.Drawing.Color.Gainsboro
        Me.apppic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.apppic.Image = Global.INSTALLER.My.Resources.Resources.test
        Me.apppic.Location = New System.Drawing.Point(30, 105)
        Me.apppic.Name = "apppic"
        Me.apppic.Size = New System.Drawing.Size(268, 222)
        Me.apppic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.apppic.TabIndex = 3
        Me.apppic.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(24, 335)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 274)
        Me.Panel3.TabIndex = 78
        Me.Panel3.Visible = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(704, 45)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Modifica pacchetto di installazione primario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelsteps)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelappname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.apppic)
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "createapp"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestisci l'applicazione"
        Me.Panel2.ResumeLayout(False)
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.apppic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents panelgoto As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents apppic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labelappname As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelsteps As Label
    Friend WithEvents chooseimg As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents sessantaquattro As Button
    Friend WithEvents trentadue As Button
    Friend WithEvents custom As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
End Class
