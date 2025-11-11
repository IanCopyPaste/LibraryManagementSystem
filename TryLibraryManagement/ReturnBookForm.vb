Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ReturnBookForm
    Private Sub ReturnBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookID.Text = getID3
        Try
            dbConOpen()
            Dim query As String = "SELECT * FROM books WHERE bookID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", getID3)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtTitle.Text = read.GetString("title")
                txtAuth.Text = read.GetString("author")
                txtDate.Text = read.GetDateTime("publishDate")
                txtGenre.Text = read.GetString("category")
                txtStatus.Text = read.GetString("stat")
                Dim imageByte() As Byte = CType(read("profile"), Byte())
                Dim ms As New MemoryStream(imageByte)
                Dim img As Image = Image.FromStream(ms)
                borrowPic.Image = img
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "BORROW ERROR(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "BORROW ERROR(1)")
        Finally
            dbConClose()
            If txtStatus.Text = "Not Available" Then
                txtStatus.Text = "You Borrowed it Nigga"
            End If
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If MsgBox("ARE YOU SURE TO RETURN BOOKID: " & getID3, vbYesNo + vbQuestion, "SURE KANA BA YA") = MsgBoxResult.Yes Then
            Try
                dbConOpen()
                Dim query0 As String = "UPDATE books SET stat = 'Available' WHERE bookID = @id"
                Dim cmd0 As New MySqlCommand(query0, con)
                cmd0.Parameters.AddWithValue("@id", getID3)

                Dim query1 As String = "UPDATE borrow SET stat = 'Returned' WHERE userID = @id0 AND bookID = @id1"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@id0", accNum)
                cmd1.Parameters.AddWithValue("@id1", getID3)

                cmd0.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()

            Catch ex As MySqlException

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class