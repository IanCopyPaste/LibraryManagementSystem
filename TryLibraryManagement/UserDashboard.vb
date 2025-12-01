Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class UserDashboard

    ' SIGN OUT BUTTON
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        Form1.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the welcome message with the user's name stored in FetchAnything.name
        txtWelcome.Text = "Welcome! " & FetchAnything.name

        ' Show the User ID using the account number from FetchAnything.accNum
        userIDlbl.Text = "UserID: " & FetchAnything.accNum

        ' Load the user's profile image into the picture box
        ProfileBoxUpper.Image = userImage

        ' Load all available books (using wildcard % to fetch everything)
        loadBooks("%")

        ' Check if the profile image exists
        If ProfileBoxUpper.Image Is Nothing Then
            ' If no image, enable profile upload or edit options
            profileEnable(True)
        Else
            ' If image exists, disable profile edit unless needed
            profileEnable(False)
        End If
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        ' When the profile button is clicked, open the file dialog to select an image
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ' Save the selected file path or process it for storage
            createPath(OpenFileDialog1.FileName)

            ' Upload the selected profile image to the system/database
            uploadProfiles()
        End If
    End Sub

    Private Sub updateProfileBtn_Click(sender As Object, e As EventArgs) Handles updateProfileBtn.Click
        ' When the Update Profile button is clicked, open the file dialog to choose a new image
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ' Process or save the selected image file path
            createPath(OpenFileDialog1.FileName)

            ' Upload and update the profile image in the system/database
            uploadProfiles()
        End If
    End Sub

    Private Sub btnYourBooks_Click(sender As Object, e As EventArgs) Handles btnYourBooks.Click
        YourBorrowedBooks.Show()
        Me.Dispose()
    End Sub

    Private Sub txtSearchList_TextChanged(sender As Object, e As EventArgs) Handles txtSearchList.TextChanged
        ' Load books based on the current search text while typing
        loadBooks(txtSearchList.Text)

        ' If the search box is empty, load all available books again
        If txtSearchList.Text = "" Then
            loadBooks("%") ' % acts as a wildcard to show all results
        End If
    End Sub

    ' METHODS
    Public Sub profileEnable(ok As Boolean)
        ' Show the profile button if ok is True (e.g., when user has no profile image yet)
        profileBtn.Visible = ok

        ' Show the update profile button when ok is False (e.g., when profile image already exists)
        updateProfileBtn.Visible = Not ok
    End Sub

    Public Sub uploadProfiles()
        Try
            ' Open database connection
            dbConOpen()

            ' SQL update statement to store the selected profile image into the database
            Dim query As String = "UPDATE users SET profile_image = LOAD_FILE(@path) WHERE userID = @id"
            Dim cmd As New MySqlCommand(query, con)

            ' Attach values to the SQL parameters: user ID and file path for the profile image
            cmd.Parameters.AddWithValue("@id", accNum)
            cmd.Parameters.AddWithValue("@path", pathTocreate)

            ' Execute the command to update the database
            cmd.ExecuteNonQuery()

            ' Success message after uploading
            MsgBox("PROFILE PICTURE UPLOADED SUCESSFULLY!", vbInformation, "PROFILE UPLOADED!")

        Catch ex As MySqlException
            ' Catch any MySQL-related database errors
            MsgBox(ex.Message, vbCritical, "PROFILE INSERTION ERROR(0)")

        Catch ex As Exception
            ' Catch any other general errors
            MsgBox(ex.Message, vbCritical, "PROFILE INSERTION ERROR(1)")

        Finally
            ' Always close the connection after execution
            dbConClose()

            ' Reload the profile image after updating the database
            loadProfileImage()

            ' Refresh UI to reflect the updated profile picture
            refresh()
        End Try
    End Sub

    Public Sub refresh()
        ' Create a new instance of the UserDashboard form
        Dim ud As New UserDashboard

        ' Show the newly created dashboard (refreshing the page visually)
        ud.Show()

        ' Close the current form to remove the old instance from memory
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh()
    End Sub

    Public Sub loadBooks(param As String)
        ' Clear existing book records from the UI before loading new ones
        flowPanelRecords.Controls.Clear()

        Try
            ' Open database connection
            dbConOpen()

            ' Query to search books using the provided parameter (title or category)
            Dim query As String = "SELECT bookID, profile, category, title FROM books WHERE title LIKE @search OR category LIKE @search"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & param & "%")

            ' Execute query and retrieve rows that match
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop through all returned records
            While reader.Read()
                ' Read data from columns
                Dim title As String = reader.GetString("title")
                Dim imgBytes() As Byte = CType(reader("profile"), Byte())
                Dim cat As String = reader.GetString("category")
                Dim getID2 As Integer = reader.GetValue("bookID")

                ' Convert image bytes into a displayable image
                Dim ms As New MemoryStream(imgBytes)
                Dim img As Image = Image.FromStream(ms)

                ' Create card container with shadow effect
                Dim cardShadow As New Panel With {
                    .Width = 180,
                    .Height = 300,
                    .Margin = New Padding(15),
                    .BackColor = Color.Gainsboro,
                    .Padding = New Padding(0, 3, 3, 3)
                }

                ' Main card panel to represent a book
                Dim card As New Panel With {
                    .Width = 177,
                    .Height = 277,
                    .BackColor = Color.Teal,
                    .Dock = DockStyle.Fill,
                    .Cursor = Cursors.Hand
                }

                ' Image container area
                Dim imgContainer As New Panel With {
                    .Width = 160,
                    .Height = 200,
                    .Location = New Point(9, 9),
                    .BackColor = Color.Teal
                }

                ' Display book cover image
                Dim pic As New PictureBox With {
                    .Image = img,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Width = 160,
                    .Height = 200,
                    .Location = New Point(0, 0),
                    .BackColor = Color.Transparent
                }

                ' Book title label
                Dim lblTitle As New Label With {
                    .Text = title,
                    .ForeColor = Color.White,
                    .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                    .AutoSize = True,
                    .MaximumSize = New Size(160, 0),
                    .Location = New Point(9, 212),
                    .TextAlign = ContentAlignment.TopLeft
                }

                ' Book genre label
                Dim lblGenre As New Label With {
                    .Text = "Genre: " & cat,
                    .ForeColor = Color.White,
                    .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                    .AutoSize = True,
                    .MaximumSize = New Size(160, 0),
                    .Location = New Point(9, 258),
                    .TextAlign = ContentAlignment.TopLeft
                }

                ' Hover animation — expand shadow padding
                AddHandler card.MouseEnter,
                    Sub()
                        cardShadow.Padding = New Padding(0, 5, 5, 5)
                    End Sub

                ' Leave hover animation — back to normal
                AddHandler card.MouseLeave,
                    Sub()
                        cardShadow.Padding = New Padding(0, 3, 3, 3)
                    End Sub

                ' When card is clicked → open book borrowing form
                AddHandler card.Click,
                    Sub()
                        FetchAnything.getID3 = getID2
                        BorrowBookForm.Show()
                    End Sub

                ' Make picture + title clickable with same behavior and hover effect
                For Each ctrl As Control In {pic, imgContainer, lblTitle}
                    ctrl.Cursor = Cursors.Hand

                    AddHandler ctrl.Click,
                        Sub()
                            FetchAnything.getID3 = getID2
                            BorrowBookForm.Show()
                        End Sub

                    AddHandler ctrl.MouseEnter,
                        Sub()
                            cardShadow.Padding = New Padding(0, 5, 5, 5)
                        End Sub

                    AddHandler ctrl.MouseLeave,
                        Sub()
                            cardShadow.Padding = New Padding(0, 3, 3, 3)
                        End Sub
                Next

                ' Build the card UI
                imgContainer.Controls.Add(pic)
                card.Controls.Add(imgContainer)
                card.Controls.Add(lblTitle)
                card.Controls.Add(lblGenre)
                cardShadow.Controls.Add(card)

                ' Add card to the flow panel layout
                flowPanelRecords.Controls.Add(cardShadow)
            End While

            ' Close data reader
            reader.Close()

        Catch ex As Exception
            ' Display any unexpected error
            MessageBox.Show("Error: " & ex.Message)

        Finally
            ' Close database connection always
            dbConClose()
        End Try
    End Sub

    'methods
End Class
