Imports System.Data.Odbc

Public Class Laporan
    Dim con1 As OdbcConnection
    Dim cmd1 As OdbcCommand
    Dim adp1 As OdbcDataAdapter
    Dim dt_katalog As New DataTable
    Dim ds As DataSet
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim cmd As OdbcCommand
    Dim laporandata As New ArrayList()


    Sub koneksi()
        con1 = New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
        Try
            If con1.State = ConnectionState.Closed Then
                con1.Open()
                MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal" & ex.Message)
        End Try
    End Sub

    Sub isi_combo()
        Try
            If con1.State = ConnectionState.Closed Then
                con1.Open()
            End If

            Dim query As String = "SELECT invoice FROM tbl_transaksi"
            cmd = New OdbcCommand(query, con1)
            dr = cmd.ExecuteReader()

            idTransaksi.Items.Clear()
            While dr.Read()
                idTransaksi.Items.Add(dr("invoice").ToString())
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Sub Invoice1()
        ds = New DataSet()
        ds.Clear()
        da = New OdbcDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(tgl_masuk, 5, 3)AS UNSIGNED)) IS NULL THEN 1 
                                ELSE MAX(CAST(SUBSTRING(tgl_masuk, 5, 3) AS UNSIGNED)) + 1 END AS nomor 
                                FROM ( 
                                SELECT 
                                MAX(CAST(SUBSTRING(tgl_masuk, 9, 2) AS UNSIGNED)) AS bln, 
                                MAX(CAST(SUBSTRING(tgl_masuk, 9, 2) AS UNSIGNED)) AS thn,
                                tgl_masuk
                                FROM tbl_transaksi
                                GROUP BY tgl_masuk) a
                                WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", con1)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        invoice.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub
    Private Function GenerateFakturPenjualan() As String
        Dim tanggalSekarang As String = tanggal.Value.ToString("yyyyMMddHHmmss")
        Dim fakturPenjualan As String = "INV/" & tanggalSekarang
        Return fakturPenjualan
    End Function

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Invoice1()
        GenerateFakturPenjualan()
        isi_combo()


    End Sub
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            If con1 Is Nothing Then
                MsgBox("Koneksi belum diinisialisasi.")
                Return
            End If

            Dim selectedProduct As String = idTransaksi.SelectedItem.ToString()
            Dim query As String = "INSERT INTO tbl_laporan (invoice, Nama_Pembeli, Nama_Produk, Jumlah_Beli, total) VALUES (?, ?, ?, ?, ?)"

            Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                conn.Open()

                Using cmd As New OdbcCommand(query, conn)
                    cmd.Parameters.AddWithValue("@invoice", selectedProduct)
                    cmd.Parameters.AddWithValue("@Nama_Pembeli", namaPembeli.Text)
                    cmd.Parameters.AddWithValue("@Nama_Produk", namaProduk.Text)
                    cmd.Parameters.AddWithValue("@Jumlah_Beli", jumlahPembelian.Text)
                    cmd.Parameters.AddWithValue("@total", totalPembelian.Text)
                    cmd.ExecuteNonQuery()
                End Using


                ds.Clear()
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try

        Try
            da = New OdbcDataAdapter("SELECT MAX(Nama_Produk) FROM tbl_laporan", con1)
            da.Fill(ds, "xxx1")

            If ds.Tables("xxx1").Rows.Count > 0 AndAlso ds.Tables("xxx1").Rows(0).Item(0) IsNot DBNull.Value Then
                namaProduk.Text = ds.Tables("xxx1").Rows(0).Item(0).ToString()
            Else
                namaProduk.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Gagal mengambil nilai berikutnya: " & ex.Message)
        End Try

        Try
            da = New OdbcDataAdapter("SELECT invoice, Nama_Pembeli, Nama_Produk, Jumlah_Beli, total FROM tbl_laporan ", con1)
            ds.Clear()
            da.Fill(ds, "xxx")
            DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        Catch ex As Exception
            MsgBox("Gagal mengambil data dari database: " & ex.Message)
        End Try

        isi_combo()
        tbototal.Text = HitungTotalLaporan()
        namaPembeli.Text = ""
        namaProduk.Text = ""
        jumlahPembelian.Text = ""
        totalPembelian.Text = ""
    End Sub






    Private Sub cetaksemua()
        cmd1 = New OdbcCommand("SELECT * FROM tbl_katalog", con1)
        adp1 = New OdbcDataAdapter(cmd1)
        adp1.Fill(dt_katalog)

        con1.Close()
        con1.Dispose()
    End Sub

    Private Sub invoice_TextChanged(sender As Object, e As EventArgs) Handles invoice.TextChanged

    End Sub
    Private Function HitungTotalLaporan() As Double
        Dim total As Double = 0

        Try
            Dim query As String = "SELECT SUM(total) AS Total_Pembelian FROM tbl_laporan"
            da = New OdbcDataAdapter(query, con1)
            Dim ds As New DataSet()
            da.Fill(ds, "TotalPembelian")

            If ds.Tables("TotalPembelian").Rows.Count > 0 AndAlso Not IsDBNull(ds.Tables("TotalPembelian").Rows(0)("Total_Pembelian")) Then
                total = Convert.ToDouble(ds.Tables("TotalPembelian").Rows(0)("Total_Pembelian"))
            End If
        Catch ex As Exception
            MsgBox("Kesalahan dalam menghitung total pembelian: " & ex.Message)
        End Try

        Return total
    End Function



    Private Sub idTransaksi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idTransaksi.SelectedIndexChanged
        Try
            Dim selectedProduk As String = idTransaksi.SelectedItem.ToString()

            Dim query As String = "SELECT t.Nama_Pembeli, t.Nama_Produk, t.Jumlah_Beli, k.total FROM tbl_transaksi  t INNER JOIN tbl_total k WHERE invoice = ?"
            cmd = New OdbcCommand(query, con1)
            cmd.Parameters.Add(New OdbcParameter("namaBarang1", selectedProduk))
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                namaPembeli.Text = dr("Nama_Pembeli").ToString()
                namaProduk.Text = dr("Nama_Produk").ToString()
                jumlahPembelian.Text = dr("Jumlah_Beli").ToString()
                totalPembelian.Text = dr("Total").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim beranda As New Beranda()
        beranda.Show()
        Me.Hide()
    End Sub
    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub





End Class