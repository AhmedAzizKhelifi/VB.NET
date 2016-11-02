<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNoPenerbangan = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblKodePesawat = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblKotaTujuan = New System.Windows.Forms.Label()
        Me.lblBeratBarang = New System.Windows.Forms.Label()
        Me.lblMaskapai = New System.Windows.Forms.Label()
        Me.lblNamaPerusahaan = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(96, 24)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(126, 20)
        Me.txtCari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Faktur"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 107)
        Me.Panel1.TabIndex = 2
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatal.Location = New System.Drawing.Point(148, 50)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(44, 31)
        Me.btnBatal.TabIndex = 19
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCari.Location = New System.Drawing.Point(96, 50)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(46, 31)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblNoPenerbangan)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblKodePesawat)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblKotaTujuan)
        Me.Panel2.Controls.Add(Me.lblBeratBarang)
        Me.Panel2.Controls.Add(Me.lblMaskapai)
        Me.Panel2.Controls.Add(Me.lblNamaPerusahaan)
        Me.Panel2.Controls.Add(Me.lblTanggal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 351)
        Me.Panel2.TabIndex = 3
        '
        'lblNoPenerbangan
        '
        Me.lblNoPenerbangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNoPenerbangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoPenerbangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPenerbangan.Location = New System.Drawing.Point(129, 269)
        Me.lblNoPenerbangan.Name = "lblNoPenerbangan"
        Me.lblNoPenerbangan.Size = New System.Drawing.Size(201, 27)
        Me.lblNoPenerbangan.TabIndex = 13
        Me.lblNoPenerbangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "No. Penerbangan"
        '
        'lblKodePesawat
        '
        Me.lblKodePesawat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKodePesawat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKodePesawat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodePesawat.Location = New System.Drawing.Point(129, 150)
        Me.lblKodePesawat.Name = "lblKodePesawat"
        Me.lblKodePesawat.Size = New System.Drawing.Size(201, 27)
        Me.lblKodePesawat.TabIndex = 11
        Me.lblKodePesawat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Kode Pesawat"
        '
        'lblKotaTujuan
        '
        Me.lblKotaTujuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKotaTujuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKotaTujuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKotaTujuan.Location = New System.Drawing.Point(129, 230)
        Me.lblKotaTujuan.Name = "lblKotaTujuan"
        Me.lblKotaTujuan.Size = New System.Drawing.Size(201, 27)
        Me.lblKotaTujuan.TabIndex = 9
        Me.lblKotaTujuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBeratBarang
        '
        Me.lblBeratBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBeratBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBeratBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBarang.Location = New System.Drawing.Point(129, 188)
        Me.lblBeratBarang.Name = "lblBeratBarang"
        Me.lblBeratBarang.Size = New System.Drawing.Size(201, 27)
        Me.lblBeratBarang.TabIndex = 8
        Me.lblBeratBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaskapai
        '
        Me.lblMaskapai.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMaskapai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaskapai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaskapai.Location = New System.Drawing.Point(129, 110)
        Me.lblMaskapai.Name = "lblMaskapai"
        Me.lblMaskapai.Size = New System.Drawing.Size(201, 27)
        Me.lblMaskapai.TabIndex = 7
        Me.lblMaskapai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamaPerusahaan
        '
        Me.lblNamaPerusahaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNamaPerusahaan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaPerusahaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPerusahaan.Location = New System.Drawing.Point(129, 68)
        Me.lblNamaPerusahaan.Name = "lblNamaPerusahaan"
        Me.lblNamaPerusahaan.Size = New System.Drawing.Size(201, 27)
        Me.lblNamaPerusahaan.TabIndex = 6
        Me.lblNamaPerusahaan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTanggal
        '
        Me.lblTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(129, 27)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(201, 27)
        Me.lblTanggal.TabIndex = 5
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Kota Tujuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Berat Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Maskapai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Perusahaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(129, 309)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(201, 27)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Status"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(255, 27)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 54)
        Me.btnBrowse.TabIndex = 20
        Me.btnBrowse.Text = "-------"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(376, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form4"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Cek Status"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblKotaTujuan As System.Windows.Forms.Label
    Friend WithEvents lblBeratBarang As System.Windows.Forms.Label
    Friend WithEvents lblMaskapai As System.Windows.Forms.Label
    Friend WithEvents lblNamaPerusahaan As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblNoPenerbangan As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblKodePesawat As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
