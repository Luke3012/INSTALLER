<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuovoaggiornamento
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.aspetta = New System.Windows.Forms.Timer(Me.components)
        Me.updatetext = New System.Windows.Forms.Label()
        Me.whatchange = New System.Windows.Forms.Label()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.updatelbl = New System.Windows.Forms.Label()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.whatchangebtn = New System.Windows.Forms.Button()
        Me.labelversion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.updatepic = New System.Windows.Forms.PictureBox()
        Me.updateicon = New System.Windows.Forms.PictureBox()
        Me.updatingpanel = New System.Windows.Forms.Panel()
        Me.stato = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.donepanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.updatepic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.updatingpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.donepanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Controls.Add(Me.closebutton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 85)
        Me.Panel2.TabIndex = 57
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(520, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Aggiornamento disponibile!"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
        Me.formicon.Image = Global.INSTALLER.My.Resources.Resources.update
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
        Me.closebutton.Location = New System.Drawing.Point(702, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'aspetta
        '
        Me.aspetta.Interval = 3000
        '
        'updatetext
        '
        Me.updatetext.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatetext.Location = New System.Drawing.Point(75, 306)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(478, 71)
        Me.updatetext.TabIndex = 58
        Me.updatetext.Text = "E' disponibile l'aggiornamento di INSTALLER alla versione più recente."
        Me.updatetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'whatchange
        '
        Me.whatchange.Cursor = System.Windows.Forms.Cursors.Default
        Me.whatchange.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whatchange.Location = New System.Drawing.Point(157, 126)
        Me.whatchange.Name = "whatchange"
        Me.whatchange.Size = New System.Drawing.Size(176, 38)
        Me.whatchange.TabIndex = 60
        Me.whatchange.Text = "Cosa cambia?"
        Me.whatchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.updatelbl)
        Me.panelgoto.Controls.Add(Me.updatebtn)
        Me.panelgoto.Controls.Add(Me.whatchangebtn)
        Me.panelgoto.Controls.Add(Me.whatchange)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 483)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(784, 165)
        Me.panelgoto.TabIndex = 68
        '
        'updatelbl
        '
        Me.updatelbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.updatelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatelbl.Location = New System.Drawing.Point(488, 126)
        Me.updatelbl.Name = "updatelbl"
        Me.updatelbl.Size = New System.Drawing.Size(140, 38)
        Me.updatelbl.TabIndex = 63
        Me.updatelbl.Text = "Aggiorna"
        Me.updatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updatebtn
        '
        Me.updatebtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.updatee
        Me.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebtn.FlatAppearance.BorderSize = 0
        Me.updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(490, 17)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(136, 108)
        Me.updatebtn.TabIndex = 1
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'whatchangebtn
        '
        Me.whatchangebtn.BackgroundImage = Global.INSTALLER.My.Resources.Resources.book
        Me.whatchangebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.whatchangebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.whatchangebtn.FlatAppearance.BorderSize = 0
        Me.whatchangebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.whatchangebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.whatchangebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.whatchangebtn.Location = New System.Drawing.Point(168, 17)
        Me.whatchangebtn.Name = "whatchangebtn"
        Me.whatchangebtn.Size = New System.Drawing.Size(154, 111)
        Me.whatchangebtn.TabIndex = 62
        Me.whatchangebtn.UseVisualStyleBackColor = False
        '
        'labelversion
        '
        Me.labelversion.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelversion.Location = New System.Drawing.Point(246, 225)
        Me.labelversion.Name = "labelversion"
        Me.labelversion.Size = New System.Drawing.Size(136, 23)
        Me.labelversion.TabIndex = 69
        Me.labelversion.Text = "Versione 0.0.0"
        Me.labelversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.labelversion)
        Me.Panel1.Controls.Add(Me.updatepic)
        Me.Panel1.Controls.Add(Me.updatetext)
        Me.Panel1.Controls.Add(Me.updateicon)
        Me.Panel1.Location = New System.Drawing.Point(78, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 368)
        Me.Panel1.TabIndex = 70
        '
        'updatepic
        '
        Me.updatepic.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.updatepic.Location = New System.Drawing.Point(238, 72)
        Me.updatepic.Name = "updatepic"
        Me.updatepic.Size = New System.Drawing.Size(153, 149)
        Me.updatepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updatepic.TabIndex = 59
        Me.updatepic.TabStop = False
        '
        'updateicon
        '
        Me.updateicon.Image = Global.INSTALLER.My.Resources.Resources.uppy
        Me.updateicon.Location = New System.Drawing.Point(159, 8)
        Me.updateicon.Name = "updateicon"
        Me.updateicon.Size = New System.Drawing.Size(310, 295)
        Me.updateicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updateicon.TabIndex = 61
        Me.updateicon.TabStop = False
        '
        'updatingpanel
        '
        Me.updatingpanel.Controls.Add(Me.stato)
        Me.updatingpanel.Controls.Add(Me.Label1)
        Me.updatingpanel.Controls.Add(Me.PictureBox1)
        Me.updatingpanel.Controls.Add(Me.PictureBox2)
        Me.updatingpanel.Location = New System.Drawing.Point(78, 92)
        Me.updatingpanel.Name = "updatingpanel"
        Me.updatingpanel.Size = New System.Drawing.Size(628, 542)
        Me.updatingpanel.TabIndex = 71
        Me.updatingpanel.Visible = False
        '
        'stato
        '
        Me.stato.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stato.Location = New System.Drawing.Point(148, 472)
        Me.stato.Name = "stato"
        Me.stato.Size = New System.Drawing.Size(332, 29)
        Me.stato.TabIndex = 70
        Me.stato.Text = "Aggiornamento in corso..."
        Me.stato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Versione 0.0.0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.installer
        Me.PictureBox1.Location = New System.Drawing.Point(238, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INSTALLER.My.Resources.Resources.updating
        Me.PictureBox2.Location = New System.Drawing.Point(194, 285)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 197)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'donepanel
        '
        Me.donepanel.Controls.Add(Me.Label2)
        Me.donepanel.Controls.Add(Me.PictureBox3)
        Me.donepanel.Location = New System.Drawing.Point(46, 92)
        Me.donepanel.Name = "donepanel"
        Me.donepanel.Size = New System.Drawing.Size(676, 503)
        Me.donepanel.TabIndex = 72
        Me.donepanel.Visible = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 66)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Tutto fatto!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sto riavviando ..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INSTALLER.My.Resources.Resources.updatedone
        Me.PictureBox3.Location = New System.Drawing.Point(212, 98)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(252, 231)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'nuovoaggiornamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.updatingpanel)
        Me.Controls.Add(Me.donepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuovoaggiornamento"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aggiornamento Disponibile!"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.updatepic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.updatingpanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.donepanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents closebutton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents aspetta As Timer
    Friend WithEvents updatetext As Label
    Friend WithEvents updatepic As PictureBox
    Friend WithEvents whatchange As Label
    Friend WithEvents updateicon As PictureBox
    Friend WithEvents whatchangebtn As Button
    Friend WithEvents panelgoto As Panel
    Friend WithEvents updatebtn As Button
    Friend WithEvents updatelbl As Label
    Friend WithEvents labelversion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents updatingpanel As Panel
    Friend WithEvents stato As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents donepanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
End Class
