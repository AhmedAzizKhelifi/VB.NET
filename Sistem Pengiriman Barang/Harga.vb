Imports System.Data.SqlClient
Public Class Harga

    Dim con As SqlConnection
    Dim adKota As SqlDataAdapter
    Dim adPajak As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim kunciKota(0) As DataColumn
    Dim kunciPajak(0) As DataColumn
    Dim ds As DataSet

    Private Sub radHarga_CheckedChanged(sender As Object, e As EventArgs) Handles radHarga.CheckedChanged
        If radHarga.Checked Then
            Panel1.Enabled = True
            Panel2.Enabled = False
        ElseIf radPajak.Checked Then
            Panel2.Enabled = True
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub radPajak_CheckedChanged(sender As Object, e As EventArgs) Handles radPajak.CheckedChanged
        If radHarga.Checked Then
            Panel1.Enabled = True
            Panel2.Enabled = False
        ElseIf radPajak.Checked Then
            Panel2.Enabled = True
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub Harga_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form2.Focus()
        Form2.HargaToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Harga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Panel1.Enabled = False
        Panel2.Enabled = False
        cboJenis.SelectedIndex = -1

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("Select * from [Kota Tujuan]", con)
        adKota = New SqlDataAdapter(cmd)

        cmd = New SqlCommand("Select * from Pajak", con)
        adPajak = New SqlDataAdapter(cmd)

        ds = New DataSet
        adKota.Fill(ds, "Kota")
        adPajak.Fill(ds, "Pajak")
        con.Close()

        kunciKota(0) = ds.Tables("Kota").Columns(0)
        ds.Tables("Kota").PrimaryKey = kunciKota

        kunciPajak(0) = ds.Tables("Pajak").Columns(0)
        ds.Tables("Pajak").PrimaryKey = kunciPajak


    End Sub

    Private Sub txtKodeKota_LostFocus(sender As Object, e As EventArgs) Handles txtKodeKota.LostFocus
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = UCase(txtKodeKota.Text)
        baris = ds.Tables("Kota").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblNamaKota.Text = baris(1)
            lblHarga.Text = Format(baris(4), "0,000")
        Else
            MsgBox("Data tidak ditemukan")
            txtKodeKota.Clear()
            lblHarga.Text = "0"
            lblNamaKota.Text = "Kota"
        End If

    End Sub

    Private Sub cboJenis_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboJenis.SelectedValueChanged
        Dim baris As DataRow
        Dim cari(0) As String
        cari(0) = cboJenis.Text
        baris = ds.Tables("Pajak").Rows.Find(cari)

        If baris IsNot Nothing Then
            lblPajak.Text = baris(1) & " %"
        End If

    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = UCase(txtKodeKota.Text)
            baris = ds.Tables("Kota").Rows.Find(cari)

            If baris IsNot Nothing Then
                baris(4) = Val(txtHarga.Text)
                MsgBox("Sukses")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Merubah Harga Kota kode : " & txtKodeKota.Text)
                txtKodeKota.Focus()
                txtKodeKota.Clear()
                lblHarga.Text = "0"
                lblNamaKota.Text = "Nama Kota"
                txtHarga.Clear()
            End If
        End If
    End Sub

    Private Sub txtPajak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPajak.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim baris As DataRow
            Dim cari(0) As String
            cari(0) = cboJenis.Text
            baris = ds.Tables("Pajak").Rows.Find(cari)

            If baris IsNot Nothing Then
                baris(1) = Val(txtPajak.Text)
                MsgBox("Berhasil")
                Form2.lstAktivitas.Items.Add(Now.ToShortTimeString & vbTab & "Merubah Pajak Pengiriman : " & cboJenis.Text)
                lblPajak.Text = "0"
                txtPajak.Clear()
                cboJenis.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If radPajak.Checked Then
            Dim jlh As Integer
            Dim cb As SqlCommandBuilder
            cb = New SqlCommandBuilder(adPajak)
            adPajak = cb.DataAdapter
            jlh = adPajak.Update(ds, "Pajak")
            MsgBox(jlh & " data berhasil terupdate ke tabel")
        ElseIf radHarga.Checked Then
            Dim jlh As Integer
            Dim cb As SqlCommandBuilder
            cb = New SqlCommandBuilder(adKota)
            adKota = cb.DataAdapter
            jlh = adKota.Update(ds, "Kota")
            MsgBox(jlh & " data berhasil terupdate ke tabel")
        End If
    End Sub

End Class