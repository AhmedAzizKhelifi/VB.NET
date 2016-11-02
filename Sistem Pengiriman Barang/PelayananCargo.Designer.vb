<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PelayananCargo
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
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.btnTampil1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNamaKota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTampil2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNamaMaskapai = New System.Windows.Forms.TextBox()
        Me.btnTampil3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtKodePesawat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTampil4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatal.Location = New System.Drawing.Point(367, 394)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 19)
        Me.btnBatal.TabIndex = 20
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpSampai)
        Me.GroupBox1.Controls.Add(Me.dtpDari)
        Me.GroupBox1.Controls.Add(Me.btnTampil1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 67)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berdasarkan Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sampai"
        '
        'dtpSampai
        '
        Me.dtpSampai.Location = New System.Drawing.Point(205, 28)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(132, 20)
        Me.dtpSampai.TabIndex = 2
        '
        'dtpDari
        '
        Me.dtpDari.Location = New System.Drawing.Point(6, 28)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(132, 20)
        Me.dtpDari.TabIndex = 1
        '
        'btnTampil1
        '
        Me.btnTampil1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTampil1.Location = New System.Drawing.Point(355, 31)
        Me.btnTampil1.Name = "btnTampil1"
        Me.btnTampil1.Size = New System.Drawing.Size(49, 21)
        Me.btnTampil1.TabIndex = 0
        Me.btnTampil1.Text = "Tampil"
        Me.btnTampil1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtNamaKota)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnTampil2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 73)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Berdasarkan Kota"
        '
        'txtNamaKota
        '
        Me.txtNamaKota.Location = New System.Drawing.Point(173, 28)
        Me.txtNamaKota.Name = "txtNamaKota"
        Me.txtNamaKota.Size = New System.Drawing.Size(117, 20)
        Me.txtNamaKota.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Kota"
        '
        'btnTampil2
        '
        Me.btnTampil2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTampil2.Location = New System.Drawing.Point(355, 31)
        Me.btnTampil2.Name = "btnTampil2"
        Me.btnTampil2.Size = New System.Drawing.Size(49, 21)
        Me.btnTampil2.TabIndex = 1
        Me.btnTampil2.Text = "Tampil"
        Me.btnTampil2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtNamaMaskapai)
        Me.GroupBox3.Controls.Add(Me.btnTampil3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 74)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Berdasarkan Maskapai"
        '
        'txtNamaMaskapai
        '
        Me.txtNamaMaskapai.Location = New System.Drawing.Point(173, 28)
        Me.txtNamaMaskapai.Name = "txtNamaMaskapai"
        Me.txtNamaMaskapai.Size = New System.Drawing.Size(117, 20)
        Me.txtNamaMaskapai.TabIndex = 5
        '
        'btnTampil3
        '
        Me.btnTampil3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTampil3.Location = New System.Drawing.Point(355, 31)
        Me.btnTampil3.Name = "btnTampil3"
        Me.btnTampil3.Size = New System.Drawing.Size(49, 21)
        Me.btnTampil3.TabIndex = 2
        Me.btnTampil3.Text = "Tampil"
        Me.btnTampil3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Maskapai"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtKodePesawat)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btnTampil4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(419, 73)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Berdasarkan No. Pesawat"
        '
        'txtKodePesawat
        '
        Me.txtKodePesawat.Location = New System.Drawing.Point(173, 28)
        Me.txtKodePesawat.Name = "txtKodePesawat"
        Me.txtKodePesawat.Size = New System.Drawing.Size(117, 20)
        Me.txtKodePesawat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kode Pesawat"
        '
        'btnTampil4
        '
        Me.btnTampil4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTampil4.Location = New System.Drawing.Point(355, 31)
        Me.btnTampil4.Name = "btnTampil4"
        Me.btnTampil4.Size = New System.Drawing.Size(49, 21)
        Me.btnTampil4.TabIndex = 3
        Me.btnTampil4.Text = "Tampil"
        Me.btnTampil4.UseVisualStyleBackColor = True
        '
        'PelayananCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PelayananCargo"
        Me.Text = "Pelayanan Cargo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTampil1 As System.Windows.Forms.Button
    Friend WithEvents btnTampil2 As System.Windows.Forms.Button
    Friend WithEvents btnTampil3 As System.Windows.Forms.Button
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampil4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNamaKota As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaMaskapai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodePesawat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
