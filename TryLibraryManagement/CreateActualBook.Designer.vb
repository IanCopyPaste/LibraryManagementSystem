<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateActualBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateActualBook))
        txtTitle = New TextBox()
        InsertBtn = New Button()
        bookPic = New PictureBox()
        txtAuthor = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtCategory = New ComboBox()
        Label4 = New Label()
        txtPubDate = New DateTimePicker()
        Label5 = New Label()
        btnUploadPhoto = New Button()
        UploadPhotoDialoag = New OpenFileDialog()
        btnBack = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(bookPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.BorderStyle = BorderStyle.None
        txtTitle.Cursor = Cursors.Hand
        txtTitle.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(70, 113)
        txtTitle.Margin = New Padding(3, 2, 3, 2)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(181, 18)
        txtTitle.TabIndex = 0
        ' 
        ' InsertBtn
        ' 
        InsertBtn.BackColor = Color.DarkSlateGray
        InsertBtn.Cursor = Cursors.Hand
        InsertBtn.FlatAppearance.BorderSize = 0
        InsertBtn.FlatStyle = FlatStyle.Flat
        InsertBtn.Font = New Font("Segoe UI Semibold", 12.75F, FontStyle.Bold)
        InsertBtn.ForeColor = Color.White
        InsertBtn.Location = New Point(133, 389)
        InsertBtn.Margin = New Padding(3, 2, 3, 2)
        InsertBtn.Name = "InsertBtn"
        InsertBtn.Size = New Size(257, 32)
        InsertBtn.TabIndex = 1
        InsertBtn.Text = "Insert"
        InsertBtn.UseVisualStyleBackColor = False
        ' 
        ' bookPic
        ' 
        bookPic.BackColor = Color.DarkSlateGray
        bookPic.Location = New Point(300, 56)
        bookPic.Margin = New Padding(3, 2, 3, 2)
        bookPic.Name = "bookPic"
        bookPic.Size = New Size(196, 284)
        bookPic.SizeMode = PictureBoxSizeMode.StretchImage
        bookPic.TabIndex = 2
        bookPic.TabStop = False
        ' 
        ' txtAuthor
        ' 
        txtAuthor.BorderStyle = BorderStyle.None
        txtAuthor.Cursor = Cursors.Hand
        txtAuthor.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuthor.Location = New Point(70, 179)
        txtAuthor.Margin = New Padding(3, 2, 3, 2)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(181, 18)
        txtAuthor.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(53, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 6
        Label2.Text = "Book Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(53, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 7
        Label3.Text = "Book Author"
        ' 
        ' txtCategory
        ' 
        txtCategory.Cursor = Cursors.Hand
        txtCategory.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategory.FormattingEnabled = True
        txtCategory.Items.AddRange(New Object() {"Adult", "Horror", "Science Fiction", "Romance", "Poetry", "Lifestyle", "Action", "History", "Fantasy", "Mystery", "Thriller", "Drama", "Biography", "Adventure", "Self-Help"})
        txtCategory.Location = New Point(53, 244)
        txtCategory.Margin = New Padding(3, 2, 3, 2)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(211, 25)
        txtCategory.TabIndex = 9
        txtCategory.Text = "Adult"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(53, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 10
        Label4.Text = "Category"
        ' 
        ' txtPubDate
        ' 
        txtPubDate.Cursor = Cursors.Hand
        txtPubDate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPubDate.Location = New Point(53, 303)
        txtPubDate.Margin = New Padding(3, 2, 3, 2)
        txtPubDate.Name = "txtPubDate"
        txtPubDate.Size = New Size(211, 25)
        txtPubDate.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(53, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 12
        Label5.Text = "Date Published"
        ' 
        ' btnUploadPhoto
        ' 
        btnUploadPhoto.BackColor = Color.Teal
        btnUploadPhoto.Cursor = Cursors.Hand
        btnUploadPhoto.FlatAppearance.BorderSize = 0
        btnUploadPhoto.FlatStyle = FlatStyle.Flat
        btnUploadPhoto.Font = New Font("Rockwell", 11.25F, FontStyle.Bold)
        btnUploadPhoto.ForeColor = Color.White
        btnUploadPhoto.Image = CType(resources.GetObject("btnUploadPhoto.Image"), Image)
        btnUploadPhoto.Location = New Point(319, 174)
        btnUploadPhoto.Margin = New Padding(3, 2, 3, 2)
        btnUploadPhoto.Name = "btnUploadPhoto"
        btnUploadPhoto.Size = New Size(155, 40)
        btnUploadPhoto.TabIndex = 13
        btnUploadPhoto.Text = "Upload Photo"
        btnUploadPhoto.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUploadPhoto.UseVisualStyleBackColor = False
        ' 
        ' UploadPhotoDialoag
        ' 
        UploadPhotoDialoag.FileName = "OpenFileDialog1"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSlateGray
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.Location = New Point(12, 12)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(164, 40)
        btnBack.TabIndex = 14
        btnBack.Text = "Back To Dashboard"
        btnBack.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(53, 99)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(211, 46)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 42
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(53, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' CreateActualBook
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(557, 460)
        Controls.Add(btnBack)
        Controls.Add(btnUploadPhoto)
        Controls.Add(Label5)
        Controls.Add(txtPubDate)
        Controls.Add(Label4)
        Controls.Add(txtCategory)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAuthor)
        Controls.Add(bookPic)
        Controls.Add(InsertBtn)
        Controls.Add(txtTitle)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MinimumSize = New Size(573, 499)
        Name = "CreateActualBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Insert a Book"
        TopMost = True
        CType(bookPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents InsertBtn As Button
    Friend WithEvents bookPic As PictureBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPubDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents UploadPhotoDialoag As OpenFileDialog
    Friend WithEvents btnBack As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
