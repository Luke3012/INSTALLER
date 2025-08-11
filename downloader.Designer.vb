<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class downloader
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
        Me.status = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.task1 = New System.Windows.Forms.GroupBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.speed1 = New System.Windows.Forms.Label()
        Me.retry1 = New System.Windows.Forms.Button()
        Me.status1 = New System.Windows.Forms.Label()
        Me.task2 = New System.Windows.Forms.GroupBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.speed2 = New System.Windows.Forms.Label()
        Me.retry2 = New System.Windows.Forms.Button()
        Me.status2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.task3 = New System.Windows.Forms.GroupBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.speed3 = New System.Windows.Forms.Label()
        Me.retry3 = New System.Windows.Forms.Button()
        Me.status3 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.settingsbtn = New System.Windows.Forms.Button()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.panelsettings = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.automode = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closesettingsbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closesettings = New System.Windows.Forms.Timer(Me.components)
        Me.task1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.task2.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.task3.SuspendLayout()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelsettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(83, 45)
        Me.status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(197, 30)
        Me.status.TabIndex = 0
        Me.status.Text = "Task in corso: 0"
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 32)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(435, 35)
        Me.ProgressBar1.TabIndex = 2
        '
        'task1
        '
        Me.task1.Controls.Add(Me.pic1)
        Me.task1.Controls.Add(Me.speed1)
        Me.task1.Controls.Add(Me.retry1)
        Me.task1.Controls.Add(Me.status1)
        Me.task1.Controls.Add(Me.ProgressBar1)
        Me.task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task1.Location = New System.Drawing.Point(4, 97)
        Me.task1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task1.Name = "task1"
        Me.task1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task1.Size = New System.Drawing.Size(530, 137)
        Me.task1.TabIndex = 3
        Me.task1.TabStop = False
        Me.task1.Text = "Task 1"
        '
        'pic1
        '
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Image = Global.INSTALLER.My.Resources.Resources.apps
        Me.pic1.Location = New System.Drawing.Point(452, 32)
        Me.pic1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(69, 92)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 6
        Me.pic1.TabStop = False
        '
        'speed1
        '
        Me.speed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed1.Location = New System.Drawing.Point(357, 52)
        Me.speed1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.speed1.Name = "speed1"
        Me.speed1.Size = New System.Drawing.Size(84, 20)
        Me.speed1.TabIndex = 5
        Me.speed1.Text = "0 kb/s"
        Me.speed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'retry1
        '
        Me.retry1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retry1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retry1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retry1.Location = New System.Drawing.Point(345, 77)
        Me.retry1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.retry1.Name = "retry1"
        Me.retry1.Size = New System.Drawing.Size(99, 49)
        Me.retry1.TabIndex = 4
        Me.retry1.Text = "Riprova"
        Me.retry1.UseVisualStyleBackColor = True
        '
        'status1
        '
        Me.status1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status1.Location = New System.Drawing.Point(9, 72)
        Me.status1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(326, 59)
        Me.status1.TabIndex = 3
        Me.status1.Text = "Nulla..."
        Me.status1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'task2
        '
        Me.task2.Controls.Add(Me.pic2)
        Me.task2.Controls.Add(Me.speed2)
        Me.task2.Controls.Add(Me.retry2)
        Me.task2.Controls.Add(Me.status2)
        Me.task2.Controls.Add(Me.ProgressBar2)
        Me.task2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task2.Location = New System.Drawing.Point(4, 244)
        Me.task2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task2.Name = "task2"
        Me.task2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task2.Size = New System.Drawing.Size(530, 137)
        Me.task2.TabIndex = 4
        Me.task2.TabStop = False
        Me.task2.Text = "Task 2"
        '
        'pic2
        '
        Me.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic2.Location = New System.Drawing.Point(452, 32)
        Me.pic2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(69, 92)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 7
        Me.pic2.TabStop = False
        '
        'speed2
        '
        Me.speed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed2.Location = New System.Drawing.Point(357, 48)
        Me.speed2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.speed2.Name = "speed2"
        Me.speed2.Size = New System.Drawing.Size(84, 20)
        Me.speed2.TabIndex = 6
        Me.speed2.Text = "0 kb/s"
        Me.speed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'retry2
        '
        Me.retry2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retry2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retry2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retry2.Location = New System.Drawing.Point(345, 77)
        Me.retry2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.retry2.Name = "retry2"
        Me.retry2.Size = New System.Drawing.Size(99, 49)
        Me.retry2.TabIndex = 5
        Me.retry2.Text = "Riprova"
        Me.retry2.UseVisualStyleBackColor = True
        '
        'status2
        '
        Me.status2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status2.Location = New System.Drawing.Point(9, 72)
        Me.status2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(326, 59)
        Me.status2.TabIndex = 3
        Me.status2.Text = "Nulla..."
        Me.status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(9, 32)
        Me.ProgressBar2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(435, 35)
        Me.ProgressBar2.TabIndex = 2
        '
        'task3
        '
        Me.task3.Controls.Add(Me.pic3)
        Me.task3.Controls.Add(Me.speed3)
        Me.task3.Controls.Add(Me.retry3)
        Me.task3.Controls.Add(Me.status3)
        Me.task3.Controls.Add(Me.ProgressBar3)
        Me.task3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task3.Location = New System.Drawing.Point(4, 390)
        Me.task3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task3.Name = "task3"
        Me.task3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.task3.Size = New System.Drawing.Size(530, 137)
        Me.task3.TabIndex = 5
        Me.task3.TabStop = False
        Me.task3.Text = "Task 3"
        '
        'pic3
        '
        Me.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic3.Location = New System.Drawing.Point(448, 32)
        Me.pic3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(72, 92)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 8
        Me.pic3.TabStop = False
        '
        'speed3
        '
        Me.speed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed3.Location = New System.Drawing.Point(357, 52)
        Me.speed3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.speed3.Name = "speed3"
        Me.speed3.Size = New System.Drawing.Size(84, 20)
        Me.speed3.TabIndex = 7
        Me.speed3.Text = "0 kb/s"
        Me.speed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'retry3
        '
        Me.retry3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retry3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retry3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retry3.Location = New System.Drawing.Point(345, 77)
        Me.retry3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.retry3.Name = "retry3"
        Me.retry3.Size = New System.Drawing.Size(99, 49)
        Me.retry3.TabIndex = 6
        Me.retry3.Text = "Riprova"
        Me.retry3.UseVisualStyleBackColor = True
        '
        'status3
        '
        Me.status3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status3.Location = New System.Drawing.Point(9, 72)
        Me.status3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status3.Name = "status3"
        Me.status3.Size = New System.Drawing.Size(326, 59)
        Me.status3.TabIndex = 3
        Me.status3.Text = "Nulla..."
        Me.status3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(9, 32)
        Me.ProgressBar3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(435, 35)
        Me.ProgressBar3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.settingsbtn)
        Me.Panel2.Controls.Add(Me.status)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 85)
        Me.Panel2.TabIndex = 66
        '
        'settingsbtn
        '
        Me.settingsbtn.AccessibleDescription = ""
        Me.settingsbtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.settings1
        Me.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsbtn.FlatAppearance.BorderSize = 0
        Me.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsbtn.Location = New System.Drawing.Point(454, 18)
        Me.settingsbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.settingsbtn.Name = "settingsbtn"
        Me.settingsbtn.Size = New System.Drawing.Size(65, 60)
        Me.settingsbtn.TabIndex = 51
        Me.settingsbtn.UseVisualStyleBackColor = True
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.downloader
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(77, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
        '
        'TitleText
        '
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(80, 3)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(317, 55)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Downloader di INSTALLER"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelsettings
        '
        Me.panelsettings.Controls.Add(Me.Button1)
        Me.panelsettings.Controls.Add(Me.automode)
        Me.panelsettings.Controls.Add(Me.Label3)
        Me.panelsettings.Controls.Add(Me.Label2)
        Me.panelsettings.Controls.Add(Me.closesettingsbtn)
        Me.panelsettings.Controls.Add(Me.Label1)
        Me.panelsettings.Location = New System.Drawing.Point(0, 0)
        Me.panelsettings.Name = "panelsettings"
        Me.panelsettings.Size = New System.Drawing.Size(538, 94)
        Me.panelsettings.TabIndex = 67
        Me.panelsettings.Visible = False
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = ""
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.reboot
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(215, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 81)
        Me.Button1.TabIndex = 58
        Me.Button1.UseVisualStyleBackColor = True
        '
        'automode
        '
        Me.automode.Appearance = System.Windows.Forms.Appearance.Button
        Me.automode.BackgroundImage = Global.INSTALLER.My.Resources.Resources.switchon
        Me.automode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.automode.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.automode.Checked = True
        Me.automode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.automode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.automode.FlatAppearance.BorderSize = 0
        Me.automode.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.automode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.automode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.automode.Location = New System.Drawing.Point(6, 1)
        Me.automode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.automode.Name = "automode"
        Me.automode.Size = New System.Drawing.Size(79, 81)
        Me.automode.TabIndex = 54
        Me.automode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.automode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 66)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Forza il riavvio di Downloader"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 67)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Modalità automatica"
        '
        'closesettingsbtn
        '
        Me.closesettingsbtn.AccessibleDescription = ""
        Me.closesettingsbtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.cancel_96px
        Me.closesettingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closesettingsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closesettingsbtn.FlatAppearance.BorderSize = 0
        Me.closesettingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closesettingsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closesettingsbtn.Location = New System.Drawing.Point(455, 8)
        Me.closesettingsbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closesettingsbtn.Name = "closesettingsbtn"
        Me.closesettingsbtn.Size = New System.Drawing.Size(65, 60)
        Me.closesettingsbtn.TabIndex = 52
        Me.closesettingsbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Chiudi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'closesettings
        '
        Me.closesettings.Interval = 10000
        '
        'downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.task3)
        Me.Controls.Add(Me.task2)
        Me.Controls.Add(Me.task1)
        Me.Controls.Add(Me.panelsettings)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "downloader"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Downloader di INSTALLER"
        Me.TopMost = True
        Me.task1.ResumeLayout(False)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.task2.ResumeLayout(False)
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.task3.ResumeLayout(False)
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelsettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents status As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents task1 As GroupBox
    Friend WithEvents status1 As Label
    Friend WithEvents task2 As GroupBox
    Friend WithEvents status2 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents task3 As GroupBox
    Friend WithEvents status3 As Label
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents retry1 As Button
    Friend WithEvents retry2 As Button
    Friend WithEvents retry3 As Button
    Friend WithEvents speed1 As Label
    Friend WithEvents speed2 As Label
    Friend WithEvents speed3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents settingsbtn As Button
    Friend WithEvents panelsettings As Panel
    Friend WithEvents closesettingsbtn As Button
    Friend WithEvents automode As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents closesettings As Timer
    Friend WithEvents Button1 As Button
End Class
