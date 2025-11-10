Imports MySql.Data.MySqlClient

Public Class SignUp
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles toLogIn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignUpbtn.Click
        If fnameBox.Text = "" Or lnameBox.Text = "" Or emailBox.Text = "" Or usernamBox.Text = "" Then
            MsgBox("Please Complete Credentials!", vbInformation, "Credentials!")
        ElseIf passwordBox.Text <> CpasswordBox.Text Then
            MsgBox("Passwords Do Not Match!!", vbInformation, "Passwords!")
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

                    Dim query1 As String = "INSERT INTO users (nameID, username, password,email, role) VALUES (@lastID, @user, @pass, @email, 'user')"
                    Dim cmd1 As New MySqlCommand(query1, con)
                    cmd1.Parameters.AddWithValue("@lastID", lastID)
                    cmd1.Parameters.AddWithValue("@user", usernamBox.Text.Trim)
                    cmd1.Parameters.AddWithValue("@pass", CpasswordBox.Text.Trim)
                    cmd1.Parameters.AddWithValue("@email", emailBox.Text.Trim)
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

    Private Sub CpasswordBox_TextChanged(sender As Object, e As EventArgs) Handles CpasswordBox.TextChanged
        If passwordBox.Text = CpasswordBox.Text Then
            confirmLbl.Text = "Passwords Match!!"
            confirmLbl.ForeColor = Color.Green
            SignUpbtn.Enabled = True
        Else
            confirmLbl.Text = "Passwords Do Not Match!!"
            confirmLbl.ForeColor = Color.Red
            SignUpbtn.Enabled = False
        End If
    End Sub

    Dim see As Boolean = False
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If see Then
            passwordBox.UseSystemPasswordChar = False
            see = False
        Else
            passwordBox.UseSystemPasswordChar = True
            see = True
        End If
    End Sub
End Class