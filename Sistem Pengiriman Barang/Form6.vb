Imports System.Data.SqlClient
Public Class Form6

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim kunci(0) As DataColumn

    Sub bersih()
        txtKodeperusahaan.Clear()
        txtAlamat.Clear()
        txtNamaPerusahaan.Clear()
        txtNoTelp.Clear()
    End Sub

   

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKodeperusahaan.Enabled = False
        txtNamaPerusahaan.Enabled = False
        txtAlamat.Enabled = False
        txtNoTelp.Enabled = False

        RadioButton1.Checked = True
        Label5.Visible = False
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("select * from Perusahaan", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Perusahaan")
        con.Close()

        kunci(0) = ds.Tables("Perusahaan").Columns(0)
        ds.Tables("Perusahaan").PrimaryKey = kunci
    End Sub

    Private Sub radTambah_CheckedChanged(sender As Object, e As EventArgs) Handles radTambah.CheckedChanged
        If radHapus.Checked = True Then
            txtAlamat.Enabled = False
            txtNamaPerusahaan.Enabled = False
            txtNoTelp.Enabled = False
            Label5.Visible = False
            txtKodeperusahaan.Enabled = True
        ElseIf radTambah.Checked = True Then
            txtKodeperusahaan.Enabled = True
            txtAlamat.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtNoTelp.Enabled = True
            Label5.Visible = True
        ElseIf radUbah.Checked Then
            txtKodeperusahaan.Enabled = True
            txtAlamat.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtNoTelp.Enabled = True
            Label5.Visible = False
        End If
    End Sub

    Private Sub radUbah_CheckedChanged(sender As Object, e As EventArgs) Handles radUbah.CheckedChanged
        If radHapus.Checked = True Then
            txtAlamat.Enabled = False
            txtKodeperusahaan.Enabled = True
            txtNamaPerusahaan.Enabled = False
            txtNoTelp.Enabled = False
            Label5.Visible = False
        ElseIf radTambah.Checked = True Then
            txtAlamat.Enabled = True
            txtKodeperusahaan.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtNoTelp.Enabled = True
            Label5.Visible = True
        ElseIf radUbah.Checked Then
            txtAlamat.Enabled = True
            txtKodeperusahaan.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtNoTelp.Enabled = True
            Label5.Visible = False
        End If
    End Sub

    Private Sub radHapus_CheckedChanged(sender As Object, e As EventArgs) Handles radHapus.CheckedChanged
        If radHapus.Checked = True Then
            txtAlamat.Enabled = False
            txtKodeperusahaan.Enabled = True
            txtNamaPerusahaan.Enabled = False
            txtNoTelp.Enabled = False
            Label5.Visible = False
        ElseIf radTambah.Checked = True Then
            txtAlamat.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtKodeperusahaan.Enabled = True
            txtNoTelp.Enabled = True
            Label5.Visible = True
        ElseIf radUbah.Checked Then
            txtAlamat.Enabled = True
            txtNamaPerusahaan.Enabled = True
            txtNoTelp.Enabled = True
            txtKodeperusahaan.Enabled = True
            Label5.Visible = False
        End If
    End Sub

    Private Sub txtKodeperusahaan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeperusahaan.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeperusahaan.Text
            baris = ds.Tables("Perusahaan").Rows.Find(cari)
            If baris IsNot Nothing Then
                If radTambah.Checked = True Then
                    MsgBox("Kode Perusahaan sudah digunakan")
                    txtKodeperusahaan.Clear()
                ElseIf radHapus.Checked = True Then
                    txtNamaPerusahaan.Text = baris(1)
                    txtAlamat.Text = baris(2)
                    txtNoTelp.Text = baris(3)
                ElseIf radUbah.Checked = True Then
                    txtNamaPerusahaan.Text = baris(1)
                    txtAlamat.Text = baris(2)
                    txtNoTelp.Text = baris(3)
                End If
            Else
                If radHapus.Checked Or radUbah.Checked Then
                    MsgBox("Data tidak ditemukan")
                    Call bersih()
                Else
                    MsgBox("Data tidak ditemukan")

                End If
            End If
        End If
    End Sub

    Private Sub btnPost_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click
        If radTambah.Checked Then
            Dim baris As DataRow
            baris = ds.Tables("Perusahaan").NewRow
            baris(0) = txtKodeperusahaan.Text
            baris(1) = txtNamaPerusahaan.Text
            baris(2) = txtAlamat.Text
            baris(3) = txtNoTelp.Text
            ds.Tables("Perusahaan").Rows.Add(baris)
            MsgBox("Berhasil")
            Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menambah Perusahaan Kode : " & txtKodeperusahaan.Text)
            Call bersih()
        ElseIf radUbah.Checked Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeperusahaan.Text
            baris = ds.Tables("Perusahaan").Rows.Find(cari)
            If baris IsNot Nothing Then
                baris(1) = txtNamaPerusahaan.Text
                baris(2) = txtAlamat.Text
                baris(3) = txtNoTelp.Text
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Ubah Perusahaan Kode : " & txtKodeperusahaan.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If
        ElseIf radHapus.Checked Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeperusahaan.Text
            baris = ds.Tables("Perusahaan").Rows.Find(cari)
            If baris IsNot Nothing Then
                baris.Delete()
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menghapus Perusahaan Kode : " & txtKodeperusahaan.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click_1(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.Focus()
        Form2.mnuDataPelanggan.Enabled = True
    End Sub

    Private Sub btnKosong_Click(sender As Object, e As EventArgs) Handles btnKosong.Click
        txtKodeperusahaan.Focus()
        txtKodeperusahaan.Clear()
        txtAlamat.Clear()
        txtNoTelp.Clear()
        txtNamaPerusahaan.Clear()
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jlh As Integer
        Dim cb As SqlCommandBuilder
        cb = New SqlCommandBuilder(ad)
        ad = cb.DataAdapter
        jlh = ad.Update(ds, "Perusahaan")
        MsgBox(jlh & " data berhasil terupdate ke tabel")
    End Sub
End Class