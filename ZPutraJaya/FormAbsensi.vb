Public Class FormAbsensi
    Sub ShowAbsensi()
        DataGridAbsensi.DataSource = showTable("SELECT * FROM [dbo].[Absensi]")
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

    Sub ResetForm()
        Dim dt As DateTime = DateTime.Now
        DateAbsensi.Value = dt
        AutoCompletePegawai()
        ComboKeterangan.SelectedItem = Nothing
    End Sub

    Private Sub FormAbsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowAbsensi()
        AutoCompletePegawai()
        LabelStatus.Visible = False
        LabelStatus.Text = "Add"
    End Sub
     
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim dt As DateTime = DateTime.Now

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString

        Connection()

        If LabelStatus.Text = "Add" Then

            query = "INSERT INTO [dbo].[Absensi]" +
                        "([ID_Pegawai]" +
                        ",[Tanggal]" +
                        ",[Keterangan]" +
                        ",[DateAdded]" +
                        ",[IsDeleted])" +
                    "VALUES" +
                        "('" + Pegawai + "'" +
                        ",'" + DateAbsensi.Value + "'" +
                        ",'" + ComboKeterangan.SelectedItem + "'" +
                        ",'" + dt.ToString() + "'" +
                        ",0) "
            label = "Data berhasil ditambahkan"

        ElseIf LabelStatus.Text = "Edit" Then
            query = "UPDATE [dbo].[Absensi]" +
                        "SET [ID_Pegawai] = '" + Pegawai + "'" +
                            ",[Tanggal] = '" + DateAbsensi.Value + "'" +
                            ",[Keterangan] = '" + ComboKeterangan.SelectedItem + "'" +
                            ",[ModifiedDate] = '" + dt.ToString() + "'" +
                        "WHERE ID_Absensi = " + LabelIDData.Text + ""

            label = "Data ID : " + LabelIDData.Text + " berhasil diubah"
        End If
        Console.WriteLine(query)
        output = ActionQuery(query)

        If (output = 1) Then
            MsgBox(label)
            ResetForm()
            ShowAbsensi()
        End If
    End Sub

    Private Sub DataGridAbsensi_Click(sender As Object, e As EventArgs) Handles DataGridAbsensi.Click
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridAbsensi.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridAbsensi_DoubleClick(sender As Object, e As EventArgs) Handles DataGridAbsensi.DoubleClick
        Dim data As DataGridViewRow = DataGridAbsensi.CurrentRow

        LabelStatus.Text = "Edit"

        ComboPegawai.SelectedValue = data.Cells(1).Value
        DateAbsensi.Value = data.Cells(2).Value
        ComboKeterangan.SelectedItem = data.Cells(3).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Absensi]" +
                           "SET  " +
                              "[ModifiedDate] = '" + dt.ToString() + "'" +
                              ",[IsDeleted] = 1" +
                         "WHERE ID_Absensi = " + LabelIDData.Text + ""
            Console.WriteLine(query)
            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox("Data ID :  " + LabelIDData.Text + " berhasil dihapus")
                ResetForm()
                ShowAbsensi()
            End If
        End If
    End Sub
End Class
