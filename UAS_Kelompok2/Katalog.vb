Imports System.Configuration
Imports System.Data.Odbc
Public Class Katalog
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dr As OdbcDataReader
    Dim cmd As OdbcCommand
    Private Sub Katalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM tbl_katalog", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub
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

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If conn Is Nothing Then
            MsgBox("Koneksi belum diinisialisasi.")
            Return
        End If

        Dim OdbcCommand As New OdbcCommand()

        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Gagal membuka koneksi: " & ex.Message)
                Return
            End Try
        End If

        OdbcCommand.Connection = conn
        OdbcCommand.CommandText = "INSERT INTO tbl_katalog (Kode_Produk, Nama_Produk, Jenis_Produk, Stok_Produk, Harga_Jual, Harga_Beli) VALUES (?, ?, ?, ?, ?, ?)"
        OdbcCommand.Parameters.AddWithValue("@Kode_Produk", kodeProduk.Text)
        OdbcCommand.Parameters.AddWithValue("@Nama_Produk", namaProduk.Text)
        OdbcCommand.Parameters.AddWithValue("@Jenis_Produk", jenisProduk.Text)
        OdbcCommand.Parameters.AddWithValue("@Stok_Produk", stokProduk.Text)
        OdbcCommand.Parameters.AddWithValue("@Harga_Jual", hargaJual.Text)
        OdbcCommand.Parameters.AddWithValue("@Harga_Beli", hargaBeli.Text)

        Try
            OdbcCommand.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ds.Clear()

        Try
            da = New OdbcDataAdapter("SELECT MAX(CAST(Kode_Produk AS SIGNED)) + 1 FROM tbl_katalog", conn)
            da.Fill(ds, "xxx1")
            If ds.Tables("xxx1").Rows.Count > 0 AndAlso ds.Tables("xxx1").Rows(0).Item(0) IsNot DBNull.Value Then
                kodeProduk.Text = ds.Tables("xxx1").Rows(0).Item(0).ToString()
            Else
                kodeProduk.Text = "1" ' Atur nilai default jika tabel kosong.
            End If
        Catch ex As Exception
            MsgBox("Gagal mengambil nilai berikutnya: " & ex.Message)
        End Try

        Try
            da = New OdbcDataAdapter("SELECT Kode_Produk, Nama_Produk, Jenis_Produk, Stok_Produk, Harga_Jual, Harga_Beli FROM tbl_katalog", conn)
            da.Fill(ds, "xxx")
            DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        Catch ex As Exception
            MsgBox("Gagal mengambil data dari database: " & ex.Message)
        End Try

        kodeProduk.Text = ""
        namaProduk.Text = ""
        jenisProduk.Text = ""
        stokProduk.Text = ""
        hargaJual.Text = ""
        hargaBeli.Text = ""
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

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim kodeprodukToDelete As String = selectedRow.Cells("Kode_Produk").Value.ToString()

            Dim OdbcCommand As New OdbcCommand()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            OdbcCommand.Connection = conn
            OdbcCommand.CommandText = "DELETE FROM tbl_katalog WHERE Kode_Produk = ?"
            OdbcCommand.Parameters.AddWithValue("@Kode_Produk", kodeprodukToDelete)

            Try
                OdbcCommand.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message)
            Finally
                conn.Close()
            End Try

            ds.Clear()
            da = New OdbcDataAdapter("SELECT  Kode_Produk, Nama_Produk, Jenis_Produk, Stok_Produk, Harga_Jual, Harga_Beli FROM tbl_katalog", conn)
            da.Fill(ds, "xxx")
        Else
            MsgBox("Pilih baris yang ingin dihapus terlebih dahulu.")
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim kodeprodukToUpdate As String = selectedRow.Cells("Kode_Produk").Value.ToString()

            If Not String.IsNullOrEmpty(kodeprodukToUpdate) Then
                Dim OdbcCommand As New OdbcCommand()

                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                OdbcCommand.Connection = conn
                OdbcCommand.CommandText = "UPDATE tbl_katalog SET Nama_Produk = ?, Jenis_Produk = ?, Stok_Produk = ?, Harga_Jual = ?, Harga_Beli = ? WHERE Kode_Produk = ?"
                OdbcCommand.Parameters.AddWithValue("@Nama_Produk", namaProduk.Text)
                OdbcCommand.Parameters.AddWithValue("@Jenis_Produk", jenisProduk.Text)
                OdbcCommand.Parameters.AddWithValue("@Stok_Produk", stokProduk.Text)
                OdbcCommand.Parameters.AddWithValue("@Harga_Jual", hargaJual.Text)
                OdbcCommand.Parameters.AddWithValue("@Harga_Beli", hargaBeli.Text)
                OdbcCommand.Parameters.AddWithValue("@Kode_Produk", kodeprodukToUpdate)

                Try
                    OdbcCommand.ExecuteNonQuery()
                    MsgBox("Data berhasil diubah")
                Catch ex As Exception
                    MsgBox("Gagal mengubah data: " & ex.Message)
                Finally
                    conn.Close()
                End Try

                ' Refresh your dataset after the update
                ds.Clear()
                Try
                    da = New OdbcDataAdapter("SELECT Kode_Produk, Nama_Produk, Jenis_Produk, Stok_Produk, Harga_Jual, Harga_Beli FROM tbl_katalog", conn)
                    da.Fill(ds, "xxx")
                    DataGridView1.DataSource = ds.Tables("xxx").DefaultView
                Catch ex As Exception
                    MsgBox("Gagal mengambil data dari database: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub bersihkan_Click(sender As Object, e As EventArgs) Handles bersihkan.Click
        kodeProduk.Text = ""
        namaProduk.Text = ""
        jenisProduk.Text = ""
        stokProduk.Text = ""
        hargaJual.Text = ""
        hargaBeli.Text = ""
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim beranda As New Beranda()
        beranda.Show()
        Me.Hide()
    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim kodeprodukToUpdate As String = selectedRow.Cells("Kode_Produk").Value.ToString()
        If Not String.IsNullOrEmpty(kodeprodukToUpdate) Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Try
                Dim OdbcCommand As New OdbcCommand("SELECT Nama_Produk, Jenis_Produk, Stok_Produk, Harga_Jual, Harga_Beli FROM tbl_katalog WHERE Kode_Produk = ?", conn)
                OdbcCommand.Parameters.AddWithValue("@Kode_Produk", kodeprodukToUpdate)

                Dim reader As OdbcDataReader = OdbcCommand.ExecuteReader()

                If reader.Read() Then

                    namaProduk.Text = reader("Nama_Produk").ToString()
                    jenisProduk.Text = reader("Jenis_Produk").ToString()
                    stokProduk.Text = reader("Stok_Produk").ToString()
                    hargaJual.Text = reader("Harga_Jual").ToString()
                    hargaBeli.Text = reader("Harga_Beli").ToString()
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class
