Public Class FormAbsensi
    Private c As Integer

    Sub ShowAbsensi(Optional ByVal query As String = "")
        If query = "" Then
            query = "SELECT A.ID_Absensi, Nama_Pegawai , Keterangan , A.DateAdded  FROM Absensi AS A INNER JOIN Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai "
        End If

        DataGridAbsensi.DataSource = showTable(query)
    End Sub
    Sub AutoCompletePegawai()
        Dim query As String = "SELECT [ID_Pegawai],[Nama_Pegawai] FROM Pegawai WHERE IsDeleted != 1"
        AutoComplete(query, ComboPegawai, "Nama_Pegawai", "ID_Pegawai")


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
        LabelIDData.Text = DataGridAbsensi.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridAbsensi_DoubleClick(sender As Object, e As EventArgs) Handles DataGridAbsensi.DoubleClick
        Dim data As DataGridViewRow = DataGridAbsensi.CurrentRow

        LabelStatus.Text = "Edit"

        ComboPegawai.SelectedValue = data.Cells(1).Value
        DateAbsensi.Value = data.Cells(2).Value
        ComboKeterangan.SelectedItem = data.Cells(3).Value
    End Sub

    Private Sub ComboCariPegawai_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim id As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString
        ShowAbsensi("SELECT A.ID_Absensi, Nama_Pegawai , Keterangan , A.DateAdded  FROM Absensi AS A INNER JOIN Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai WHERE A.ID_Pegawai = '" + id + "' ")

    End Sub

    Private Sub ButtonCari_Click(sender As Object, e As EventArgs)

    End Sub
End Class
