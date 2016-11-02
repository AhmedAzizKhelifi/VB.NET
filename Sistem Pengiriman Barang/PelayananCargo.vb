Imports System.Data.SqlClient
Public Class PelayananCargo

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim ds As DataSet

    Private Sub PelayananCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("select t1.No_Faktur,  t1.Kode_Perusahaan,t1.Kode_Pesawat , t1.Berat_Barang, t1.Total,t1.Tanggal, t2.Nama_Kota, t3.Maskapai from TransaksiPengiriman as t1, [Kota Tujuan] as t2, Pesawat as t3 where t1.Kode_Kota = t2.Kode_Kota and t1.Kode_Pesawat = t3.Kode_Pesawat", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Transaksi_Pengiriman")
        con.Close()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.Focus()
    End Sub

    Private Sub btnTampil1_Click(sender As Object, e As EventArgs) Handles btnTampil1.Click
        If dtpSampai.Value < dtpDari.Value Then
            MsgBox("Tanggal Awal Harus lebih Kecil dari Tanggal Akhir")
        Else
            Dim cr As New CrystalReport5
            Dim pre As New CrystalReport

            cr.SetDataSource(ds)
            pre.CrystalReportViewer1.ReportSource = cr
            pre.CrystalReportViewer1.SelectionFormula = "{Transaksi_Pengiriman.Tanggal} in Date('" & Format(dtpDari.Value, "yyyy-MM-dd") & "') to Date('" & Format(dtpSampai.Value, "yyyy-MM-dd") & "')"
            pre.WindowState = FormWindowState.Maximized
            pre.ShowDialog()
        End If
        
    End Sub

    Private Sub btnTampil2_Click(sender As Object, e As EventArgs) Handles btnTampil2.Click
        Dim cr As New CrystalReport5
        Dim pre As New CrystalReport

        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.CrystalReportViewer1.SelectionFormula = "{Transaksi_Pengiriman.Nama_Kota} = '" & txtNamaKota.Text & "'"
        pre.WindowState = FormWindowState.Maximized
        pre.Show()
    End Sub

    Private Sub btnTampil3_Click(sender As Object, e As EventArgs) Handles btnTampil3.Click
        Dim cr As New CrystalReport5
        Dim pre As New CrystalReport

        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.CrystalReportViewer1.SelectionFormula = "{Transaksi_Pengiriman.Maskapai} = '" & txtNamaMaskapai.Text & "'"
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
    End Sub

    Private Sub btnTampil4_Click(sender As Object, e As EventArgs) Handles btnTampil4.Click
        Dim cr As New CrystalReport5
        Dim pre As New CrystalReport

        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.CrystalReportViewer1.SelectionFormula = "{Transaksi_Pengiriman.Kode_Pesawat} = '" & UCase(txtKodePesawat.Text) & "'"
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
    End Sub
End Class