<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembayaran))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.bayar = New Guna.UI2.WinForms.Guna2Button()
        Me.batal = New Guna.UI2.WinForms.Guna2Button()
        Me.kembali = New Guna.UI2.WinForms.Guna2Button()
        Me.tboidtransaksi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbototalPembelian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbonominal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbokembalian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.tbokembalian)
        Me.Guna2GroupBox1.Controls.Add(Me.tbonominal)
        Me.Guna2GroupBox1.Controls.Add(Me.tbototalPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.tboidtransaksi)
        Me.Guna2GroupBox1.Controls.Add(Me.kembali)
        Me.Guna2GroupBox1.Controls.Add(Me.batal)
        Me.Guna2GroupBox1.Controls.Add(Me.bayar)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Navy
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(798, 449)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "PEMBAYARAN"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 173)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(126, 17)
        Me.Guna2HtmlLabel1.TabIndex = 28
        Me.Guna2HtmlLabel1.Text = "Nominal Uang Pembeli"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(386, 85)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(100, 17)
        Me.Guna2HtmlLabel2.TabIndex = 29
        Me.Guna2HtmlLabel2.Text = "Jumlah Kembalian"
        '
        'bayar
        '
        Me.bayar.BorderColor = System.Drawing.Color.White
        Me.bayar.BorderRadius = 8
        Me.bayar.BorderThickness = 1
        Me.bayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bayar.FillColor = System.Drawing.Color.OrangeRed
        Me.bayar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bayar.ForeColor = System.Drawing.Color.White
        Me.bayar.Image = CType(resources.GetObject("bayar.Image"), System.Drawing.Image)
        Me.bayar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bayar.Location = New System.Drawing.Point(386, 153)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(141, 37)
        Me.bayar.TabIndex = 32
        Me.bayar.Text = "Bayar Sekarang"
        Me.bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'batal
        '
        Me.batal.BorderColor = System.Drawing.Color.White
        Me.batal.BorderRadius = 8
        Me.batal.BorderThickness = 1
        Me.batal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.batal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.batal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.batal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.batal.FillColor = System.Drawing.Color.OrangeRed
        Me.batal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.batal.ForeColor = System.Drawing.Color.White
        Me.batal.Image = CType(resources.GetObject("batal.Image"), System.Drawing.Image)
        Me.batal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.batal.Location = New System.Drawing.Point(550, 153)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(141, 37)
        Me.batal.TabIndex = 33
        Me.batal.Text = "Batal"
        '
        'kembali
        '
        Me.kembali.BorderColor = System.Drawing.Color.White
        Me.kembali.BorderRadius = 8
        Me.kembali.BorderThickness = 1
        Me.kembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.kembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.kembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.kembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.kembali.FillColor = System.Drawing.Color.OrangeRed
        Me.kembali.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kembali.ForeColor = System.Drawing.Color.White
        Me.kembali.Image = CType(resources.GetObject("kembali.Image"), System.Drawing.Image)
        Me.kembali.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.kembali.Location = New System.Drawing.Point(464, 213)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(159, 37)
        Me.kembali.TabIndex = 34
        Me.kembali.Text = "selesai"
        Me.kembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tboidtransaksi
        '
        Me.tboidtransaksi.BorderRadius = 8
        Me.tboidtransaksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tboidtransaksi.DefaultText = ""
        Me.tboidtransaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tboidtransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tboidtransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tboidtransaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tboidtransaksi.FillColor = System.Drawing.Color.Silver
        Me.tboidtransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tboidtransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tboidtransaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tboidtransaksi.Location = New System.Drawing.Point(147, 69)
        Me.tboidtransaksi.Name = "tboidtransaksi"
        Me.tboidtransaksi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tboidtransaksi.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tboidtransaksi.PlaceholderText = "Masukkan Jumlah Pembelian"
        Me.tboidtransaksi.SelectedText = ""
        Me.tboidtransaksi.Size = New System.Drawing.Size(201, 29)
        Me.tboidtransaksi.TabIndex = 35
        '
        'tbototalPembelian
        '
        Me.tbototalPembelian.BorderRadius = 8
        Me.tbototalPembelian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbototalPembelian.DefaultText = ""
        Me.tbototalPembelian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbototalPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbototalPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbototalPembelian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbototalPembelian.FillColor = System.Drawing.Color.Silver
        Me.tbototalPembelian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbototalPembelian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbototalPembelian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbototalPembelian.Location = New System.Drawing.Point(147, 115)
        Me.tbototalPembelian.Name = "tbototalPembelian"
        Me.tbototalPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbototalPembelian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tbototalPembelian.PlaceholderText = "Masukkan Jumlah Pembelian"
        Me.tbototalPembelian.SelectedText = ""
        Me.tbototalPembelian.Size = New System.Drawing.Size(201, 29)
        Me.tbototalPembelian.TabIndex = 36
        '
        'tbonominal
        '
        Me.tbonominal.BorderRadius = 8
        Me.tbonominal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbonominal.DefaultText = ""
        Me.tbonominal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbonominal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbonominal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbonominal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbonominal.FillColor = System.Drawing.Color.Silver
        Me.tbonominal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbonominal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbonominal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbonominal.Location = New System.Drawing.Point(147, 161)
        Me.tbonominal.Name = "tbonominal"
        Me.tbonominal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbonominal.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tbonominal.PlaceholderText = "Masukkan Jumlah Pembelian"
        Me.tbonominal.SelectedText = ""
        Me.tbonominal.Size = New System.Drawing.Size(201, 29)
        Me.tbonominal.TabIndex = 37
        '
        'tbokembalian
        '
        Me.tbokembalian.BorderRadius = 8
        Me.tbokembalian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbokembalian.DefaultText = ""
        Me.tbokembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbokembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbokembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbokembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbokembalian.FillColor = System.Drawing.Color.Silver
        Me.tbokembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbokembalian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbokembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbokembalian.Location = New System.Drawing.Point(492, 81)
        Me.tbokembalian.Name = "tbokembalian"
        Me.tbokembalian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbokembalian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tbokembalian.PlaceholderText = "Masukkan Jumlah Pembelian"
        Me.tbokembalian.SelectedText = ""
        Me.tbokembalian.Size = New System.Drawing.Size(201, 29)
        Me.tbokembalian.TabIndex = 38
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(15, 69)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(64, 17)
        Me.Guna2HtmlLabel3.TabIndex = 41
        Me.Guna2HtmlLabel3.Text = "Id Transaksi"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(15, 124)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(88, 17)
        Me.Guna2HtmlLabel6.TabIndex = 40
        Me.Guna2HtmlLabel6.Text = "Total Pembelian"
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "Pembayaran"
        Me.Text = "Pembayaran"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
    Friend WithEvents tbonominal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbototalPembelian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tboidtransaksi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents batal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bayar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbokembalian As Guna.UI2.WinForms.Guna2TextBox
End Class
