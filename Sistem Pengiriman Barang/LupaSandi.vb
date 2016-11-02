Imports System.Data.SqlClient
Public Class LupaSandi
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adPengguna As SqlDataAdapter
    Dim dsPesawat As DataSet

    Sub bersih()
        txtKodePin.Clear()
        txtNoAdmin.Clear()
    End Sub

    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim x As DataRow
        Dim b(0) As String

        b(0) = txtNoAdmin.Text
        x = dsPesawat.Tables("User").Rows.Find(b)

        If x IsNot Nothing Then
            If x(2) = txtKodePin.Text Then
                lblTampil.Text = x(1)
                Call bersih()
            Else
                lblTampil.Text = "Kode PIN Anda Salah"
                Call bersih()
            End If
        Else
            lblTampil.Text = "Nomor Admin Anda Salah"
            Call bersih()
        End If
    End Sub

    Private Sub LupaSandi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
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
    End Sub

    Private Sub txtKodePin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePin.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim x As DataRow
            Dim b(0) As String

            b(0) = txtNoAdmin.Text
            x = dsPesawat.Tables("User").Rows.Find(b)

            If x IsNot Nothing Then
                If x(2) = txtKodePin.Text Then
                    lblTampil.Text = x(1)
                    Call bersih()
                Else
                    lblTampil.Text = "Kode PIN Anda Salah"
                    Call bersih()
                End If
            Else
                lblTampil.Text = "Nomor Admin Anda Salah"
                Call bersih()
            End If
        End If
    End Sub

    Private Sub txtNoAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoAdmin.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim x As DataRow
            Dim b(0) As String

            b(0) = txtNoAdmin.Text
            x = dsPesawat.Tables("User").Rows.Find(b)

            If x IsNot Nothing Then
                If x(2) = txtKodePin.Text Then
                    lblTampil.Text = x(1)
                    Call bersih()
                Else
                    lblTampil.Text = "Kode PIN Anda Salah"
                    Call bersih()
                End If
            Else
                lblTampil.Text = "Nomor Admin Anda Salah"
                Call bersih()
            End If
        End If
    End Sub
End Class