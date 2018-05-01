Public Class FormRecordPekerja
    Private q As String = "SELECT A.ID_Record_Pegawai as ID, A.ID_Produk, A.ID_Pegawai, A.Jumlah, B.Nama_Pegawai, C.Nama_Produk" +
                              " FROM dbo.Record_Pegawai AS A INNER JOIN" +
                                " dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai INNER JOIN" +
                                " dbo.Produk AS C ON A.ID_Produk = C.ID_Produk WHERE A.IsDeleted != 1"
    Sub GetDataAutoComplete()
        Dim pegawaiData As DataTable = showTable("SELECT [ID_Pegawai],[Nama_Pegawai] FROM Pegawai WHERE IsDeleted != 1")
        Dim colPegawai As New AutoCompleteStringCollection

        Dim PegawaiRow As DataRow = pegawaiData.NewRow
        PegawaiRow("Nama_Pegawai") = "-----Pilih-----"
        PegawaiRow("ID_Pegawai") = ""
        pegawaiData.Rows.InsertAt(PegawaiRow, 0)

        ComboPegawai.DataSource = pegawaiData
        ComboPegawai.DisplayMember = "Nama_Pegawai"
        ComboPegawai.ValueMember = "ID_Pegawai"

        For i = 0 To pegawaiData.Rows.Count - 1
            colPegawai.Add(pegawaiData.Rows(i)("Nama_Pegawai").ToString())
        Next

        ComboPegawai.AutoCompleteCustomSource = colPegawai

        Dim produkData As DataTable = showTable("SELECT [ID_Produk],[Nama_Produk] FROM Produk WHERE IsDeleted != 1")
        Dim col As New AutoCompleteStringCollection

        Dim ProdukRow As DataRow = produkData.NewRow
        ProdukRow("Nama_Produk") = "-----Pilih-----"
        ProdukRow("ID_Produk") = ""
        produkData.Rows.InsertAt(ProdukRow, 0)

        ComboProduk.DataSource = produkData
        ComboProduk.DisplayMember = "Nama_Produk"
        ComboProduk.ValueMember = "ID_Produk"

        For i = 0 To produkData.Rows.Count - 1
            col.Add(produkData.Rows(i)("Nama_Produk").ToString())
        Next

        ComboProduk.AutoCompleteCustomSource = col
    End Sub

    Sub ShowRecord(ByVal query As String)
        DataGridRecordPekerja.DataSource = showTable(query)
    End Sub

    Sub ResetForm()
        GetDataAutoComplete()
        TextJumlah.Text = String.Empty
    End Sub

    Private Sub FormRecordPekerja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelStatus.Visible = False
        LabelStatus.Text = "Add"
        GetDataAutoComplete()
        ShowRecord(q)
    End Sub

    Private Sub ComboPegawai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPegawai.SelectedIndexChanged
        'Dim id As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString
        'If id <> String.Empty Then
        '    Console.WriteLine(id)
        '    Dim query As String = q + " WHERE A.ID_Pegawai = '" + id + "'"
        '    ShowRecord(query)
        'End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim dt As DateTime = DateTime.Now

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString
        Dim Produk As String = CType(ComboProduk.SelectedItem, DataRowView).Row.Item("ID_Produk").ToString

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
                        ",'" + dt.ToString() + "'" +
                        ",0) "
            label = "Data berhasil ditambahkan"

        ElseIf LabelStatus.Text = "Edit" Then
            query = "UPDATE [dbo].[Record_Pegawai]" +
                        "SET [ID_Produk] = '" + Produk + "'" +
                            ",[ID_Pegawai] = '" + Pegawai + "'" +
                            ",[Jumlah] = " + TextJumlah.Text + "" +
                            ",[ModifiedDate] = '" + dt.ToString() + "'" +
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

    Private Sub DataGridRecordPekerja_DoubleClick(sender As Object, e As EventArgs) Handles DataGridRecordPekerja.DoubleClick
        Dim data As DataGridViewRow = DataGridRecordPekerja.CurrentRow

        LabelStatus.Text = "Edit"


        ComboProduk.SelectedValue = data.Cells(1).Value
        TextJumlah.Text = data.Cells(3).Value
        ComboPegawai.SelectedValue = data.Cells(2).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Record_Pegawai]" +
                           "SET  " +
                              "[ModifiedDate] = '" + dt.ToString() + "'" +
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
End Class