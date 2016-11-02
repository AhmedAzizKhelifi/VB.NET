<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPengaturan = New System.Windows.Forms.ToolStripMenuItem()
        Me.HargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktivitasTerkiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTutup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataBandara = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataPesawat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPengirimanBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCekStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanNamaKonsumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPesawatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKotaTujuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPengirimanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBiayaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPresentasPajakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsTutup = New System.Windows.Forms.ToolStripButton()
        Me.tsKeluar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCekKota = New System.Windows.Forms.ToolStripTextBox()
        Me.tsPilihan = New System.Windows.Forms.ToolStripComboBox()
        Me.tsKota = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPengirimanBarang = New System.Windows.Forms.ToolStripButton()
        Me.tsCekStatus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lstAktivitas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkinCrafter2 = New DMSoft.SkinCrafter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CachedCrystalReport61 = New Sistem_Pengiriman_Barang.CachedCrystalReport6()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMaster, Me.mnuTransaksi, Me.mnuLaporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1365, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPengaturan, Me.mnuKeluar, Me.mnuTutup})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(42, 22)
        Me.mnuFile.Text = "&File"
        '
        'mnuPengaturan
        '
        Me.mnuPengaturan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HargaToolStripMenuItem, Me.TampilanToolStripMenuItem, Me.AktivitasTerkiniToolStripMenuItem})
        Me.mnuPengaturan.Image = CType(resources.GetObject("mnuPengaturan.Image"), System.Drawing.Image)
        Me.mnuPengaturan.Name = "mnuPengaturan"
        Me.mnuPengaturan.Size = New System.Drawing.Size(154, 22)
        Me.mnuPengaturan.Text = "Pengaturan"
        '
        'HargaToolStripMenuItem
        '
        Me.HargaToolStripMenuItem.Name = "HargaToolStripMenuItem"
        Me.HargaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HargaToolStripMenuItem.Text = "Harga"
        '
        'TampilanToolStripMenuItem
        '
        Me.TampilanToolStripMenuItem.Name = "TampilanToolStripMenuItem"
        Me.TampilanToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.TampilanToolStripMenuItem.Text = "Tampilan"
        '
        'AktivitasTerkiniToolStripMenuItem
        '
        Me.AktivitasTerkiniToolStripMenuItem.Name = "AktivitasTerkiniToolStripMenuItem"
        Me.AktivitasTerkiniToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AktivitasTerkiniToolStripMenuItem.Text = "Aktivitas Terkini"
        '
        'mnuKeluar
        '
        Me.mnuKeluar.Image = CType(resources.GetObject("mnuKeluar.Image"), System.Drawing.Image)
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.Size = New System.Drawing.Size(154, 22)
        Me.mnuKeluar.Text = "Keluar"
        '
        'mnuTutup
        '
        Me.mnuTutup.Image = CType(resources.GetObject("mnuTutup.Image"), System.Drawing.Image)
        Me.mnuTutup.Name = "mnuTutup"
        Me.mnuTutup.Size = New System.Drawing.Size(154, 22)
        Me.mnuTutup.Text = "Tutup"
        '
        'mnuMaster
        '
        Me.mnuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataBandara, Me.mnuDataPelanggan, Me.mnuDataPesawat})
        Me.mnuMaster.Name = "mnuMaster"
        Me.mnuMaster.Size = New System.Drawing.Size(65, 22)
        Me.mnuMaster.Text = "&Master"
        '
        'mnuDataBandara
        '
        Me.mnuDataBandara.Image = CType(resources.GetObject("mnuDataBandara.Image"), System.Drawing.Image)
        Me.mnuDataBandara.Name = "mnuDataBandara"
        Me.mnuDataBandara.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuDataBandara.Size = New System.Drawing.Size(244, 22)
        Me.mnuDataBandara.Text = "Data Tujuan"
        '
        'mnuDataPelanggan
        '
        Me.mnuDataPelanggan.Image = CType(resources.GetObject("mnuDataPelanggan.Image"), System.Drawing.Image)
        Me.mnuDataPelanggan.Name = "mnuDataPelanggan"
        Me.mnuDataPelanggan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuDataPelanggan.Size = New System.Drawing.Size(244, 22)
        Me.mnuDataPelanggan.Text = "Data Perusahaan"
        '
        'mnuDataPesawat
        '
        Me.mnuDataPesawat.Image = CType(resources.GetObject("mnuDataPesawat.Image"), System.Drawing.Image)
        Me.mnuDataPesawat.Name = "mnuDataPesawat"
        Me.mnuDataPesawat.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuDataPesawat.Size = New System.Drawing.Size(244, 22)
        Me.mnuDataPesawat.Text = "Data Pesawat"
        '
        'mnuTransaksi
        '
        Me.mnuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPengirimanBarang, Me.mnuCekStatus})
        Me.mnuTransaksi.Name = "mnuTransaksi"
        Me.mnuTransaksi.Size = New System.Drawing.Size(80, 22)
        Me.mnuTransaksi.Text = "&Transaksi"
        '
        'mnuPengirimanBarang
        '
        Me.mnuPengirimanBarang.Image = CType(resources.GetObject("mnuPengirimanBarang.Image"), System.Drawing.Image)
        Me.mnuPengirimanBarang.Name = "mnuPengirimanBarang"
        Me.mnuPengirimanBarang.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuPengirimanBarang.Size = New System.Drawing.Size(247, 22)
        Me.mnuPengirimanBarang.Text = "Pengiriman Barang"
        '
        'mnuCekStatus
        '
        Me.mnuCekStatus.Image = CType(resources.GetObject("mnuCekStatus.Image"), System.Drawing.Image)
        Me.mnuCekStatus.Name = "mnuCekStatus"
        Me.mnuCekStatus.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCekStatus.Size = New System.Drawing.Size(247, 22)
        Me.mnuCekStatus.Text = "Cek Status"
        '
        'mnuLaporan
        '
        Me.mnuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanNamaKonsumenToolStripMenuItem, Me.LaporanPesawatToolStripMenuItem, Me.LaporanKotaTujuanToolStripMenuItem, Me.LaporanPengirimanToolStripMenuItem, Me.LaporanBiayaToolStripMenuItem, Me.LaporanPresentasPajakToolStripMenuItem})
        Me.mnuLaporan.Name = "mnuLaporan"
        Me.mnuLaporan.Size = New System.Drawing.Size(75, 22)
        Me.mnuLaporan.Text = "&Laporan"
        '
        'LaporanNamaKonsumenToolStripMenuItem
        '
        Me.LaporanNamaKonsumenToolStripMenuItem.Name = "LaporanNamaKonsumenToolStripMenuItem"
        Me.LaporanNamaKonsumenToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanNamaKonsumenToolStripMenuItem.Text = "Laporan Perusahaan"
        '
        'LaporanPesawatToolStripMenuItem
        '
        Me.LaporanPesawatToolStripMenuItem.Name = "LaporanPesawatToolStripMenuItem"
        Me.LaporanPesawatToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanPesawatToolStripMenuItem.Text = "Laporan Pesawat"
        '
        'LaporanKotaTujuanToolStripMenuItem
        '
        Me.LaporanKotaTujuanToolStripMenuItem.Name = "LaporanKotaTujuanToolStripMenuItem"
        Me.LaporanKotaTujuanToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanKotaTujuanToolStripMenuItem.Text = "Laporan Kota Tujuan"
        '
        'LaporanPengirimanToolStripMenuItem
        '
        Me.LaporanPengirimanToolStripMenuItem.Name = "LaporanPengirimanToolStripMenuItem"
        Me.LaporanPengirimanToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanPengirimanToolStripMenuItem.Text = "Laporan Pelayanan Cargo"
        '
        'LaporanBiayaToolStripMenuItem
        '
        Me.LaporanBiayaToolStripMenuItem.Name = "LaporanBiayaToolStripMenuItem"
        Me.LaporanBiayaToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanBiayaToolStripMenuItem.Text = "Laporan Biaya"
        '
        'LaporanPresentasPajakToolStripMenuItem
        '
        Me.LaporanPresentasPajakToolStripMenuItem.Name = "LaporanPresentasPajakToolStripMenuItem"
        Me.LaporanPresentasPajakToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.LaporanPresentasPajakToolStripMenuItem.Text = "Laporan Presentase Pajak"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTutup, Me.tsKeluar, Me.ToolStripSeparator1, Me.tsCekKota, Me.tsPilihan, Me.tsKota, Me.ToolStripSeparator2, Me.tsPengirimanBarang, Me.tsCekStatus, Me.ToolStripSeparator3, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1365, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsTutup
        '
        Me.tsTutup.BackColor = System.Drawing.Color.White
        Me.tsTutup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsTutup.Image = CType(resources.GetObject("tsTutup.Image"), System.Drawing.Image)
        Me.tsTutup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTutup.Name = "tsTutup"
        Me.tsTutup.Size = New System.Drawing.Size(23, 35)
        Me.tsTutup.ToolTipText = "Tutup"
        '
        'tsKeluar
        '
        Me.tsKeluar.BackColor = System.Drawing.Color.White
        Me.tsKeluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsKeluar.Image = CType(resources.GetObject("tsKeluar.Image"), System.Drawing.Image)
        Me.tsKeluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsKeluar.Name = "tsKeluar"
        Me.tsKeluar.Size = New System.Drawing.Size(23, 35)
        Me.tsKeluar.Text = "ToolStripButton2"
        Me.tsKeluar.ToolTipText = "Keluar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tsCekKota
        '
        Me.tsCekKota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tsCekKota.Name = "tsCekKota"
        Me.tsCekKota.Size = New System.Drawing.Size(100, 38)
        Me.tsCekKota.ToolTipText = "Cek Kota"
        '
        'tsPilihan
        '
        Me.tsPilihan.AutoCompleteCustomSource.AddRange(New String() {"Nama Kota", "Kode Kota"})
        Me.tsPilihan.AutoSize = False
        Me.tsPilihan.Items.AddRange(New Object() {"Nama Kota", "Kode Kota"})
        Me.tsPilihan.Name = "tsPilihan"
        Me.tsPilihan.Size = New System.Drawing.Size(87, 23)
        '
        'tsKota
        '
        Me.tsKota.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsKota.Name = "tsKota"
        Me.tsKota.Size = New System.Drawing.Size(40, 35)
        Me.tsKota.Text = "Kota"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tsPengirimanBarang
        '
        Me.tsPengirimanBarang.AutoSize = False
        Me.tsPengirimanBarang.BackColor = System.Drawing.Color.White
        Me.tsPengirimanBarang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPengirimanBarang.Image = CType(resources.GetObject("tsPengirimanBarang.Image"), System.Drawing.Image)
        Me.tsPengirimanBarang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPengirimanBarang.Name = "tsPengirimanBarang"
        Me.tsPengirimanBarang.Size = New System.Drawing.Size(30, 40)
        Me.tsPengirimanBarang.Text = "ToolStripButton1"
        Me.tsPengirimanBarang.ToolTipText = "Kirim Barang"
        '
        'tsCekStatus
        '
        Me.tsCekStatus.BackColor = System.Drawing.Color.White
        Me.tsCekStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCekStatus.Image = CType(resources.GetObject("tsCekStatus.Image"), System.Drawing.Image)
        Me.tsCekStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCekStatus.Name = "tsCekStatus"
        Me.tsCekStatus.Size = New System.Drawing.Size(23, 35)
        Me.tsCekStatus.Text = "ToolStripButton2"
        Me.tsCekStatus.ToolTipText = "Cek Status"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(78, 35)
        Me.ToolStripLabel1.Text = "Nama Admin"
        '
        'lstAktivitas
        '
        Me.lstAktivitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAktivitas.FormattingEnabled = True
        Me.lstAktivitas.ItemHeight = 16
        Me.lstAktivitas.Location = New System.Drawing.Point(1002, 100)
        Me.lstAktivitas.Name = "lstAktivitas"
        Me.lstAktivitas.Size = New System.Drawing.Size(351, 532)
        Me.lstAktivitas.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1022, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Aktivitas Terkini"
        '
        'SkinCrafter2
        '
        Me.SkinCrafter2.SkinFile = Nothing
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "SKF|*.skf"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1365, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAktivitas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = " Cargo Line"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPengaturan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsTutup As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsKeluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuTutup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataBandara As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataPesawat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPengirimanBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCekStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TampilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanNamaKonsumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPesawatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKotaTujuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPengirimanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBiayaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCekKota As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsPilihan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsKota As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPengirimanBarang As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCekStatus As System.Windows.Forms.ToolStripButton
    Friend WithEvents AktivitasTerkiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstAktivitas As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LaporanPresentasPajakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinCrafter2 As DMSoft.SkinCrafter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CachedCrystalReport61 As Sistem_Pengiriman_Barang.CachedCrystalReport6
End Class
