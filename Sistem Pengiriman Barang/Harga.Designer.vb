<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Harga
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtKodeKota = New System.Windows.Forms.TextBox()
        Me.lblNamaKota = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.lblPajak = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboJenis = New System.Windows.Forms.ComboBox()
        Me.radHarga = New System.Windows.Forms.RadioButton()
        Me.radPajak = New System.Windows.Forms.RadioButton()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtHarga)
        Me.Panel1.Controls.Add(Me.lblHarga)
        Me.Panel1.Controls.Add(Me.txtKodeKota)
        Me.Panel1.Controls.Add(Me.lblNamaKota)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 165)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Harga Sekarang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ubah Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(140, 120)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 1
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(137, 85)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(48, 18)
        Me.lblHarga.TabIndex = 3
        Me.lblHarga.Text = "Harga"
        '
        'txtKodeKota
        '
        Me.txtKodeKota.Location = New System.Drawing.Point(140, 13)
        Me.txtKodeKota.Name = "txtKodeKota"
        Me.txtKodeKota.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeKota.TabIndex = 0
        '
        'lblNamaKota
        '
        Me.lblNamaKota.AutoSize = True
        Me.lblNamaKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKota.Location = New System.Drawing.Point(137, 49)
        Me.lblNamaKota.Name = "lblNamaKota"
        Me.lblNamaKota.Size = New System.Drawing.Size(83, 18)
        Me.lblNamaKota.TabIndex = 1
        Me.lblNamaKota.Text = "Nama Kota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Kota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtPajak)
        Me.Panel2.Controls.Add(Me.lblPajak)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cboJenis)
        Me.Panel2.Location = New System.Drawing.Point(339, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 165)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ubah Pajak"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Pajak Sekarang"
        '
        'txtPajak
        '
        Me.txtPajak.Location = New System.Drawing.Point(141, 120)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Size = New System.Drawing.Size(100, 20)
        Me.txtPajak.TabIndex = 1
        '
        'lblPajak
        '
        Me.lblPajak.AutoSize = True
        Me.lblPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPajak.Location = New System.Drawing.Point(138, 74)
        Me.lblPajak.Name = "lblPajak"
        Me.lblPajak.Size = New System.Drawing.Size(45, 18)
        Me.lblPajak.TabIndex = 2
        Me.lblPajak.Text = "Pajak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jenis Penerbangan"
        '
        'cboJenis
        '
        Me.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenis.FormattingEnabled = True
        Me.cboJenis.Items.AddRange(New Object() {"Domestik", "Lokal", "Internasional"})
        Me.cboJenis.Location = New System.Drawing.Point(141, 13)
        Me.cboJenis.Name = "cboJenis"
        Me.cboJenis.Size = New System.Drawing.Size(121, 21)
        Me.cboJenis.TabIndex = 0
        '
        'radHarga
        '
        Me.radHarga.AutoSize = True
        Me.radHarga.Location = New System.Drawing.Point(100, 12)
        Me.radHarga.Name = "radHarga"
        Me.radHarga.Size = New System.Drawing.Size(109, 17)
        Me.radHarga.TabIndex = 2
        Me.radHarga.TabStop = True
        Me.radHarga.Text = "Harga Pengiriman"
        Me.radHarga.UseVisualStyleBackColor = True
        '
        'radPajak
        '
        Me.radPajak.AutoSize = True
        Me.radPajak.Location = New System.Drawing.Point(441, 12)
        Me.radPajak.Name = "radPajak"
        Me.radPajak.Size = New System.Drawing.Size(52, 17)
        Me.radPajak.TabIndex = 3
        Me.radPajak.TabStop = True
        Me.radPajak.Text = "Pajak"
        Me.radPajak.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimpan.Location = New System.Drawing.Point(296, 236)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(54, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(646, 271)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.radPajak)
        Me.Controls.Add(Me.radHarga)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Harga"
        Me.Text = "Harga"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtKodeKota As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaKota As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents lblPajak As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboJenis As System.Windows.Forms.ComboBox
    Friend WithEvents radHarga As System.Windows.Forms.RadioButton
    Friend WithEvents radPajak As System.Windows.Forms.RadioButton
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
