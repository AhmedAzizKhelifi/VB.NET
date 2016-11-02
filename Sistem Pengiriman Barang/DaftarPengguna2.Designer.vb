<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarPengguna2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.radHapus = New System.Windows.Forms.RadioButton()
        Me.radUbah = New System.Windows.Forms.RadioButton()
        Me.radBuatbaru = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoAdmin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKodePin = New System.Windows.Forms.TextBox()
        Me.txtSandi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'btnBersih
        '
        Me.btnBersih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBersih.Location = New System.Drawing.Point(270, 308)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(59, 26)
        Me.btnBersih.TabIndex = 14
        Me.btnBersih.Text = "Kosong"
        Me.btnBersih.UseVisualStyleBackColor = true
        '
        'btnCek
        '
        Me.btnCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCek.Location = New System.Drawing.Point(396, 308)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(53, 29)
        Me.btnCek.TabIndex = 13
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = true
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimpan.Location = New System.Drawing.Point(335, 307)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(55, 29)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = true
        '
        'radHapus
        '
        Me.radHapus.AutoSize = true
        Me.radHapus.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.radHapus.Location = New System.Drawing.Point(332, 35)
        Me.radHapus.Name = "radHapus"
        Me.radHapus.Size = New System.Drawing.Size(88, 19)
        Me.radHapus.TabIndex = 11
        Me.radHapus.TabStop = true
        Me.radHapus.Text = "Hapus"
        Me.radHapus.UseVisualStyleBackColor = true
        '
        'radUbah
        '
        Me.radUbah.AutoSize = true
        Me.radUbah.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.radUbah.Location = New System.Drawing.Point(201, 35)
        Me.radUbah.Name = "radUbah"
        Me.radUbah.Size = New System.Drawing.Size(77, 19)
        Me.radUbah.TabIndex = 10
        Me.radUbah.TabStop = true
        Me.radUbah.Text = "Ubah"
        Me.radUbah.UseVisualStyleBackColor = true
        '
        'radBuatbaru
        '
        Me.radBuatbaru.AutoSize = true
        Me.radBuatbaru.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.radBuatbaru.Location = New System.Drawing.Point(36, 35)
        Me.radBuatbaru.Name = "radBuatbaru"
        Me.radBuatbaru.Size = New System.Drawing.Size(132, 19)
        Me.radBuatbaru.TabIndex = 9
        Me.radBuatbaru.TabStop = true
        Me.radBuatbaru.Text = "Buat Baru"
        Me.radBuatbaru.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNoAdmin)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.txtKodePin)
        Me.Panel1.Controls.Add(Me.txtSandi)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 226)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(264, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Maksimal 6 Digit"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(264, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Maksimal 30 digit"
        '
        'txtNoAdmin
        '
        Me.txtNoAdmin.Location = New System.Drawing.Point(113, 26)
        Me.txtNoAdmin.Name = "txtNoAdmin"
        Me.txtNoAdmin.Size = New System.Drawing.Size(145, 20)
        Me.txtNoAdmin.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(113, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(145, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(113, 142)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(145, 20)
        Me.txtNama.TabIndex = 8
        '
        'txtKodePin
        '
        Me.txtKodePin.Location = New System.Drawing.Point(113, 107)
        Me.txtKodePin.Name = "txtKodePin"
        Me.txtKodePin.Size = New System.Drawing.Size(145, 20)
        Me.txtKodePin.TabIndex = 7
        '
        'txtSandi
        '
        Me.txtSandi.Location = New System.Drawing.Point(113, 65)
        Me.txtSandi.Name = "txtSandi"
        Me.txtSandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtSandi.Size = New System.Drawing.Size(145, 20)
        Me.txtSandi.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(13, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(13, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode PIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sandi"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Admin"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Location = New System.Drawing.Point(535, 154)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'DaftarPengguna2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(467, 372)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnBersih)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.radHapus)
        Me.Controls.Add(Me.radUbah)
        Me.Controls.Add(Me.radBuatbaru)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DaftarPengguna2"
        Me.Text = "Daftar Pengguna2"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnBersih As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents radHapus As System.Windows.Forms.RadioButton
    Friend WithEvents radUbah As System.Windows.Forms.RadioButton
    Friend WithEvents radBuatbaru As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePin As System.Windows.Forms.TextBox
    Friend WithEvents txtSandi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
