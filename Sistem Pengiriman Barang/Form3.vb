Imports System.Data.SqlClient
Public Class Form3

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adPswt, adKota, adPerusahaan, adTransaksi, adPajak, adCR As SqlDataAdapter
    Dim ds, dos As DataSet
    Dim PKpswt(0), PKkota(0), PKperusahaan(0), PKtransaksi(0), PKpajak(0) As DataColumn
    Dim pajak, harga, h As Double
    Dim hj As String

    Sub bersih()
        txtKodePerusahaan.Focus()
        txtBerat.Clear()
        txtDibayar.Clear()
        txtKodePerusahaan.Clear()
        txtKodePesawat.Clear()
        txtKodeTujuan.Clear()
        txtNomorPenerbangan.Clear()
        lblBiaya.Text = "0"
        lblKembalian.Text = "0"
        lblMaskapai.Text = "Maskapai"
        lblNamaBandara.Text = "Bandara"
        lblNamaPerusahaan.Text = "Perusahaan"
        cboJenisPenerbangan.SelectedIndex = -1
        lblNoFaktur.Text = ""
    End Sub

    Sub updateDS()
        Dim jlh As Integer
        Dim cb As SqlCommandBuilder
        cb = New SqlCommandBuilder(adTransaksi)
        adTransaksi = cb.DataAdapter
        jlh = adTransaksi.Update(ds, "Transaksi")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Form2.Focus()
        Form2.mnuPengirimanBarang.Enabled = True
        Form2.tsPengirimanBarang.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("Select * From Perusahaan", con)
        adPerusahaan = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * From Pesawat", con)
        adPswt = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * from Pajak", con)
        adPajak = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * from [Kota Tujuan]", con)
        adKota = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * from TransaksiPengiriman", con)
        adTransaksi = New SqlDataAdapter(cmd)

        ds = New DataSet
        adKota.Fill(ds, "Kota")
        adPerusahaan.Fill(ds, "Perusahaan")
        adPswt.Fill(ds, "Pesawat")
        adTransaksi.Fill(ds, "Transaksi")
        adPajak.Fill(ds, "Pajak")
        con.Close()

        PKkota(0) = ds.Tables("Kota").Columns(0)
        ds.Tables("Kota").PrimaryKey = PKkota

        PKperusahaan(0) = ds.Tables("Perusahaan").Columns(0)
        ds.Tables("Perusahaan").PrimaryKey = PKperusahaan

        PKpswt(0) = ds.Tables("Pesawat").Columns(0)
        ds.Tables("Pesawat").PrimaryKey = PKpswt

        PKtransaksi(0) = ds.Tables("Transaksi").Columns(0)
        ds.Tables("Transaksi").PrimaryKey = PKtransaksi

        PKpajak(0) = ds.Tables("Pajak").Columns(0)
        ds.Tables("Pajak").PrimaryKey = PKpajak

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim baris As DataRow
        baris = ds.Tables("Transaksi").NewRow
        baris(0) = lblNoFaktur.Text
        baris(1) = UCase(txtKodePerusahaan.Text)
        baris(2) = UCase(txtKodePesawat.Text)
        baris(3) = UCase(txtNomorPenerbangan.Text)
        baris(4) = cboJenisPenerbangan.Text
        baris(5) = Val(txtBerat.Text)
        baris(6) = txtKodeTujuan.Text
        baris(7) = h
        baris(8) = Now.Date.Date
        baris(9) = "Tunggu"
        ds.Tables("Transaksi").Rows.Add(baris)
        MsgBox("Berhasil")
        Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Transaksi Pengiriman Kode : " & lblNoFaktur.Text)
        hj = lblNoFaktur.Text
        Call updateDS()

        cmd = New SqlCommand("select t1.No_Faktur,  t1.Kode_Perusahaan,t1.Kode_Pesawat , t1.Berat_Barang, t1.Total, t2.Nama_Kota from TransaksiPengiriman as t1, [Kota Tujuan] as t2, Perusahaan as t3 where t1.Kode_Kota = t2.Kode_Kota and t1.Kode_Perusahaan = t3.Kode_Perusahaan and  t1.No_Faktur='" & lblNoFaktur.Text & "'", con)

        adCR = New SqlDataAdapter(cmd)
        dos = New DataSet
        adCR.Fill(dos, "TransaksiPengiriman")
        con.Close()
        Dim cr As New CrystalReport1
        Dim pre As New CrystalReport

        cr.SetDataSource(dos)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
        Call bersih()
    End Sub

    Private Sub txtKodePerusahaan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePerusahaan.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim x As Integer
            x = ds.Tables("Transaksi").Rows.Count
            lblNoFaktur.Text = 110000000 + x + 1
            hj = 110000000 + x + 1
        End If
    End Sub

    Private Sub txtKodePerusahaan_LostFocus(sender As Object, e As EventArgs) Handles txtKodePerusahaan.LostFocus
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = UCase(txtKodePerusahaan.Text)
        baris = ds.Tables("Perusahaan").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblNamaPerusahaan.Text = baris(1)
        Else
            lblNamaPerusahaan.Text = "Perusahaan tidak terdaftar"
            txtKodePerusahaan.Clear()
            txtKodePerusahaan.Focus()
        End If

    End Sub

    Private Sub txtKodePesawat_LostFocus(sender As Object, e As EventArgs) Handles txtKodePesawat.LostFocus
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = UCase(txtKodePesawat.Text)
        baris = ds.Tables("Pesawat").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblMaskapai.Text = baris(2)
        Else
            lblMaskapai.Text = "Pesawat tidak terdaftar"
            txtKodePesawat.Clear()
            txtKodePesawat.Focus()
        End If
    End Sub

    Private Sub cboJenisPenerbangan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboJenisPenerbangan.SelectedValueChanged
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = cboJenisPenerbangan.Text
        baris = ds.Tables("Pajak").Rows.Find(cari)

        If baris IsNot Nothing Then
            pajak = baris(1) / 100
        End If
    End Sub

    Private Sub txtKodeTujuan_LostFocus(sender As Object, e As EventArgs) Handles txtKodeTujuan.LostFocus
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = txtKodeTujuan.Text
        baris = ds.Tables("Kota").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblNamaBandara.Text = baris(2)
            harga = Val(baris(4))
        Else
            lblNamaBandara.Text = "Kode Kota Salah"
            txtKodeTujuan.Focus()
        End If
    End Sub

    Private Sub txtBerat_TextChanged(sender As Object, e As EventArgs) Handles txtBerat.TextChanged
        Dim z, x, biaya As Double
        z = Val(txtBerat.Text) * harga
        x = z * pajak
        biaya = x + z
        h = biaya
        lblBiaya.Text = Format(biaya, "0,000")

    End Sub

    Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
        Dim z As Double
        z = Val(txtDibayar.Text) - h
        lblKembalian.Text = Format(z, "0,000")
    End Sub

   End Class