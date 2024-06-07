Imports System.Configuration
Imports System.Data.Odbc

Public Class Beranda
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

    Private Sub katalog_Click(sender As Object, e As EventArgs) Handles katalog.Click
        Dim katalog As New Katalog()
        katalog.Show()
        Me.Hide()
    End Sub

    Private Sub transaksi_Click(sender As Object, e As EventArgs) Handles transaksi.Click
        Dim transaksi As New Transaksi()
        transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Dim laporan As New Laporan()
        laporan.Show()
        Me.Hide()
    End Sub

    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class
