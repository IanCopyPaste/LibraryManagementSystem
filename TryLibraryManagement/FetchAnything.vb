Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Module FetchAnything
    'for display name
    Public name As String
    'for display and funtional id
    Public accNum As String
    Public nameID As Integer

    'for double slash sa blob
    Public pathTocreate As String

    'variable para sa borrow booko form
    Public getID3 As Integer

    'app password for the sender of the message
    Private pass As New appPass
    Private pas As String = pass.getAppPass

    'fetch profile picture to any form
    Public userImage As Image

    'VARIABLES TO IPASA YUNG CREDENTIALS FROM SIGNUP FORM PAPUNTA DITO PARA IEXECUTE YUNG INSERT INFO METHOD
    Public fname As String
    Public lname As String
    Public mname As String
    Public suffix As String
    Public username As String
    Public email As String
    Public password As String


    'CreateActualBookForm

    'main process
    Public Function checkIfBookTitleisUnique(HELLO As String)
        Try
            con.Open()
            Dim query As String = "SELECT title FROM books WHERE title = @title"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@title", HELLO)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            If read.HasRows Then
                Return True
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "BOOK ERROR(0)")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "BOOK ERROR(1)")
        Finally
            GC.Collect()
            con.Close()
        End Try
        Return False
    End Function

    Public Function checkUsernameUnique(username As String)
        Try
            con.Open()
            Dim query As String = "SELECT * FROM users WHERE username=?"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("username", username)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            If read.HasRows Then
                Return True
            End If
            read.Close()
        Catch ex As MySqlException
            MsgBox("ERROR OCCURED IN USERNAME UNIQUE", vbCritical, "ERROR OCCURED(0)")
        Catch ex As Exception
            MsgBox("ERROR OCCURED IN USERNAME UNIQUE", vbCritical, "ERROR OCCURED(1)")
        Finally
            con.Close()
        End Try
        Return False
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

    'API CALLS FOR SIGN UP
    Public otp As String

    'BASICALLY MAG GEGENERATE SIYA DITO NG RANDOM NUMBERS NA 6 DIGITS AT GAGAMITIN PARA SA OTP
    Public Function generateCode()
        Dim rand As New Random
        Dim code As String = rand.Next(100000, 1000000).ToString("D6")
        Return code
    End Function

    'ITO YUNG SUB NA NAG SESEND NG EMAIL
    Public Sub SendEmail()
        Try
            otp = generateCode()
            'ITONG BLOCK NA TO, ITO YUNG FOUNDATION NG EMAIL
            Dim mail As New MailMessage()
            mail.From = New MailAddress("bobbycuen@gmail.com", "FROM: LIBRARY MANAGEMENT SYSTEM by Ian")
            mail.To.Add(email)
            mail.Subject = "Your Verification Code: " & otp
            mail.Body = "Your one-time password for verification is " & otp & ". Please use this code to complete your login within five minutes. 
                        Do not share this code with anyone to keep your account secure. 
                        If you did not request this verification, please ignore this message."

            'ITO YUNG FORMAT NG EMAIL PARA ALAM NI SMTP ANG TARGET DOMAIN
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            'ITONG OBJECT NA TO IS KINUKUHA NIYA YUNG INFO AT PASSWORD NI SENDER NAKA ENCAPSULATE YUNG PASS PARA HINDI NIYO MAKITA!
            smtp.Credentials = New NetworkCredential("bobbycuen@gmail.com", pas)
            smtp.EnableSsl = True
            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'ITONG SUB NA TO PARA, TATAWAGIN TO SA SIGN UP FORM PARA IPSOK YUNG CRED SA DATABASE
    Public Sub insertInfo()
        Try
            DBcon.dbConOpen()
            Dim queryVer As String = "SELECT * FROM users WHERE username = @user"
            Dim cmd2 As New MySqlCommand(queryVer, con)
            cmd2.Parameters.AddWithValue("@user", username)
            Dim ver As MySqlDataReader = cmd2.ExecuteReader
            If ver.HasRows Then
                MsgBox("USERNAME ALREARY EXIST!", vbInformation, "USERNAME DUPLICATION")
                ver.Close()
            Else
                ver.Close()
                Dim query As String = "INSERT INTO namess (fname,lname,mname,suffix) VALUES (UCASE(@fname),UCASE(@lname),UCASE(@mname),UCASE(@suffix))"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@mname", mname)
                cmd.Parameters.AddWithValue("@suffix", suffix)
                cmd.ExecuteNonQuery()
                Dim lastID As Long = cmd.LastInsertedId

                Dim query1 As String = "INSERT INTO users (nameID, username, password,email, role) VALUES (@lastID, @user, @pass, @email, 'user')"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@lastID", lastID)
                cmd1.Parameters.AddWithValue("@user", username)
                cmd1.Parameters.AddWithValue("@pass", password)
                cmd1.Parameters.AddWithValue("@email", email)
                cmd1.ExecuteNonQuery()

                MsgBox("USER REGISTERED SUCESSFULLY!", vbInformation, "YEHEY!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR OCCURED")
        Finally
            GC.Collect()
            DBcon.dbConClose()
            clear(SignUp.Panel1)
        End Try
    End Sub
    'API CALLS FOR SIGN UP

    'API CALLS FOR BORROW HISTORY

    'ITONG SUB NA TO AY PARA SA BORROW HISTORY PANG NOTIFY DIN
    Public Sub NotifyReturnees(emails As String, misij As String)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("bobbycuen@gmail.com", "FROM: LIBRARY MANAGEMENT SYSTEM by Ian")
            mail.To.Add(emails)
            mail.Subject = "KINDLY RETURN THE BOOK!"
            mail.Body = misij

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("bobbycuen@gmail.com", pas)
            smtp.EnableSsl = True

            smtp.Send(mail)

            MessageBox.Show("YOUR NOTICE WAS SENT TO THEIR EMAIL!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'API CALLS FOR BORROW HISTORY

    'method for diaplaying profile picture
    Public Sub loadProfileImage()
        Try
            dbConOpen()
            Dim query As String = "SELECT profile_image FROM users WHERE userID = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", accNum)
            Dim pic As Object = cmd.ExecuteScalar
            Dim imagesByte() As Byte = DirectCast(pic, Byte())
            Dim ms As New MemoryStream(imagesByte)
            userImage = Image.FromStream(ms)
        Catch ex As Exception
        Finally
            dbConClose()
        End Try
    End Sub
    'method for diaplaying profile picture

    'ITONG SUB NA TO AY PANG CLEAR NG TEXTBOX SA LAHAT NG FORM PARA ISAHAN NALANG
    Sub clear(pnl As Panel)
        For Each obj In pnl.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub
End Module
