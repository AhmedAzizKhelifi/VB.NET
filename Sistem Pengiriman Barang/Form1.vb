Imports System.Data.SqlClient
Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adPengguna As SqlDataAdapter
    Dim dsPesawat As DataSet

    Sub bersih()
        txtNomor.Clear()
        txtSandi.Clear()
        txtNomor.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        control.Visible = False
        Me.Width = 349
        Me.Height = 423

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()

        cmd = New SqlCommand("Select * from Pengguna", con)
        adPengguna = New SqlDataAdapter(cmd)

        dsPesawat = New DataSet
        adPengguna.Fill(dsPesawat, "User")

        con.Close()
        Dim key(0) As DataColumn
        key(0) = dsPesawat.Tables("User").Columns(0)
        dsPesawat.Tables("User").PrimaryKey = key

        Call bersih()
    End Sub

    Private Sub btnCTRL_Click(sender As Object, e As EventArgs) Handles btnCTRL.Click
        btnCTRL.Visible = False
        control.Visible = True
        Me.Height = 423
        Me.Width = 460
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim b As DataRow
        Dim x(0) As String

        x(0) = txtNomor.Text
        b = dsPesawat.Tables("User").Rows.Find(x)

        If txtNomor.Text = "10000" And txtSandi.Text = "hantu" Then

            ''Sini Panggil Form Admin
            DaftarPengguna.ShowDialog()
            Call bersih()
        ElseIf txtNomor.Text = "20000" And txtSandi.Text = "bantu" Then
            DaftarPengguna2.ShowDialog()
            Call bersih()
        ElseIf b IsNot Nothing Then
            If b(1) = txtSandi.Text And b(5) = "Transaksi" Then
                Me.Hide()
                Form2.Show()
                Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
            ElseIf b(1) = txtSandi.Text And b(5) = "Loader" Then
                Me.Hide()
                LoadBarang.Show()
                Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
            Else
                MessageBox.Show("Sandi yang Anda masukkan salah", "Sandi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Nomor Anda tidak terdaftar", "Nomor Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Call bersih()
    End Sub

    Private Sub txtSandi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSandi.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim b As DataRow
            Dim x(0) As String

            x(0) = txtNomor.Text
            b = dsPesawat.Tables("User").Rows.Find(x)
            If txtNomor.Text = "10000" And txtSandi.Text = "hantu" Then

                DaftarPengguna.ShowDialog()
                Call bersih()
                ''Sini Panggil Form Admin
            ElseIf txtNomor.Text = "20000" And txtSandi.Text = "bantu" Then
                DaftarPengguna2.ShowDialog()
                Call bersih()
            ElseIf b IsNot Nothing Then
                If b(1) = txtSandi.Text And b(5) = "Transaksi" Then
                    Me.Hide()
                    Form2.Show()
                    Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
                ElseIf b(1) = txtSandi.Text And b(5) = "Loader" Then
                    Me.Hide()
                    LoadBarang.Show()
                    Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
                Else
                    MessageBox.Show("Sandi yang Anda masukkan salah", "Sandi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Call bersih()
                End If
            Else
                MessageBox.Show("Nomor Anda tidak terdaftar", "Nomor Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Call bersih()
            End If
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        btnCTRL.Visible = True
        control.Visible = False
        Me.Width = 349
        Me.Height = 423
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim b As DataRow
            Dim x(0) As String

            x(0) = txtNomor.Text
            b = dsPesawat.Tables("User").Rows.Find(x)
            If txtNomor.Text = "10000" And txtSandi.Text = "hantu" Then

                DaftarPengguna.ShowDialog()
                Call bersih()
                ''Sini Panggil Form Admin
            ElseIf txtNomor.Text = "20000" And txtSandi.Text = "bantu" Then
                DaftarPengguna2.ShowDialog()
                Call bersih()
            ElseIf b IsNot Nothing Then
                If b(1) = txtSandi.Text And b(5) = "Transaksi" Then
                    Me.Hide()
                    Form2.Show()
                    Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
                ElseIf b(1) = txtSandi.Text And b(5) = "Loader" Then
                    Me.Hide()
                    LoadBarang.Show()
                    Form2.ToolStripLabel1.Text = "Anda masuk sebagai : " & b(3)
                Else
                    MessageBox.Show("Sandi yang Anda masukkan salah", "Sandi Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Call bersih()
                End If
            Else
                MessageBox.Show("Nomor Anda tidak terdaftar", "Nomor Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Call bersih()
            End If
        End If
    End Sub

    Private Sub linkLupaSandi_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLupaSandi.LinkClicked
        LupaSandi.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Info.ShowDialog()
    End Sub
End Class