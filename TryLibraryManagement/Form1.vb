Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient
Public Class Form1

    'etong sub na to is ginagamit for validation or LOG IN BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        'ITO AY CHINECHECK NIYA KUNG MAY LAMAN SI PASSWORD TEXT BOX
        If txtUsernameLog.Text = "" Or txtPasswordLog.Text = "" Then
            MsgBox("PLEASE ENTER CREDENTIALS", vbInformation, "INPUTS")
            clear(Panel1)
        Else
            'DITO NIYA NA IPAPASOK YUNG USER AT ICHECHECK KUNG ANG ROLE AY ADMIN OR USER
            Try
                dbConOpen()
                Dim query As String = "SELECT * FROM users u 
                                       INNER JOIN namess n ON n.nameID = u.nameID
                                       WHERE u.username = @user AND u.password = @pass"
                Dim verify As New MySqlCommand(query, con)
                verify.Parameters.AddWithValue("@user", txtUsernameLog.Text)
                verify.Parameters.AddWithValue("@pass", txtPasswordLog.Text)
                Dim count As MySqlDataReader = verify.ExecuteReader
                If count.HasRows Then
                    While count.Read
                        FetchAnything.name = count.GetString("fname")
                        FetchAnything.accNum = count.GetValue("userID")
                        If count.GetString("role") = "admin" Then
                            MsgBox("LOG IN SUCCESS TO ADMIN", vbInformation, "SUCCESS")
                            count.Close()
                            loadProfileImage()
                            MainDashboard.Show()
                            Me.Hide()
                            Exit While
                        ElseIf count.GetString("role") = "user" Then
                            count.Close()
                            loadProfileImage()
                            UserDashboard.Show()
                            Me.Hide()
                            Exit While
                        End If
                    End While
                    'DITO KAPAG WALANG NAG MATCH SI READ SA MGA INPUT NI USER MAGBABATO NIYA NG INCORRECT ETC. PARANG GANYAN
                Else
                    MsgBox("INCORRECT USERNAME OR PASSWORD", vbCritical, "ERROR")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "CONNECTION ERROR")
            Finally
                GC.Collect()
                dbConClose()
                clear(Panel1)
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles toSignUp.Click
        SignUp.Show()
        Me.Hide()
    End Sub
    'ITONG SUB NA TO AY TINATAWAG PARA MAG LOOP

    Dim see As Boolean = False

    'ITONG SUB NA TO IS GINAGAMIT PARA MAKITA YUNG PASSWORD INSTEAD NA PURO DOT
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If see Then
            txtPasswordLog.UseSystemPasswordChar = False
            see = False
        Else
            txtPasswordLog.UseSystemPasswordChar = True
            see = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class