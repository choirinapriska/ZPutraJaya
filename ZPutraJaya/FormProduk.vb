Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormProduk

    Sub ShowProduk()
        DataGridProduk.DataSource = showTable("SELECT ID_Produk as ID ,Nama_Produk as NamaProduk,Harga_Produk as HargaProduk ,DateAdded as TanggalInput FROM Produk WHERE IsDeleted != 1")
    End Sub

    Sub GenerateIDProduk()
        Text_IDProduk.Text = GenID("Produk", "PD")
    End Sub

    Sub ResetForm()
        LabelStatus.Visible = False
        LabelStatus.Text = "Add"

        ShowProduk()
        GenerateIDProduk()
        TextNamaProduk.Text = String.Empty
        TextHargaProduk.Text = String.Empty
    End Sub

    Function CheckForm()
        Dim status As String = String.Empty

        If TextNamaProduk.Text = String.Empty Then
            status = status + " Nama Produk Kosong"
        ElseIf TextHargaProduk.Text = String.Empty Then
            status = status + " \n Harga Produk Kosong"
        End If
        Return status
    End Function

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String = String.Empty
        Dim label As String = String.Empty
        Dim output As Integer

        Dim status = CheckForm()

        Dim dt As DateTime = DateTime.Now

        If status = String.Empty Then
            Connection()

            If LabelStatus.Text = "Add" Then
                query = "INSERT INTO [dbo].[Produk]" +
                               "([ID_Produk]" +
                               ",[Nama_Produk]" +
                               ",[Harga_Produk]" +
                               ",[DateAdded]" +
                               ",[IsDeleted])" +
                         "VALUES" +
                               "('" + Text_IDProduk.Text + "'" +
                               ",'" + TextNamaProduk.Text + "'" +
                               "," + TextHargaProduk.Text + "" +
                               ",GETDATE()" +
                               ",0" +
                         ")"

                label = "Data ID : " + Text_IDProduk.Text + " berhasil ditambahkan"
            ElseIf LabelStatus.Text = "Edit" Then

                query = "UPDATE [dbo].[Produk]" +
                        "SET " +
                            "[Nama_Produk] = '" + TextNamaProduk.Text + "'" +
                            ",[Harga_Produk] = " + TextHargaProduk.Text + "" +
                            ",[ModifiedDate] = GETDATE()" +
                        " WHERE " +
                            " ID_Produk = '" + Text_IDProduk.Text + "'"

                label = "Data ID : " + Text_IDProduk.Text + " berhasil diubah"
            End If

            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox(label)
                ResetForm()
                ShowProduk()
            End If

        Else
            MsgBox(status)
        End If
    End Sub

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub


    Private Sub TextHargaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextHargaProduk.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridProduk_DoubleClick(sender As Object, e As EventArgs) Handles DataGridProduk.DoubleClick
        Dim data As DataGridViewRow = DataGridProduk.CurrentRow

        LabelStatus.Text = "Edit"

        Text_IDProduk.Text = data.Cells(0).Value
        TextNamaProduk.Text = data.Cells(1).Value
        TextHargaProduk.Text = data.Cells(2).Value
    End Sub

    Private Sub DataGridProduk_Click(sender As Object, e As EventArgs) Handles DataGridProduk.Click
        ButtonDelete.Visible = True
        LabelIDData.Text = DataGridProduk.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String
        Dim dt As DateTime = DateTime.Now
        Dim output As Integer
        Dim result As Integer = MessageBox.Show("Hapus Data ID : " + LabelIDData.Text + " ? ", "Delete Data " + LabelIDData.Text + "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "UPDATE [dbo].[Produk]" +
                    "SET " +
                        "[IsDeleted] = 1" +
                        ",[ModifiedDate] = GETDATE()" +
                     " WHERE " +
                        " ID_Produk = '" + LabelIDData.Text + "'"
            output = ActionQuery(query)

            If (output = 1) Then
                MsgBox("Data ID :  " + LabelIDData.Text + " berhasil dihapus")
                ResetForm()
                ShowProduk()
            End If
        End If
    End Sub
End Class