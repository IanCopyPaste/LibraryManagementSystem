<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        uploadPhotoDialog = New OpenFileDialog()
        TopPanel = New Panel()
        PictureBox1 = New PictureBox()
        updateProfileBtn = New Button()
        profileBtn = New Button()
        userIDlbl = New Label()
        txtWelcome = New TextBox()
        ProfileBoxUpper = New PictureBox()
        Label1 = New Label()
        SidePanel = New Panel()
        BookHistoryBtn = New Button()
        btnBookDashboard = New Button()
        SignOutBtn = New Button()
        InsertBooksBtn = New Button()
        userPageBtn = New Button()
        refreshBtn = New Button()
        MainPanel = New Panel()
        Label9 = New Label()
        txtUserID = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ProfileBoxMain = New PictureBox()
        updateBtn = New Button()
        comboAccess = New ComboBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        txtSuffix = New TextBox()
        txtMname = New TextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        searchBox = New TextBox()
        ewanTable = New DataGridView()
        USER_ID = New DataGridViewTextBoxColumn()
        FULLNAME = New DataGridViewTextBoxColumn()
        USERNAME = New DataGridViewTextBoxColumn()
        EMAIL = New DataGridViewTextBoxColumn()
        ACCESS = New DataGridViewTextBoxColumn()
        Edit = New DataGridViewImageColumn()
        Delete = New DataGridViewImageColumn()
        TimeLabel = New Label()
        TimeForTimer = New Timer(components)
        ToolTip1 = New ToolTip(components)
        TopPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(ProfileBoxMain, ComponentModel.ISupportInitialize).BeginInit()
        CType(ewanTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' uploadPhotoDialog
        ' 
        uploadPhotoDialog.FileName = "profileDialog"
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.Brown
        TopPanel.Controls.Add(PictureBox1)
        TopPanel.Controls.Add(updateProfileBtn)
        TopPanel.Controls.Add(profileBtn)
        TopPanel.Controls.Add(userIDlbl)
        TopPanel.Controls.Add(txtWelcome)
        TopPanel.Controls.Add(ProfileBoxUpper)
        TopPanel.Controls.Add(Label1)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
        TopPanel.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(58, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' updateProfileBtn
        ' 
        updateProfileBtn.BackColor = Color.Tomato
        updateProfileBtn.Cursor = Cursors.Hand
        updateProfileBtn.FlatAppearance.BorderSize = 0
        updateProfileBtn.FlatStyle = FlatStyle.Flat
        updateProfileBtn.Font = New Font("Rockwell", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        updateProfileBtn.ForeColor = Color.White
        updateProfileBtn.Image = CType(resources.GetObject("updateProfileBtn.Image"), Image)
        updateProfileBtn.Location = New Point(1073, 12)
        updateProfileBtn.Name = "updateProfileBtn"
        updateProfileBtn.Size = New Size(99, 46)
        updateProfileBtn.TabIndex = 8
        updateProfileBtn.Text = " Update" & vbCrLf & " Profile"
        updateProfileBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        updateProfileBtn.UseVisualStyleBackColor = False
        ' 
        ' profileBtn
        ' 
        profileBtn.BackColor = Color.Tomato
        profileBtn.Cursor = Cursors.Hand
        profileBtn.FlatAppearance.BorderSize = 0
        profileBtn.FlatStyle = FlatStyle.Flat
        profileBtn.Font = New Font("Rockwell", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        profileBtn.ForeColor = Color.White
        profileBtn.Image = CType(resources.GetObject("profileBtn.Image"), Image)
        profileBtn.Location = New Point(1163, 12)
        profileBtn.Name = "profileBtn"
        profileBtn.Size = New Size(100, 46)
        profileBtn.TabIndex = 7
        profileBtn.Text = "  Upload " & vbCrLf & " Profile"
        profileBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        profileBtn.UseVisualStyleBackColor = False
        ' 
        ' userIDlbl
        ' 
        userIDlbl.AutoSize = True
        userIDlbl.BackColor = Color.Transparent
        userIDlbl.Font = New Font("Rockwell", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        userIDlbl.ForeColor = Color.White
        userIDlbl.Location = New Point(761, 44)
        userIDlbl.Name = "userIDlbl"
        userIDlbl.Size = New Size(67, 19)
        userIDlbl.TabIndex = 6
        userIDlbl.Text = "UserID: "
        ' 
        ' txtWelcome
        ' 
        txtWelcome.BackColor = Color.Brown
        txtWelcome.BorderStyle = BorderStyle.None
        txtWelcome.Font = New Font("Sitka Small Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtWelcome.ForeColor = Color.WhiteSmoke
        txtWelcome.Location = New Point(761, 10)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.ReadOnly = True
        txtWelcome.Size = New Size(237, 31)
        txtWelcome.TabIndex = 2
        txtWelcome.Text = "Welcome, "
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1178, 3)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(76, 68)
        ProfileBoxUpper.TabIndex = 1
        ProfileBoxUpper.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Text Semibold", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(65, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(584, 53)
        Label1.TabIndex = 0
        Label1.Text = "Barangay International Library"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.Salmon
        SidePanel.Controls.Add(BookHistoryBtn)
        SidePanel.Controls.Add(btnBookDashboard)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Controls.Add(InsertBooksBtn)
        SidePanel.Controls.Add(userPageBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(105, 563)
        SidePanel.TabIndex = 1
        ' 
        ' BookHistoryBtn
        ' 
        BookHistoryBtn.BackColor = Color.Brown
        BookHistoryBtn.Cursor = Cursors.Hand
        BookHistoryBtn.FlatAppearance.BorderSize = 0
        BookHistoryBtn.FlatStyle = FlatStyle.Flat
        BookHistoryBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        BookHistoryBtn.ForeColor = Color.WhiteSmoke
        BookHistoryBtn.Image = CType(resources.GetObject("BookHistoryBtn.Image"), Image)
        BookHistoryBtn.Location = New Point(0, 186)
        BookHistoryBtn.Name = "BookHistoryBtn"
        BookHistoryBtn.Size = New Size(105, 60)
        BookHistoryBtn.TabIndex = 9
        BookHistoryBtn.Text = "Borrow History"
        BookHistoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        BookHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' btnBookDashboard
        ' 
        btnBookDashboard.BackColor = Color.Brown
        btnBookDashboard.Cursor = Cursors.Hand
        btnBookDashboard.FlatAppearance.BorderSize = 0
        btnBookDashboard.FlatStyle = FlatStyle.Flat
        btnBookDashboard.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnBookDashboard.ForeColor = Color.WhiteSmoke
        btnBookDashboard.Image = CType(resources.GetObject("btnBookDashboard.Image"), Image)
        btnBookDashboard.Location = New Point(0, 267)
        btnBookDashboard.Name = "btnBookDashboard"
        btnBookDashboard.Size = New Size(106, 60)
        btnBookDashboard.TabIndex = 7
        btnBookDashboard.Text = "Book Dash" & vbCrLf & "Board"
        btnBookDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDashboard.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = Color.Brown
        SignOutBtn.Cursor = Cursors.Hand
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        SignOutBtn.ForeColor = Color.WhiteSmoke
        SignOutBtn.Image = CType(resources.GetObject("SignOutBtn.Image"), Image)
        SignOutBtn.Location = New Point(0, 472)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(105, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' InsertBooksBtn
        ' 
        InsertBooksBtn.BackColor = Color.Brown
        InsertBooksBtn.Cursor = Cursors.Hand
        InsertBooksBtn.FlatAppearance.BorderSize = 0
        InsertBooksBtn.FlatStyle = FlatStyle.Flat
        InsertBooksBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBooksBtn.ForeColor = Color.WhiteSmoke
        InsertBooksBtn.Image = CType(resources.GetObject("InsertBooksBtn.Image"), Image)
        InsertBooksBtn.Location = New Point(0, 104)
        InsertBooksBtn.Name = "InsertBooksBtn"
        InsertBooksBtn.Size = New Size(105, 60)
        InsertBooksBtn.TabIndex = 1
        InsertBooksBtn.Text = "Manage" & vbCrLf & "Books" & vbCrLf
        InsertBooksBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        InsertBooksBtn.UseVisualStyleBackColor = False
        ' 
        ' userPageBtn
        ' 
        userPageBtn.BackColor = Color.Brown
        userPageBtn.Cursor = Cursors.Hand
        userPageBtn.FlatAppearance.BorderSize = 0
        userPageBtn.FlatStyle = FlatStyle.Flat
        userPageBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userPageBtn.ForeColor = Color.WhiteSmoke
        userPageBtn.Image = CType(resources.GetObject("userPageBtn.Image"), Image)
        userPageBtn.Location = New Point(0, 19)
        userPageBtn.Name = "userPageBtn"
        userPageBtn.Size = New Size(105, 60)
        userPageBtn.TabIndex = 0
        userPageBtn.Text = "Manage Users"
        userPageBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' refreshBtn
        ' 
        refreshBtn.BackColor = Color.Transparent
        refreshBtn.Cursor = Cursors.Hand
        refreshBtn.FlatAppearance.BorderSize = 0
        refreshBtn.FlatAppearance.MouseOverBackColor = Color.LightCoral
        refreshBtn.FlatStyle = FlatStyle.Flat
        refreshBtn.Font = New Font("Rockwell", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        refreshBtn.ForeColor = Color.Transparent
        refreshBtn.Image = CType(resources.GetObject("refreshBtn.Image"), Image)
        refreshBtn.Location = New Point(0, 6)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(44, 38)
        refreshBtn.TabIndex = 5
        refreshBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Tomato
        MainPanel.Controls.Add(Label9)
        MainPanel.Controls.Add(txtUserID)
        MainPanel.Controls.Add(Label8)
        MainPanel.Controls.Add(Label7)
        MainPanel.Controls.Add(Label6)
        MainPanel.Controls.Add(Label5)
        MainPanel.Controls.Add(Label4)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(ProfileBoxMain)
        MainPanel.Controls.Add(refreshBtn)
        MainPanel.Controls.Add(updateBtn)
        MainPanel.Controls.Add(comboAccess)
        MainPanel.Controls.Add(txtEmail)
        MainPanel.Controls.Add(txtUsername)
        MainPanel.Controls.Add(txtSuffix)
        MainPanel.Controls.Add(txtMname)
        MainPanel.Controls.Add(txtLname)
        MainPanel.Controls.Add(txtFname)
        MainPanel.Controls.Add(searchBox)
        MainPanel.Controls.Add(ewanTable)
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Font = New Font("Sitka Banner", 12.7499981F, FontStyle.Bold Or FontStyle.Italic)
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(128, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 23)
        Label9.TabIndex = 21
        Label9.Text = "User ID"
        ' 
        ' txtUserID
        ' 
        txtUserID.BackColor = Color.Brown
        txtUserID.BorderStyle = BorderStyle.FixedSingle
        txtUserID.Font = New Font("Rockwell", 11.25F)
        txtUserID.ForeColor = Color.White
        txtUserID.Location = New Point(118, 173)
        txtUserID.Name = "txtUserID"
        txtUserID.ReadOnly = True
        txtUserID.Size = New Size(102, 25)
        txtUserID.TabIndex = 20
        txtUserID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(235, 414)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 23)
        Label8.TabIndex = 19
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(45, 414)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 23)
        Label7.TabIndex = 18
        Label7.Text = "User Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Banner", 12.7499981F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(149, 477)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 24)
        Label6.TabIndex = 17
        Label6.Text = "Access"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(235, 331)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 23)
        Label5.TabIndex = 16
        Label5.Text = "Suffix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(36, 331)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 23)
        Label4.TabIndex = 15
        Label4.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(215, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 23)
        Label3.TabIndex = 14
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(42, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 23)
        Label2.TabIndex = 13
        Label2.Text = "First Name"
        ' 
        ' ProfileBoxMain
        ' 
        ProfileBoxMain.BackColor = Color.Brown
        ProfileBoxMain.BackgroundImageLayout = ImageLayout.Stretch
        ProfileBoxMain.ErrorImage = Nothing
        ProfileBoxMain.InitialImage = Nothing
        ProfileBoxMain.Location = New Point(88, 19)
        ProfileBoxMain.Name = "ProfileBoxMain"
        ProfileBoxMain.Size = New Size(160, 145)
        ProfileBoxMain.TabIndex = 4
        ProfileBoxMain.TabStop = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.Brown
        updateBtn.Cursor = Cursors.Hand
        updateBtn.Enabled = False
        updateBtn.FlatAppearance.BorderSize = 0
        updateBtn.FlatAppearance.MouseOverBackColor = Color.Salmon
        updateBtn.FlatStyle = FlatStyle.Flat
        updateBtn.Font = New Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateBtn.ForeColor = Color.WhiteSmoke
        updateBtn.Location = New Point(40, 520)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(281, 31)
        updateBtn.TabIndex = 12
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' comboAccess
        ' 
        comboAccess.BackColor = Color.Brown
        comboAccess.FlatStyle = FlatStyle.Flat
        comboAccess.Font = New Font("Rockwell", 11.25F)
        comboAccess.ForeColor = Color.White
        comboAccess.FormattingEnabled = True
        comboAccess.Items.AddRange(New Object() {"user", "admin"})
        comboAccess.Location = New Point(88, 451)
        comboAccess.Name = "comboAccess"
        comboAccess.Size = New Size(178, 25)
        comboAccess.TabIndex = 11
        comboAccess.Text = "user"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Brown
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Rockwell", 11.25F)
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(183, 386)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(155, 25)
        txtEmail.TabIndex = 10
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Brown
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Rockwell", 11.25F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(11, 386)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(152, 25)
        txtUsername.TabIndex = 9
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSuffix
        ' 
        txtSuffix.BackColor = Color.Brown
        txtSuffix.BorderStyle = BorderStyle.FixedSingle
        txtSuffix.Font = New Font("Rockwell", 11.25F)
        txtSuffix.ForeColor = Color.White
        txtSuffix.Location = New Point(183, 302)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.ReadOnly = True
        txtSuffix.Size = New Size(155, 25)
        txtSuffix.TabIndex = 8
        txtSuffix.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMname
        ' 
        txtMname.BackColor = Color.Brown
        txtMname.BorderStyle = BorderStyle.FixedSingle
        txtMname.Font = New Font("Rockwell", 11.25F)
        txtMname.ForeColor = Color.White
        txtMname.Location = New Point(11, 302)
        txtMname.Name = "txtMname"
        txtMname.ReadOnly = True
        txtMname.Size = New Size(152, 25)
        txtMname.TabIndex = 7
        txtMname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLname
        ' 
        txtLname.BackColor = Color.Brown
        txtLname.BorderStyle = BorderStyle.FixedSingle
        txtLname.Font = New Font("Rockwell", 11.25F)
        txtLname.ForeColor = Color.White
        txtLname.Location = New Point(183, 231)
        txtLname.Name = "txtLname"
        txtLname.ReadOnly = True
        txtLname.Size = New Size(155, 25)
        txtLname.TabIndex = 6
        txtLname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFname
        ' 
        txtFname.BackColor = Color.Brown
        txtFname.BorderStyle = BorderStyle.FixedSingle
        txtFname.Font = New Font("Rockwell", 11.25F)
        txtFname.ForeColor = Color.White
        txtFname.Location = New Point(11, 231)
        txtFname.Name = "txtFname"
        txtFname.ReadOnly = True
        txtFname.Size = New Size(152, 25)
        txtFname.TabIndex = 5
        txtFname.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchBox
        ' 
        searchBox.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(804, 19)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search User"
        searchBox.Size = New Size(345, 25)
        searchBox.TabIndex = 3
        ' 
        ' ewanTable
        ' 
        ewanTable.AllowUserToAddRows = False
        ewanTable.AllowUserToDeleteRows = False
        ewanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ewanTable.BackgroundColor = Color.Brown
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Brown
        DataGridViewCellStyle1.Font = New Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ewanTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ewanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ewanTable.Columns.AddRange(New DataGridViewColumn() {USER_ID, FULLNAME, USERNAME, EMAIL, ACCESS, Edit, Delete})
        ewanTable.Cursor = Cursors.Hand
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Tomato
        DataGridViewCellStyle7.Font = New Font("Sitka Banner", 12.7499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionBackColor = Color.Salmon
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        ewanTable.DefaultCellStyle = DataGridViewCellStyle7
        ewanTable.GridColor = Color.Tomato
        ewanTable.Location = New Point(353, 51)
        ewanTable.Name = "ewanTable"
        ewanTable.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.Lime
        DataGridViewCellStyle8.Font = New Font("Sitka Banner", 12.7499981F, FontStyle.Bold Or FontStyle.Italic)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        ewanTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        ewanTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ewanTable.Size = New Size(796, 481)
        ewanTable.TabIndex = 2
        ' 
        ' USER_ID
        ' 
        USER_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        USER_ID.DataPropertyName = "USER_ID"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        USER_ID.DefaultCellStyle = DataGridViewCellStyle2
        USER_ID.FillWeight = 426.3958F
        USER_ID.HeaderText = "UserID"
        USER_ID.MinimumWidth = 80
        USER_ID.Name = "USER_ID"
        USER_ID.ReadOnly = True
        ' 
        ' FULLNAME
        ' 
        FULLNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FULLNAME.DataPropertyName = "FULLNAME"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        FULLNAME.DefaultCellStyle = DataGridViewCellStyle3
        FULLNAME.FillWeight = 74.611824F
        FULLNAME.HeaderText = "Fullname"
        FULLNAME.MinimumWidth = 175
        FULLNAME.Name = "FULLNAME"
        FULLNAME.ReadOnly = True
        FULLNAME.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' USERNAME
        ' 
        USERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        USERNAME.DataPropertyName = "USERNAME"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        USERNAME.DefaultCellStyle = DataGridViewCellStyle4
        USERNAME.FillWeight = 74.611824F
        USERNAME.HeaderText = "Username"
        USERNAME.MinimumWidth = 150
        USERNAME.Name = "USERNAME"
        USERNAME.ReadOnly = True
        USERNAME.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' EMAIL
        ' 
        EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        EMAIL.DataPropertyName = "EMAIL"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        EMAIL.DefaultCellStyle = DataGridViewCellStyle5
        EMAIL.FillWeight = 74.611824F
        EMAIL.HeaderText = "Email"
        EMAIL.MinimumWidth = 150
        EMAIL.Name = "EMAIL"
        EMAIL.ReadOnly = True
        EMAIL.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' ACCESS
        ' 
        ACCESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ACCESS.DataPropertyName = "ACCESS"
        ACCESS.FillWeight = 8.837968F
        ACCESS.HeaderText = "Access"
        ACCESS.MinimumWidth = 100
        ACCESS.Name = "ACCESS"
        ACCESS.ReadOnly = True
        ACCESS.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Edit
        ' 
        Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.NullValue = resources.GetObject("DataGridViewCellStyle6.NullValue")
        Edit.DefaultCellStyle = DataGridViewCellStyle6
        Edit.FillWeight = 17.2273083F
        Edit.HeaderText = "Edit"
        Edit.Image = CType(resources.GetObject("Edit.Image"), Image)
        Edit.ImageLayout = DataGridViewImageCellLayout.Zoom
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Resizable = DataGridViewTriState.False
        Edit.Width = 40
        ' 
        ' Delete
        ' 
        Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Delete.FillWeight = 23.7032948F
        Delete.HeaderText = "Delete"
        Delete.Image = CType(resources.GetObject("Delete.Image"), Image)
        Delete.ImageLayout = DataGridViewImageCellLayout.Zoom
        Delete.Name = "Delete"
        Delete.ReadOnly = True
        Delete.Resizable = DataGridViewTriState.True
        Delete.Width = 57
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.BackColor = Color.Transparent
        TimeLabel.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = Color.WhiteSmoke
        TimeLabel.Location = New Point(353, 19)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(129, 25)
        TimeLabel.TabIndex = 1
        TimeLabel.Text = "Time Now: "
        ' 
        ' TimeForTimer
        ' 
        TimeForTimer.Enabled = True
        TimeForTimer.Interval = 1000
        ' 
        ' ToolTip1
        ' 
        ToolTip1.BackColor = Color.Brown
        ToolTip1.ForeColor = Color.White
        ' 
        ' MainDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "MainDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainDashboard"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(ProfileBoxMain, ComponentModel.ISupportInitialize).EndInit()
        CType(ewanTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents uploadPhotoDialog As OpenFileDialog
    Friend WithEvents TopPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents txtWelcome As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TimeForTimer As Timer
    Friend WithEvents InsertBooksBtn As Button
    Friend WithEvents userPageBtn As Button
    Friend WithEvents ewanTable As DataGridView
    Friend WithEvents refreshBtn As Button
    Friend WithEvents userIDlbl As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents comboAccess As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents profileBtn As Button
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents updateProfileBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProfileBoxMain As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents btnBookDashboard As Button
    Friend WithEvents BookHistoryBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents USER_ID As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAME As DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents ACCESS As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
