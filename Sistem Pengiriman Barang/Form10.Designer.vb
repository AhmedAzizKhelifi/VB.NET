<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnPerbarui = New System.Windows.Forms.Button()
        Me.lblKotaTujuan = New System.Windows.Forms.Label()
        Me.lblNoFaktur = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTglKirim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.dgvTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTampil
        '
        Me.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTampil.Location = New System.Drawing.Point(0, 1)
        Me.dgvTampil.Name = "dgvTampil"
        Me.dgvTampil.Size = New System.Drawing.Size(484, 230)
        Me.dgvTampil.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnPerbarui)
        Me.Panel1.Location = New System.Drawing.Point(12, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 67)
        Me.Panel1.TabIndex = 3
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
        'btnPerbarui
        '
        Me.btnPerbarui.Location = New System.Drawing.Point(14, 29)
        Me.btnPerbarui.Name = "btnPerbarui"
        Me.btnPerbarui.Size = New System.Drawing.Size(61, 23)
        Me.btnPerbarui.TabIndex = 1
        Me.btnPerbarui.Text = "Perbarui"
        Me.btnPerbarui.UseVisualStyleBackColor = True
        '
        'lblKotaTujuan
        '
        Me.lblKotaTujuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKotaTujuan.Location = New System.Drawing.Point(273, 276)
        Me.lblKotaTujuan.Name = "lblKotaTujuan"
        Me.lblKotaTujuan.Size = New System.Drawing.Size(198, 23)
        Me.lblKotaTujuan.TabIndex = 12
        Me.lblKotaTujuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoFaktur
        '
        Me.lblNoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoFaktur.Location = New System.Drawing.Point(273, 241)
        Me.lblNoFaktur.Name = "lblNoFaktur"
        Me.lblNoFaktur.Size = New System.Drawing.Size(198, 23)
        Me.lblNoFaktur.TabIndex = 11
        Me.lblNoFaktur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kota Tujuan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "No Faktur"
        '
        'lblTglKirim
        '
        Me.lblTglKirim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTglKirim.Location = New System.Drawing.Point(273, 307)
        Me.lblTglKirim.Name = "lblTglKirim"
        Me.lblTglKirim.Size = New System.Drawing.Size(198, 23)
        Me.lblTglKirim.TabIndex = 14
        Me.lblTglKirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tanggal Kirim"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(273, 342)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 38)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 402)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblTglKirim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblKotaTujuan)
        Me.Controls.Add(Me.lblNoFaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTampil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form10"
        Me.Text = "Pengembalian Barang"
        CType(Me.dgvTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTampil As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPerbarui As System.Windows.Forms.Button
    Friend WithEvents lblKotaTujuan As System.Windows.Forms.Label
    Friend WithEvents lblNoFaktur As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTglKirim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
