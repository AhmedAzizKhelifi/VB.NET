Imports System.Data.SqlClient
Public Class Form8

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad, ad1 As SqlDataAdapter
    Dim ds As DataSet

    Sub tmp1()
        cmd = New SqlCommand("select t1.Tanggal,t1.No_Faktur,t1.Kode_Perusahaan, t2.nama_perusahaan from TransaksiPengiriman as t1, Perusahaan as t2 where t1.Kode_Perusahaan = t2.kode_perusahaan", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Find")
        con.Close()
        DataGridView1.DataSource = ds.Tables("Find")
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        con = New SqlConnection("Data source=REY\REY; initial catalog=Pesawat; Integrated security=True")
        con.Open()
        Call tmp1()
    End Sub

    Private Sub btnPerbarui_Click(sender As Object, e As EventArgs) Handles btnPerbarui.Click
        Call tmp1()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Form4.txtCari.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ds.Tables("Find").DefaultView.RowFilter = "Tanggal='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        DataGridView1.DataSource = ds.Tables("Find")
    End Sub
End Class