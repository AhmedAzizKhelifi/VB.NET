<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPesawat
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
        Me.btnTampilSemua = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMaskapai = New System.Windows.Forms.TextBox()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTampilSemua
        '
        Me.btnTampilSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilSemua.Location = New System.Drawing.Point(12, 12)
        Me.btnTampilSemua.Name = "btnTampilSemua"
        Me.btnTampilSemua.Size = New System.Drawing.Size(374, 48)
        Me.btnTampilSemua.TabIndex = 0
        Me.btnTampilSemua.Text = "Tampilkan Keseluruhan"
        Me.btnTampilSemua.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtMaskapai)
        Me.Panel1.Controls.Add(Me.btnTampil)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 133)
        Me.Panel1.TabIndex = 1
        '
        'txtMaskapai
        '
        Me.txtMaskapai.Location = New System.Drawing.Point(159, 40)
        Me.txtMaskapai.Name = "txtMaskapai"
        Me.txtMaskapai.Size = New System.Drawing.Size(137, 20)
        Me.txtMaskapai.TabIndex = 3
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(159, 82)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 2
        Me.btnTampil.Text = "Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maskapai"
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatal.Location = New System.Drawing.Point(332, 228)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(54, 23)
        Me.btnBatal.TabIndex = 20
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'LaporanPesawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnTampilSemua)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LaporanPesawat"
        Me.Text = "LaporanPesawat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTampilSemua As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaskapai As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
