<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnBookForm))
        Button1 = New Button()
        Label3 = New Label()
        txtBookID = New TextBox()
        btnReturn = New Button()
        Label6 = New Label()
        txtStatus = New TextBox()
        Label5 = New Label()
        txtGenre = New TextBox()
        Label4 = New Label()
        txtDate = New TextBox()
        Label2 = New Label()
        txtAuth = New TextBox()
        Label1 = New Label()
        txtTitle = New TextBox()
        borrowPic = New PictureBox()
        lblNotVail = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        CType(borrowPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 24)
        Button1.TabIndex = 33
        Button1.Text = "Go Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(365, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 32
        Label3.Text = "Book ID"
        ' 
        ' txtBookID
        ' 
        txtBookID.BackColor = Color.White
        txtBookID.BorderStyle = BorderStyle.None
        txtBookID.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBookID.Location = New Point(378, 50)
        txtBookID.Name = "txtBookID"
        txtBookID.PlaceholderText = "BookID"
        txtBookID.ReadOnly = True
        txtBookID.Size = New Size(147, 20)
        txtBookID.TabIndex = 31
        txtBookID.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.DarkSlateGray
        btnReturn.FlatAppearance.BorderSize = 0
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(149, 375)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(282, 31)
        btnReturn.TabIndex = 30
        btnReturn.Text = "Return Book"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(32, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 29
        Label6.Text = "Status"
        ' 
        ' txtStatus
        ' 
        txtStatus.BackColor = Color.White
        txtStatus.BorderStyle = BorderStyle.None
        txtStatus.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(47, 302)
        txtStatus.Name = "txtStatus"
        txtStatus.PlaceholderText = "Status"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(214, 20)
        txtStatus.TabIndex = 28
        txtStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(32, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 27
        Label5.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.White
        txtGenre.BorderStyle = BorderStyle.None
        txtGenre.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(47, 243)
        txtGenre.Name = "txtGenre"
        txtGenre.PlaceholderText = "Genre"
        txtGenre.ReadOnly = True
        txtGenre.Size = New Size(214, 20)
        txtGenre.TabIndex = 26
        txtGenre.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(32, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 20)
        Label4.TabIndex = 25
        Label4.Text = "Date Published"
        ' 
        ' txtDate
        ' 
        txtDate.BackColor = Color.White
        txtDate.BorderStyle = BorderStyle.None
        txtDate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDate.Location = New Point(47, 183)
        txtDate.Name = "txtDate"
        txtDate.PlaceholderText = "Publication Date"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(214, 20)
        txtDate.TabIndex = 24
        txtDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(33, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 23
        Label2.Text = "Author"
        ' 
        ' txtAuth
        ' 
        txtAuth.BackColor = Color.White
        txtAuth.BorderStyle = BorderStyle.None
        txtAuth.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuth.Location = New Point(47, 124)
        txtAuth.Name = "txtAuth"
        txtAuth.PlaceholderText = "Author"
        txtAuth.ReadOnly = True
        txtAuth.Size = New Size(214, 20)
        txtAuth.TabIndex = 22
        txtAuth.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(33, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 21
        Label1.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.BackColor = Color.White
        txtTitle.BorderStyle = BorderStyle.None
        txtTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(47, 64)
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = "Title"
        txtTitle.ReadOnly = True
        txtTitle.Size = New Size(214, 20)
        txtTitle.TabIndex = 20
        txtTitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' borrowPic
        ' 
        borrowPic.BackColor = Color.DarkSlateGray
        borrowPic.BorderStyle = BorderStyle.FixedSingle
        borrowPic.Location = New Point(353, 77)
        borrowPic.Name = "borrowPic"
        borrowPic.Size = New Size(198, 255)
        borrowPic.SizeMode = PictureBoxSizeMode.StretchImage
        borrowPic.TabIndex = 19
        borrowPic.TabStop = False
        ' 
        ' lblNotVail
        ' 
        lblNotVail.AutoSize = True
        lblNotVail.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNotVail.ForeColor = Color.White
        lblNotVail.Location = New Point(203, 355)
        lblNotVail.Name = "lblNotVail"
        lblNotVail.Size = New Size(185, 17)
        lblNotVail.TabIndex = 34
        lblNotVail.Text = "*Sorry Book is not Avaialble*"
        lblNotVail.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(33, 58)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(239, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 44
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(33, 117)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(239, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(33, 177)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(239, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 46
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(33, 237)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(239, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 47
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(32, 296)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(239, 33)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 48
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.None
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(365, 44)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(174, 33)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 49
        PictureBox6.TabStop = False
        ' 
        ' ReturnBookForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(584, 418)
        Controls.Add(lblNotVail)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtBookID)
        Controls.Add(btnReturn)
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
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MinimumSize = New Size(600, 457)
        Name = "ReturnBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReturnBookForm"
        CType(borrowPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents borrowPic As PictureBox
    Friend WithEvents lblNotVail As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
