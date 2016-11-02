Imports System.Data.SqlClient
Public Class DaftarPengguna2

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim r As SqlDataReader
    Dim j As Integer

    Sub kosong()
        If radHapus.Checked Or radUbah.Checked Then
            txtNoAdmin.Focus()
        Else
            txtSandi.Focus()
        End If
        txtEmail.Clear()
        txtKodePin.Clear()
        txtNama.Clear()
        txtNoAdmin.Clear()
        txtSandi.Clear()
    End Sub

    Private Sub DaftarPengguna_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()
    End Sub


    Private Sub DaftarPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        radBuatbaru.Checked = False
        radHapus.Checked = False
        radUbah.Checked = False
        btnCek.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        txtEmail.Enabled = False
        txtKodePin.Enabled = False
        txtNama.Enabled = False
        txtNoAdmin.Enabled = False
        txtSandi.Enabled = False
        MaximizeBox = False
        MinimizeBox = False
        btnSimpan.Enabled = False

        '=========================================>

        con = New SqlConnection("Data source=REY\REY; Initial catalog=Pesawat; Integrated security=True")
        con.Open()
    End Sub

    Private Sub radBuatbaru_CheckedChanged(sender As Object, e As EventArgs) Handles radBuatbaru.CheckedChanged
        If radBuatbaru.Checked = True Then
            Label6.Visible = True
            Label7.Visible = True
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtSandi.Enabled = True
            btnCek.Visible = True
            txtNoAdmin.Enabled = False
            btnSimpan.Enabled = False
        ElseIf radHapus.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = False
            txtKodePin.Enabled = False
            txtNama.Enabled = False
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = False
            btnCek.Visible = False
        ElseIf radUbah.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = True
            btnCek.Visible = False
        End If

    End Sub

    Private Sub radUbah_CheckedChanged(sender As Object, e As EventArgs) Handles radUbah.CheckedChanged
        If radBuatbaru.Checked = True Then
            Label6.Visible = True
            Label7.Visible = True
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtSandi.Enabled = True
            btnCek.Enabled = True
            btnSimpan.Enabled = False
        ElseIf radHapus.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = False
            txtKodePin.Enabled = False
            txtNama.Enabled = False
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = False
            btnCek.Enabled = False
            btnSimpan.Enabled = True
        ElseIf radUbah.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = True
            btnCek.Enabled = False
            btnSimpan.Enabled = True
        End If

    End Sub

    Private Sub radHapus_CheckedChanged(sender As Object, e As EventArgs) Handles radHapus.CheckedChanged
        If radBuatbaru.Checked = True Then
            Label6.Visible = True
            Label7.Visible = True
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtSandi.Enabled = True
            btnCek.Enabled = True
            btnSimpan.Enabled = False
        ElseIf radHapus.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = False
            txtKodePin.Enabled = False
            txtNama.Enabled = False
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = False
            btnCek.Enabled = False
            btnSimpan.Enabled = True
        ElseIf radUbah.Checked = True Then
            Label6.Visible = False
            Label7.Visible = False
            txtEmail.Enabled = True
            txtKodePin.Enabled = True
            txtNama.Enabled = True
            txtNoAdmin.Enabled = True
            txtSandi.Enabled = True
            btnCek.Enabled = False
            btnSimpan.Enabled = True
        End If

    End Sub
    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        cmd = New SqlCommand("Select NoAdmin From Pengguna where NoAdmin='" & txtNoAdmin.Text & "'", con)
        r = cmd.ExecuteReader
        r.Close()
        If radBuatbaru.Checked = True Then
            btnSimpan.Enabled = False
            cmd = New SqlCommand("insert into Pengguna values('" & txtNoAdmin.Text & "','" & txtSandi.Text & "','" & txtKodePin.Text & "','" & txtNama.Text & "','" & txtEmail.Text & "','Loader')", con)
            j = cmd.ExecuteNonQuery

            If j > 0 Then
                MsgBox("Berhasil")
            Else
                MsgBox("Gagal")
            End If
            Call kosong()
        ElseIf radHapus.Checked = True Then
            cmd = New SqlCommand("Delete From Pengguna where NoAdmin='" & txtNoAdmin.Text & "'", con)
            j = cmd.ExecuteNonQuery
            If j > 0 Then
                MsgBox("Berhasil")
            Else
                MsgBox("Gagal")
            End If
            Call kosong()
        ElseIf radUbah.Checked = True Then
            cmd = New SqlCommand("Update Pengguna Set Sandi='" & txtSandi.Text & "',KodePin='" & txtKodePin.Text & "',NamaAdmin='" & txtNama.Text & "',Email='" & txtEmail.Text & "' where NoAdmin='" & txtNoAdmin.Text & "'", con)
            j = cmd.ExecuteNonQuery

            If j > 0 Then
                MsgBox("Suksess")
            Else
                MsgBox("No Admin Tidak Terdaftar")
            End If
            Call kosong()
        End If
        btnCek.Enabled = True
    End Sub

    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim has As Integer
        btnSimpan.Enabled = True
        cmd = New SqlCommand("select count(*) from Pengguna", con)
        r = cmd.ExecuteReader

        If r.Read Then
            has = r(0)
        End If

        txtNoAdmin.Text = "L" & 2100000 + has + 1
        r.Close()
        btnCek.Enabled = False
        btnSimpan.Enabled = True
        r.Close()
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        Call kosong()
    End Sub

    Private Sub txtNoAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoAdmin.KeyPress
        If e.KeyChar = Chr(13) Then
            If radHapus.Checked = True Or radUbah.Checked = True Then
                cmd = New SqlCommand("Select * From Pengguna where NoAdmin='" & txtNoAdmin.Text & "'", con)
                r = cmd.ExecuteReader

                If r.Read Then
                    txtSandi.Text = r(1)
                    txtKodePin.Text = r(2)
                    txtNama.Text = r(3)
                    txtEmail.Text = r(4)
                Else
                    MsgBox("No Admin Tidak terdaftar")
                End If
                r.Close()
            End If
        End If
    End Sub
End Class