Imports System.Configuration
Imports System.Data.Odbc

Public Class Pembayaran
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

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilkanIDTransaksi()
        Total()

    End Sub


    Private Sub Total()
        Try
            Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                conn.Open()


                Dim query As String = "SELECT MAX(total) AS MaxID FROM tbl_total"

                Using cmd As New OdbcCommand(query, conn)
                    Dim total As Object = cmd.ExecuteScalar()

                    If total IsNot DBNull.Value Then

                        tbototalPembelian.Text = total.ToString()
                    Else

                        tbototalPembelian.Text = "Tidak ada ID Transaksi"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Kesalahan dalam menampilkan ID transaksi: " & ex.Message)
        End Try
    End Sub

    Private Sub TampilkanIDTransaksi()
        Try
            Using conn As New OdbcConnection("dsn=dsn_amn;Database=database_amn;Uid=root;Pwd=")
                conn.Open()


                Dim query As String = "SELECT MAX(invoice) AS MaxID FROM tbl_transaksi"

                Using cmd As New OdbcCommand(query, conn)
                    Dim idTransaksi As Object = cmd.ExecuteScalar()

                    If idTransaksi IsNot DBNull.Value Then

                        tboidtransaksi.Text = idTransaksi.ToString()
                    Else

                        tboidtransaksi.Text = "Tidak ada ID Transaksi"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Kesalahan dalam menampilkan ID transaksi: " & ex.Message)
        End Try
    End Sub

    Sub bayar1()
        Try
            TampilkanIDTransaksi()
            Dim idTransaksi As String = tboidtransaksi.Text
            If idTransaksi <> "Tidak ada ID Transaksi" Then
                MessageBox.Show("Pembayaran berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tidak dapat melanjutkan proses pembayaran karena tidak ada ID transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try

            Dim totalPembelian As Decimal = Convert.ToDecimal(tbototalPembelian.Text)
            Dim nominal As Decimal = Convert.ToDecimal(tbonominal.Text)


            Dim kembalian As Decimal = nominal - totalPembelian



            tbokembalian.Text = kembalian.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub bayar_Click(sender As Object, e As EventArgs) Handles bayar.Click
        bayar1()
    End Sub

    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        Dim transaksi As New Transaksi()
        transaksi.Show()
        Me.Hide()
    End Sub


    Sub Simpan()

    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click

        Dim beranda As New Beranda()
        beranda.Show()
        Me.Hide()
    End Sub
End Class
