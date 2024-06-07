<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.invoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tanggal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.namaPembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.namaProduk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.jumlahPembelian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.totalPembelian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.simpan = New Guna.UI2.WinForms.Guna2Button()
        Me.tbototal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.print = New Guna.UI2.WinForms.Guna2Button()
        Me.kembali = New Guna.UI2.WinForms.Guna2Button()
        Me.idTransaksi = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.tbototal)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox1.Controls.Add(Me.idTransaksi)
        Me.Guna2GroupBox1.Controls.Add(Me.kembali)
        Me.Guna2GroupBox1.Controls.Add(Me.print)
        Me.Guna2GroupBox1.Controls.Add(Me.DataGridView1)
        Me.Guna2GroupBox1.Controls.Add(Me.simpan)
        Me.Guna2GroupBox1.Controls.Add(Me.totalPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.jumlahPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.namaProduk)
        Me.Guna2GroupBox1.Controls.Add(Me.namaPembeli)
        Me.Guna2GroupBox1.Controls.Add(Me.tanggal)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.invoice)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Navy
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(802, 450)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "INVOICE"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(139, 70)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(22, 17)
        Me.Guna2HtmlLabel5.TabIndex = 16
        Me.Guna2HtmlLabel5.Text = "INV"
        '
        'invoice
        '
        Me.invoice.BorderRadius = 8
        Me.invoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.invoice.DefaultText = ""
        Me.invoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.invoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.invoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.invoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.invoice.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.invoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.invoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.invoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.invoice.Location = New System.Drawing.Point(167, 63)
        Me.invoice.Name = "invoice"
        Me.invoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.invoice.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.invoice.PlaceholderText = "Nomor Invoice"
        Me.invoice.ReadOnly = True
        Me.invoice.SelectedText = ""
        Me.invoice.Size = New System.Drawing.Size(201, 29)
        Me.invoice.TabIndex = 17
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(381, 68)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(45, 17)
        Me.Guna2HtmlLabel2.TabIndex = 18
        Me.Guna2HtmlLabel2.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.BorderColor = System.Drawing.Color.White
        Me.tanggal.BorderRadius = 8
        Me.tanggal.BorderThickness = 1
        Me.tanggal.Checked = True
        Me.tanggal.FillColor = System.Drawing.Color.Silver
        Me.tanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggal.Location = New System.Drawing.Point(432, 55)
        Me.tanggal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tanggal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(200, 41)
        Me.tanggal.TabIndex = 19
        Me.tanggal.Value = New Date(2023, 12, 23, 7, 53, 55, 940)
        '
        'namaPembeli
        '
        Me.namaPembeli.BorderRadius = 8
        Me.namaPembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaPembeli.DefaultText = ""
        Me.namaPembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namaPembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namaPembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaPembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaPembeli.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.namaPembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namaPembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPembeli.Location = New System.Drawing.Point(139, 166)
        Me.namaPembeli.Name = "namaPembeli"
        Me.namaPembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namaPembeli.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.namaPembeli.PlaceholderText = " Nama Pembeli"
        Me.namaPembeli.SelectedText = ""
        Me.namaPembeli.Size = New System.Drawing.Size(201, 29)
        Me.namaPembeli.TabIndex = 23
        '
        'namaProduk
        '
        Me.namaProduk.BorderRadius = 8
        Me.namaProduk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaProduk.DefaultText = ""
        Me.namaProduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namaProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namaProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaProduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaProduk.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.namaProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namaProduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaProduk.Location = New System.Drawing.Point(139, 211)
        Me.namaProduk.Name = "namaProduk"
        Me.namaProduk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namaProduk.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.namaProduk.PlaceholderText = "Nama Produk"
        Me.namaProduk.SelectedText = ""
        Me.namaProduk.Size = New System.Drawing.Size(201, 29)
        Me.namaProduk.TabIndex = 25
        '
        'jumlahPembelian
        '
        Me.jumlahPembelian.BorderRadius = 8
        Me.jumlahPembelian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahPembelian.DefaultText = ""
        Me.jumlahPembelian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.jumlahPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.jumlahPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.jumlahPembelian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.jumlahPembelian.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.jumlahPembelian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.jumlahPembelian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.jumlahPembelian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.jumlahPembelian.Location = New System.Drawing.Point(139, 255)
        Me.jumlahPembelian.Name = "jumlahPembelian"
        Me.jumlahPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.jumlahPembelian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.jumlahPembelian.PlaceholderText = "Jumlah Pembelian"
        Me.jumlahPembelian.SelectedText = ""
        Me.jumlahPembelian.Size = New System.Drawing.Size(201, 29)
        Me.jumlahPembelian.TabIndex = 27
        '
        'totalPembelian
        '
        Me.totalPembelian.BorderRadius = 8
        Me.totalPembelian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalPembelian.DefaultText = ""
        Me.totalPembelian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalPembelian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalPembelian.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.totalPembelian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalPembelian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.totalPembelian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalPembelian.Location = New System.Drawing.Point(139, 297)
        Me.totalPembelian.Name = "totalPembelian"
        Me.totalPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalPembelian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.totalPembelian.PlaceholderText = "Total Pembelian"
        Me.totalPembelian.ReadOnly = True
        Me.totalPembelian.SelectedText = ""
        Me.totalPembelian.Size = New System.Drawing.Size(201, 29)
        Me.totalPembelian.TabIndex = 29
        '
        'simpan
        '
        Me.simpan.BorderColor = System.Drawing.Color.White
        Me.simpan.BorderRadius = 8
        Me.simpan.BorderThickness = 1
        Me.simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.simpan.FillColor = System.Drawing.Color.OrangeRed
        Me.simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.simpan.ForeColor = System.Drawing.Color.White
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.simpan.Location = New System.Drawing.Point(113, 356)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(102, 37)
        Me.simpan.TabIndex = 30
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbototal
        '
        Me.tbototal.BorderRadius = 8
        Me.tbototal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbototal.DefaultText = ""
        Me.tbototal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbototal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbototal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbototal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbototal.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbototal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbototal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbototal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbototal.Location = New System.Drawing.Point(509, 366)
        Me.tbototal.Name = "tbototal"
        Me.tbototal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbototal.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.tbototal.PlaceholderText = "Total Pembelian"
        Me.tbototal.ReadOnly = True
        Me.tbototal.SelectedText = ""
        Me.tbototal.Size = New System.Drawing.Size(201, 29)
        Me.tbototal.TabIndex = 38
        '
        'print
        '
        Me.print.BorderColor = System.Drawing.Color.White
        Me.print.BorderRadius = 8
        Me.print.BorderThickness = 1
        Me.print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.print.FillColor = System.Drawing.Color.OrangeRed
        Me.print.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.print.ForeColor = System.Drawing.Color.White
        Me.print.Image = CType(resources.GetObject("print.Image"), System.Drawing.Image)
        Me.print.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.print.Location = New System.Drawing.Point(638, 401)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(126, 37)
        Me.print.TabIndex = 34
        Me.print.Text = "Print Laporan"
        Me.print.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.kembali.Location = New System.Drawing.Point(473, 401)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(159, 37)
        Me.kembali.TabIndex = 35
        Me.kembali.Text = "Kembali Ke Beranda"
        Me.kembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'idTransaksi
        '
        Me.idTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.idTransaksi.BorderRadius = 8
        Me.idTransaksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.idTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idTransaksi.FillColor = System.Drawing.Color.Silver
        Me.idTransaksi.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTransaksi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.idTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.idTransaksi.ItemHeight = 30
        Me.idTransaksi.Location = New System.Drawing.Point(139, 114)
        Me.idTransaksi.Name = "idTransaksi"
        Me.idTransaksi.Size = New System.Drawing.Size(201, 36)
        Me.idTransaksi.TabIndex = 36
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(553, 332)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(88, 17)
        Me.Guna2HtmlLabel8.TabIndex = 37
        Me.Guna2HtmlLabel8.Text = "Total Pembelian"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 19
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(357, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(423, 203)
        Me.DataGridView1.TabIndex = 33
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 19
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(27, 118)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(64, 17)
        Me.Guna2HtmlLabel11.TabIndex = 46
        Me.Guna2HtmlLabel11.Text = "Id Transaksi"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(27, 166)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(81, 17)
        Me.Guna2HtmlLabel10.TabIndex = 45
        Me.Guna2HtmlLabel10.Text = "Nama Pembeli"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(27, 211)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(76, 17)
        Me.Guna2HtmlLabel9.TabIndex = 44
        Me.Guna2HtmlLabel9.Text = "Nama Produk"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(27, 297)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(88, 17)
        Me.Guna2HtmlLabel6.TabIndex = 43
        Me.Guna2HtmlLabel6.Text = "Total Pembelian"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(27, 256)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(100, 17)
        Me.Guna2HtmlLabel7.TabIndex = 42
        Me.Guna2HtmlLabel7.Text = "Jumlah Pembelian"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbototal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents idTransaksi As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents kembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents simpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalPembelian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents jumlahPembelian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents namaProduk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents namaPembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tanggal As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents invoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
