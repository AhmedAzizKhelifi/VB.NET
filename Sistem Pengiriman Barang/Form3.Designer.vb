<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoFaktur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodePerusahaan = New System.Windows.Forms.TextBox()
        Me.lblNamaPerusahaan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKodePesawat = New System.Windows.Forms.TextBox()
        Me.lblMaskapai = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNomorPenerbangan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNamaBandara = New System.Windows.Forms.Label()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeTujuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboJenisPenerbangan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Faktur"
        '
        'lblNoFaktur
        '
        Me.lblNoFaktur.BackColor = System.Drawing.Color.White
        Me.lblNoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoFaktur.Location = New System.Drawing.Point(143, 10)
        Me.lblNoFaktur.Name = "lblNoFaktur"
        Me.lblNoFaktur.Size = New System.Drawing.Size(125, 24)
        Me.lblNoFaktur.TabIndex = 1
        Me.lblNoFaktur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Perusahaan"
        '
        'txtKodePerusahaan
        '
        Me.txtKodePerusahaan.Location = New System.Drawing.Point(143, 60)
        Me.txtKodePerusahaan.Name = "txtKodePerusahaan"
        Me.txtKodePerusahaan.Size = New System.Drawing.Size(125, 20)
        Me.txtKodePerusahaan.TabIndex = 3
        '
        'lblNamaPerusahaan
        '
        Me.lblNamaPerusahaan.AutoSize = True
        Me.lblNamaPerusahaan.Location = New System.Drawing.Point(294, 67)
        Me.lblNamaPerusahaan.Name = "lblNamaPerusahaan"
        Me.lblNamaPerusahaan.Size = New System.Drawing.Size(64, 13)
        Me.lblNamaPerusahaan.TabIndex = 4
        Me.lblNamaPerusahaan.Text = "Perusahaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kode Pesawat"
        '
        'txtKodePesawat
        '
        Me.txtKodePesawat.Location = New System.Drawing.Point(143, 93)
        Me.txtKodePesawat.Name = "txtKodePesawat"
        Me.txtKodePesawat.Size = New System.Drawing.Size(125, 20)
        Me.txtKodePesawat.TabIndex = 6
        '
        'lblMaskapai
        '
        Me.lblMaskapai.AutoSize = True
        Me.lblMaskapai.Location = New System.Drawing.Point(294, 96)
        Me.lblMaskapai.Name = "lblMaskapai"
        Me.lblMaskapai.Size = New System.Drawing.Size(53, 13)
        Me.lblMaskapai.TabIndex = 7
        Me.lblMaskapai.Text = "Maskapai"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtNomorPenerbangan)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblNoFaktur)
        Me.Panel1.Controls.Add(Me.lblMaskapai)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKodePesawat)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKodePerusahaan)
        Me.Panel1.Controls.Add(Me.lblNamaPerusahaan)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 167)
        Me.Panel1.TabIndex = 8
        '
        'txtNomorPenerbangan
        '
        Me.txtNomorPenerbangan.Location = New System.Drawing.Point(143, 124)
        Me.txtNomorPenerbangan.Name = "txtNomorPenerbangan"
        Me.txtNomorPenerbangan.Size = New System.Drawing.Size(125, 20)
        Me.txtNomorPenerbangan.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nomor Penerbangan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblNamaBandara)
        Me.Panel2.Controls.Add(Me.txtDibayar)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtKodeTujuan)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtBerat)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cboJenisPenerbangan)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(12, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 202)
        Me.Panel2.TabIndex = 9
        '
        'lblNamaBandara
        '
        Me.lblNamaBandara.AutoSize = True
        Me.lblNamaBandara.Location = New System.Drawing.Point(122, 92)
        Me.lblNamaBandara.Name = "lblNamaBandara"
        Me.lblNamaBandara.Size = New System.Drawing.Size(78, 13)
        Me.lblNamaBandara.TabIndex = 16
        Me.lblNamaBandara.Text = "Nama Bandara"
        '
        'txtDibayar
        '
        Me.txtDibayar.Location = New System.Drawing.Point(121, 161)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(100, 20)
        Me.txtDibayar.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Dibayar"
        '
        'txtKodeTujuan
        '
        Me.txtKodeTujuan.Location = New System.Drawing.Point(123, 59)
        Me.txtKodeTujuan.Name = "txtKodeTujuan"
        Me.txtKodeTujuan.Size = New System.Drawing.Size(45, 20)
        Me.txtKodeTujuan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Tujuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(174, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "-.Kg"
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(121, 126)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(45, 20)
        Me.txtBerat.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Berat"
        '
        'cboJenisPenerbangan
        '
        Me.cboJenisPenerbangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenisPenerbangan.FormattingEnabled = True
        Me.cboJenisPenerbangan.Items.AddRange(New Object() {"Domestik", "Lokal", "Internasional"})
        Me.cboJenisPenerbangan.Location = New System.Drawing.Point(123, 17)
        Me.cboJenisPenerbangan.Name = "cboJenisPenerbangan"
        Me.cboJenisPenerbangan.Size = New System.Drawing.Size(111, 21)
        Me.cboJenisPenerbangan.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Jenis Penerbangan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Rp."
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiaya.Location = New System.Drawing.Point(393, 234)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(22, 27)
        Me.lblBiaya.TabIndex = 12
        Me.lblBiaya.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Biaya :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(353, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Rp."
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(393, 338)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(22, 27)
        Me.lblKembalian.TabIndex = 14
        Me.lblKembalian.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(353, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Kembalian :"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(355, 420)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 24)
        Me.btnOK.TabIndex = 17
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(424, 420)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(63, 24)
        Me.btnBatal.TabIndex = 18
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengiriman Barang"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNoFaktur As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodePerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaPerusahaan As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodePesawat As System.Windows.Forms.TextBox
    Friend WithEvents lblMaskapai As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboJenisPenerbangan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKodeTujuan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDibayar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblKembalian As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblNamaBandara As System.Windows.Forms.Label
    Friend WithEvents txtNomorPenerbangan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
