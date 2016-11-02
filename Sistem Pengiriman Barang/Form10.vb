Imports System.Data.SqlClient
Public Class Form10

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim jlh As Integer

    Sub tampil()
        cmd = New SqlCommand("select No_Faktur,t2.nama_kota,Tanggal,Berat_Barang from TransaksiPengiriman as t1,[Kota Tujuan] as t2 where t1.Kode_Kota=t2.Kode_Kota and Status='Dikirim'", con)
        read = cmd.ExecuteReader

        While read.Read
            dgvTampil.Rows.Add(read(0), read(1), Format(read(2), "dd/MM/yyyy"), read(3))
        End While
        read.Close()
    End Sub

    Private Sub Form10_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LoadBarang.PengembalianBarangToolStripMenuItem.Enabled = True
        con.Close()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        With dgvTampil
            .ColumnCount = 4
            .Columns(0).HeaderText = "No.Faktur"
            .Columns(1).HeaderText = "Kota Tujuan"
            .Columns(2).HeaderText = "Tanggal Kirim"
            .Columns(3).HeaderText = "Berat Barang (satuan KG)"
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        Call tampil()
    End Sub

    Private Sub btnPerbarui_Click(sender As Object, e As EventArgs) Handles btnPerbarui.Click
        dgvTampil.Rows.Clear()
        Call tampil()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        dgvTampil.Rows.Clear()
        cmd = New SqlCommand("select No_Faktur,t2.nama_kota,Tanggal,Berat_Barang from TransaksiPengiriman as t1,[Kota Tujuan] as t2 where t1.Kode_Kota=t2.Kode_Kota and Status='Dikirim' and Tanggal='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'", con)
        read = cmd.ExecuteReader

        While read.Read
            dgvTampil.Rows.Add(read(0), read(1), Format(read(2), "dd/MM/yyyy"), read(3))
        End While
        read.Close()
    End Sub

    Private Sub dgvTampil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTampil.CellClick
        lblNoFaktur.Text = dgvTampil.Rows(e.RowIndex).Cells(0).Value
        lblKotaTujuan.Text = dgvTampil.Rows(e.RowIndex).Cells(1).Value
        lblTglKirim.Text = dgvTampil.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        dgvTampil.Rows.Clear()
        cmd = New SqlCommand("Update TransaksiPengiriman set Status='Dikembalikan' where No_Faktur='" & lblNoFaktur.Text & "'", con)
        jlh = cmd.ExecuteNonQuery

        If jlh > 0 Then
            MsgBox("Berhasil")
            lblKotaTujuan.Text = ""
            lblNoFaktur.Text = ""
            lblTglKirim.Text = ""
        Else
            MsgBox("Gagal")
            lblKotaTujuan.Text = ""
            lblNoFaktur.Text = ""
            lblTglKirim.Text = ""
        End If
        Call tampil()
    End Sub
End Class