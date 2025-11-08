Imports MySql.Data.MySqlClient

Public Class SignUp
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles toLogIn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignUpbtn.Click
        If fnameBox.Text = "" Or lnameBox.Text = "" Then
            MsgBox("Please Enter Firstname and Lastname", vbInformation, "Credentials!")
        ElseIf passwordBox.Text <> CpasswordBox.Text Then
            MsgBox("Password Do Not Match", vbInformation, "Password!")
        Else
            Try
                DBcon.dbConOpen()
                Dim queryVer As String = "SELECT * FROM users WHERE username = @user"
                Dim cmd2 As New MySqlCommand(queryVer, con)
                cmd2.Parameters.AddWithValue("@user", usernamBox.Text)
                Dim ver As MySqlDataReader = cmd2.ExecuteReader
                If ver.HasRows Then
                    MsgBox("USERNAME ALREARY EXIST!", vbInformation, "USERNAME DUPLICATION")
                    ver.Close()
                Else
                    ver.Close()
                    Dim query As String = "INSERT INTO namess (fname,lname,mname,suffix) VALUES (UCASE(@fname),UCASE(@lname),UCASE(@mname),UCASE(@suffix))"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@fname", fnameBox.Text.Trim)
                    cmd.Parameters.AddWithValue("@lname", lnameBox.Text.Trim)
                    cmd.Parameters.AddWithValue("@mname", mnameBox.Text.Trim)
                    cmd.Parameters.AddWithValue("@suffix", suffBox.Text.Trim)
                    cmd.ExecuteNonQuery()
                    Dim lastID As Long = cmd.LastInsertedId

                    Dim query1 As String = "INSERT INTO users (nameID, username, password, role) VALUES (@lastID, @user, @pass, 'user')"
                    Dim cmd1 As New MySqlCommand(query1, con)
                    cmd1.Parameters.AddWithValue("@lastID", lastID)
                    cmd1.Parameters.AddWithValue("@user", usernamBox.Text.Trim)
                    cmd1.Parameters.AddWithValue("@pass", passwordBox.Text.Trim)
                    cmd1.ExecuteNonQuery()

                    MsgBox("ACCOUNT CREATED SUCCESFULLY", vbInformation, "ANGAS TOTOO")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
            Finally
                GC.Collect()
                DBcon.dbConClose()
                clear()
            End Try
        End If
    End Sub
    Sub clear()
        For Each obj In Panel1.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class