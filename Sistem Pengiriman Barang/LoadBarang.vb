Imports DMSoft
Public Class LoadBarang

    Dim SkinOb As SkinCrafter
    Dim a As LoadBarang

    Sub skin()
        DMSoft.SkinCrafter.Init()
        SkinOb = New DMSoft.SkinCrafter
        SkinOb.InitDecoration(2)
        SkinOb.LoadSkinFromFile("D:\KULIAH\Tugas Besar Bhs.Prog\Sistem Pengiriman Barang\Desain\x-skin.skf")
        SkinOb.ApplySkin()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
        Form1.txtNomor.Focus()
        Form1.txtSandi.Clear()
        Form1.txtNomor.Clear()
    End Sub

    Private Sub TutupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutupToolStripMenuItem.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub TampilanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilanToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SkinOb.LoadSkinFromFile(OpenFileDialog1.FileName)
        End If
        SkinOb.ApplySkin()
    End Sub

    Private Sub LoadBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call skin()
        Me.IsMdiContainer = True
        a = Me.MdiParent
    End Sub

    Private Sub MuatBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuatBarangToolStripMenuItem.Click
        Dim b As New Form9
        b.MdiParent = Me
        b.Show()
        MuatBarangToolStripMenuItem.Enabled = False
    End Sub

    Private Sub PengembalianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianBarangToolStripMenuItem.Click
        Dim b As New Form10
        b.MdiParent = Me
        b.Show()
        PengembalianBarangToolStripMenuItem.Enabled = False
    End Sub
End Class