Imports System.Data.SqlClient

Module ModuleConnection

    Public conn As SqlConnection
    Public DataAdapter As SqlDataAdapter
    Public DataReader As SqlDataReader
    Public DataRow As DataRow
    Public DataSet As DataSet
    Public cmd As SqlCommand
    Public sql As String


    Public Sub Connection()
        Dim con As String
        con = "Data Source=localhost;Initial Catalog=zPutraJaya;Integrated Security=True"

        Try
            conn = New SqlConnection(con)
            conn.Open()
           
        Catch ex As Exception
            MsgBox("Error Connection : " + ex.Message.ToString())
        End Try
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Error Connection : " + ex.Message.ToString())
            End Try
        End If
    End Sub

End Module
