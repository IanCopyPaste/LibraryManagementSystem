Imports System.Data.Common
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class MainDashboard
    ' Form Load event - initialize UI and setup
    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fromFetchDesign() ' Set welcome text and userID label
        loadTable() ' Load all users into DataGridView
        checkIfNullProfile() ' Check if current user has a profile image
        ProfileBoxMain.SizeMode = PictureBoxSizeMode.StretchImage
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.Zoom
        ToolTip.SetToolTip(refreshBtn, "Refresh") ' Set tooltip for refresh button
    End Sub

    ' DataGridView cell click - handle Delete/Edit actions
    Private Sub ewanTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ewanTable.CellContentClick
        Try
            Dim userID As Integer = ewanTable.Rows(e.RowIndex).Cells(2).Value
            displayAllIntxtBox(userID) ' Display selected user info in textboxes
            If e.RowIndex >= 0 Then
                Dim col = ewanTable.Columns(e.ColumnIndex)
                If col.Name = "Delete" Then
                    ' Confirm deletion
                    If MsgBox("ARE YOU SURE YOU WANT TO DELETE user: " & userID, vbYesNo + vbQuestion, "CONFIRMATION") = MsgBoxResult.Yes Then
                        exeQueryAndDisplay("DELETE FROM users WHERE userID = @?", userID) ' Delete user
                    End If
                ElseIf col.Name = "Edit" Then
                    UpdateCredentialsVisibility(False) ' Make textboxes editable
                    txtFname.Focus()
                Else
                    UpdateCredentialsVisibility(True) ' Set textboxes readonly
                End If
            End If
        Catch ex As Exception
            ' Exception ignored
        End Try
    End Sub

    ' Update button - confirm update and save changes
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If MsgBox("Are you sure you want to update user: " & txtUserID.Text, vbYesNo + vbQuestion, "Update User") = MsgBoxResult.Yes Then
            UpdateCredentials() ' Save updated user info
        End If
        UpdateCredentialsVisibility(True) ' Reset textboxes to readonly
    End Sub

    ' Upload new profile image
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        uploadPhotoDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg"
        If uploadPhotoDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = uploadPhotoDialog.FileName
            insertProfile(path) ' Insert image into DB
            refresh() ' Refresh dashboard
        End If
    End Sub

    ' Update existing profile image
    Private Sub updateProfileBtn_Click(sender As Object, e As EventArgs) Handles updateProfileBtn.Click
        uploadPhotoDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg"
        If uploadPhotoDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = uploadPhotoDialog.FileName
            insertProfile(path)
            refresh()
        End If
    End Sub

    ' Timer tick - update time label
    Private Sub TimeForTimer_Tick(sender As Object, e As EventArgs) Handles TimeForTimer.Tick
        TimeLabel.Text = "Time Now: " & "  " & Date.Now
    End Sub

    ' Search box text changed - filter DataGridView
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        searchUser()
        If searchBox.Text = "" Then
            loadTable() ' Reload all users if search is cleared
        End If
    End Sub

    ' Refresh button
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        refresh()
    End Sub

    ' Open InsertBooks form
    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        InsertBooks.Show()
        Close()
    End Sub

    ' Sign out - clear image, show login form, close dashboard
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        userImage = Nothing
        Form1.Show()
        Me.Close()
    End Sub

    ' Set welcome message and userID
    Sub fromFetchDesign()
        txtWelcome.Text = "Welcome! " & FetchAnything.name
        userIDlbl.Text = "UserID: " & FetchAnything.accNum
    End Sub

    ' Load all users into DataGridView
    Sub loadTable()
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT u.userID AS USER_ID, CONCAT_WS(' ', n.fname, n.mname, n.lname, n.suffix) AS FULLNAME,
                               u.username AS USERNAME, u.email AS EMAIL, u.role AS ACCESS FROM users u
                               INNER JOIN namess n ON n.nameID = u.nameID;"
            Dim da As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            da.Fill(dt)
            ewanTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect() ' Unnecessary, forces garbage collection
            DBcon.dbConOpen() ' Should close, not open
        End Try
    End Sub

    ' Execute query with parameter and reload table
    Public Sub exeQueryAndDisplay(RawQuery As String, param As String)
        Try
            DBcon.dbConOpen()
            Dim cmd As New MySqlCommand(RawQuery, con)
            cmd.Parameters.AddWithValue("@?", param)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        Finally
            DBcon.dbConClose()
            loadTable()
        End Try
    End Sub

    ' Insert profile image into DB
    Sub insertProfile(path As String)
        Dim path2 As String = ""
        For Each e As String In path
            If e = "/" Then e = "//"
            path2 += e
        Next
        Try
            dbConOpen()
            Dim query As String = "UPDATE users 
                               SET profile_image = LOAD_FILE(@path) 
                               WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@path", path2)
            cmd.Parameters.AddWithValue("@userID", FetchAnything.accNum)
            Dim close As MySqlDataReader = cmd.ExecuteReader()
            close.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED2")
        Finally
            GC.Collect()
            dbConClose()
        End Try
    End Sub

    ' Check if current user has profile image
    Function checkIfNullProfile()
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image FROM users WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", FetchAnything.accNum)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                profileBtnVisibility(True) ' Show profile upload button
                Return True
            Else
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                profileBtnVisibility(False)
                ProfileBoxUpper.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED1")
        Finally
            GC.Collect()
            dbConClose()
        End Try
        Return False
    End Function

    ' Search users
    Sub searchUser()
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT u.userID as USER_ID, CONCAT(n.fname,' ',n.mname,' ',n.lname,' ',n.suffix) AS FULLNAME,
                               u.username AS USERNAME, u.email AS EMAIL, u.role AS ACCESS
                               FROM users u JOIN namess n ON n.nameID = u.nameID
                               WHERE u.userID LIKE @search OR n.fname LIKE @search OR n.lname LIKE @search
                               OR u.username LIKE @search OR u.email LIKE @search OR u.role LIKE @search;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & searchBox.Text & "%")
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            ewanTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
        End Try
    End Sub

    ' Display user info in textboxes
    Sub displayAllIntxtBox(id As Integer)
        Try
            DBcon.dbConOpen()
            Dim query As String = "SELECT * FROM users u JOIN namess n ON n.nameID = u.nameID WHERE u.userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtFname.Text = If(IsDBNull(read("fname")), "", read("fname").ToString())
                txtLname.Text = If(IsDBNull(read("lname")), "", read("lname").ToString())
                txtMname.Text = If(IsDBNull(read("mname")), "", read("mname").ToString())
                txtSuffix.Text = If(IsDBNull(read("suffix")), "", read("suffix").ToString())
                txtUsername.Text = If(IsDBNull(read("username")), "", read("username").ToString())
                txtEmail.Text = If(IsDBNull(read("email")), "", read("email").ToString())
                comboAccess.Text = If(IsDBNull(read("role")), "", read("role").ToString())
                FetchAnything.nameID = If(IsDBNull(read("nameID")), 0, read.GetInt32("nameID"))
            End While
            txtUserID.Text = id.ToString
            read.Close()
            checkForProfile(id) ' Load user profile
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
        End Try
    End Sub

    ' Check profile for specific user
    Sub checkForProfile(id As Integer)
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image FROM users WHERE userID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                ProfileBoxMain.Image = Image.FromFile("C:\Users\CLIENT\Documents\vbWorks\TryLibraryManagement\sdsdsds.jpg") ' placeholder
            Else
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                ProfileBoxMain.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            con.Close()
        End Try
    End Sub

    ' Update user credentials
    Sub UpdateCredentials()
        Try
            dbConOpen()
            Dim query1 As String = "UPDATE namess SET fname = @fname, lname = @lname, mname = @mname, suffix = @suffix WHERE nameID = @nameID;"
            Dim query2 As String = "UPDATE users SET username = @user, role = @role, email = @email WHERE userID = @userID;"
            Dim cmd1 As New MySqlCommand(query1, con)
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd1.Parameters.AddWithValue("@nameID", FetchAnything.nameID)
            cmd1.Parameters.AddWithValue("@fname", txtFname.Text)
            cmd1.Parameters.AddWithValue("@lname", txtLname.Text)
            cmd1.Parameters.AddWithValue("@mname", txtMname.Text)
            cmd1.Parameters.AddWithValue("@suffix", txtSuffix.Text)
            cmd2.Parameters.AddWithValue("@userID", txtUserID.Text)
            cmd2.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd2.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd2.Parameters.AddWithValue("@role", comboAccess.Text)
            cmd1.ExecuteNonQuery() ' Execute name update
            cmd2.ExecuteNonQuery() ' Execute user update
            MsgBox("User Updated Successfully!", vbInformation, "Update Successfull")
            loadTable() ' Refresh table
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            dbConClose()
        End Try
    End Sub

    ' Enable or disable editing of textboxes
    Sub UpdateCredentialsVisibility(ok As Boolean)
        txtFname.ReadOnly = ok
        txtLname.ReadOnly = ok
        txtMname.ReadOnly = ok
        txtSuffix.ReadOnly = ok
        txtUsername.ReadOnly = ok
        txtEmail.ReadOnly = ok
        updateBtn.Enabled = Not ok
    End Sub

    ' Show or hide profile buttons
    Sub profileBtnVisibility(open As Boolean)
        profileBtn.Enabled = open
        profileBtn.Visible = open
        updateProfileBtn.Enabled = Not open
        updateProfileBtn.Visible = Not open
    End Sub

    ' Refresh dashboard by reopening form
    Sub refresh()
        Me.Close()
        Dim main As New MainDashboard
        main.Show()
    End Sub

    ' Navigation buttons
    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        refresh()
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        BorrowHistory.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBookDashboard_Click(sender As Object, e As EventArgs) Handles btnBookDashboard.Click
        BookDashboardForAdmin.Show()
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        refresh()
    End Sub
End Class
