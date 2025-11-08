Imports MySql.Data.MySqlClient

Public Class InsertBooks
    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        Dim ins As New InsertBooks
        Dispose()
        ins.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewBook.Click
        CreateActualBook.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = "Time Now: " & Date.Now & " " & TimeOfDay
    End Sub

    'main process
    Private Sub InsertBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Dim query As String = "SELECT bookID, title, author, publishDate, category FROM books"
            Dim dasd As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dasd.Fill(dt)
            BookTable.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "Book Table Error 1")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Book Table Error 2")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        Dim pic As New PictureBox
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        If upPic1.ShowDialog = DialogResult.OK Then
            pic.Image = Image.FromFile(upPic1.FileName)
        End If
    End Sub
    'main process
End Class