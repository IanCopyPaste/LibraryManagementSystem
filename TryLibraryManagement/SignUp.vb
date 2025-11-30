Imports MySql.Data.MySqlClient

Public Class SignUp
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles toLogIn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'ITONG SUB NA TO AY CHEKCING KUNG COMPLETE ANG NILAGAY NI USER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignUpbtn.Click
        If checkUsernameUnique(usernamBox.Text.Trim) Then
            MsgBox("USERNAME ALREADY TAKEN! PLEASE CHOOSE ANOTHER", vbInformation, "USERNAME")
            Exit Sub
        End If
        If fnameBox.Text = "" Or lnameBox.Text = "" Or emailBox.Text = "" Or usernamBox.Text = "" Then
            MsgBox("Please Complete Credentials!", vbInformation, "Credentials!")
        ElseIf passwordBox.Text <> CpasswordBox.Text Then
            MsgBox("Passwords Do Not Match!!", vbInformation, "Passwords!")
        Else
            fname = fnameBox.Text.Trim
            lname = lnameBox.Text.Trim
            mname = mnameBox.Text.Trim
            suffix = suffBox.Text.Trim
            username = usernamBox.Text.Trim
            email = emailBox.Text.Trim
            password = CpasswordBox.Text.Trim
            SendEmail()
            SignUpOtpCode.Show()
        End If
    End Sub

    'ITONG SUB NA TO AY PARA NAG BABAGO YUNG STATUS NG CONFIRM PASS PAG NAG EENTER
    Private Sub CpasswordBox_TextChanged(sender As Object, e As EventArgs) Handles CpasswordBox.TextChanged
        If passwordBox.Text = CpasswordBox.Text Then
            confirmLbl.Text = "Passwords Match!!"
            confirmLbl.ForeColor = Color.DarkGreen
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

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class