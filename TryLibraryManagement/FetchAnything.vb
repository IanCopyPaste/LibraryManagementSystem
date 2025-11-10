Imports System.Net
Imports System.Net.Mail
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

    'API CALLS
    Public Sub SendEmail(email As String, code As Integer)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("bobbycuen@gmail.com", "FROM: LIBRARY MANAGEMENT SYSTEM by Ian")
            mail.To.Add(email)
            mail.Subject = "Your Verification Code: " & code
            mail.Body = "Your one-time password for verification is" & code & ". Please use this code to complete your login within five minutes. 
Do not share this code with anyone to keep your account secure. 
If you did not request this verification, please ignore this message.
"

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("bobbycuen@gmail.com", "iqpv kbbd dniy akom")
            smtp.EnableSsl = True

            smtp.Send(mail)

            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'API CALLS
End Module
