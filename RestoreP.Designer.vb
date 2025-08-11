<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestoreP))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.INSTALLER.My.Resources.Resources.deleteall
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(214, 240)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(258, 218)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 70)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sei sicuro di voler ripristinare il programma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alle impostazioni iniziali?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Size = New System.Drawing.Size(688, 85)
        Me.Panel2.TabIndex = 58
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
        Me.back.Location = New System.Drawing.Point(606, 0)
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
        Me.TitleText.Size = New System.Drawing.Size(416, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Ripristina INSTALLER"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.giphy
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 463)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 48)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Elimina Tutto."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'RestoreP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(688, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestoreP"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ripristina INSTALLER"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents back As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
