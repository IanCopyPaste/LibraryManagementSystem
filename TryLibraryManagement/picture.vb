Imports System.IO
Imports MySql.Data.MySqlClient

Public Class picture
    Private Sub picture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image FROM users WHERE userID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", 1000)
            Dim imgByte() As Byte = CType(cmd.ExecuteScalar, Byte())
            Dim ms As New MemoryStream(imgByte)

            PictureBox1.Image = Image.FromStream(ms)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

        End Try
    End Sub

    Private Sub pathCheck_Click(sender As Object, e As EventArgs) Handles pathCheck.Click
        If Photo.ShowDialog = DialogResult.OK Then
            Dim path As String = Photo.FileName
            addSlash(path)
        End If
    End Sub
    Public Sub addSlash(path As String)
        Dim path2 As String
        For Each e As String In path
            If e = "\" Then
                e = "\\"
            End If
            path2 = path2 + e
        Next
        MsgBox(path2)
    End Sub
End Class