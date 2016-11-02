Imports System.Data.SqlClient
Public Class LaporanPesawat

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad, x As SqlDataAdapter
    Dim ds As DataSet

    Private Sub LaporanPesawat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()
        cmd = New SqlCommand("select * from Pesawat", con)
        ad = New SqlDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, "Pesawat")
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilSemua.Click
        Dim cr As New CrystalReport3
        Dim pre As New CrystalReport

        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.WindowState = FormWindowState.Maximized
        pre.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Form2.Focus()
        Form2.LaporanPesawatToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Dim cr As New CrystalReport3
        Dim pre As New CrystalReport

        cr.SetDataSource(ds)
        pre.CrystalReportViewer1.ReportSource = cr
        pre.CrystalReportViewer1.SelectionFormula = "{Pesawat.Maskapai} = '" & txtMaskapai.Text & "'"
        pre.WindowState = FormWindowState.Maximized
        pre.ShowDialog()
    End Sub
End Class