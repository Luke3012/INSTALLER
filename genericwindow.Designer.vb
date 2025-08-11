<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class genericwindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genericwindow))
        Me.custom = New System.Windows.Forms.Button()
        Me.trentadue = New System.Windows.Forms.Button()
        Me.sessantaquattro = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.after = New System.Windows.Forms.Button()
        Me.imagebox = New System.Windows.Forms.PictureBox()
        Me.description = New System.Windows.Forms.RichTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'custom
        '
        Me.custom.BackColor = System.Drawing.Color.Gainsboro
        Me.custom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custom.FlatAppearance.BorderSize = 0
        Me.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.custom.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custom.Location = New System.Drawing.Point(24, 475)
        Me.custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.custom.Name = "custom"
        Me.custom.Size = New System.Drawing.Size(542, 85)
        Me.custom.TabIndex = 1
        Me.custom.Text = "Installa"
        Me.custom.UseVisualStyleBackColor = False
        Me.custom.Visible = False
        '
        'trentadue
        '
        Me.trentadue.BackColor = System.Drawing.Color.Gainsboro
        Me.trentadue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trentadue.FlatAppearance.BorderSize = 0
        Me.trentadue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trentadue.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trentadue.Location = New System.Drawing.Point(24, 569)
        Me.trentadue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trentadue.Name = "trentadue"
        Me.trentadue.Size = New System.Drawing.Size(261, 98)
        Me.trentadue.TabIndex = 2
        Me.trentadue.Text = "Installa 32 Bit"
        Me.trentadue.UseVisualStyleBackColor = False
        Me.trentadue.Visible = False
        '
        'sessantaquattro
        '
        Me.sessantaquattro.BackColor = System.Drawing.Color.Gainsboro
        Me.sessantaquattro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sessantaquattro.FlatAppearance.BorderSize = 0
        Me.sessantaquattro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sessantaquattro.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessantaquattro.Location = New System.Drawing.Point(294, 569)
        Me.sessantaquattro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sessantaquattro.Name = "sessantaquattro"
        Me.sessantaquattro.Size = New System.Drawing.Size(272, 98)
        Me.sessantaquattro.TabIndex = 3
        Me.sessantaquattro.Text = "Installa 64 Bit"
        Me.sessantaquattro.UseVisualStyleBackColor = False
        Me.sessantaquattro.Visible = False
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
        Me.Panel2.Size = New System.Drawing.Size(1004, 85)
        Me.Panel2.TabIndex = 57
        '
        'TitleText
        '
        Me.TitleText.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(106, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(465, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Installa l'App"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = CType(resources.GetObject("formicon.Image"), System.Drawing.Image)
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(106, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'closebutton
        '
        Me.closebutton.AutoSize = True
        Me.closebutton.BackgroundImage = CType(resources.GetObject("closebutton.BackgroundImage"), System.Drawing.Image)
        Me.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Location = New System.Drawing.Point(922, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(18, 212)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(76, 86)
        Me.back.TabIndex = 5
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.UseVisualStyleBackColor = True
        '
        'after
        '
        Me.after.BackgroundImage = CType(resources.GetObject("after.BackgroundImage"), System.Drawing.Image)
        Me.after.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.after.Cursor = System.Windows.Forms.Cursors.Hand
        Me.after.FlatAppearance.BorderSize = 0
        Me.after.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.after.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.after.Location = New System.Drawing.Point(495, 212)
        Me.after.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.after.Name = "after"
        Me.after.Size = New System.Drawing.Size(76, 86)
        Me.after.TabIndex = 6
        Me.after.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.after.UseVisualStyleBackColor = True
        '
        'imagebox
        '
        Me.imagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagebox.Cursor = System.Windows.Forms.Cursors.Help
        Me.imagebox.Image = CType(resources.GetObject("imagebox.Image"), System.Drawing.Image)
        Me.imagebox.Location = New System.Drawing.Point(104, 112)
        Me.imagebox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imagebox.Name = "imagebox"
        Me.imagebox.Size = New System.Drawing.Size(382, 302)
        Me.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagebox.TabIndex = 4
        Me.imagebox.TabStop = False
        '
        'description
        '
        Me.description.BackColor = System.Drawing.Color.Gainsboro
        Me.description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.description.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.Location = New System.Drawing.Point(580, 112)
        Me.description.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Size = New System.Drawing.Size(411, 555)
        Me.description.TabIndex = 4
        Me.description.Text = ""
        Me.description.Visible = False
        '
        'genericwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 680)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.after)
        Me.Controls.Add(Me.imagebox)
        Me.Controls.Add(Me.sessantaquattro)
        Me.Controls.Add(Me.trentadue)
        Me.Controls.Add(Me.custom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "genericwindow"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "genericwindow"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents custom As Button
    Friend WithEvents trentadue As Button
    Friend WithEvents sessantaquattro As Button
    Friend WithEvents imagebox As PictureBox
    Friend WithEvents after As Button
    Friend WithEvents back As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents closebutton As Button
    Friend WithEvents description As RichTextBox
End Class
