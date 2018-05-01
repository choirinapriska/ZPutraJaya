Public Class FormGaji
    Sub GenerateIDGaji()
        Text_IDGaji.Text = GenID("Gaji", "GJ")
    End Sub

    Sub ShowGaji()
        DataGridGaji.DataSource = showTable("SELECT A.ID_Gaji, A.ID_Pegawai, A.Kasbon_Pegawai, A.Total, A.DateAdded, B.Nama_Pegawai FROM dbo.Gaji AS A INNER JOIN dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai")
    End Sub

    Sub ResetForm()
        AutoCompletePegawai()
        GenerateIDGaji()
        TextKasbon.Text = String.Empty
        TextBoxTotal.Text = String.Empty
    End Sub

    Sub AutoCompletePegawai()
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
    End Sub
    Private Sub FormGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelStatus.Visible = False
        LabelStatus.Text = "Add"
        ShowGaji()
        GenerateIDGaji()
        AutoCompletePegawai()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim dt As DateTime = DateTime.Now

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString 

        Connection()

        If LabelStatus.Text = "Add" Then

            query = "INSERT INTO [dbo].[Gaji]" +
                        "([ID_Gaji]" +
                        ",[ID_Pegawai]" +
                        ",[Kasbon_Pegawai]" +
                        ",[Total]" +
                        ",[DateAdded]" +
                        ",[IsDeleted])" +
                    "VALUES" +
                        "('" + Text_IDGaji.Text + "'" +
                        ",'" + Pegawai + "'" +
                        "," + TextKasbon.Text + "" +
                        "," + TextBoxTotal.Text + "" +
                        ",'" + dt.ToString() + "'" +
                        ",0) "
            label = "Data berhasil ditambahkan"

        ElseIf LabelStatus.Text = "Edit" Then
            query = "UPDATE [dbo].[Gaji]" +
                        "SET  [ID_Pegawai] = '" + Pegawai + "'" +
                            ",[Kasbon_Pegawai] = " + TextKasbon.Text + "" +
                            ",[Total] = " + TextBoxTotal.Text + "" +
                            ",[ModifiedDate] = '" + dt.ToString() + "'" +
                        "WHERE ID_Gaji = '" + Text_IDGaji.Text + "'"

            label = "Data ID : " + LabelIDData.Text + " berhasil diubah"
        End If
        Console.WriteLine(query)
        output = ActionQuery(query)

        If (output = 1) Then
            MsgBox(label)
            ResetForm()
            ShowGaji()
        End If
    End Sub

    Private Sub ComboPegawai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPegawai.SelectedIndexChanged
        Dim id As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString

        If id <> String.Empty Then
            Dim data As DataTable = showTable("SELECT A.ID_Record_Pegawai as ID,A.DateAdded as Tanggal,B.Nama_Pegawai, C.Nama_Produk, A.Jumlah, C.Harga_Produk " +
                                            " FROM dbo.Record_Pegawai AS A INNER JOIN" +
                                            " dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai INNER JOIN" +
                                            " dbo.Produk AS C ON A.ID_Produk = C.ID_Produk WHERE A.IsDeleted != 1 AND  A.ID_Pegawai = '" + id + "'")

            DataGridRecordPekerja.DataSource = data

            Dim total As Integer = 0

            For i = 0 To data.Rows.Count - 1
                Dim jumlah As Integer = data.Rows(i)("Jumlah")
                Dim harga As Integer = data.Rows(i)("Harga_Produk")

                total += jumlah * harga
            Next

            TextBoxTotal.Text = total 
        End If
    End Sub

    Private Sub DataGridGaji_Click(sender As Object, e As EventArgs) Handles DataGridGaji.Click
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridGaji.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridGaji_DoubleClick(sender As Object, e As EventArgs) Handles DataGridGaji.DoubleClick
        Dim data As DataGridViewRow = DataGridGaji.CurrentRow

        LabelStatus.Text = "Edit"

        Text_IDGaji.Text = data.Cells(0).Value
        ComboPegawai.SelectedValue = data.Cells(1).Value
        TextKasbon.Text = data.Cells(2).Value
        TextBoxTotal.Text = data.Cells(3).Value
    End Sub
End Class