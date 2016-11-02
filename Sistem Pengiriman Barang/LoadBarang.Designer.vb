<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadBarang
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuatBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkinCrafter1 = New DMSoft.SkinCrafter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TampilanToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.TutupToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TampilanToolStripMenuItem
        '
        Me.TampilanToolStripMenuItem.Name = "TampilanToolStripMenuItem"
        Me.TampilanToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TampilanToolStripMenuItem.Text = "Tampilan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'TutupToolStripMenuItem
        '
        Me.TutupToolStripMenuItem.Name = "TutupToolStripMenuItem"
        Me.TutupToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TutupToolStripMenuItem.Text = "Tutup"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuatBarangToolStripMenuItem, Me.PengembalianBarangToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'MuatBarangToolStripMenuItem
        '
        Me.MuatBarangToolStripMenuItem.Name = "MuatBarangToolStripMenuItem"
        Me.MuatBarangToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.MuatBarangToolStripMenuItem.Text = "Muat Barang"
        '
        'PengembalianBarangToolStripMenuItem
        '
        Me.PengembalianBarangToolStripMenuItem.Name = "PengembalianBarangToolStripMenuItem"
        Me.PengembalianBarangToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.PengembalianBarangToolStripMenuItem.Text = "Pengembalian Barang"
        '
        'SkinCrafter1
        '
        Me.SkinCrafter1.SkinFile = Nothing
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "SKF|*.skf"
        '
        'LoadBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 379)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LoadBarang"
        Me.Text = "Load Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TampilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuatBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinCrafter1 As DMSoft.SkinCrafter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
