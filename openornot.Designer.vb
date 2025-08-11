<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class openornot
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
        Me.panelgoto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gotolist = New System.Windows.Forms.Button()
        Me.listlbl = New System.Windows.Forms.Label()
        Me.labeltitle = New System.Windows.Forms.Label()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.panelgoto.SuspendLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelgoto
        '
        Me.panelgoto.BackColor = System.Drawing.Color.Gainsboro
        Me.panelgoto.Controls.Add(Me.Button1)
        Me.panelgoto.Controls.Add(Me.Label1)
        Me.panelgoto.Controls.Add(Me.gotolist)
        Me.panelgoto.Controls.Add(Me.listlbl)
        Me.panelgoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelgoto.Location = New System.Drawing.Point(0, 372)
        Me.panelgoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelgoto.Name = "panelgoto"
        Me.panelgoto.Size = New System.Drawing.Size(679, 149)
        Me.panelgoto.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.INSTALLER.My.Resources.Resources.back2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 105)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Annulla"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gotolist
        '
        Me.gotolist.BackColor = System.Drawing.Color.Transparent
        Me.gotolist.BackgroundImage = Global.INSTALLER.My.Resources.Resources.shipping_and_delivery
        Me.gotolist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gotolist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gotolist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.gotolist.FlatAppearance.BorderSize = 0
        Me.gotolist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.gotolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gotolist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotolist.Location = New System.Drawing.Point(392, 5)
        Me.gotolist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gotolist.Name = "gotolist"
        Me.gotolist.Size = New System.Drawing.Size(133, 105)
        Me.gotolist.TabIndex = 60
        Me.gotolist.UseVisualStyleBackColor = False
        '
        'listlbl
        '
        Me.listlbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.listlbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listlbl.Location = New System.Drawing.Point(389, 115)
        Me.listlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.listlbl.Name = "listlbl"
        Me.listlbl.Size = New System.Drawing.Size(138, 29)
        Me.listlbl.TabIndex = 61
        Me.listlbl.Text = "Installa"
        Me.listlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labeltitle
        '
        Me.labeltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltitle.Location = New System.Drawing.Point(12, 9)
        Me.labeltitle.Name = "labeltitle"
        Me.labeltitle.Size = New System.Drawing.Size(655, 97)
        Me.labeltitle.TabIndex = 65
        Me.labeltitle.Text = "Installare quest'applicazione ?"
        Me.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'image
        '
        Me.image.Location = New System.Drawing.Point(165, 109)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(349, 223)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image.TabIndex = 66
        Me.image.TabStop = False
        '
        'openornot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(679, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.labeltitle)
        Me.Controls.Add(Me.panelgoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.name = "openornot"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Installa"
        Me.TopMost = True
        Me.panelgoto.ResumeLayout(False)
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelgoto As Panel
    Friend WithEvents gotolist As Button
    Friend WithEvents listlbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents labeltitle As Label
    Friend WithEvents image As PictureBox
End Class
