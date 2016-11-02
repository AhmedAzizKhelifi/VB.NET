Imports DMSoft
Imports System.Data.SqlClient
Public Class Form2


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim j As Integer
    Dim r As SqlDataReader
    Dim a As Form2
    Dim SkinOb As SkinCrafter

    Sub skin()
        DMSoft.SkinCrafter.Init()
        SkinOb = New DMSoft.SkinCrafter
        SkinOb.InitDecoration(2)
        SkinOb.LoadSkinFromFile("D:\KULIAH\Tugas Besar Bhs.Prog\Sistem Pengiriman Barang\Desain\x-skin.skf")
        SkinOb.ApplySkin()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call skin()

        Me.IsMdiContainer = True
        a = Me.MdiParent

        AktivitasTerkiniToolStripMenuItem.Checked = True

        If AktivitasTerkiniToolStripMenuItem.Checked = True Then
            Label1.Visible = True
            lstAktivitas.Visible = True
        ElseIf AktivitasTerkiniToolStripMenuItem.Checked = False Then
            Label1.Visible = False
            lstAktivitas.Visible = False
        End If

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        
    End Sub

    Private Sub TutupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTutup.Click, tsTutup.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click, tsKeluar.Click
        Me.Close()
        Form1.Show()
        Form1.txtSandi.Clear()
        Form1.txtNomor.Clear()

    End Sub


    Private Sub mnuPengirimanBarang_Click(sender As Object, e As EventArgs) Handles mnuPengirimanBarang.Click, tsPengirimanBarang.Click
        Dim a As New Form3
        a.MdiParent = Me
        a.Show()
        mnuPengirimanBarang.Enabled = False
        tsPengirimanBarang.Enabled = False
    End Sub


    Private Sub mnuCekStatus_Click(sender As Object, e As EventArgs) Handles mnuCekStatus.Click, tsCekStatus.Click
        Dim a As New Form4
        a.MdiParent = Me
        a.Show()
        mnuCekStatus.Enabled = False
        tsCekStatus.Enabled = False
    End Sub

    Private Sub tsCekKota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tsCekKota.KeyPress
        If e.KeyChar = Chr(13) Then
            If tsPilihan.Text = "Nama Kota" Then
                cmd = New SqlCommand("select Nama_Kota from [Kota Tujuan] where Kode_Kota='" & tsCekKota.Text & "'", con)
                r = cmd.ExecuteReader

                If r.Read Then
                    tsKota.Text = r(0)
                Else
                    tsKota.Text = "Kode Kota Salah"
                End If
                r.Close()
            ElseIf tsPilihan.Text = "Kode Kota" Then
                cmd = New SqlCommand("select Kode_Kota from [Kota Tujuan] where Temp_kota='" & UCase(tsCekKota.Text) & "'", con)
                r = cmd.ExecuteReader

                If r.Read Then
                    tsKota.Text = r(0)
                Else
                    tsKota.Text = "Nama Kota Salah"
                End If
                r.Close()
            End If
        End If
    End Sub

    Private Sub mnuDataBandara_Click(sender As Object, e As EventArgs) Handles mnuDataBandara.Click
        Dim a As New Form5
        a.MdiParent = Me
        a.Show()
        mnuDataBandara.Enabled = False
    End Sub

    Private Sub mnuDataPelanggan_Click(sender As Object, e As EventArgs) Handles mnuDataPelanggan.Click
        Dim a As New Form6
        a.MdiParent = Me
        a.Show()
        mnuDataPelanggan.Enabled = False
    End Sub

    Private Sub mnuDataPesawat_Click(sender As Object, e As EventArgs) Handles mnuDataPesawat.Click
        Dim a As New Form7
        a.MdiParent = Me
        a.Show()
        mnuDataPesawat.Enabled = False
    End Sub

    Private Sub AktivitasTerkiniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktivitasTerkiniToolStripMenuItem.Click
        If AktivitasTerkiniToolStripMenuItem.Checked = True Then
            Label1.Visible = False
            lstAktivitas.Visible = False
            AktivitasTerkiniToolStripMenuItem.Checked = False
        ElseIf AktivitasTerkiniToolStripMenuItem.Checked = False Then
            Label1.Visible = True
            lstAktivitas.Visible = True
            AktivitasTerkiniToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub tsKosong_Click(sender As Object, e As EventArgs)
        If Form5.txtKodeKota.Focus = True Then
            Form5.txtKodeKota.Clear()
            Form5.txtNamaBandara.Clear()
            Form5.txtNamaKota.Clear()
            Form5.RadioButton1.Checked = True
        End If
        'Dim z As Form5

        'For Each z In Me.MdiChildren
        '    If Form5 Is ActiveMdiChild = True Then
        '        Form5.txtKodeKota.Clear()
        '        Form5.txtNamaBandara.Clear()
        '        Form5.txtNamaKota.Clear()
        '        Form5.RadioButton1.Checked = True
        '    End If
        'Next

        'If Form3 Is ActiveMdiChild Then
        '    Form3.txtBerat.Clear()
        '    Form3.txtDibayar.Clear()
        '    Form3.txtKodePerusahaan.Clear()
        '    Form3.txtKodePesawat.Clear()
        '    Form3.txtKodeTujuan.Clear()
        '    Form3.txtNomorPenerbangan.Clear()
        '    Form3.lblBiaya.Text = "0"
        '    Form3.lblKembalian.Text = "0"
        '    Form3.lblMaskapai.Text = "Maskapai"
        '    Form3.lblNamaBandara.Text = "Bandara"
        '    Form3.lblNamaPerusahaan.Text = "Perusahaan"
        '    Form3.cboJenisPenerbangan.SelectedIndex = -1
        '    Form3.txtKodePerusahaan.Focus()
        'ElseIf Form4 Is ActiveMdiChild Then
        '    Form4.txtCari.Clear()
        '    Form4.lblBeratBarang.Text = ""
        '    Form4.lblKotaTujuan.Text = ""
        '    Form4.lblMaskapai.Text = ""
        '    Form4.lblNamaPerusahaan.Text = ""
        '    Form4.lblTanggal.Text = ""
        'End If
    End Sub

    Private Sub HargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HargaToolStripMenuItem.Click
        Dim a As New Harga
        a.MdiParent = Me
        a.Show()
        HargaToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LaporanNamaKonsumenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanNamaKonsumenToolStripMenuItem.Click
        Dim ad As SqlDataAdapter
        Dim ds As DataSet
        Dim cr As New CrystalReport2
        Dim pre As New CrystalReport

        cmd = New SqlCommand("Select * from Perusahaan", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Perusahaan")
       
        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
    End Sub

    Private Sub LaporanPesawatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPesawatToolStripMenuItem.Click
        Dim a As New LaporanPesawat
        a.MdiParent = Me
        a.Show()
        LaporanPesawatToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LaporanKotaTujuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKotaTujuanToolStripMenuItem.Click
        Dim hd As SqlDataAdapter
        Dim dz As DataSet
        Dim cr As New CrystalReport4
        Dim pre As New CrystalReport

        cmd = New SqlCommand("select Kode_Kota, Nama_Kota, Nama_Bandara from [Kota Tujuan]", con)
        hd = New SqlDataAdapter(cmd)
        dz = New DataSet
        hd.Fill(dz, "Kota Tujuan")

        cr.SetDataSource(dz)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.Show()
    End Sub

    Private Sub LaporanBiayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBiayaToolStripMenuItem.Click
        Dim hd, hq As SqlDataAdapter
        Dim dz As DataSet
        Dim cr As New CrystalReport6
        Dim pre As New CrystalReport

        cmd = New SqlCommand("select Kode_Kota, Nama_Kota, Harga from [Kota Tujuan]", con)
        hd = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * from Pajak", con)
        hq = New SqlDataAdapter(cmd)

        dz = New DataSet
        hd.Fill(dz, "Harga")
        hq.Fill(dz, "Pajak")

        cr.SetDataSource(dz)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
    End Sub

    Private Sub LaporanPresentasPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPresentasPajakToolStripMenuItem.Click
        Dim hq As SqlDataAdapter
        Dim dz As DataSet
        Dim cr As New CrystalReport7
        Dim pre As New CrystalReport

        cmd = New SqlCommand("Select * from Pajak", con)
        hq = New SqlDataAdapter(cmd)

        dz = New DataSet
        hq.Fill(dz, "Pajak")

        cr.SetDataSource(dz)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()

    End Sub

    Private Sub LaporanPengirimanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPengirimanToolStripMenuItem.Click
        PelayananCargo.Show()
    End Sub

    Private Sub TampilanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilanToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SkinOb.LoadSkinFromFile(OpenFileDialog1.FileName)
        End If
        SkinOb.ApplySkin()
    End Sub
End Class