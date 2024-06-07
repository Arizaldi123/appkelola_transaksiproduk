<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beranda))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.katalog = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.transaksi = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.laporan = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.keluar = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(802, 453)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BorderRadius = 15
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(168, 146)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(251, 168)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(197, 109)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(189, 35)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Selamat Datang Di"
        '
        'katalog
        '
        Me.katalog.BorderColor = System.Drawing.Color.White
        Me.katalog.BorderRadius = 8
        Me.katalog.BorderThickness = 1
        Me.katalog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.katalog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.katalog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.katalog.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.katalog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.katalog.FillColor = System.Drawing.Color.Orange
        Me.katalog.FillColor2 = System.Drawing.Color.Navy
        Me.katalog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.katalog.ForeColor = System.Drawing.Color.White
        Me.katalog.Image = CType(resources.GetObject("katalog.Image"), System.Drawing.Image)
        Me.katalog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.katalog.Location = New System.Drawing.Point(448, 144)
        Me.katalog.Name = "katalog"
        Me.katalog.Size = New System.Drawing.Size(207, 45)
        Me.katalog.TabIndex = 9
        Me.katalog.Text = "Katalog Produk"
        '
        'transaksi
        '
        Me.transaksi.BorderColor = System.Drawing.Color.White
        Me.transaksi.BorderRadius = 8
        Me.transaksi.BorderThickness = 1
        Me.transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.transaksi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.transaksi.FillColor = System.Drawing.Color.Orange
        Me.transaksi.FillColor2 = System.Drawing.Color.Navy
        Me.transaksi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.transaksi.ForeColor = System.Drawing.Color.White
        Me.transaksi.Image = CType(resources.GetObject("transaksi.Image"), System.Drawing.Image)
        Me.transaksi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transaksi.Location = New System.Drawing.Point(448, 207)
        Me.transaksi.Name = "transaksi"
        Me.transaksi.Size = New System.Drawing.Size(207, 45)
        Me.transaksi.TabIndex = 10
        Me.transaksi.Text = "Transaksi"
        '
        'laporan
        '
        Me.laporan.BorderColor = System.Drawing.Color.White
        Me.laporan.BorderRadius = 8
        Me.laporan.BorderThickness = 1
        Me.laporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.laporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.laporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.laporan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.laporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.laporan.FillColor = System.Drawing.Color.Orange
        Me.laporan.FillColor2 = System.Drawing.Color.Navy
        Me.laporan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.laporan.ForeColor = System.Drawing.Color.White
        Me.laporan.Image = CType(resources.GetObject("laporan.Image"), System.Drawing.Image)
        Me.laporan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.laporan.Location = New System.Drawing.Point(448, 269)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(207, 45)
        Me.laporan.TabIndex = 11
        Me.laporan.Text = "Laporan Penjualan"
        '
        'keluar
        '
        Me.keluar.BorderColor = System.Drawing.Color.White
        Me.keluar.BorderRadius = 8
        Me.keluar.BorderThickness = 1
        Me.keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.keluar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.keluar.FillColor = System.Drawing.Color.Orange
        Me.keluar.FillColor2 = System.Drawing.Color.Navy
        Me.keluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.keluar.ForeColor = System.Drawing.Color.White
        Me.keluar.Image = CType(resources.GetObject("keluar.Image"), System.Drawing.Image)
        Me.keluar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.keluar.Location = New System.Drawing.Point(448, 331)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(207, 45)
        Me.keluar.TabIndex = 13
        Me.keluar.Text = "Keluar Aplikasi"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.laporan)
        Me.Controls.Add(Me.transaksi)
        Me.Controls.Add(Me.katalog)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "Beranda"
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents katalog As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents transaksi As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents laporan As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents keluar As Guna.UI2.WinForms.Guna2GradientButton
End Class
