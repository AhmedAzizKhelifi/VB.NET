Imports System.Data.SqlClient
Public Class Form9

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim jlh As Integer

    Sub tampil()
        cmd = New SqlCommand("select  Tanggal, No_Faktur, t1.Kode_Kota,t2.Nama_Kota, Kode_Pesawat, Berat_Barang, Status from TransaksiPengiriman as t1, [Kota Tujuan] as t2 where t1.Kode_Kota=t2.Kode_Kota and Status='Tunggu'", con)
        read = cmd.ExecuteReader

        While read.Read
            dgvTampil.Rows.Add(Format(read(0), "dd/MM/yyyy"), read(1), read(2), read(3), read(4), read(5), read(6))
        End While
        read.Close()
    End Sub

    Private Sub Form9_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LoadBarang.MuatBarangToolStripMenuItem.Enabled = True
        con.Close()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        With dgvTampil
            .ColumnCount = 7
            .Columns(0).HeaderText = "Tanggal"
            .Columns(1).HeaderText = "No Faktur"
            .Columns(2).HeaderText = "Kode Kota"
            .Columns(3).HeaderText = "Nama Kota"
            .Columns(4).HeaderText = "Kode Pesawat"
            .Columns(5).HeaderText = "Berat Barang"
            .Columns(6).HeaderText = "Status"
        End With

        dgvTampil.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()
        Call tampil()
    End Sub

    Private Sub btnPerbarui_Click(sender As Object, e As EventArgs) Handles btnPerbarui.Click
        dgvTampil.Rows.Clear()
        Call tampil()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dgvTampil.Rows.Clear()
        cmd = New SqlCommand("select  Tanggal, No_Faktur, t1.Kode_Kota,t2.Nama_Kota, Kode_Pesawat, Berat_Barang, Status from TransaksiPengiriman as t1, [Kota Tujuan] as t2 where t1.Kode_Kota=t2.Kode_Kota and Status='Tunggu' and Tanggal='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'", con)
        read = cmd.ExecuteReader

        While read.Read
            dgvTampil.Rows.Add(Format(read(0), "dd/MM/yyyy"), read(1), read(2), read(3), read(4), read(5), read(6))
        End While
        read.Close()
    End Sub

    Private Sub dgvTampil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTampil.CellClick
        lblNoFaktur.Text = dgvTampil.Rows(e.RowIndex).Cells(1).Value
        lblKotaTujuan.Text = dgvTampil.Rows(e.RowIndex).Cells(3).Value
        lblNoPesawat.Text = dgvTampil.Rows(e.RowIndex).Cells(4).Value
        lblBeratBarang.Text = dgvTampil.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        cmd = New SqlCommand("Update TransaksiPengiriman set Status='Dikirim' where No_Faktur='" & lblNoFaktur.Text & "'", con)
        jlh = cmd.ExecuteNonQuery

        If jlh > 0 Then
            MsgBox("Berhasil")
            lblBeratBarang.Text = ""
            lblKotaTujuan.Text = ""
            lblNoFaktur.Text = ""
            lblNoPesawat.Text = ""
        Else
            MsgBox("Gagal")
            lblBeratBarang.Text = ""
            lblKotaTujuan.Text = ""
            lblNoFaktur.Text = ""
            lblNoPesawat.Text = ""
        End If
        dgvTampil.Rows.Clear()
        Call tampil()
    End Sub
End Class