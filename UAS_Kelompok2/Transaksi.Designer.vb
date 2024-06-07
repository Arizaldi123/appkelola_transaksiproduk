<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.kembali = New Guna.UI2.WinForms.Guna2Button()
        Me.pembayaran = New Guna.UI2.WinForms.Guna2Button()
        Me.totalPembelian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.hapus = New Guna.UI2.WinForms.Guna2Button()
        Me.edit = New Guna.UI2.WinForms.Guna2Button()
        Me.simpan = New Guna.UI2.WinForms.Guna2Button()
        Me.idTransaksi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.namaPembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tanggalPembelian = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cari = New Guna.UI2.WinForms.Guna2Button()
        Me.kodeProduk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.statusProduk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.jumlahPembelian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bersihkan = New Guna.UI2.WinForms.Guna2Button()
        Me.pilihProduk = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.cari)
        Me.Guna2GroupBox1.Controls.Add(Me.bersihkan)
        Me.Guna2GroupBox1.Controls.Add(Me.kembali)
        Me.Guna2GroupBox1.Controls.Add(Me.pembayaran)
        Me.Guna2GroupBox1.Controls.Add(Me.totalPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.DataGridView1)
        Me.Guna2GroupBox1.Controls.Add(Me.hapus)
        Me.Guna2GroupBox1.Controls.Add(Me.edit)
        Me.Guna2GroupBox1.Controls.Add(Me.simpan)
        Me.Guna2GroupBox1.Controls.Add(Me.jumlahPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.statusProduk)
        Me.Guna2GroupBox1.Controls.Add(Me.kodeProduk)
        Me.Guna2GroupBox1.Controls.Add(Me.pilihProduk)
        Me.Guna2GroupBox1.Controls.Add(Me.tanggalPembelian)
        Me.Guna2GroupBox1.Controls.Add(Me.namaPembeli)
        Me.Guna2GroupBox1.Controls.Add(Me.idTransaksi)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Navy
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(800, 452)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "TRANSAKSI"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.kembali.Location = New System.Drawing.Point(595, 385)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(159, 37)
        Me.kembali.TabIndex = 27
        Me.kembali.Text = "Kembali Ke Beranda"
        Me.kembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pembayaran
        '
        Me.pembayaran.BorderColor = System.Drawing.Color.White
        Me.pembayaran.BorderRadius = 8
        Me.pembayaran.BorderThickness = 1
        Me.pembayaran.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pembayaran.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pembayaran.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pembayaran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pembayaran.FillColor = System.Drawing.Color.OrangeRed
        Me.pembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pembayaran.ForeColor = System.Drawing.Color.White
        Me.pembayaran.Image = CType(resources.GetObject("pembayaran.Image"), System.Drawing.Image)
        Me.pembayaran.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pembayaran.Location = New System.Drawing.Point(595, 333)
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(159, 37)
        Me.pembayaran.TabIndex = 26
        Me.pembayaran.Text = "Pembayaran"
        Me.pembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.totalPembelian.Location = New System.Drawing.Point(572, 289)
        Me.totalPembelian.Name = "totalPembelian"
        Me.totalPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalPembelian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.totalPembelian.PlaceholderText = "Total Pembelian"
        Me.totalPembelian.ReadOnly = True
        Me.totalPembelian.SelectedText = ""
        Me.totalPembelian.Size = New System.Drawing.Size(201, 29)
        Me.totalPembelian.TabIndex = 25
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(629, 266)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(88, 17)
        Me.Guna2HtmlLabel6.TabIndex = 24
        Me.Guna2HtmlLabel6.Text = "Total Pembelian"
        '
        'DataGridView1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeight = 19
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(18, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(528, 156)
        Me.DataGridView1.TabIndex = 23
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
        'hapus
        '
        Me.hapus.BorderColor = System.Drawing.Color.White
        Me.hapus.BorderRadius = 8
        Me.hapus.BorderThickness = 1
        Me.hapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.hapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.hapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.hapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.hapus.FillColor = System.Drawing.Color.OrangeRed
        Me.hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hapus.ForeColor = System.Drawing.Color.White
        Me.hapus.Image = CType(resources.GetObject("hapus.Image"), System.Drawing.Image)
        Me.hapus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.hapus.Location = New System.Drawing.Point(686, 194)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(102, 37)
        Me.hapus.TabIndex = 22
        Me.hapus.Text = "Hapus"
        Me.hapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'edit
        '
        Me.edit.BorderColor = System.Drawing.Color.White
        Me.edit.BorderRadius = 8
        Me.edit.BorderThickness = 1
        Me.edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.edit.FillColor = System.Drawing.Color.OrangeRed
        Me.edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.edit.ForeColor = System.Drawing.Color.White
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.edit.Location = New System.Drawing.Point(686, 132)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(102, 37)
        Me.edit.TabIndex = 21
        Me.edit.Text = "Edit"
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
        Me.simpan.Location = New System.Drawing.Point(686, 72)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(102, 37)
        Me.simpan.TabIndex = 20
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'idTransaksi
        '
        Me.idTransaksi.BorderRadius = 8
        Me.idTransaksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idTransaksi.DefaultText = ""
        Me.idTransaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.idTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.idTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idTransaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idTransaksi.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.idTransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.idTransaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTransaksi.Location = New System.Drawing.Point(127, 66)
        Me.idTransaksi.Name = "idTransaksi"
        Me.idTransaksi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idTransaksi.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.idTransaksi.PlaceholderText = "Id Transaksi"
        Me.idTransaksi.ReadOnly = True
        Me.idTransaksi.SelectedText = ""
        Me.idTransaksi.Size = New System.Drawing.Size(201, 29)
        Me.idTransaksi.TabIndex = 13
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
        Me.namaPembeli.FillColor = System.Drawing.Color.Silver
        Me.namaPembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namaPembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPembeli.Location = New System.Drawing.Point(127, 111)
        Me.namaPembeli.Name = "namaPembeli"
        Me.namaPembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namaPembeli.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.namaPembeli.PlaceholderText = "Masukkan Nama Pembeli"
        Me.namaPembeli.SelectedText = ""
        Me.namaPembeli.Size = New System.Drawing.Size(201, 29)
        Me.namaPembeli.TabIndex = 14
        '
        'tanggalPembelian
        '
        Me.tanggalPembelian.BorderColor = System.Drawing.Color.White
        Me.tanggalPembelian.BorderRadius = 8
        Me.tanggalPembelian.BorderThickness = 1
        Me.tanggalPembelian.Checked = True
        Me.tanggalPembelian.FillColor = System.Drawing.Color.Silver
        Me.tanggalPembelian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tanggalPembelian.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggalPembelian.Location = New System.Drawing.Point(127, 155)
        Me.tanggalPembelian.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tanggalPembelian.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tanggalPembelian.Name = "tanggalPembelian"
        Me.tanggalPembelian.Size = New System.Drawing.Size(200, 41)
        Me.tanggalPembelian.TabIndex = 15
        Me.tanggalPembelian.Value = New Date(2023, 12, 23, 7, 53, 55, 940)
        '
        'cari
        '
        Me.cari.BorderColor = System.Drawing.Color.White
        Me.cari.BorderRadius = 8
        Me.cari.BorderThickness = 1
        Me.cari.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cari.FillColor = System.Drawing.Color.OrangeRed
        Me.cari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cari.ForeColor = System.Drawing.Color.White
        Me.cari.Image = CType(resources.GetObject("cari.Image"), System.Drawing.Image)
        Me.cari.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cari.Location = New System.Drawing.Point(128, 209)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(99, 33)
        Me.cari.TabIndex = 29
        Me.cari.Text = "Cari"
        Me.cari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'kodeProduk
        '
        Me.kodeProduk.BorderRadius = 8
        Me.kodeProduk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodeProduk.DefaultText = ""
        Me.kodeProduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kodeProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kodeProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodeProduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodeProduk.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kodeProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodeProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kodeProduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodeProduk.Location = New System.Drawing.Point(462, 119)
        Me.kodeProduk.Name = "kodeProduk"
        Me.kodeProduk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kodeProduk.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.kodeProduk.PlaceholderText = "Kode Produk"
        Me.kodeProduk.ReadOnly = True
        Me.kodeProduk.SelectedText = ""
        Me.kodeProduk.Size = New System.Drawing.Size(201, 29)
        Me.kodeProduk.TabIndex = 17
        '
        'statusProduk
        '
        Me.statusProduk.BorderRadius = 8
        Me.statusProduk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.statusProduk.DefaultText = ""
        Me.statusProduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.statusProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.statusProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.statusProduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.statusProduk.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.statusProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.statusProduk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.statusProduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.statusProduk.Location = New System.Drawing.Point(462, 164)
        Me.statusProduk.Name = "statusProduk"
        Me.statusProduk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.statusProduk.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.statusProduk.PlaceholderText = "Status Produk"
        Me.statusProduk.ReadOnly = True
        Me.statusProduk.SelectedText = ""
        Me.statusProduk.Size = New System.Drawing.Size(201, 29)
        Me.statusProduk.TabIndex = 18
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
        Me.jumlahPembelian.FillColor = System.Drawing.Color.Silver
        Me.jumlahPembelian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.jumlahPembelian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.jumlahPembelian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.jumlahPembelian.Location = New System.Drawing.Point(462, 213)
        Me.jumlahPembelian.Name = "jumlahPembelian"
        Me.jumlahPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.jumlahPembelian.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.jumlahPembelian.PlaceholderText = "Masukkan Jumlah Pembelian"
        Me.jumlahPembelian.SelectedText = ""
        Me.jumlahPembelian.Size = New System.Drawing.Size(201, 29)
        Me.jumlahPembelian.TabIndex = 19
        '
        'bersihkan
        '
        Me.bersihkan.BorderColor = System.Drawing.Color.White
        Me.bersihkan.BorderRadius = 8
        Me.bersihkan.BorderThickness = 1
        Me.bersihkan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bersihkan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bersihkan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bersihkan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bersihkan.FillColor = System.Drawing.Color.OrangeRed
        Me.bersihkan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bersihkan.ForeColor = System.Drawing.Color.White
        Me.bersihkan.Image = CType(resources.GetObject("bersihkan.Image"), System.Drawing.Image)
        Me.bersihkan.Location = New System.Drawing.Point(24, 209)
        Me.bersihkan.Name = "bersihkan"
        Me.bersihkan.Size = New System.Drawing.Size(98, 33)
        Me.bersihkan.TabIndex = 28
        Me.bersihkan.Text = "Bersihkan"
        '
        'pilihProduk
        '
        Me.pilihProduk.BackColor = System.Drawing.Color.Transparent
        Me.pilihProduk.BorderColor = System.Drawing.Color.White
        Me.pilihProduk.BorderRadius = 8
        Me.pilihProduk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.pilihProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pilihProduk.FillColor = System.Drawing.Color.Silver
        Me.pilihProduk.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pilihProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pilihProduk.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.pilihProduk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pilihProduk.ItemHeight = 30
        Me.pilihProduk.Location = New System.Drawing.Point(462, 66)
        Me.pilihProduk.Name = "pilihProduk"
        Me.pilihProduk.Size = New System.Drawing.Size(201, 36)
        Me.pilihProduk.TabIndex = 16
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(361, 123)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(71, 17)
        Me.Guna2HtmlLabel4.TabIndex = 34
        Me.Guna2HtmlLabel4.Text = "Kode Produk"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(361, 170)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(76, 17)
        Me.Guna2HtmlLabel8.TabIndex = 33
        Me.Guna2HtmlLabel8.Text = "Status Produk"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(361, 218)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(100, 17)
        Me.Guna2HtmlLabel7.TabIndex = 32
        Me.Guna2HtmlLabel7.Text = "Jumlah Pembelian"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(361, 75)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(67, 17)
        Me.Guna2HtmlLabel3.TabIndex = 31
        Me.Guna2HtmlLabel3.Text = "Pilih Produk"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 76)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(64, 17)
        Me.Guna2HtmlLabel2.TabIndex = 37
        Me.Guna2HtmlLabel2.Text = "Id Transaksi"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(17, 168)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(104, 17)
        Me.Guna2HtmlLabel1.TabIndex = 36
        Me.Guna2HtmlLabel1.Text = "Tanggal Pembelian"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(18, 123)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(81, 17)
        Me.Guna2HtmlLabel9.TabIndex = 35
        Me.Guna2HtmlLabel9.Text = "Nama Pembeli"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents hapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents simpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalPembelian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pembayaran As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents kembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bersihkan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents jumlahPembelian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents statusProduk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kodeProduk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pilihProduk As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tanggalPembelian As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents namaPembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents idTransaksi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
