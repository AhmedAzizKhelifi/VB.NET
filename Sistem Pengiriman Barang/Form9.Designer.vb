<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.dgvTampil = New System.Windows.Forms.DataGridView()
        Me.btnPerbarui = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNoFaktur = New System.Windows.Forms.Label()
        Me.lblKotaTujuan = New System.Windows.Forms.Label()
        Me.lblNoPesawat = New System.Windows.Forms.Label()
        Me.lblBeratBarang = New System.Windows.Forms.Label()
        Me.btnKirim = New System.Windows.Forms.Button()
        CType(Me.dgvTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTampil
        '
        Me.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTampil.Location = New System.Drawing.Point(-1, -1)
        Me.dgvTampil.Name = "dgvTampil"
        Me.dgvTampil.Size = New System.Drawing.Size(743, 293)
        Me.dgvTampil.TabIndex = 0
        '
        'btnPerbarui
        '
        Me.btnPerbarui.Location = New System.Drawing.Point(14, 29)
        Me.btnPerbarui.Name = "btnPerbarui"
        Me.btnPerbarui.Size = New System.Drawing.Size(61, 23)
        Me.btnPerbarui.TabIndex = 1
        Me.btnPerbarui.Text = "Perbarui"
        Me.btnPerbarui.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnPerbarui)
        Me.Panel1.Location = New System.Drawing.Point(12, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 67)
        Me.Panel1.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(81, 29)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(55, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kota Tujuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No Pesawat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Berat Barang"
        '
        'lblNoFaktur
        '
        Me.lblNoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoFaktur.Location = New System.Drawing.Point(407, 302)
        Me.lblNoFaktur.Name = "lblNoFaktur"
        Me.lblNoFaktur.Size = New System.Drawing.Size(245, 23)
        Me.lblNoFaktur.TabIndex = 7
        Me.lblNoFaktur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKotaTujuan
        '
        Me.lblKotaTujuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKotaTujuan.Location = New System.Drawing.Point(407, 337)
        Me.lblKotaTujuan.Name = "lblKotaTujuan"
        Me.lblKotaTujuan.Size = New System.Drawing.Size(245, 23)
        Me.lblKotaTujuan.TabIndex = 8
        Me.lblKotaTujuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoPesawat
        '
        Me.lblNoPesawat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoPesawat.Location = New System.Drawing.Point(407, 369)
        Me.lblNoPesawat.Name = "lblNoPesawat"
        Me.lblNoPesawat.Size = New System.Drawing.Size(245, 23)
        Me.lblNoPesawat.TabIndex = 9
        Me.lblNoPesawat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBeratBarang
        '
        Me.lblBeratBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBeratBarang.Location = New System.Drawing.Point(407, 401)
        Me.lblBeratBarang.Name = "lblBeratBarang"
        Me.lblBeratBarang.Size = New System.Drawing.Size(245, 23)
        Me.lblBeratBarang.TabIndex = 10
        Me.lblBeratBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKirim
        '
        Me.btnKirim.Location = New System.Drawing.Point(658, 302)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(75, 48)
        Me.btnKirim.TabIndex = 11
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 492)
        Me.Controls.Add(Me.btnKirim)
        Me.Controls.Add(Me.lblBeratBarang)
        Me.Controls.Add(Me.lblNoPesawat)
        Me.Controls.Add(Me.lblKotaTujuan)
        Me.Controls.Add(Me.lblNoFaktur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTampil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form9"
        Me.Text = "Muat Barang"
        CType(Me.dgvTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTampil As System.Windows.Forms.DataGridView
    Friend WithEvents btnPerbarui As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNoFaktur As System.Windows.Forms.Label
    Friend WithEvents lblKotaTujuan As System.Windows.Forms.Label
    Friend WithEvents lblNoPesawat As System.Windows.Forms.Label
    Friend WithEvents lblBeratBarang As System.Windows.Forms.Label
    Friend WithEvents btnKirim As System.Windows.Forms.Button
End Class
