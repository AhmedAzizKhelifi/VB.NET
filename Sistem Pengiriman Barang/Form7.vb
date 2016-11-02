Imports System.Data.SqlClient
Public Class Form7

    Dim con As SqlConnection
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim kunci(0) As DataColumn
    Dim cmd As SqlCommand

    Sub bersih()
        txtJenisPesawat.Clear()
        txtKodePesawat.Clear()
        txtMaskapai.Clear()
        txtKodePesawat.Focus()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtJenisPesawat.Enabled = False
        txtKodePesawat.Enabled = False
        txtMaskapai.Enabled = False
        RadioButton1.Checked = True

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()
        cmd = New SqlCommand("select * from Pesawat", con)

        ad = New SqlDataAdapter(cmd)

        ds = New DataSet
        ad.Fill(ds, "Pesawat")

        kunci(0) = ds.Tables("Pesawat").Columns(0)
        ds.Tables("Pesawat").PrimaryKey = kunci


    End Sub

    Private Sub radTambah_CheckedChanged(sender As Object, e As EventArgs) Handles radTambah.CheckedChanged
        If radTambah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radUbah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radHapus.Checked Then
            txtJenisPesawat.Enabled = False
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = False
        End If
    End Sub

    Private Sub radUbah_CheckedChanged(sender As Object, e As EventArgs) Handles radUbah.CheckedChanged
        If radTambah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radUbah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radHapus.Checked Then
            txtJenisPesawat.Enabled = False
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = False
        End If
    End Sub

    Private Sub radHapus_CheckedChanged(sender As Object, e As EventArgs) Handles radHapus.CheckedChanged
        If radTambah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radUbah.Checked Then
            txtJenisPesawat.Enabled = True
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = True
        ElseIf radHapus.Checked Then
            txtJenisPesawat.Enabled = False
            txtKodePesawat.Enabled = True
            txtMaskapai.Enabled = False
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.Focus()
        Form2.mnuDataPesawat.Enabled = True
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If radTambah.Checked Then
            Dim baris As DataRow
            baris = ds.Tables("Pesawat").NewRow
            baris(0) = UCase(txtKodePesawat.Text)
            baris(1) = txtJenisPesawat.Text
            baris(2) = txtMaskapai.Text
            MsgBox("Berhasil")
            ds.Tables("Pesawat").Rows.Add(baris)
            Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menambahkan Pesawat Kode : " & txtKodePesawat.Text)
            Call bersih()
        ElseIf radUbah.Checked Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = UCase(txtKodePesawat.Text)
            baris = ds.Tables("Pesawat").Rows.Find(cari)

            If baris IsNot Nothing Then
                baris(1) = txtJenisPesawat.Text
                baris(2) = txtMaskapai.Text
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Ubah Pesawat Kode : " & txtKodePesawat.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If

        ElseIf radHapus.Checked Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = UCase(txtKodePesawat.Text)
            baris = ds.Tables("Pesawat").Rows.Find(cari)

            If baris IsNot Nothing Then
                baris.Delete()
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menghapus Pesawat Kode : " & txtKodePesawat.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If
        End If
    End Sub

    Private Sub txtKodePesawat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePesawat.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = UCase(txtKodePesawat.Text)
            baris = ds.Tables("Pesawat").Rows.Find(cari)

            If baris IsNot Nothing Then
                If radTambah.Checked = True Then
                    MsgBox("Kode Pesawat sudah digunakan")
                    Call bersih()
                ElseIf radHapus.Checked = True Then
                    txtJenisPesawat.Text = baris(1)
                    txtMaskapai.Text = baris(2)
                ElseIf radUbah.Checked = True Then
                    txtJenisPesawat.Text = baris(1)
                    txtMaskapai.Text = baris(2)
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

    Private Sub btnKosong_Click(sender As Object, e As EventArgs) Handles btnKosong.Click
        txtJenisPesawat.Clear()
        txtKodePesawat.Clear()
        txtMaskapai.Clear()
        txtKodePesawat.Focus()
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jlh As Integer
        Dim cb As SqlCommandBuilder
        cb = New SqlCommandBuilder(ad)
        ad = cb.DataAdapter
        jlh = ad.Update(ds, "Pesawat")
        MsgBox(jlh & " data berhasil terupdate ke tabel")
    End Sub
End Class