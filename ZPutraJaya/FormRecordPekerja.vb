Public Class FormRecordPekerja
    Private q As String = "SELECT A.ID_Record_Pegawai as ID,B.Nama_Pegawai,C.Nama_Produk, A.Jumlah, A.ID_Produk, A.ID_Pegawai,A.DateAdded" +
                              " FROM dbo.Record_Pegawai AS A INNER JOIN" +
                                " dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai INNER JOIN" +
                                " dbo.Produk AS C ON A.ID_Produk = C.ID_Produk WHERE A.IsDeleted != 1"
    Sub GetDataAutoComplete()
        Dim queryPegawai As String = "SELECT [ID_Pegawai],[Nama_Pegawai] FROM Pegawai WHERE IsDeleted != 1"
        Dim queryProduk As String = "SELECT [ID_Produk],[Nama_Produk] FROM Produk WHERE IsDeleted != 1"

        AutoComplete(queryPegawai, ComboPegawai, "Nama_Pegawai", "ID_Pegawai")
        AutoComplete(queryProduk, ComboProduk, "Nama_Produk", "ID_Produk")
    End Sub

    Sub ShowRecord(ByVal query As String)
        DataGridRecordPekerja.DataSource = showTable(query)
    End Sub

    Sub ResetForm()

        LabelStatus.Visible = False
        LabelStatus.Text = "Add"
        GetDataAutoComplete()
        ShowRecord(q)
        TextJumlah.Text = String.Empty
        DateTimeTgl.Value = Date.Now

    End Sub

    Private Sub FormRecordPekerja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString
        Dim Produk As String = CType(ComboProduk.SelectedItem, DataRowView).Row.Item("ID_Produk").ToString

        Dim tgl As String = DateTimeTgl.Value.ToString("yyyy-M-dd")

        Connection()

        If LabelStatus.Text = "Add" Then

            query = "INSERT INTO [dbo].[Record_Pegawai]" +
                        "([ID_Produk]" +
                        ",[ID_Pegawai]" +
                        ",[Jumlah]" +
                        ",[DateAdded]" +
                        ",[IsDeleted])" +
                    "VALUES" +
                        "('" + Produk + "'" +
                        ",'" + Pegawai + "'" +
                        "," + TextJumlah.Text + "" +
                        ",'" + tgl + "'" +
                        ",0) "
            label = "Data berhasil ditambahkan"

        ElseIf LabelStatus.Text = "Edit" Then
            query = "UPDATE [dbo].[Record_Pegawai]" +
                        "SET [ID_Produk] = '" + Produk + "'" +
                            ",[ID_Pegawai] = '" + Pegawai + "'" +
                            ",[Jumlah] = " + TextJumlah.Text + "" +
                            ",[ModifiedDate] = getdate()" +
                        "WHERE ID_Record_Pegawai = " + LabelIDData.Text + ""

            label = "Data ID : " + LabelIDData.Text + " berhasil diubah"
        End If
        Console.WriteLine(query)
        output = ActionQuery(query)

        If (output = 1) Then
            MsgBox(label)
            ResetForm()
            ShowRecord(q)
        End If

    End Sub

    Private Sub DataGridRecordPekerja_Click(sender As Object, e As EventArgs) Handles DataGridRecordPekerja.Click
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridRecordPekerja.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridRecordPekerja_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick, DataGridRecordPekerja.DoubleClick
        Dim data As DataGridViewRow = DataGridRecordPekerja.CurrentRow

        LabelStatus.Text = "Edit"


        ComboProduk.SelectedValue = data.Cells(4).Value
        TextJumlah.Text = data.Cells(3).Value
        ComboPegawai.SelectedValue = data.Cells(5).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Record_Pegawai]" +
                           "SET  " +
                              "[ModifiedDate] = getdate()" +
                              ",[IsDeleted] = 1" +
                         "WHERE ID_Record_Pegawai = " + LabelIDData.Text + ""
            Console.WriteLine(query)
            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox("Data ID :  " + LabelIDData.Text + " berhasil dihapus")
                ResetForm()
                ShowRecord(q)
            End If
        End If
    End Sub

    Private Sub TextJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class