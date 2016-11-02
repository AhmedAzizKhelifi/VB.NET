<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKosong = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaBandara = New System.Windows.Forms.TextBox()
        Me.txtNamaKota = New System.Windows.Forms.TextBox()
        Me.txtKodeKota = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.radTambah = New System.Windows.Forms.RadioButton()
        Me.radUbah = New System.Windows.Forms.RadioButton()
        Me.radHapus = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnKosong)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtNamaBandara)
        Me.Panel1.Controls.Add(Me.txtNamaKota)
        Me.Panel1.Controls.Add(Me.txtKodeKota)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Location = New System.Drawing.Point(13, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 264)
        Me.Panel1.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimpan.Location = New System.Drawing.Point(220, 226)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(56, 23)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKosong
        '
        Me.btnKosong.Location = New System.Drawing.Point(286, 226)
        Me.btnKosong.Name = "btnKosong"
        Me.btnKosong.Size = New System.Drawing.Size(52, 23)
        Me.btnKosong.TabIndex = 11
        Me.btnKosong.Text = "Kosong"
        Me.btnKosong.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Maksimal 10 digit"
        '
        'txtNamaBandara
        '
        Me.txtNamaBandara.Location = New System.Drawing.Point(165, 140)
        Me.txtNamaBandara.Name = "txtNamaBandara"
        Me.txtNamaBandara.Size = New System.Drawing.Size(172, 20)
        Me.txtNamaBandara.TabIndex = 9
        '
        'txtNamaKota
        '
        Me.txtNamaKota.Location = New System.Drawing.Point(165, 92)
        Me.txtNamaKota.Name = "txtNamaKota"
        Me.txtNamaKota.Size = New System.Drawing.Size(172, 20)
        Me.txtNamaKota.TabIndex = 8
        '
        'txtKodeKota
        '
        Me.txtKodeKota.Location = New System.Drawing.Point(165, 50)
        Me.txtKodeKota.Name = "txtKodeKota"
        Me.txtKodeKota.Size = New System.Drawing.Size(115, 20)
        Me.txtKodeKota.TabIndex = 7
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatal.Location = New System.Drawing.Point(344, 226)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 23)
        Me.btnBatal.TabIndex = 6
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Bandara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Kota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Kota"
        '
        'btnOk
        '
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.Location = New System.Drawing.Point(164, 226)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(50, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'radTambah
        '
        Me.radTambah.AutoSize = True
        Me.radTambah.Location = New System.Drawing.Point(61, 12)
        Me.radTambah.Name = "radTambah"
        Me.radTambah.Size = New System.Drawing.Size(64, 17)
        Me.radTambah.TabIndex = 1
        Me.radTambah.TabStop = True
        Me.radTambah.Text = "Tambah"
        Me.radTambah.UseVisualStyleBackColor = True
        '
        'radUbah
        '
        Me.radUbah.AutoSize = True
        Me.radUbah.Location = New System.Drawing.Point(166, 12)
        Me.radUbah.Name = "radUbah"
        Me.radUbah.Size = New System.Drawing.Size(51, 17)
        Me.radUbah.TabIndex = 2
        Me.radUbah.TabStop = True
        Me.radUbah.Text = "Ubah"
        Me.radUbah.UseVisualStyleBackColor = True
        '
        'radHapus
        '
        Me.radHapus.AutoSize = True
        Me.radHapus.Location = New System.Drawing.Point(260, 12)
        Me.radHapus.Name = "radHapus"
        Me.radHapus.Size = New System.Drawing.Size(56, 17)
        Me.radHapus.TabIndex = 3
        Me.radHapus.TabStop = True
        Me.radHapus.Text = "Hapus"
        Me.radHapus.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(518, 97)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.radHapus)
        Me.Controls.Add(Me.radUbah)
        Me.Controls.Add(Me.radTambah)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form5"
        Me.Text = "Kota Tujuan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents radTambah As System.Windows.Forms.RadioButton
    Friend WithEvents radUbah As System.Windows.Forms.RadioButton
    Friend WithEvents radHapus As System.Windows.Forms.RadioButton
    Friend WithEvents txtNamaBandara As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKota As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeKota As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnKosong As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
