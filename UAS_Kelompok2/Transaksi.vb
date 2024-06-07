Imports System.Configuration
Imports System.Data.Odbc

Public Class Transaksi
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dr As OdbcDataReader
    Dim cmd As OdbcCommand

    Sub koneksi()
        conn = New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal" & ex.Message)
        End Try
    End Sub

    Sub Invoice()
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
                                WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        idTransaksi.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Private Function GenerateFakturPenjualan() As String
        Dim tanggalSekarang As String = tanggalPembelian.Value.ToString("yyyyMMddHHmmss")
        Dim fakturPenjualan As String = "INV/" & tanggalSekarang
        Return fakturPenjualan
    End Function

    Sub isi_combo()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT Nama_Produk FROM tbl_katalog"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            pilihProduk.Items.Clear()
            While dr.Read()
                pilihProduk.Items.Add(dr("Nama_Produk").ToString())
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Sub isi_tabel()
        ds = New DataSet()
        da = New OdbcDataAdapter("SELECT * FROM tbl_transaksi", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Invoice()
        GenerateFakturPenjualan()
        isi_combo()
        isi_tabel()

    End Sub

    Private Sub tanggalPembelian_ValueChanged(sender As Object, e As EventArgs) Handles tanggalPembelian.ValueChanged
        idTransaksi.Text = GenerateFakturPenjualan()
    End Sub

    Private Sub kodeProduk_TextChanged(sender As Object, e As EventArgs) Handles kodeProduk.TextChanged
        Try

            Dim query As String = "SELECT Stok_Produk FROM tbl_katalog WHERE Kode_Produk = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("@kodeProduk", kodeProduk.Text)

            Dim stok As Integer = Convert.ToInt32(cmd.ExecuteScalar())


            If stok > 0 Then
                statusProduk.Text = "Tersedia"
            Else
                statusProduk.Text = "Kosong"
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub pilihProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihProduk.SelectedIndexChanged
        Try
            Dim selectedProduk As String = pilihProduk.SelectedItem.ToString()
            Dim query As String = "SELECT Kode_Produk FROM tbl_katalog WHERE Nama_Produk = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.Add(New OdbcParameter("namaBarang1", selectedProduk))
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                kodeProduk.Text = dr("Kode_Produk").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            If conn Is Nothing Then
                MsgBox("Koneksi belum diinisialisasi.")
                Return
            End If
            Dim selectedProduct As String = pilihProduk.SelectedItem.ToString()

            Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                conn.Open()

                Using OdbcCommand As New OdbcCommand("INSERT INTO tbl_transaksi (invoice, Nama_Pembeli, Kode_Produk, Jumlah_Beli, Nama_Produk) VALUES ( ?, ?, ?, ?, ?)", conn)
                    OdbcCommand.Parameters.AddWithValue("@invoice", idTransaksi.Text)
                    OdbcCommand.Parameters.AddWithValue("@Nama_Pembeli", namaPembeli.Text)
                    OdbcCommand.Parameters.AddWithValue("@Kode_Produk", kodeProduk.Text)
                    OdbcCommand.Parameters.AddWithValue("@Jumlah_Beli", jumlahPembelian.Text)
                    OdbcCommand.Parameters.AddWithValue("@Nama_Produk", selectedProduct)
                    OdbcCommand.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan")
                End Using


                ds.Clear()
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try


        Try
            da = New OdbcDataAdapter("SELECT MAX(CAST(Kode_Produk AS SIGNED)) + 1 FROM tbl_transaksi", conn)
            da.Fill(ds, "xxx1")
            If ds.Tables("xxx1").Rows.Count > 0 AndAlso ds.Tables("xxx1").Rows(0).Item(0) IsNot DBNull.Value Then
                kodeProduk.Text = ds.Tables("xxx1").Rows(0).Item(0).ToString()
            Else
                kodeProduk.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Gagal mengambil nilai berikutnya: " & ex.Message)
        End Try

        Try
            da = New OdbcDataAdapter("SELECT t.invoice, t.Nama_Pembeli, t.Kode_Produk, t.Jumlah_Beli, k.nama_produk, k.harga_jual FROM tbl_transaksi t INNER JOIN tbl_katalog k ON t.Kode_Produk = k.Kode_Produk", conn)
            da.Fill(ds, "xxx")
            DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        Catch ex As Exception
            MsgBox("Gagal mengambil data dari database: " & ex.Message)
        End Try
        isi_combo()
        totalPembelian.Text = HitungTotalPembelian()
        kodeProduk.Text = ""
        statusProduk.Text = ""
        jumlahPembelian.Text = ""

    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim kodeProdukToUpdate As String = selectedRow.Cells("Kode_Produk").Value.ToString()
            Dim selectedProduct As String = pilihProduk.SelectedItem.ToString()

            If Not String.IsNullOrEmpty(kodeProdukToUpdate) Then
                Try
                    Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                        conn.Open()

                        Dim updateCommand As New OdbcCommand("UPDATE tbl_transaksi SET invoice = ?, Nama_Pembeli = ?, Jumlah_Beli = ? , Nama_Produk = ?, WHERE Kode_Produk = ?", conn)


                        updateCommand.Parameters.AddWithValue("@invoice", idTransaksi.Text)
                        updateCommand.Parameters.AddWithValue("@Nama_Pembeli", namaPembeli.Text)
                        updateCommand.Parameters.AddWithValue("@Jumlah_Beli", jumlahPembelian.Text)
                        updateCommand.Parameters.AddWithValue("@Nama_Produk", selectedProduct)
                        updateCommand.Parameters.AddWithValue("@Kode_Produk", kodeProdukToUpdate)

                        Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                        MsgBox(rowsAffected & " data berhasil diubah")


                        ds.Clear()
                        da = New OdbcDataAdapter("SELECT t.invoice, t.Nama_Pembeli, t.Kode_Produk, t.Jumlah_Beli, k.nama_produk, k.harga_jual FROM tbl_transaksi t INNER JOIN tbl_katalog k ON t.Kode_Produk = k.Kode_Produk", conn)
                        da.Fill(ds, "xxx")
                        totalPembelian.Text = HitungTotalPembelian()
                        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
                    End Using
                Catch ex As Exception
                    MsgBox("Gagal mengubah data: " & ex.Message)
                End Try
            End If
        Else
            MsgBox("Pilih baris yang ingin diubah terlebih dahulu.")
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim kodeprodukToDelete As String = selectedRow.Cells("Kode_Produk").Value.ToString()

                Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                    conn.Open()

                    Dim deleteCommand As New OdbcCommand("DELETE FROM tbl_transaksi WHERE Kode_Produk = ?", conn)
                    deleteCommand.Parameters.AddWithValue("@Kode_Produk", kodeprodukToDelete)
                    deleteCommand.ExecuteNonQuery()


                    ds.Clear()
                    da = New OdbcDataAdapter("SELECT t.invoice, t.Nama_Pembeli, t.Kode_Produk, t.Jumlah_Beli, k.nama_produk, k.harga_jual FROM tbl_transaksi t INNER JOIN tbl_katalog k ON t.Kode_Produk = k.Kode_Produk", conn)
                    da.Fill(ds, "xxx")


                    totalPembelian.Text = HitungTotalPembelian()
                End Using

                MsgBox("Data berhasil dihapus")
            Else
                MsgBox("Pilih baris yang ingin dihapus terlebih dahulu.")
            End If
        Catch ex As Exception
            MsgBox("Gagal menghapus data: " & ex.Message)
        End Try
    End Sub



    Private Sub bersihkan_Click(sender As Object, e As EventArgs) Handles bersihkan.Click
        idTransaksi.Text = ""
        namaPembeli.Text = ""
        kodeProduk.Text = ""
        statusProduk.Text = ""
        totalPembelian.Text = ""
        jumlahPembelian.Text = ""
        isi_combo()
    End Sub

    Private Sub pembayaran_Click(sender As Object, e As EventArgs) Handles pembayaran.Click
        SimpanTotalPembelianKeTransaksi()
        Dim pembayaran As New Pembayaran()
        pembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim beranda As New Beranda()
        beranda.Show()
        Me.Hide()
    End Sub

    Private Function HitungTotalPembelian() As Double
        Dim total As Double = 0

        Try
            Dim query As String = "SELECT SUM(t.Jumlah_Beli * k.harga_jual) AS Total_Pembelian FROM tbl_transaksi t INNER JOIN tbl_katalog k ON t.Kode_Produk = k.Kode_Produk"
            da = New OdbcDataAdapter(query, conn)
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

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim selectedProductName As String = selectedRow.Cells("Nama_Produk").Value.ToString()

            If Not String.IsNullOrEmpty(selectedProductName) Then
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If


                    Dim sqlCommand As New OdbcCommand("SELECT Nama_pembeli, invoice, Kode_Produk, Jumlah_Beli FROM tbl_transaksi WHERE Nama_Produk = ?", conn)
                    sqlCommand.Parameters.AddWithValue("@Nama_Produk", selectedProductName)
                    Dim reader As OdbcDataReader = sqlCommand.ExecuteReader()

                    If reader.Read() Then
                        namaPembeli.Text = reader("Nama_Pembeli").ToString()
                        idTransaksi.Text = reader("invoice").ToString()
                        kodeProduk.Text = reader("Kode_Produk").ToString()
                        jumlahPembelian.Text = reader("Jumlah_Beli").ToString()

                    Else
                        MsgBox("Data tidak ditemukan")
                    End If

                    reader.Close()
                Catch ex As Exception
                    MsgBox("Gagal mengambil data dari database: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MsgBox("Pilih baris yang ingin diubah terlebih dahulu.")
        End If
    End Sub

    Private Sub SimpanTotalPembelianKeTransaksi()
        Try
            Dim totalPembelian As Double = HitungTotalPembelian()

            Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                conn.Open()


                Dim insertQuery As String = "INSERT INTO tbl_total (total) VALUES (?)"

                Using cmd As New OdbcCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("total", totalPembelian)
                    cmd.ExecuteNonQuery()

                    MsgBox("Total pembelian berhasil disimpan ke dalam tabel tbl_transaksi.")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Kesalahan dalam menyimpan total pembelian ke dalam tabel transaksi: " & ex.Message)
        End Try
    End Sub



    Private Sub totalPembelian_TextChanged(sender As Object, e As EventArgs) Handles totalPembelian.TextChanged

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class