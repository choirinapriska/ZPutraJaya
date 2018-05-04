<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordPekerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BonusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasbonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.MenuToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(898, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsensiToolStripMenuItem, Me.PegawaiToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.RecordPekerjaToolStripMenuItem, Me.GajiToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'AbsensiToolStripMenuItem
        '
        Me.AbsensiToolStripMenuItem.Name = "AbsensiToolStripMenuItem"
        Me.AbsensiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbsensiToolStripMenuItem.Text = "Absensi"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PegawaiToolStripMenuItem.Text = "Pegawai"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'RecordPekerjaToolStripMenuItem
        '
        Me.RecordPekerjaToolStripMenuItem.Name = "RecordPekerjaToolStripMenuItem"
        Me.RecordPekerjaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecordPekerjaToolStripMenuItem.Text = "Record Pekerja"
        '
        'GajiToolStripMenuItem
        '
        Me.GajiToolStripMenuItem.Name = "GajiToolStripMenuItem"
        Me.GajiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GajiToolStripMenuItem.Text = "Gaji"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BonusToolStripMenuItem, Me.KasbonToolStripMenuItem, Me.TabunganToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.MenuToolStripMenuItem.Text = "Keuangan"
        '
        'BonusToolStripMenuItem
        '
        Me.BonusToolStripMenuItem.Name = "BonusToolStripMenuItem"
        Me.BonusToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BonusToolStripMenuItem.Text = "Bonus"
        '
        'KasbonToolStripMenuItem
        '
        Me.KasbonToolStripMenuItem.Name = "KasbonToolStripMenuItem"
        Me.KasbonToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.KasbonToolStripMenuItem.Text = "Kasbon"
        '
        'TabunganToolStripMenuItem
        '
        Me.TabunganToolStripMenuItem.Name = "TabunganToolStripMenuItem"
        Me.TabunganToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TabunganToolStripMenuItem.Text = "Tabungan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 527)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BonusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasbonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordPekerjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
