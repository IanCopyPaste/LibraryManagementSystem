Imports MySql.Data.MySqlClient

Public Class BorrowHistory
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        InsertBooks.Show()
        Me.Dispose()
    End Sub
    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        Dim b1 As New BorrowHistory
        b1.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = "Date Now: " & Date.Now
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim bh1 As New BorrowHistory
        bh1.Show()
        Me.Close()
    End Sub

    Private Sub BorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfileBoxUpper.Image = userImage
        ToolTip1.SetToolTip(Refresh, "Refresh")
        loadOrFilterTable("")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboStat.SelectedIndexChanged
        If comboStat.Text = "All" Then
            loadOrFilterTable("")
        ElseIf comboStat.Text = "Returned" Then
            loadOrFilterTable("Returned")
        ElseIf comboStat.Text = "Borrowed" Then
            loadOrFilterTable("Borrowed")
        End If
    End Sub

    Private Sub BorrowTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowTable.CellClick
        Dim title As String = ""
        Dim borrowDate As Date
        Dim dueDate As Date
        Try
            Dim id As Integer = BorrowTable.Rows(e.RowIndex).Cells(1).Value
            title = BorrowTable.Rows(e.RowIndex).Cells(3).Value
            txtEmail.Text = BorrowTable.Rows(e.RowIndex).Cells(2).Value
            Try
                dbConOpen()
                Dim query As String = "SELECT br.borrowDate AS borrowD, br.dueDate AS DueD
                                   FROM borrow br JOIN users u ON u.userID = br.userID
                                   WHERE u.userID = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                Dim read As MySqlDataReader = cmd.ExecuteReader
                While read.Read
                    borrowDate = read.GetDateTime("borrowD")
                    dueDate = read.GetDateTime("DueD")
                End While
            Catch ex As MySqlException
                MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(0)")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(1)")
            Finally
                dbConClose()
            End Try
        Catch ex As Exception
        Finally
            RichTextBox1.Text = "🔔 Library Due Date Reminder" & vbCrLf &
    "Book Title: " & title & vbCrLf &
    "Borrowed Date: " & borrowDate & vbCrLf &
    "Due Date: " & dueDate & vbCrLf & vbCrLf &
    "⚠️ This book is now due for return." & vbCrLf &
    "Please return it to the library immediately to avoid penalties or suspension of borrowing privileges."
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        NotifyReturnees(txtEmail.Text, RichTextBox1.Text)
    End Sub

    Private Sub btnClearBorrow_Click(sender As Object, e As EventArgs) Handles btnClearBorrow.Click
        If MsgBox("ARE YOU SURE YOU WANT TO CLEAR THE HISTORY RECORD?", vbYesNo + vbQuestion, "CLEAR CONFIRMATION") = MsgBoxResult.Yes Then
            Try
                dbConOpen()
                Dim query As String = "TRUNCATE borrow"
                Dim cmd As New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("TABLE CLEARED", vbInformation, "CLEARED")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "TRUNCATION ERROR(0)")
            Finally
                dbConClose()
            End Try
        End If
    End Sub

    Public Sub loadOrFilterTable(stat As String)
        Try
            dbConOpen()
            Dim query As String = "SELECT br.borrowID AS BorrowID, u.userID AS UserID, u.email AS Email, bk.title AS Book_Borrowed, br.borrowDate AS Borrowed_On, br.dueDate AS Due_Date, br.stat AS Statuss
                                   FROM borrow br JOIN users u ON u.userID = br.userID
                                   JOIN books bk ON bk.bookID = br.bookID
                                   WHERE (@stat = '' OR br.stat = @stat)"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@stat", stat)
            Dim dasd As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dasd.Fill(dt)
            BorrowTable.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR BORROW HISTORY(1)")
        Finally
            dbConClose()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MainDashboard.Show
        Dispose
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookDashboardForAdmin.Show()
        Me.Dispose()
    End Sub
End Class