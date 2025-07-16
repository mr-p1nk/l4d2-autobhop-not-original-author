<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_principal))
        Me.cbx_act = New System.Windows.Forms.CheckBox()
        Me.pl_title = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_close = New System.Windows.Forms.Label()
        Me.lb_min = New System.Windows.Forms.Label()
        Me.lb_titulo = New System.Windows.Forms.Label()
        Me.lb_settings = New System.Windows.Forms.Label()
        Me.pl_title.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_act
        '
        Me.cbx_act.AutoSize = True
        Me.cbx_act.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbx_act.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_act.ForeColor = System.Drawing.Color.White
        Me.cbx_act.Location = New System.Drawing.Point(57, 100)
        Me.cbx_act.Name = "cbx_act"
        Me.cbx_act.Size = New System.Drawing.Size(106, 29)
        Me.cbx_act.TabIndex = 0
        Me.cbx_act.Text = "Enable"
        Me.cbx_act.UseVisualStyleBackColor = True
        '
        'pl_title
        '
        Me.pl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pl_title.Controls.Add(Me.PictureBox1)
        Me.pl_title.Controls.Add(Me.lb_close)
        Me.pl_title.Controls.Add(Me.lb_min)
        Me.pl_title.Controls.Add(Me.lb_titulo)
        Me.pl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.pl_title.Location = New System.Drawing.Point(0, 0)
        Me.pl_title.Name = "pl_title"
        Me.pl_title.Size = New System.Drawing.Size(230, 36)
        Me.pl_title.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MrBhop.My.Resources.Resources.bhop_back_inverted
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lb_close
        '
        Me.lb_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_close.Image = Global.MrBhop.My.Resources.Resources.cross_m
        Me.lb_close.Location = New System.Drawing.Point(196, 11)
        Me.lb_close.Name = "lb_close"
        Me.lb_close.Size = New System.Drawing.Size(30, 19)
        Me.lb_close.TabIndex = 2
        '
        'lb_min
        '
        Me.lb_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_min.Image = Global.MrBhop.My.Resources.Resources.RES
        Me.lb_min.Location = New System.Drawing.Point(154, 15)
        Me.lb_min.Name = "lb_min"
        Me.lb_min.Size = New System.Drawing.Size(33, 13)
        Me.lb_min.TabIndex = 1
        '
        'lb_titulo
        '
        Me.lb_titulo.AutoSize = True
        Me.lb_titulo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_titulo.ForeColor = System.Drawing.Color.White
        Me.lb_titulo.Location = New System.Drawing.Point(39, 7)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(82, 23)
        Me.lb_titulo.TabIndex = 0
        Me.lb_titulo.Text = "Mr. Bhop"
        '
        'lb_settings
        '
        Me.lb_settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_settings.Image = Global.MrBhop.My.Resources.Resources.settings_inv
        Me.lb_settings.Location = New System.Drawing.Point(187, 52)
        Me.lb_settings.Name = "lb_settings"
        Me.lb_settings.Size = New System.Drawing.Size(31, 23)
        Me.lb_settings.TabIndex = 2
        '
        'f_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(230, 200)
        Me.Controls.Add(Me.lb_settings)
        Me.Controls.Add(Me.pl_title)
        Me.Controls.Add(Me.cbx_act)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(230, 200)
        Me.MinimumSize = New System.Drawing.Size(230, 200)
        Me.Name = "f_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_principal"
        Me.pl_title.ResumeLayout(False)
        Me.pl_title.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents cbx_act As CheckBox
    Friend WithEvents pl_title As Panel
    Friend WithEvents lb_close As Label
    Friend WithEvents lb_min As Label
    Friend WithEvents lb_titulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_settings As Label
End Class
