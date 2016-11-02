<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LupaSandi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoAdmin = New System.Windows.Forms.TextBox()
        Me.txtKodePin = New System.Windows.Forms.TextBox()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.lblTampil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pin"
        '
        'txtNoAdmin
        '
        Me.txtNoAdmin.Location = New System.Drawing.Point(149, 23)
        Me.txtNoAdmin.Name = "txtNoAdmin"
        Me.txtNoAdmin.Size = New System.Drawing.Size(100, 20)
        Me.txtNoAdmin.TabIndex = 2
        '
        'txtKodePin
        '
        Me.txtKodePin.Location = New System.Drawing.Point(149, 62)
        Me.txtKodePin.Name = "txtKodePin"
        Me.txtKodePin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtKodePin.Size = New System.Drawing.Size(100, 20)
        Me.txtKodePin.TabIndex = 3
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(149, 104)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(75, 23)
        Me.btnCek.TabIndex = 4
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'lblTampil
        '
        Me.lblTampil.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTampil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTampil.Location = New System.Drawing.Point(296, 42)
        Me.lblTampil.Name = "lblTampil"
        Me.lblTampil.Size = New System.Drawing.Size(182, 23)
        Me.lblTampil.TabIndex = 5
        Me.lblTampil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LupaSandi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 149)
        Me.Controls.Add(Me.lblTampil)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.txtKodePin)
        Me.Controls.Add(Me.txtNoAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LupaSandi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lupa Sandi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePin As System.Windows.Forms.TextBox
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents lblTampil As System.Windows.Forms.Label
End Class
