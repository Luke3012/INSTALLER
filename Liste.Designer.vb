<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Liste
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.image1 = New System.Windows.Forms.PictureBox()
        Me.image2 = New System.Windows.Forms.PictureBox()
        Me.image3 = New System.Windows.Forms.PictureBox()
        Me.wait = New System.Windows.Forms.Timer(Me.components)
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.goinstall = New System.Windows.Forms.Button()
        Me.favouritelistlbl = New System.Windows.Forms.Label()
        Me.goinstalllbl = New System.Windows.Forms.Label()
        Me.deletelistlbl = New System.Windows.Forms.Label()
        Me.create = New System.Windows.Forms.Button()
        Me.favouritelist = New System.Windows.Forms.Button()
        Me.editlistlbl = New System.Windows.Forms.Label()
        Me.createlbl = New System.Windows.Forms.Label()
        Me.editlist = New System.Windows.Forms.Button()
        Me.deletelist = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.back)
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Controls.Add(Me.closebutton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 85)
        Me.Panel2.TabIndex = 56
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.BackgroundImage = Global.INSTALLER.My.Resources.Resources.back
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Dock = System.Windows.Forms.DockStyle.Right
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(806, 0)
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
        Me.TitleText.Size = New System.Drawing.Size(270, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Liste"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.lists
        Me.formicon.Location = New System.Drawing.Point(0, 0)
        Me.formicon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formicon.Name = "formicon"
        Me.formicon.Size = New System.Drawing.Size(81, 85)
        Me.formicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.formicon.TabIndex = 2
        Me.formicon.TabStop = False
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
        Me.closebutton.Location = New System.Drawing.Point(888, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 26)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 472)
        Me.Panel1.TabIndex = 57
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(348, 498)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.image1)
        Me.GroupBox3.Controls.Add(Me.image2)
        Me.GroupBox3.Controls.Add(Me.image3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(375, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(578, 498)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Panoramica"
        '
        'image1
        '
        Me.image1.BackColor = System.Drawing.Color.Gainsboro
        Me.image1.Location = New System.Drawing.Point(180, 62)
        Me.image1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(316, 176)
        Me.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image1.TabIndex = 0
        Me.image1.TabStop = False
        '
        'image2
        '
        Me.image2.BackColor = System.Drawing.Color.Gainsboro
        Me.image2.Location = New System.Drawing.Point(30, 163)
        Me.image2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image2.Name = "image2"
        Me.image2.Size = New System.Drawing.Size(316, 176)
        Me.image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image2.TabIndex = 1
        Me.image2.TabStop = False
        '
        'image3
        '
        Me.image3.BackColor = System.Drawing.Color.Gainsboro
        Me.image3.Location = New System.Drawing.Point(219, 280)
        Me.image3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.image3.Name = "image3"
        Me.image3.Size = New System.Drawing.Size(316, 176)
        Me.image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image3.TabIndex = 2
        Me.image3.TabStop = False
        '
        'wait
        '
        Me.wait.Interval = 200
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.goinstall)
        Me.panelgoto.Controls.Add(Me.favouritelistlbl)
        Me.panelgoto.Controls.Add(Me.goinstalllbl)
        Me.panelgoto.Controls.Add(Me.deletelistlbl)
        Me.panelgoto.Controls.Add(Me.create)
        Me.panelgoto.Controls.Add(Me.favouritelist)
        Me.panelgoto.Controls.Add(Me.editlistlbl)
        Me.panelgoto.Controls.Add(Me.createlbl)
        Me.panelgoto.Controls.Add(Me.editlist)
        Me.panelgoto.Controls.Add(Me.deletelist)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 602)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(970, 189)
        Me.panelgoto.TabIndex = 64
        '
        'goinstall
        '
        Me.goinstall.BackColor = System.Drawing.Color.Transparent
        Me.goinstall.BackgroundImage = Global.INSTALLER.My.Resources.Resources.goinstall
        Me.goinstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.goinstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goinstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.goinstall.FlatAppearance.BorderSize = 0
        Me.goinstall.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.goinstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.goinstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.goinstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.goinstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goinstall.Location = New System.Drawing.Point(56, 15)
        Me.goinstall.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.goinstall.Name = "goinstall"
        Me.goinstall.Size = New System.Drawing.Size(132, 128)
        Me.goinstall.TabIndex = 18
        Me.goinstall.UseVisualStyleBackColor = False
        '
        'favouritelistlbl
        '
        Me.favouritelistlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.favouritelistlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.favouritelistlbl.Location = New System.Drawing.Point(742, 146)
        Me.favouritelistlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.favouritelistlbl.Name = "favouritelistlbl"
        Me.favouritelistlbl.Size = New System.Drawing.Size(181, 29)
        Me.favouritelistlbl.TabIndex = 62
        Me.favouritelistlbl.Text = "Rendi preferita"
        Me.favouritelistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'goinstalllbl
        '
        Me.goinstalllbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.goinstalllbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goinstalllbl.Location = New System.Drawing.Point(54, 146)
        Me.goinstalllbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.goinstalllbl.Name = "goinstalllbl"
        Me.goinstalllbl.Size = New System.Drawing.Size(138, 29)
        Me.goinstalllbl.TabIndex = 58
        Me.goinstalllbl.Text = "Installa"
        Me.goinstalllbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'deletelistlbl
        '
        Me.deletelistlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.deletelistlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletelistlbl.Location = New System.Drawing.Point(573, 146)
        Me.deletelistlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.deletelistlbl.Name = "deletelistlbl"
        Me.deletelistlbl.Size = New System.Drawing.Size(152, 29)
        Me.deletelistlbl.TabIndex = 61
        Me.deletelistlbl.Text = "Elimina Lista"
        Me.deletelistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'create
        '
        Me.create.BackColor = System.Drawing.Color.Transparent
        Me.create.BackgroundImage = Global.INSTALLER.My.Resources.Resources.add2
        Me.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.create.FlatAppearance.BorderSize = 0
        Me.create.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.Location = New System.Drawing.Point(234, 18)
        Me.create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(132, 123)
        Me.create.TabIndex = 57
        Me.create.UseVisualStyleBackColor = False
        '
        'favouritelist
        '
        Me.favouritelist.BackColor = System.Drawing.Color.Transparent
        Me.favouritelist.BackgroundImage = Global.INSTALLER.My.Resources.Resources.addfavourite
        Me.favouritelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.favouritelist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.favouritelist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.favouritelist.FlatAppearance.BorderSize = 0
        Me.favouritelist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.favouritelist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.favouritelist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.favouritelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.favouritelist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.favouritelist.Location = New System.Drawing.Point(768, 18)
        Me.favouritelist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.favouritelist.Name = "favouritelist"
        Me.favouritelist.Size = New System.Drawing.Size(138, 128)
        Me.favouritelist.TabIndex = 12
        Me.favouritelist.UseVisualStyleBackColor = False
        '
        'editlistlbl
        '
        Me.editlistlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.editlistlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editlistlbl.Location = New System.Drawing.Point(394, 146)
        Me.editlistlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.editlistlbl.Name = "editlistlbl"
        Me.editlistlbl.Size = New System.Drawing.Size(160, 29)
        Me.editlistlbl.TabIndex = 60
        Me.editlistlbl.Text = "Modifica Lista"
        Me.editlistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'createlbl
        '
        Me.createlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.createlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createlbl.Location = New System.Drawing.Point(216, 146)
        Me.createlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.createlbl.Name = "createlbl"
        Me.createlbl.Size = New System.Drawing.Size(165, 29)
        Me.createlbl.TabIndex = 59
        Me.createlbl.Text = "Aggiungi Lista"
        Me.createlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editlist
        '
        Me.editlist.BackColor = System.Drawing.Color.Transparent
        Me.editlist.BackgroundImage = Global.INSTALLER.My.Resources.Resources.edit
        Me.editlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editlist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.editlist.FlatAppearance.BorderSize = 0
        Me.editlist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.editlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.editlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editlist.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editlist.Location = New System.Drawing.Point(408, 18)
        Me.editlist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.editlist.Name = "editlist"
        Me.editlist.Size = New System.Drawing.Size(132, 123)
        Me.editlist.TabIndex = 11
        Me.editlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.editlist.UseVisualStyleBackColor = False
        '
        'deletelist
        '
        Me.deletelist.BackColor = System.Drawing.Color.Transparent
        Me.deletelist.BackgroundImage = Global.INSTALLER.My.Resources.Resources.delete2
        Me.deletelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deletelist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletelist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.deletelist.FlatAppearance.BorderSize = 0
        Me.deletelist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.deletelist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.deletelist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.deletelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletelist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletelist.Location = New System.Drawing.Point(564, 15)
        Me.deletelist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deletelist.Name = "deletelist"
        Me.deletelist.Size = New System.Drawing.Size(170, 132)
        Me.deletelist.TabIndex = 17
        Me.deletelist.UseVisualStyleBackColor = False
        '
        'Liste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(970, 791)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Liste"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents back As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents closebutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents image1 As PictureBox
    Friend WithEvents image2 As PictureBox
    Friend WithEvents image3 As PictureBox
    Friend WithEvents wait As Timer
    Friend WithEvents panelgoto As Panel
    Friend WithEvents goinstall As Button
    Friend WithEvents favouritelistlbl As Label
    Friend WithEvents goinstalllbl As Label
    Friend WithEvents deletelistlbl As Label
    Friend WithEvents create As Button
    Friend WithEvents favouritelist As Button
    Friend WithEvents editlistlbl As Label
    Friend WithEvents createlbl As Label
    Friend WithEvents editlist As Button
    Friend WithEvents deletelist As Button
End Class
