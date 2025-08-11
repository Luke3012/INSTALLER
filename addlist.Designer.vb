<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addlist))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.sessantaquattro = New System.Windows.Forms.Button()
        Me.trentadue = New System.Windows.Forms.Button()
        Me.custom = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.imagebox = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(1064, 85)
        Me.Panel2.TabIndex = 57
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Dock = System.Windows.Forms.DockStyle.Right
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(982, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(82, 85)
        Me.back.TabIndex = 3
        Me.back.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(555, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Aggiungi Elementi alla Lista"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.additem
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(0, 95)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(316, 527)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 58
        '
        'sessantaquattro
        '
        Me.sessantaquattro.BackColor = System.Drawing.Color.Gainsboro
        Me.sessantaquattro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sessantaquattro.FlatAppearance.BorderSize = 0
        Me.sessantaquattro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sessantaquattro.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessantaquattro.Location = New System.Drawing.Point(216, 400)
        Me.sessantaquattro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sessantaquattro.Name = "sessantaquattro"
        Me.sessantaquattro.Size = New System.Drawing.Size(204, 129)
        Me.sessantaquattro.TabIndex = 62
        Me.sessantaquattro.Text = "Installa 64 Bit"
        Me.sessantaquattro.UseVisualStyleBackColor = False
        '
        'trentadue
        '
        Me.trentadue.BackColor = System.Drawing.Color.Gainsboro
        Me.trentadue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trentadue.FlatAppearance.BorderSize = 0
        Me.trentadue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trentadue.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trentadue.Location = New System.Drawing.Point(8, 400)
        Me.trentadue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trentadue.Name = "trentadue"
        Me.trentadue.Size = New System.Drawing.Size(200, 129)
        Me.trentadue.TabIndex = 61
        Me.trentadue.Text = "Installa 32 Bit"
        Me.trentadue.UseVisualStyleBackColor = False
        '
        'custom
        '
        Me.custom.BackColor = System.Drawing.Color.Gainsboro
        Me.custom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custom.FlatAppearance.BorderSize = 0
        Me.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.custom.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custom.Location = New System.Drawing.Point(8, 275)
        Me.custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.custom.Name = "custom"
        Me.custom.Size = New System.Drawing.Size(412, 109)
        Me.custom.TabIndex = 60
        Me.custom.Text = "Installa"
        Me.custom.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.imagebox)
        Me.GroupBox1.Controls.Add(Me.sessantaquattro)
        Me.GroupBox1.Controls.Add(Me.custom)
        Me.GroupBox1.Controls.Add(Me.trentadue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(324, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(429, 548)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Decidi cosa Inserire"
        Me.GroupBox1.Visible = False
        '
        'imagebox
        '
        Me.imagebox.BackColor = System.Drawing.Color.Gainsboro
        Me.imagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagebox.Location = New System.Drawing.Point(62, 35)
        Me.imagebox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imagebox.Name = "imagebox"
        Me.imagebox.Size = New System.Drawing.Size(306, 222)
        Me.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagebox.TabIndex = 59
        Me.imagebox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(753, 85)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(310, 548)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scegli"
        Me.GroupBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 388)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modifica nome"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 357)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 258)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aggiungi Elemento"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(62, 75)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 177)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'addlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.name = "addlist"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aggiungi elementi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents back As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents imagebox As PictureBox
    Friend WithEvents sessantaquattro As Button
    Friend WithEvents trentadue As Button
    Friend WithEvents custom As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
