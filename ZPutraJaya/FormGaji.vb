Public Class FormGaji

    Sub GenerateIDGaji()
        Text_IDGaji.Text = GenID("Gaji", "GJ")
    End Sub

    Sub ShowGaji()
        DataGridGaji.DataSource = showTable("SELECT A.ID_Gaji, A.ID_Pegawai, A.Total, A.DateAdded, B.Nama_Pegawai FROM dbo.Gaji AS A INNER JOIN dbo.Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai WHERE A.IsDeleted != 1")
    End Sub

    Sub ResetForm()
        Dim td As Date = Date.Today
        Dim lw As Date = DateAdd(DateInterval.Day, -6, td)

        GenerateIDGaji()
        ShowGaji()
        AutoCompletePegawai()

        DateTimeFirst.Value = lw
        DateTimeEnd.Value = td
        LabelDate.Text = td.ToString()
    End Sub

    Sub AutoCompletePegawai()
        Dim query As String = "SELECT [ID_Pegawai],[Nama_Pegawai] FROM Pegawai WHERE IsDeleted != 1"
        AutoComplete(query, ComboPegawai, "Nama_Pegawai", "ID_Pegawai")
    End Sub

    Private Sub FormGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim Pegawai As String = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("ID_Pegawai").ToString

        Connection()

        query = "INSERT INTO [dbo].[Gaji]" +
                   "([ID_Gaji]" +
                   ",[ID_Pegawai]" +
"                       ,[Total]" +
                   ",[DateAdded]" +
                   ",[IsDeleted]" +
                   ",[AddedBy])" +
                "VALUES" +
                   "('" + Text_IDGaji.Text + "'" +
                   ",'" + Pegawai + "'" +
                   "," + LabelTotal.Text + "" +
                   ",GETDATE()" +
                   ",0" +
                   ",'Admin')"

        label = "Data berhasil ditambahkan"

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
        DataGridViewRecord.Rows.Clear()
        If id <> String.Empty Then

            Dim fs As String = DateTimeEnd.Value.ToString("yyyy-MM-dd")
            Dim ls As String = DateTimeFirst.Value.ToString("yyyy-MM-dd")

            If fs = Date.Now.ToString("yyyy-MM-dd") Then
                fs = "GETDATE()"
                ls = "'" + ls + "'"
            Else
                fs = "'" + fs + "'"
                ls = "'" + ls + "'"
            End If

            Dim RecordData As DataTable = showTable("SELECT A.ID_Record_Pegawai,C.ID_Produk , C.Nama_Produk, B.ID_Pegawai, B.Nama_Pegawai, C.Harga_Produk, A.Jumlah, A.DateAdded  from Record_Pegawai AS A INNER JOIN Pegawai AS B ON A.ID_Pegawai = B.ID_Pegawai INNER JOIN Produk AS C ON A.ID_Produk = C.ID_Produk WHERE A.ID_Pegawai = '" + id + "' AND A.IsDeleted != 1 AND (A.DateAdded BETWEEN " + ls + " AND " + fs + ") ")
            Dim KasbonData As DataTable = showTable("SELECT Jumlah FROM Kasbon WHERE ID_Pegawai ='" + id + "' AND (DateAdded BETWEEN " + ls + " AND " + fs + ") AND  IsDeleted != 1 ")
            Dim BonusData As DataTable = showTable("SELECT Jumlah FROM Bonus WHERE ID_Pegawai ='" + id + "' AND (DateAdded BETWEEN " + ls + " AND " + fs + ") AND IsDeleted != 1")

            Dim kasbontotal As Integer = 0
            Dim bonustotal As Integer = 0

            If KasbonData.Rows.Count > 0 Then
                For i As Integer = 0 To KasbonData.Rows.Count - 1
                    kasbontotal += KasbonData.Rows(i)("Jumlah")
                Next
            End If

            If BonusData.Rows.Count > 0 Then
                For j As Integer = 0 To BonusData.Rows.Count - 1
                    bonustotal += BonusData.Rows(j)("Jumlah")
                Next
            End If

            If RecordData.Rows.Count > 0 Then
                With DataGridViewRecord

                    Dim content As String = String.Empty
                    Dim total As Integer = 0

                    For k As Integer = 0 To RecordData.Rows.Count - 1

                        Dim data As DataRow = RecordData.Rows(k)
                        Dim jumlah As Integer = data("Jumlah") * data("Harga_Produk")
                        Dim tanggal As Date = data("DateAdded")

                        .Rows.Add()
                        .Item(0, k).Value = (k + 1).ToString
                        .Item(1, k).Value = data("Nama_Produk")
                        .Item(2, k).Value = data("Jumlah").ToString + "x" + data("Harga_Produk").ToString
                        .Item(3, k).Value = jumlah.ToString

                        total += jumlah
                    Next
                    LabelTotal.Text = total
                End With
            End If

            LabelIDPegawai.Text = id
            LabelNamaPegawai.Text = CType(ComboPegawai.SelectedItem, DataRowView).Row.Item("Nama_Pegawai").ToString

            LabelKasbon.Text = kasbontotal
            LabelBonus.Text = bonustotal

        End If
    End Sub

    Private Sub DataGridGaji_Click(sender As Object, e As EventArgs)
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridGaji.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Gaji]" +
                    "SET " +
                        "[IsDeleted] = 1" +
                        ",[ModifiedDate] = '" + dt.ToString() + "'" +
                     " WHERE " +
                        " ID_Gaji = '" + LabelIDData.Text + "'"
            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox("Data ID :  " + LabelIDData.Text + " berhasil dihapus")
                ResetForm()
                ShowGaji()
            End If
        End If
    End Sub
End Class