Public Class FormBonus
    Sub ShowBonus(ByVal id As String)
        Dim where As String = String.Empty

        If id <> String.Empty Then
            where = " AND A.ID_Pegawai = '" + id + "'"
        End If
        DataGridBonus.DataSource = showTable("SELECT A.ID_Bonus, B.Nama_Pegawai, A.Jumlah, A.AddedBy, A.DateAdded, A.ModifiedDate, A.ID_Pegawai FROM dbo.Bonus AS A  INNER JOIN dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai WHERE A.IsDeleted !=1" + where)
    End Sub

    Sub AutoCompletePegawai()
        Dim query As String = "SELECT [ID_Pegawai],[Nama_Pegawai] FROM Pegawai WHERE IsDeleted != 1"

        AutoComplete(query, ComboPegawai, "Nama_Pegawai", "ID_Pegawai")
    End Sub

    Sub ResetForm()
        AutoCompletePegawai()
        TextBoxJumlah.Text = String.Empty
        ShowBonus(String.Empty)
        LabelStatus.Text = "Add"
    End Sub
 
    Private Sub FormBonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub TextBoxJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridBonus_Click(sender As Object, e As EventArgs) Handles DataGridBonus.Click
        LabelIDData.Text = DataGridBonus.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridBonus_DoubleClick(sender As Object, e As EventArgs) Handles DataGridBonus.DoubleClick
        Dim data As DataGridViewRow = DataGridBonus.CurrentRow

        LabelStatus.Text = "Edit"

        ComboPegawai.SelectedValue = data.Cells(6).Value
        TextBoxJumlah.Text = data.Cells(2).Value
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim dt As DateTime = DateTime.Now

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString

        Connection()

        If LabelStatus.Text = "Add" Then

            query = "INSERT INTO [dbo].[Bonus]" +
                        "([ID_Pegawai]" +
                        ",[Jumlah]" +
                        ",[DateAdded]" +
                        ",[IsDeleted]" +
                        ",[AddedBy])" +
                    "VALUES" +
                        "('" + Pegawai + "'" +
                        ",'" + TextBoxJumlah.Text + "'" +
                        ",'" + dt.ToString() + "'" +
                        ",0,'Admin') "

            label = "Data berhasil ditambahkan"

        ElseIf LabelStatus.Text = "Edit" Then
            query = "UPDATE [dbo].[Bonus]" +
                        "SET [ID_Pegawai] = '" + Pegawai + "'" +
                            ",[Jumlah] = '" + TextBoxJumlah.Text + "'" +
                            ",[ModifiedDate] = '" + dt.ToString() + "'" +
                        "WHERE ID_Bonus = " + LabelIDData.Text + ""

            label = "Data ID : " + LabelIDData.Text + " berhasil diubah"
        End If
        Console.WriteLine(query)
        output = ActionQuery(query)

        If (output = 1) Then
            MsgBox(label)
            ResetForm()
            ShowBonus(String.Empty)
        End If
    End Sub

    Private Sub ComboPegawai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPegawai.SelectedIndexChanged
        Dim id As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString
        ShowBonus(id)
        If id <> String.Empty Then
            LabelIDPegawai.Text = id
            LabelNamaPegawai.Text = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("Nama_Pegawai").ToString
        End If
    End Sub
End Class