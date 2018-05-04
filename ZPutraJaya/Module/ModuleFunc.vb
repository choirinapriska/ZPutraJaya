Module ModuleFunc
    Dim result As String

    Public Function showTable(ByVal query As String)
        Dim tblShow As New DataTable

        Connection()

        Try
            tblShow.Clear() 
            sql = query
            DataAdapter = New SqlClient.SqlDataAdapter(sql, conn)
            DataAdapter.Fill(tblShow)

            CloseConnection()

        Catch ex As Exception
            MsgBox("Error : " + ex.ToString())

        End Try

        Return tblShow
    End Function

    Public Function GenID(ByVal tabel As String, ByVal code As String)
        Dim newID As String = String.Empty
        Dim stringID As String = String.Empty
        Dim total As Integer
        Dim ds As New DataSet

        code = code.ToUpper()

        Connection()

        Try
            sql = "SELECT * FROM " + tabel
            DataAdapter = New SqlClient.SqlDataAdapter(sql, conn)
            DataAdapter.Fill(ds)

            total = ds.Tables(0).Rows.Count
            newID = Mid("00000000", 1, 8 - (Val(Trim(total.ToString())) + 1).ToString().Length) + (Val(Trim(total.ToString())) + 1).ToString()
            newID = code + newID 
        Catch ex As Exception
            MsgBox("Error : " + ex.ToString()) 
        End Try
        Return newID
    End Function

    Public Function ActionQuery(ByVal query As String)
        Dim label As Integer

        Connection()
        Try
            sql = query
            cmd = New SqlClient.SqlCommand(sql, conn)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            CloseConnection()

            label = 1
        Catch ex As Exception
            label = 0
            MsgBox("Error : " + ex.ToString)
        End Try

        Return label
    End Function


    Public Function SelectData(ByVal query As String)
        Dim dtname As New AutoCompleteStringCollection()
        Connection()
        Try

            cmd = New SqlClient.SqlCommand(query, conn)
            DataReader = cmd.ExecuteReader()

            If DataReader.HasRows = True Then
                While DataReader.Read()
                    dtname.Add(DataReader("Nama_Pegawai"))
                End While
            Else
                MessageBox.Show("Data not found")
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtname
    End Function

    Sub AutoComplete(ByVal query As String, ByVal element As ComboBox, ByVal Display As String, ByVal Value As String)
        Dim Data As DataTable = showTable(query)
        Dim cm As New AutoCompleteStringCollection

        Dim rw As DataRow = Data.NewRow
        rw(Display) = "-----Pilih-----"
        rw(Value) = ""
        Data.Rows.InsertAt(rw, 0)

        element.DataSource = Data
        element.DisplayMember = Display
        element.ValueMember = Value

        For i = 0 To Data.Rows.Count - 1
            cm.Add(Data.Rows(i)(Display).ToString())
        Next

        element.AutoCompleteCustomSource = cm
    End Sub

End Module
