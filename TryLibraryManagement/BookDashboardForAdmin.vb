Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BookDashboardForAdmin
    Private Sub BookDashboardForAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfileBoxUpper.Image = userImage
        loadBooks("%")
    End Sub

    Private Sub userPageBtn_Click(sender As Object, e As EventArgs) Handles userPageBtn.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub InsertBooksBtn_Click(sender As Object, e As EventArgs) Handles InsertBooksBtn.Click
        InsertBooks.Show()
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub BookHistoryBtn_Click(sender As Object, e As EventArgs) Handles BookHistoryBtn.Click
        BorrowHistory.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As New BookDashboardForAdmin
        bd.Show()
        Me.Dispose()
    End Sub


    Private Sub txtSearchList_TextChanged(sender As Object, e As EventArgs) Handles txtSearchList.TextChanged
        loadBooks(txtSearchList.Text)
        If txtSearchList.Text = "" Then
            loadBooks("%")
        End If
    End Sub

    'method for displaying book
    Public Sub loadBooks(param As String)
        flowPanelRecords.Controls.Clear()
        Try
            dbConOpen()
            Dim query As String = "SELECT bookID, profile, category,title FROM books WHERE title LIKE @search OR category LIKE @search"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & param & "%")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim title As String = reader.GetString("title")
                Dim imgBytes() As Byte = CType(reader("profile"), Byte())
                Dim cat As String = reader.GetString("category")
                Dim getID2 As Integer = reader.GetValue("bookID")

                Dim ms As New MemoryStream(imgBytes)
                Dim img As Image = Image.FromStream(ms)

                Dim cardShadow As New Panel With {
            .Width = 180,
            .Height = 300,
            .Margin = New Padding(15),
            .BackColor = Color.DarkGray,
            .Padding = New Padding(0, 3, 3, 3)
        }

                Dim card As New Panel With {
            .Width = 177,
            .Height = 277,
            .BackColor = Color.Teal,
            .Dock = DockStyle.Fill,
            .Cursor = Cursors.Hand
        }

                Dim imgContainer As New Panel With {
            .Width = 160,
            .Height = 200,
            .Location = New Point(9, 9),
            .BackColor = Color.CadetBlue
        }


                Dim pic As New PictureBox With {
            .Image = img,
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Width = 160,
            .Height = 200,
            .Location = New Point(0, 0),
            .BackColor = Color.Transparent
        }

                Dim lblTitle As New Label With {
            .Text = title,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10.5F, FontStyle.Bold),
            .AutoSize = True,
            .MaximumSize = New Size(160, 0),
            .Location = New Point(9, 212),
            .TextAlign = ContentAlignment.TopLeft
        }
                Dim lblGenre As New Label With {
            .Text = "Genre: " & cat,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
            .AutoSize = True,
            .MaximumSize = New Size(160, 0),
            .Location = New Point(9, 258),
            .TextAlign = ContentAlignment.TopLeft
        }
                AddHandler card.MouseEnter, Sub(sender1, e1)
                                                cardShadow.Padding = New Padding(0, 5, 5, 5)
                                            End Sub

                AddHandler card.MouseLeave, Sub(sender1, e1)
                                                cardShadow.Padding = New Padding(0, 3, 3, 3)
                                            End Sub

                AddHandler card.Click, Sub(sender1, e1)
                                           MsgBox("ADMINS CANNOT BORROW A BOOK", vbInformation, "NO! NO! NO!")
                                       End Sub

                For Each ctrl As Control In {pic, imgContainer, lblTitle}
                    ctrl.Cursor = Cursors.Hand
                    AddHandler ctrl.Click, Sub(sender2, e2)
                                               MsgBox("ADMINS CANNOT BORROW A BOOK", vbInformation, "NO! NO! NO!")
                                           End Sub
                    AddHandler ctrl.MouseEnter, Sub(sender2, e2)
                                                    cardShadow.Padding = New Padding(0, 5, 5, 5)
                                                End Sub
                    AddHandler ctrl.MouseLeave, Sub(sender2, e2)
                                                    cardShadow.Padding = New Padding(0, 3, 3, 3)
                                                End Sub
                Next
                'gawin ang card
                imgContainer.Controls.Add(pic)
                card.Controls.Add(imgContainer)
                card.Controls.Add(lblTitle)
                card.Controls.Add(lblGenre)
                cardShadow.Controls.Add(card)

                flowPanelRecords.Controls.Add(cardShadow)
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dbConClose()
        End Try
    End Sub
    'method for displaying book
End Class