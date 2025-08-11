<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteappsnew
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fileinutilibtn = New System.Windows.Forms.Button()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.elementname = New System.Windows.Forms.Label()
        Me.elementspace = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.eliminalbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.Timer(Me.components)
        Me.emptypanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.selectlbl = New System.Windows.Forms.Label()
        Me.anim = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCirc = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.emptypanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(18, 91)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 387)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fileinutilibtn)
        Me.Panel1.Controls.Add(Me.lista)
        Me.Panel1.Controls.Add(Me.TitleText)
        Me.Panel1.Controls.Add(Me.formicon)
        Me.Panel1.Controls.Add(Me.closebutton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1137, 85)
        Me.Panel1.TabIndex = 1
        '
        'fileinutilibtn
        '
        Me.fileinutilibtn.BackColor = System.Drawing.Color.Silver
        Me.fileinutilibtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileinutilibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fileinutilibtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileinutilibtn.Location = New System.Drawing.Point(850, 5)
        Me.fileinutilibtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fileinutilibtn.Name = "fileinutilibtn"
        Me.fileinutilibtn.Size = New System.Drawing.Size(195, 75)
        Me.fileinutilibtn.TabIndex = 56
        Me.fileinutilibtn.Text = "File superflui" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0,00 GB"
        Me.fileinutilibtn.UseVisualStyleBackColor = False
        Me.fileinutilibtn.Visible = False
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.ItemHeight = 20
        Me.lista.Location = New System.Drawing.Point(897, 5)
        Me.lista.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(62, 24)
        Me.lista.Sorted = True
        Me.lista.TabIndex = 55
        Me.lista.Visible = False
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(82, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(378, 85)
        Me.TitleText.TabIndex = 1
        Me.TitleText.Text = "Elimina ciò che non usi."
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formicon
        '
        Me.formicon.BackgroundImage = Global.INSTALLER.My.Resources.Resources.System_recycling_bin_empty_icon
        Me.formicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formicon.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.closebutton.Location = New System.Drawing.Point(1055, 0)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(82, 85)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.elementname)
        Me.panelgoto.Controls.Add(Me.elementspace)
        Me.panelgoto.Controls.Add(Me.Panel4)
        Me.panelgoto.Controls.Add(Me.Label2)
        Me.panelgoto.Controls.Add(Me.Label1)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 488)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(1137, 115)
        Me.panelgoto.TabIndex = 2
        '
        'elementname
        '
        Me.elementname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.elementname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.elementname.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elementname.ForeColor = System.Drawing.Color.DarkCyan
        Me.elementname.Location = New System.Drawing.Point(26, 43)
        Me.elementname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.elementname.Name = "elementname"
        Me.elementname.Size = New System.Drawing.Size(479, 60)
        Me.elementname.TabIndex = 9
        Me.elementname.Text = "Seleziona qualcosa"
        Me.elementname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'elementspace
        '
        Me.elementspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.elementspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.elementspace.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elementspace.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.elementspace.Location = New System.Drawing.Point(520, 43)
        Me.elementspace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.elementspace.Name = "elementspace"
        Me.elementspace.Size = New System.Drawing.Size(390, 60)
        Me.elementspace.TabIndex = 8
        Me.elementspace.Text = "0,00 MB"
        Me.elementspace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.eliminalbl)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(943, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 115)
        Me.Panel4.TabIndex = 7
        Me.Panel4.Visible = False
        '
        'eliminalbl
        '
        Me.eliminalbl.BackColor = System.Drawing.Color.Transparent
        Me.eliminalbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminalbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.eliminalbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminalbl.ForeColor = System.Drawing.Color.DarkRed
        Me.eliminalbl.Location = New System.Drawing.Point(9, 0)
        Me.eliminalbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.eliminalbl.Name = "eliminalbl"
        Me.eliminalbl.Size = New System.Drawing.Size(92, 115)
        Me.eliminalbl.TabIndex = 7
        Me.eliminalbl.Text = "Elimina"
        Me.eliminalbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.Recycle_Bin_Full
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(101, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 115)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Spazio occupato dall'elemento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selezionato: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wait
        '
        Me.wait.Interval = 200
        '
        'emptypanel
        '
        Me.emptypanel.Controls.Add(Me.PictureBox1)
        Me.emptypanel.Controls.Add(Me.Label6)
        Me.emptypanel.Location = New System.Drawing.Point(359, 160)
        Me.emptypanel.Name = "emptypanel"
        Me.emptypanel.Size = New System.Drawing.Size(419, 292)
        Me.emptypanel.TabIndex = 0
        Me.emptypanel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.smileys
        Me.PictureBox1.Location = New System.Drawing.Point(63, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(399, 45)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "A quanto pare non hai scaricato nulla."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectlbl
        '
        Me.selectlbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectlbl.Location = New System.Drawing.Point(369, 523)
        Me.selectlbl.Name = "selectlbl"
        Me.selectlbl.Size = New System.Drawing.Size(399, 45)
        Me.selectlbl.TabIndex = 8
        Me.selectlbl.Text = "Seleziona qualcosa..."
        Me.selectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.selectlbl.Visible = False
        '
        'anim
        '
        Me.anim.Interval = 10
        '
        'PanelCirc
        '
        Me.PanelCirc.BackColor = System.Drawing.Color.Transparent
        Me.PanelCirc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCirc.Location = New System.Drawing.Point(878, 132)
        Me.PanelCirc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCirc.Name = "PanelCirc"
        Me.PanelCirc.Size = New System.Drawing.Size(226, 239)
        Me.PanelCirc.TabIndex = 3
        Me.PanelCirc.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(882, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Spazio occupato:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(903, 384)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Spazio libero:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(878, 422)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 53)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Errore !"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'deleteappsnew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1137, 603)
        Me.Controls.Add(Me.selectlbl)
        Me.Controls.Add(Me.emptypanel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelCirc)
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "deleteappsnew"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimina le APP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.emptypanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebutton As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents panelgoto As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents wait As Timer
    Friend WithEvents lista As ListBox
    Friend WithEvents fileinutilibtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents eliminalbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents elementspace As Label
    Friend WithEvents elementname As Label
    Friend WithEvents emptypanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents selectlbl As Label
    Friend WithEvents anim As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelCirc As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
