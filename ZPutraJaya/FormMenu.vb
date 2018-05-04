Public Class FormMenu

    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        FormAbsensi.MdiParent = Me
        FormAbsensi.Show()

        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Close()
    End Sub

    Private Sub BonusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonusToolStripMenuItem.Click
        FormBonus.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Show()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Close()
    End Sub

    Private Sub KasbonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasbonToolStripMenuItem.Click
        FormKasbon.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Show()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Close()

    End Sub

    Private Sub TabunganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabunganToolStripMenuItem.Click
        FormTabungan.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Show()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Close()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        FormPegawai.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Show()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Close()
    End Sub

    Private Sub ProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukToolStripMenuItem.Click
        FormProduk.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Show()
        FormGaji.Close()
        FormRecordPekerja.Close()
    End Sub

    Private Sub GajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GajiToolStripMenuItem.Click
        FormGaji.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Show()
        FormRecordPekerja.Close()
    End Sub

    Private Sub RecordPekerjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordPekerjaToolStripMenuItem.Click
        FormRecordPekerja.MdiParent = Me
        FormAbsensi.Close()
        FormBonus.Close()
        FormKasbon.Close()
        FormTabungan.Close()
        FormPegawai.Close()
        FormProduk.Close()
        FormGaji.Close()
        FormRecordPekerja.Show()
    End Sub
End Class