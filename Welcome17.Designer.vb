<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome17
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome17))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.lightmodebtn = New System.Windows.Forms.Button()
        Me.nightmodebtn = New System.Windows.Forms.Button()
        Me.nightmodelbl = New System.Windows.Forms.Label()
        Me.lightmodelbl = New System.Windows.Forms.Label()
        Me.TimerTema = New System.Windows.Forms.Timer(Me.components)
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vai = New System.Windows.Forms.Button()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 39)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Scegli un Tema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Chiaro oppure Scuro? Beh, ognuno ha i propri gusti."
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
        Me.Panel2.Size = New System.Drawing.Size(702, 85)
        Me.Panel2.TabIndex = 65
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
        Me.back.Location = New System.Drawing.Point(620, 0)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(82, 85)
        Me.back.TabIndex = 5
        Me.back.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(520, 85)
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
        'lightmodebtn
        '
        Me.lightmodebtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.lightmode
        Me.lightmodebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.lightmodebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lightmodebtn.FlatAppearance.BorderSize = 0
        Me.lightmodebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lightmodebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lightmodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lightmodebtn.Location = New System.Drawing.Point(50, 245)
        Me.lightmodebtn.Name = "lightmodebtn"
        Me.lightmodebtn.Size = New System.Drawing.Size(266, 238)
        Me.lightmodebtn.TabIndex = 67
        Me.lightmodebtn.UseVisualStyleBackColor = True
        '
        'nightmodebtn
        '
        Me.nightmodebtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.nightmode
        Me.nightmodebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nightmodebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nightmodebtn.FlatAppearance.BorderSize = 0
        Me.nightmodebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.nightmodebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.nightmodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nightmodebtn.Location = New System.Drawing.Point(388, 245)
        Me.nightmodebtn.Name = "nightmodebtn"
        Me.nightmodebtn.Size = New System.Drawing.Size(266, 238)
        Me.nightmodebtn.TabIndex = 66
        Me.nightmodebtn.UseVisualStyleBackColor = True
        '
        'nightmodelbl
        '
        Me.nightmodelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nightmodelbl.Location = New System.Drawing.Point(386, 485)
        Me.nightmodelbl.Name = "nightmodelbl"
        Me.nightmodelbl.Size = New System.Drawing.Size(272, 43)
        Me.nightmodelbl.TabIndex = 68
        Me.nightmodelbl.Text = "Notte"
        Me.nightmodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lightmodelbl
        '
        Me.lightmodelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lightmodelbl.Location = New System.Drawing.Point(48, 485)
        Me.lightmodelbl.Name = "lightmodelbl"
        Me.lightmodelbl.Size = New System.Drawing.Size(272, 43)
        Me.lightmodelbl.TabIndex = 69
        Me.lightmodelbl.Text = "Giorno"
        Me.lightmodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerTema
        '
        Me.TimerTema.Interval = 25
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.Label3)
        Me.panelgoto.Controls.Add(Me.vai)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 562)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(702, 149)
        Me.panelgoto.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(651, 29)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Passaci il mouse accanto per provare, premi per selezionare."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vai
        '
        Me.vai.BackColor = System.Drawing.Color.Transparent
        Me.vai.BackgroundImage = Global.INSTALLER.My.Resources.Resources._next
        Me.vai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.vai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vai.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.vai.FlatAppearance.BorderSize = 0
        Me.vai.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.vai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vai.Location = New System.Drawing.Point(285, 9)
        Me.vai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.vai.Name = "vai"
        Me.vai.Size = New System.Drawing.Size(134, 105)
        Me.vai.TabIndex = 60
        Me.vai.UseVisualStyleBackColor = False
        Me.vai.Visible = False
        '
        'vailbl
        '
        Me.vailbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.vailbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vailbl.Location = New System.Drawing.Point(264, 114)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(174, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Prosegui"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.vailbl.Visible = False
        '
        'Welcome17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(702, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.lightmodelbl)
        Me.Controls.Add(Me.nightmodelbl)
        Me.Controls.Add(Me.lightmodebtn)
        Me.Controls.Add(Me.nightmodebtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome17"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tema"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents back As Button
    Friend WithEvents nightmodebtn As Button
    Friend WithEvents lightmodebtn As Button
    Friend WithEvents lightmodelbl As Label
    Friend WithEvents nightmodelbl As Label
    Friend WithEvents TimerTema As Timer
    Friend WithEvents panelgoto As Panel
    Friend WithEvents vai As Button
    Friend WithEvents vailbl As Label
    Friend WithEvents Label3 As Label
End Class
