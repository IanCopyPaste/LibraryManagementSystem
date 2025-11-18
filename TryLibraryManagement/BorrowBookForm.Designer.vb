<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowBookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        borrowPic = New PictureBox()
        txtTitle = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtAuth = New TextBox()
        Label4 = New Label()
        txtDate = New TextBox()
        Label5 = New Label()
        txtGenre = New TextBox()
        Label6 = New Label()
        txtStatus = New TextBox()
        btnBorrow = New Button()
        Label3 = New Label()
        txtBookID = New TextBox()
        Button1 = New Button()
        lblNotVail = New Label()
        CType(borrowPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' borrowPic
        ' 
        borrowPic.BackColor = Color.Green
        borrowPic.Location = New Point(353, 77)
        borrowPic.Name = "borrowPic"
        borrowPic.Size = New Size(198, 255)
        borrowPic.SizeMode = PictureBoxSizeMode.StretchImage
        borrowPic.TabIndex = 0
        borrowPic.TabStop = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(32, 77)
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Title"
        txtTitle.ReadOnly = True
        txtTitle.Size = New Size(258, 27)
        txtTitle.TabIndex = 1
        txtTitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(32, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 3
        Label1.Text = "TITLE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(32, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 5
        Label2.Text = "AUTHOR"
        ' 
        ' txtAuth
        ' 
        txtAuth.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuth.Location = New Point(32, 127)
        txtAuth.Name = "txtAuth"
        txtAuth.PlaceholderText = "Author"
        txtAuth.ReadOnly = True
        txtAuth.Size = New Size(258, 27)
        txtAuth.TabIndex = 4
        txtAuth.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(32, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 15)
        Label4.TabIndex = 8
        Label4.Text = "DATE PUBLISHED"
        ' 
        ' txtDate
        ' 
        txtDate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDate.Location = New Point(32, 177)
        txtDate.Name = "txtDate"
        txtDate.PlaceholderText = "PUBLICATION DATE"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(258, 27)
        txtDate.TabIndex = 7
        txtDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(32, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 10
        Label5.Text = "GENRE"
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(32, 227)
        txtGenre.Name = "txtGenre"
        txtGenre.PlaceholderText = "GENRE"
        txtGenre.ReadOnly = True
        txtGenre.Size = New Size(258, 27)
        txtGenre.TabIndex = 9
        txtGenre.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(32, 259)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 12
        Label6.Text = "STATUS"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(32, 279)
        txtStatus.Name = "txtStatus"
        txtStatus.PlaceholderText = "STATUS"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(258, 27)
        txtStatus.TabIndex = 11
        txtStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.Green
        btnBorrow.FlatAppearance.BorderSize = 0
        btnBorrow.FlatStyle = FlatStyle.Flat
        btnBorrow.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(149, 375)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(282, 31)
        btnBorrow.TabIndex = 14
        btnBorrow.Text = "Borrow Book"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(370, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 16
        Label3.Text = "BOOK ID"
        ' 
        ' txtBookID
        ' 
        txtBookID.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBookID.Location = New Point(370, 44)
        txtBookID.Name = "txtBookID"
        txtBookID.PlaceholderText = "BookID"
        txtBookID.Size = New Size(165, 27)
        txtBookID.TabIndex = 15
        txtBookID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 24)
        Button1.TabIndex = 17
        Button1.Text = "Go Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblNotVail
        ' 
        lblNotVail.AutoSize = True
        lblNotVail.BackColor = Color.AntiqueWhite
        lblNotVail.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNotVail.ForeColor = Color.Red
        lblNotVail.Location = New Point(203, 355)
        lblNotVail.Name = "lblNotVail"
        lblNotVail.Size = New Size(185, 17)
        lblNotVail.TabIndex = 18
        lblNotVail.Text = "*Sorry Book is not Avaialble*"
        lblNotVail.Visible = False
        ' 
        ' BorrowBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(584, 418)
        Controls.Add(lblNotVail)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtBookID)
        Controls.Add(btnBorrow)
        Controls.Add(Label6)
        Controls.Add(txtStatus)
        Controls.Add(Label5)
        Controls.Add(txtGenre)
        Controls.Add(Label4)
        Controls.Add(txtDate)
        Controls.Add(Label2)
        Controls.Add(txtAuth)
        Controls.Add(Label1)
        Controls.Add(txtTitle)
        Controls.Add(borrowPic)
        Name = "BorrowBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BorrowBookForm"
        TopMost = True
        CType(borrowPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents borrowPic As PictureBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNotVail As Label
End Class
