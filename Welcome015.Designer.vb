<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome015
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.formicon = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelfinito = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.principale = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.barra = New System.Windows.Forms.PictureBox()
        Me.vailbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.avanza = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelfinito.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.principale.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelgoto.SuspendLayout()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Senza di esso, INSTALLER è come un pesce fuor d'acqua!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 40)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Sto scaricando il database ..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Controls.Add(Me.formicon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 85)
        Me.Panel2.TabIndex = 61
        '
        'TitleText
        '
        Me.TitleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(90, 0)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(650, 85)
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
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'panelfinito
        '
        Me.panelfinito.Controls.Add(Me.Label3)
        Me.panelfinito.Controls.Add(Me.Label4)
        Me.panelfinito.Controls.Add(Me.PictureBox1)
        Me.panelfinito.Location = New System.Drawing.Point(22, 94)
        Me.panelfinito.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelfinito.Name = "panelfinito"
        Me.panelfinito.Size = New System.Drawing.Size(879, 452)
        Me.panelfinito.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 365)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 35)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Attendi un attimo..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 275)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(790, 71)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fatto!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(PS: Non eliminare la cartella Fondamental)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INSTALLER.My.Resources.Resources.done
        Me.PictureBox1.Location = New System.Drawing.Point(338, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'principale
        '
        Me.principale.Controls.Add(Me.Label1)
        Me.principale.Controls.Add(Me.Label2)
        Me.principale.Controls.Add(Me.PictureBox3)
        Me.principale.Location = New System.Drawing.Point(0, 97)
        Me.principale.Name = "principale"
        Me.principale.Size = New System.Drawing.Size(924, 363)
        Me.principale.TabIndex = 65
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INSTALLER.My.Resources.Resources.multimedia
        Me.PictureBox3.Location = New System.Drawing.Point(298, 115)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(326, 229)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.barra)
        Me.panelgoto.Controls.Add(Me.vailbl)
        Me.panelgoto.Controls.Add(Me.Button2)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 467)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(924, 128)
        Me.panelgoto.TabIndex = 66
        '
        'barra
        '
        Me.barra.Image = Global.INSTALLER.My.Resources.Resources.barra
        Me.barra.Location = New System.Drawing.Point(24, 35)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(876, 55)
        Me.barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.barra.TabIndex = 62
        Me.barra.TabStop = False
        '
        'vailbl
        '
        Me.vailbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.vailbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vailbl.Location = New System.Drawing.Point(286, 98)
        Me.vailbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vailbl.Name = "vailbl"
        Me.vailbl.Size = New System.Drawing.Size(350, 29)
        Me.vailbl.TabIndex = 61
        Me.vailbl.Text = "Riprova"
        Me.vailbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.vailbl.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.INSTALLER.My.Resources.Resources.retry
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Location = New System.Drawing.Point(382, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 98)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'avanza
        '
        Me.avanza.Interval = 10
        '
        'Welcome015
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(924, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelgoto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.principale)
        Me.Controls.Add(Me.panelfinito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome015"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione di Installer"
        Me.Panel2.ResumeLayout(False)
        CType(Me.formicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelfinito.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.principale.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelgoto.ResumeLayout(False)
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents formicon As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelfinito As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents principale As Panel
    Friend WithEvents panelgoto As Panel
    Friend WithEvents vailbl As Label
    Friend WithEvents barra As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents avanza As Timer
End Class
