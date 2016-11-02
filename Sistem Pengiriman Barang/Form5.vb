Imports System.Data.SqlClient
Public Class Form5

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim ds As DataSet
    Dim kunci(0) As DataColumn

    Sub bersih()
        txtKodeKota.Clear()
        txtNamaBandara.Clear()
        txtNamaKota.Clear()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.mnuDataBandara.Enabled = True
        Form2.Focus()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Label4.Visible = False
        txtKodeKota.Enabled = False
        txtNamaBandara.Enabled = False
        txtNamaKota.Enabled = False

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("select * from [Kota Tujuan]", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Tujuan")
        con.Close()

        kunci(0) = ds.Tables("Tujuan").Columns(0)
        ds.Tables("Tujuan").PrimaryKey = kunci

    End Sub

    Private Sub radTambah_CheckedChanged(sender As Object, e As EventArgs) Handles radTambah.CheckedChanged
        If radTambah.Checked = True Then
            Label4.Visible = True
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
            txtKodeKota.Enabled = True
        ElseIf radUbah.Checked = True Then
            Label4.Visible = False
            txtKodeKota.Enabled = True
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
        ElseIf radHapus.Checked = True Then
            Label4.Visible = False
            txtNamaBandara.Enabled = False
            txtNamaKota.Enabled = False
            txtKodeKota.Enabled = True
        End If
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If radTambah.Checked = True Then
            Dim baris As DataRow
            baris = ds.Tables("Tujuan").NewRow
            baris(0) = txtKodeKota.Text
            baris(1) = txtNamaKota.Text
            baris(2) = txtNamaBandara.Text
            baris(3) = UCase(txtNamaKota.Text)
            baris(4) = 0
            ds.Tables("Tujuan").Rows.Add(baris)
            MsgBox("Berhasil")
            Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menambahkan Kota Kode : " & txtKodeKota.Text)
            Call bersih()
        ElseIf radHapus.Checked = True Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeKota.Text
            baris = ds.Tables("Tujuan").Rows.Find(cari)
            If baris IsNot Nothing Then
                baris.Delete()
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menghapus Kota Kode : " & txtKodeKota.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If
        ElseIf radUbah.Checked = True Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeKota.Text
            baris = ds.Tables("Tujuan").Rows.Find(cari)
            If baris IsNot Nothing Then
                baris(1) = txtNamaKota.Text
                baris(2) = txtNamaBandara.Text
                baris(3) = UCase(txtNamaKota.Text)
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Ubah Kota Kode : " & txtKodeKota.Text)
                Call bersih()
            Else
                MsgBox("Data tidak ditemukan")
                Call bersih()
            End If
        End If

        'If radTambah.Checked = True Then
        '    Dim baris As DataRow
        '    baris = ds.Tables("Tujuan").NewRow
        '    baris(0) = txtKodeKota.Text
        '    baris(1) = txtNamaKota.Text
        '    baris(2) = txtNamaBandara.Text
        '    baris(3) = UCase(txtNamaKota.Text)
        '    ds.Tables("Tujuan").Rows.Add(baris)
        '    MsgBox("Berhasil")
        '    Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menambahkan Kota Kode : " & txtKodeKota.Text)
        '    Call bersih()
        'ElseIf radHapus.Checked = True Then
        '    Dim baris As DataRow
        '    Dim cari(0) As String

        '    cari(0) = txtKodeKota.Text
        '    baris = ds.Tables("Tujuan").Rows.Find(cari)
        '    If baris IsNot Nothing Then
        '        baris.Delete()
        '        MsgBox("Berhasil")
        '        Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Menghapus Kota Kode : " & txtKodeKota.Text)
        '        Call bersih()
        '    Else
        '        MsgBox("Data tidak ditemukan")
        '        Call bersih()
        '    End If
        'ElseIf radUbah.Checked = True Then
        '    Dim baris As DataRow
        '    Dim cari(0) As String

        '    cari(0) = txtKodeKota.Text
        '    baris = ds.Tables("Tujuan").Rows.Find(cari)
        '    If baris IsNot Nothing Then
        '        baris(1) = txtNamaKota.Text
        '        baris(2) = txtNamaBandara.Text
        '        baris(3) = UCase(txtNamaKota.Text)
        '        MsgBox("Berhasil")
        '        Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Ubah Kota Kode : " & txtKodeKota.Text)
        '        Call bersih()
        '    Else
        '        MsgBox("Data tidak ditemukan")
        '        Call bersih()
        '    End If
        'End If
    End Sub

    Private Sub radUbah_CheckedChanged(sender As Object, e As EventArgs) Handles radUbah.CheckedChanged
        If radTambah.Checked = True Then
            btnOk.Enabled = True
            Label4.Visible = True
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
            txtKodeKota.Enabled = True
        ElseIf radUbah.Checked = True Then
            txtKodeKota.Enabled = True
            btnOk.Enabled = True
            Label4.Visible = False
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
        ElseIf radHapus.Checked = True Then
            btnOk.Enabled = True
            txtKodeKota.Enabled = True
            Label4.Visible = False
            txtNamaBandara.Enabled = False
            txtNamaKota.Enabled = False
        End If

    End Sub

    Private Sub radHapus_CheckedChanged(sender As Object, e As EventArgs) Handles radHapus.CheckedChanged
        If radTambah.Checked = True Then
            Label4.Visible = True
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
            txtKodeKota.Enabled = True
        ElseIf radUbah.Checked = True Then
            Label4.Visible = False
            txtNamaBandara.Enabled = True
            txtNamaKota.Enabled = True
            txtKodeKota.Enabled = True
        ElseIf radHapus.Checked = True Then
            Label4.Visible = False
            txtNamaBandara.Enabled = False
            txtNamaKota.Enabled = False
            txtKodeKota.Enabled = True
        End If

    End Sub

    Private Sub txtKodeKota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeKota.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String

            cari(0) = txtKodeKota.Text
            baris = ds.Tables("Tujuan").Rows.Find(cari)
            If baris IsNot Nothing Then
                If radTambah.Checked Then
                    MsgBox("Kode Kota sudah digunakan")
                    txtKodeKota.Clear()
                Else
                    txtNamaKota.Text = baris(1)
                    txtNamaBandara.Text = baris(2)
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
        txtKodeKota.Focus()
        txtKodeKota.Clear()
        txtNamaBandara.Clear()
        txtNamaKota.Clear()
        RadioButton1.Checked = True
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jlh As Integer
        Dim cb As SqlCommandBuilder
        cb = New SqlCommandBuilder(ad)
        ad = cb.DataAdapter
        jlh = ad.Update(ds, "Tujuan")
        MsgBox(jlh & " data berhasil terupdate ke tabel")
    End Sub
End Class