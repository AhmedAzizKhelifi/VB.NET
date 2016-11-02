Imports System.Data.SqlClient
Public Class Form4

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim kunci(0) As DataColumn


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Form2.Focus()
        Form2.mnuCekStatus.Enabled = True
        Form2.tsCekStatus.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("select t1.No_Faktur ,t1.Tanggal,  t2.nama_perusahaan,  t3.Maskapai, t1.Berat_Barang, t4.Nama_Kota, t1.Kode_Pesawat, t1.No_Penerbangan, t1.Status from TransaksiPengiriman as t1 , Perusahaan as t2, Pesawat as t3, [Kota Tujuan] as t4 where t1.Kode_Kota = t4.Kode_Kota and t1.Kode_Pesawat = t3.Kode_Pesawat and t1.Kode_Perusahaan = t2.kode_perusahaan", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Transaksi")
        con.Close()

        kunci(0) = ds.Tables("Transaksi").Columns(0)
        ds.Tables("Transaksi").PrimaryKey = kunci
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = txtCari.Text
        baris = ds.Tables("Transaksi").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblTanggal.Text = Format(baris(1), "dd/MM/yyyy")
            lblNamaPerusahaan.Text = baris(2)
            lblMaskapai.Text = baris(3)
            lblBeratBarang.Text = baris(4)
            lblKotaTujuan.Text = baris(5)
            lblKodePesawat.Text = baris(6)
            lblNoPenerbangan.Text = baris(7)
            lblStatus.Text = baris(8)
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = txtCari.Text
            baris = ds.Tables("Transaksi").Rows.Find(cari)

            If baris IsNot Nothing Then
                lblTanggal.Text = Format(baris(1), "dd/MM/yyyy")
                lblNamaPerusahaan.Text = baris(2)
                lblMaskapai.Text = baris(3)
                lblBeratBarang.Text = baris(4)
                lblKotaTujuan.Text = baris(5)
                lblKodePesawat.Text = baris(6)
                lblNoPenerbangan.Text = baris(7)
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Form8.ShowDialog()
    End Sub
End Class