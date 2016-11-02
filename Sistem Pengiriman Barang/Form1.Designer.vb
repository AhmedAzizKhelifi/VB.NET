<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCTRL = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkLupaSandi = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtSandi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.control = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.control.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCTRL
        '
        Me.btnCTRL.Location = New System.Drawing.Point(166, 95)
        Me.btnCTRL.Name = "btnCTRL"
        Me.btnCTRL.Size = New System.Drawing.Size(65, 23)
        Me.btnCTRL.TabIndex = 9
        Me.btnCTRL.Text = "Kontrol"
        Me.btnCTRL.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(23, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 41)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ADMINISTRATOR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.linkLupaSandi)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtSandi)
        Me.Panel1.Controls.Add(Me.btnCTRL)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNomor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 167)
        Me.Panel1.TabIndex = 8
        '
        'linkLupaSandi
        '
        Me.linkLupaSandi.AutoSize = True
        Me.linkLupaSandi.Location = New System.Drawing.Point(85, 125)
        Me.linkLupaSandi.Name = "linkLupaSandi"
        Me.linkLupaSandi.Size = New System.Drawing.Size(70, 13)
        Me.linkLupaSandi.TabIndex = 10
        Me.linkLupaSandi.TabStop = True
        Me.linkLupaSandi.Text = "Lupa Sandi ?"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(85, 95)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "&Masuk"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtSandi
        '
        Me.txtSandi.Location = New System.Drawing.Point(85, 58)
        Me.txtSandi.Name = "txtSandi"
        Me.txtSandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtSandi.Size = New System.Drawing.Size(146, 20)
        Me.txtSandi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sandi"
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(85, 21)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(146, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nomor Admin"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(23, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 164)
        Me.Panel3.TabIndex = 10
        '
        'control
        '
        Me.control.Controls.Add(Me.btnHide)
        Me.control.Controls.Add(Me.btnExit)
        Me.control.Controls.Add(Me.btnAbout)
        Me.control.Location = New System.Drawing.Point(344, 113)
        Me.control.Name = "control"
        Me.control.Size = New System.Drawing.Size(89, 212)
        Me.control.TabIndex = 11
        '
        'btnHide
        '
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(0, 0)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(88, 43)
        Me.btnHide.TabIndex = 8
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(20, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(49, 49)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Tutup"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(20, 75)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(49, 49)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "Info"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(460, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.control)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masuk (adm)"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCTRL As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtSandi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents control As System.Windows.Forms.Panel
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents linkLupaSandi As System.Windows.Forms.LinkLabel
End Class
