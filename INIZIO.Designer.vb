<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INIZIO
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
        Me.TimerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.paneltitle = New System.Windows.Forms.Panel()
        Me.panelinstaller = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.menulbl = New System.Windows.Forms.Label()
        Me.listlbl = New System.Windows.Forms.Label()
        Me.helplbl = New System.Windows.Forms.Label()
        Me.settingslbl = New System.Windows.Forms.Label()
        Me.feedbacklbl = New System.Windows.Forms.Label()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.gotoapp = New System.Windows.Forms.Button()
        Me.gotolist = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.panelwelcome = New System.Windows.Forms.Panel()
        Me.labelupdate = New System.Windows.Forms.Label()
        Me.updatepic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelinit = New System.Windows.Forms.Panel()
        Me.labelimg3 = New System.Windows.Forms.Label()
        Me.labelimg1 = New System.Windows.Forms.Label()
        Me.labelfavlist = New System.Windows.Forms.Label()
        Me.imagelbl = New System.Windows.Forms.Label()
        Me.labelimg2 = New System.Windows.Forms.Label()
        Me.image1 = New System.Windows.Forms.Button()
        Me.image3 = New System.Windows.Forms.Button()
        Me.image2 = New System.Windows.Forms.Button()
        Me.favlist = New System.Windows.Forms.PictureBox()
        Me.TimerAvanza = New System.Windows.Forms.Timer(Me.components)
        Me.labeltitle = New System.Windows.Forms.Label()
        Me.labelinfo = New System.Windows.Forms.Label()
        Me.panellist = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panelhelp = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.panelsettings = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.panelfeedback = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.paneltitle.SuspendLayout()
        Me.panelinstaller.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.panelwelcome.SuspendLayout()
        CType(Me.updatepic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelinit.SuspendLayout()
        CType(Me.favlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panellist.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelhelp.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelsettings.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelfeedback.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelmenu.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerAnimation
        '
        Me.TimerAnimation.Interval = 15
        '
        'paneltitle
        '
        Me.paneltitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.paneltitle.Controls.Add(Me.panelinstaller)
        Me.paneltitle.Controls.Add(Me.closebutton)
        Me.paneltitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltitle.Location = New System.Drawing.Point(0, 0)
        Me.paneltitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.paneltitle.Name = "paneltitle"
        Me.paneltitle.Size = New System.Drawing.Size(981, 85)
        Me.paneltitle.TabIndex = 56
        '
        'panelinstaller
        '
        Me.panelinstaller.AutoSize = True
        Me.panelinstaller.Controls.Add(Me.Label1)
        Me.panelinstaller.Controls.Add(Me.formicon)
        Me.panelinstaller.Controls.Add(Me.TitleText)
        Me.panelinstaller.Location = New System.Drawing.Point(0, 0)
        Me.panelinstaller.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelinstaller.Name = "panelinstaller"
        Me.panelinstaller.Size = New System.Drawing.Size(320, 85)
        Me.panelinstaller.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Versione 0.0.0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.formicon.TabIndex = 5
        Me.formicon.TabStop = False
        '
        'TitleText
        '
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(74, 2)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(242, 55)
        Me.TitleText.TabIndex = 4
        Me.TitleText.Text = "INSTALLER"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'closebutton
        '
        Me.closebutton.AutoSize = True
        Me.closebutton.BackgroundImage = Global.INSTALLER.My.Resources.Resources.close_window
        Me.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Location = New System.Drawing.Point(899, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'menulbl
        '
        Me.menulbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.menulbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menulbl.Location = New System.Drawing.Point(68, 146)
        Me.menulbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.menulbl.Name = "menulbl"
        Me.menulbl.Size = New System.Drawing.Size(138, 29)
        Me.menulbl.TabIndex = 58
        Me.menulbl.Text = "Menù"
        Me.menulbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listlbl
        '
        Me.listlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.listlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listlbl.Location = New System.Drawing.Point(246, 146)
        Me.listlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.listlbl.Name = "listlbl"
        Me.listlbl.Size = New System.Drawing.Size(138, 29)
        Me.listlbl.TabIndex = 59
        Me.listlbl.Text = "Liste"
        Me.listlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'helplbl
        '
        Me.helplbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.helplbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helplbl.Location = New System.Drawing.Point(417, 146)
        Me.helplbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.helplbl.Name = "helplbl"
        Me.helplbl.Size = New System.Drawing.Size(138, 29)
        Me.helplbl.TabIndex = 60
        Me.helplbl.Text = "Centro Aiuti"
        Me.helplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settingslbl
        '
        Me.settingslbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.settingslbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingslbl.Location = New System.Drawing.Point(586, 146)
        Me.settingslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.settingslbl.Name = "settingslbl"
        Me.settingslbl.Size = New System.Drawing.Size(152, 29)
        Me.settingslbl.TabIndex = 61
        Me.settingslbl.Text = "Impostazioni"
        Me.settingslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'feedbacklbl
        '
        Me.feedbacklbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.feedbacklbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feedbacklbl.Location = New System.Drawing.Point(770, 146)
        Me.feedbacklbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.feedbacklbl.Name = "feedbacklbl"
        Me.feedbacklbl.Size = New System.Drawing.Size(144, 29)
        Me.feedbacklbl.TabIndex = 62
        Me.feedbacklbl.Text = "Feedback"
        Me.feedbacklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.gotoapp)
        Me.panelgoto.Controls.Add(Me.feedbacklbl)
        Me.panelgoto.Controls.Add(Me.menulbl)
        Me.panelgoto.Controls.Add(Me.settingslbl)
        Me.panelgoto.Controls.Add(Me.gotolist)
        Me.panelgoto.Controls.Add(Me.Button8)
        Me.panelgoto.Controls.Add(Me.helplbl)
        Me.panelgoto.Controls.Add(Me.listlbl)
        Me.panelgoto.Controls.Add(Me.Button7)
        Me.panelgoto.Controls.Add(Me.Button9)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 556)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(981, 189)
        Me.panelgoto.TabIndex = 63
        '
        'gotoapp
        '
        Me.gotoapp.BackColor = System.Drawing.Color.Transparent
        Me.gotoapp.BackgroundImage = Global.INSTALLER.My.Resources.Resources.apps
        Me.gotoapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gotoapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gotoapp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.gotoapp.FlatAppearance.BorderSize = 0
        Me.gotoapp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.gotoapp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gotoapp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gotoapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gotoapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotoapp.Location = New System.Drawing.Point(69, 15)
        Me.gotoapp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gotoapp.Name = "gotoapp"
        Me.gotoapp.Size = New System.Drawing.Size(132, 128)
        Me.gotoapp.TabIndex = 18
        Me.gotoapp.UseVisualStyleBackColor = False
        '
        'gotolist
        '
        Me.gotolist.BackColor = System.Drawing.Color.Transparent
        Me.gotolist.BackgroundImage = Global.INSTALLER.My.Resources.Resources.lists
        Me.gotolist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gotolist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gotolist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.gotolist.FlatAppearance.BorderSize = 0
        Me.gotolist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gotolist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotolist.Location = New System.Drawing.Point(248, 18)
        Me.gotolist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gotolist.Name = "gotolist"
        Me.gotolist.Size = New System.Drawing.Size(132, 123)
        Me.gotolist.TabIndex = 57
        Me.gotolist.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.INSTALLER.My.Resources.Resources.support
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(774, 14)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(132, 132)
        Me.Button8.TabIndex = 12
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.INSTALLER.My.Resources.Resources.help_icon
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(422, 18)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 123)
        Me.Button7.TabIndex = 11
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.INSTALLER.My.Resources.Resources.advsettings
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(578, 9)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(170, 140)
        Me.Button9.TabIndex = 17
        Me.Button9.UseVisualStyleBackColor = False
        '
        'panelwelcome
        '
        Me.panelwelcome.Controls.Add(Me.labelupdate)
        Me.panelwelcome.Controls.Add(Me.updatepic)
        Me.panelwelcome.Controls.Add(Me.Label2)
        Me.panelwelcome.Controls.Add(Me.PictureBox1)
        Me.panelwelcome.Controls.Add(Me.Label3)
        Me.panelwelcome.Location = New System.Drawing.Point(0, 85)
        Me.panelwelcome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelwelcome.Name = "panelwelcome"
        Me.panelwelcome.Size = New System.Drawing.Size(981, 471)
        Me.panelwelcome.TabIndex = 64
        '
        'labelupdate
        '
        Me.labelupdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelupdate.Location = New System.Drawing.Point(114, 431)
        Me.labelupdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelupdate.Name = "labelupdate"
        Me.labelupdate.Size = New System.Drawing.Size(754, 35)
        Me.labelupdate.TabIndex = 65
        Me.labelupdate.Text = "Controllo gli aggiornamenti ..."
        Me.labelupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelupdate.Visible = False
        '
        'updatepic
        '
        Me.updatepic.Location = New System.Drawing.Point(591, 215)
        Me.updatepic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updatepic.Name = "updatepic"
        Me.updatepic.Size = New System.Drawing.Size(96, 95)
        Me.updatepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updatepic.TabIndex = 64
        Me.updatepic.TabStop = False
        Me.updatepic.Visible = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 294)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 54)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Benvenuto in"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.PictureBox1.Location = New System.Drawing.Point(370, 60)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 337)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(594, 74)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "INSTALLER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelinit
        '
        Me.panelinit.Controls.Add(Me.labelimg3)
        Me.panelinit.Controls.Add(Me.labelimg1)
        Me.panelinit.Controls.Add(Me.labelfavlist)
        Me.panelinit.Controls.Add(Me.imagelbl)
        Me.panelinit.Controls.Add(Me.labelimg2)
        Me.panelinit.Controls.Add(Me.image1)
        Me.panelinit.Controls.Add(Me.image3)
        Me.panelinit.Controls.Add(Me.image2)
        Me.panelinit.Controls.Add(Me.favlist)
        Me.panelinit.Location = New System.Drawing.Point(0, 85)
        Me.panelinit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelinit.Name = "panelinit"
        Me.panelinit.Size = New System.Drawing.Size(981, 471)
        Me.panelinit.TabIndex = 66
        Me.panelinit.Visible = False
        '
        'labelimg3
        '
        Me.labelimg3.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelimg3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelimg3.Location = New System.Drawing.Point(924, 212)
        Me.labelimg3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelimg3.Name = "labelimg3"
        Me.labelimg3.Size = New System.Drawing.Size(39, 32)
        Me.labelimg3.TabIndex = 73
        Me.labelimg3.Text = "#3"
        Me.labelimg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelimg1
        '
        Me.labelimg1.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelimg1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelimg1.Location = New System.Drawing.Point(572, 212)
        Me.labelimg1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelimg1.Name = "labelimg1"
        Me.labelimg1.Size = New System.Drawing.Size(40, 32)
        Me.labelimg1.TabIndex = 71
        Me.labelimg1.Text = "#1"
        Me.labelimg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelfavlist
        '
        Me.labelfavlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.labelfavlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelfavlist.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfavlist.Location = New System.Drawing.Point(4, 300)
        Me.labelfavlist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelfavlist.Name = "labelfavlist"
        Me.labelfavlist.Size = New System.Drawing.Size(352, 54)
        Me.labelfavlist.TabIndex = 70
        Me.labelfavlist.Text = "Non hai nessuna lista preferita! :c"
        Me.labelfavlist.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imagelbl
        '
        Me.imagelbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.imagelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagelbl.Location = New System.Drawing.Point(450, 38)
        Me.imagelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.imagelbl.Name = "imagelbl"
        Me.imagelbl.Size = New System.Drawing.Size(482, 37)
        Me.imagelbl.TabIndex = 69
        Me.imagelbl.Text = "Questi sono gli ultimi download."
        Me.imagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelimg2
        '
        Me.labelimg2.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelimg2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelimg2.Location = New System.Drawing.Point(748, 300)
        Me.labelimg2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelimg2.Name = "labelimg2"
        Me.labelimg2.Size = New System.Drawing.Size(44, 32)
        Me.labelimg2.TabIndex = 72
        Me.labelimg2.Text = "#2"
        Me.labelimg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'image1
        '
        Me.image1.BackColor = System.Drawing.Color.Transparent
        Me.image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.image1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.image1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.image1.FlatAppearance.BorderSize = 0
        Me.image1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.image1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.image1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.image1.Location = New System.Drawing.Point(411, 92)
        Me.image1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(201, 152)
        Me.image1.TabIndex = 74
        Me.image1.Tag = "recente1"
        Me.image1.UseVisualStyleBackColor = False
        '
        'image3
        '
        Me.image3.BackColor = System.Drawing.Color.Transparent
        Me.image3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.image3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.image3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.image3.FlatAppearance.BorderSize = 0
        Me.image3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.image3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.image3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.image3.Location = New System.Drawing.Point(762, 92)
        Me.image3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image3.Name = "image3"
        Me.image3.Size = New System.Drawing.Size(201, 152)
        Me.image3.TabIndex = 76
        Me.image3.Tag = "recente3"
        Me.image3.UseVisualStyleBackColor = False
        '
        'image2
        '
        Me.image2.BackColor = System.Drawing.Color.Transparent
        Me.image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.image2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.image2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.image2.FlatAppearance.BorderSize = 0
        Me.image2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.image2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.image2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.image2.Location = New System.Drawing.Point(591, 180)
        Me.image2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image2.Name = "image2"
        Me.image2.Size = New System.Drawing.Size(201, 152)
        Me.image2.TabIndex = 75
        Me.image2.Tag = "recente2"
        Me.image2.UseVisualStyleBackColor = False
        '
        'favlist
        '
        Me.favlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.favlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.favlist.Image = Global.INSTALLER.My.Resources.Resources._resume
        Me.favlist.Location = New System.Drawing.Point(-129, 28)
        Me.favlist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.favlist.Name = "favlist"
        Me.favlist.Size = New System.Drawing.Size(556, 449)
        Me.favlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.favlist.TabIndex = 6
        Me.favlist.TabStop = False
        '
        'TimerAvanza
        '
        Me.TimerAvanza.Interval = 1500
        '
        'labeltitle
        '
        Me.labeltitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.labeltitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltitle.Location = New System.Drawing.Point(458, 449)
        Me.labeltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labeltitle.Name = "labeltitle"
        Me.labeltitle.Size = New System.Drawing.Size(506, 60)
        Me.labeltitle.TabIndex = 67
        Me.labeltitle.Text = "Riprendi da qui"
        Me.labeltitle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.labeltitle.Visible = False
        '
        'labelinfo
        '
        Me.labelinfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelinfo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labelinfo.Location = New System.Drawing.Point(351, 506)
        Me.labelinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelinfo.Name = "labelinfo"
        Me.labelinfo.Size = New System.Drawing.Size(612, 37)
        Me.labelinfo.TabIndex = 68
        Me.labelinfo.Text = "A cosa eravamo rimasti l'ultima volta?"
        Me.labelinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labelinfo.Visible = False
        '
        'panellist
        '
        Me.panellist.Controls.Add(Me.PictureBox4)
        Me.panellist.Location = New System.Drawing.Point(0, 83)
        Me.panellist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panellist.Name = "panellist"
        Me.panellist.Size = New System.Drawing.Size(981, 472)
        Me.panellist.TabIndex = 69
        Me.panellist.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.INSTALLER.My.Resources.Resources.e_commerce
        Me.PictureBox4.Location = New System.Drawing.Point(-178, 45)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(658, 488)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'panelhelp
        '
        Me.panelhelp.Controls.Add(Me.PictureBox5)
        Me.panelhelp.Location = New System.Drawing.Point(0, 83)
        Me.panelhelp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelhelp.Name = "panelhelp"
        Me.panelhelp.Size = New System.Drawing.Size(981, 472)
        Me.panelhelp.TabIndex = 70
        Me.panelhelp.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.INSTALLER.My.Resources.Resources.communications
        Me.PictureBox5.Location = New System.Drawing.Point(-196, 11)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(645, 488)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'panelsettings
        '
        Me.panelsettings.Controls.Add(Me.PictureBox6)
        Me.panelsettings.Location = New System.Drawing.Point(0, 83)
        Me.panelsettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelsettings.Name = "panelsettings"
        Me.panelsettings.Size = New System.Drawing.Size(981, 472)
        Me.panelsettings.TabIndex = 71
        Me.panelsettings.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.INSTALLER.My.Resources.Resources.operation
        Me.PictureBox6.Location = New System.Drawing.Point(-129, -6)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(645, 488)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'panelfeedback
        '
        Me.panelfeedback.Controls.Add(Me.PictureBox7)
        Me.panelfeedback.Location = New System.Drawing.Point(0, 83)
        Me.panelfeedback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelfeedback.Name = "panelfeedback"
        Me.panelfeedback.Size = New System.Drawing.Size(981, 472)
        Me.panelfeedback.TabIndex = 72
        Me.panelfeedback.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.INSTALLER.My.Resources.Resources.social_media
        Me.PictureBox7.Location = New System.Drawing.Point(-78, 22)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(504, 488)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        '
        'panelmenu
        '
        Me.panelmenu.Controls.Add(Me.PictureBox3)
        Me.panelmenu.Location = New System.Drawing.Point(0, 83)
        Me.panelmenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(981, 472)
        Me.panelmenu.TabIndex = 73
        Me.panelmenu.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INSTALLER.My.Resources.Resources.smarthome
        Me.PictureBox3.Location = New System.Drawing.Point(-106, 22)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(645, 488)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'INIZIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(981, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelinfo)
        Me.Controls.Add(Me.labeltitle)
        Me.Controls.Add(Me.paneltitle)
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.panelinit)
        Me.Controls.Add(Me.panelwelcome)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.panelfeedback)
        Me.Controls.Add(Me.panelsettings)
        Me.Controls.Add(Me.panelhelp)
        Me.Controls.Add(Me.panellist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "INIZIO"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INSTALLER"
        Me.paneltitle.ResumeLayout(False)
        Me.paneltitle.PerformLayout()
        Me.panelinstaller.ResumeLayout(False)
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.panelwelcome.ResumeLayout(False)
        CType(Me.updatepic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelinit.ResumeLayout(False)
        CType(Me.favlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panellist.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelhelp.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelsettings.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelfeedback.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelmenu.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerAnimation As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents gotoapp As Button
    Friend WithEvents paneltitle As Panel
    Friend WithEvents closebutton As Button
    Friend WithEvents gotolist As Button
    Friend WithEvents menulbl As Label
    Friend WithEvents listlbl As Label
    Friend WithEvents helplbl As Label
    Friend WithEvents settingslbl As Label
    Friend WithEvents feedbacklbl As Label
    Friend WithEvents panelgoto As Panel
    Friend WithEvents panelwelcome As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelinstaller As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelinit As Panel
    Friend WithEvents TimerAvanza As Timer
    Friend WithEvents labeltitle As Label
    Friend WithEvents labelinfo As Label
    Friend WithEvents labelfavlist As Label
    Friend WithEvents imagelbl As Label
    Friend WithEvents labelimg3 As Label
    Friend WithEvents labelimg2 As Label
    Friend WithEvents labelimg1 As Label
    Friend WithEvents panellist As Panel
    Friend WithEvents panelhelp As Panel
    Friend WithEvents panelsettings As Panel
    Friend WithEvents panelfeedback As Panel
    Friend WithEvents panelmenu As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents favlist As PictureBox
    Friend WithEvents updatepic As PictureBox
    Friend WithEvents labelupdate As Label
    Friend WithEvents image1 As Button
    Friend WithEvents image2 As Button
    Friend WithEvents image3 As Button
End Class
