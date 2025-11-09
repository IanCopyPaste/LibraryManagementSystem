Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Module FetchAnything
    Public name As String
    Public accNum As String
    Public nameID As Integer
    Public pathTocreate As String

    'CreateActualBookForm

    'main process
    Public Function checkIfBookTitleisUnique(HELLO As String)
        Try
            con.Open()
            Dim query As String = "SELECT title FROM books WHERE title = @tite"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@tite", HELLO)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            If read.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "OH NO!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GAGU")
        Finally
            GC.Collect()
            con.Close()
        End Try
    End Function


    'main process

    'methods
    Public Sub createPath(path As String)
        Dim path2 As String = ""
        For Each e As String In path
            If e = "\" Then
                e = "\\"
            End If
            path2 += e
        Next
        pathTocreate = path2
    End Sub
    'methods

    'CreateActualBookForm
End Module
