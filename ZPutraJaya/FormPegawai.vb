Public Class FormPegawai

    Sub ShowPegawai()
        DataGridPegawai.DataSource = showTable("SELECT [ID_Pegawai],[Nama_Pegawai],[Alamat_Pegawai],[Jenis_Pegawai],[DateAdded] as TanggalInput,[ModifiedDate] as TanggalUbah FROM Pegawai WHERE IsDeleted != 1")
    End Sub

    Sub GenerateIDPegawai()
        Text_IDPegawai.Text = GenID("Pegawai", "PG")
    End Sub

    Sub ResetForm()
        LabelStatus.Visible = False
        LabelStatus.Text = "Add"

        ShowPegawai()
        GenerateIDPegawai()
        TextNamaPegawai.Text = String.Empty
        ComboJenisPegawai.SelectedItem = Nothing
        TextBoxAlamatPegawai.Text = String.Empty
    End Sub

    Function CheckForm()
        Dim status As String = String.Empty

        If TextNamaPegawai.Text = String.Empty Then
            status = status + " Nama Pegawai Kosong"
        ElseIf ComboJenisPegawai.SelectedItem = String.Empty Then
            status = status + " \n Jenis Pegawai Kosong"
        ElseIf TextBoxAlamatPegawai.Text = String.Empty Then
            status = status + " \n Alamat Pegawai Kosong"
        End If
        Return status
    End Function

    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResetForm()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim status = CheckForm()

        Dim dt As DateTime = DateTime.Now

        If status = String.Empty Then
            Connection()

            If LabelStatus.Text = "Add" Then
                query = "INSERT INTO [dbo].[Pegawai]" +
                           "([ID_Pegawai]" +
                           ",[Nama_Pegawai]" +
                           ",[Alamat_Pegawai]" +
                           ",[Jenis_Pegawai]" +
                           ",[DateAdded]" +
                           ",[IsDeleted])" +
                        "VALUES" +
                           "('" + Text_IDPegawai.Text + "'" +
                           ",'" + TextNamaPegawai.Text + "'" +
                           ",'" + TextBoxAlamatPegawai.Text + "'" +
                           ",'" + ComboJenisPegawai.SelectedItem + "'" +
                           ",GETDATE()" +
                           ",0) "
                label = "Data ID : " + Text_IDPegawai.Text + " berhasil ditambahkan"

            ElseIf LabelStatus.Text = "Edit" Then
                query = "UPDATE [dbo].[Pegawai]" +
                           "SET [Nama_Pegawai] = '" + TextNamaPegawai.Text + "'" +
                              ",[Alamat_Pegawai] = '" + TextBoxAlamatPegawai.Text + "'" +
                              ",[Jenis_Pegawai] = '" + ComboJenisPegawai.SelectedItem + "'" +
                              ",[ModifiedDate] = GETDATE()" +
                         "WHERE ID_Pegawai = '" + Text_IDPegawai.Text + "'"

                label = "Data ID : " + Text_IDPegawai.Text + " berhasil diubah"
            End If
            Console.WriteLine(query)
            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox(label)
                ResetForm()
                ShowPegawai()
            End If

        Else
            MsgBox(status)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Pegawai]" +
                           "SET  " +
                              "[ModifiedDate] = GETDATE()" +
                              ",[IsDeleted] = 1" +
                         "WHERE ID_Pegawai = '" + LabelIDData.Text + "'"

            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox("Data ID :  " + LabelIDData.Text + " berhasil dihapus")
                ResetForm()
                ShowPegawai()
            End If
        End If
    End Sub

    Private Sub DataGridPegawai_Click(sender As Object, e As EventArgs) Handles DataGridPegawai.Click
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridPegawai.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridPegawai_DoubleClick(sender As Object, e As EventArgs) Handles DataGridPegawai.DoubleClick
        Dim data As DataGridViewRow = DataGridPegawai.CurrentRow

        LabelStatus.Text = "Edit"

        Text_IDPegawai.Text = data.Cells(0).Value
        TextNamaPegawai.Text = data.Cells(1).Value
        TextBoxAlamatPegawai.Text = data.Cells(2).Value
        ComboJenisPegawai.SelectedItem = data.Cells(3).Value
    End Sub
 

End Class