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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        TopPanel.BackColor = Color.ForestGreen
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
        PictureBox1.Location = New Point(3, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(58, 54)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' updateProfileBtn
        ' 
        updateProfileBtn.BackColor = Color.Tomato
        updateProfileBtn.FlatAppearance.BorderSize = 0
        updateProfileBtn.FlatStyle = FlatStyle.Flat
        updateProfileBtn.Font = New Font("Rockwell", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        updateProfileBtn.ForeColor = Color.WhiteSmoke
        updateProfileBtn.Image = CType(resources.GetObject("updateProfileBtn.Image"), Image)
        updateProfileBtn.Location = New Point(1084, 12)
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
        userIDlbl.ForeColor = Color.White
        userIDlbl.Location = New Point(824, 47)
        userIDlbl.Name = "userIDlbl"
        userIDlbl.Size = New Size(64, 18)
        userIDlbl.TabIndex = 6
        userIDlbl.Text = "UserID: "
        ' 
        ' txtWelcome
        ' 
        txtWelcome.BackColor = Color.White
        txtWelcome.BorderStyle = BorderStyle.None
        txtWelcome.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWelcome.Location = New Point(824, 21)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.ReadOnly = True
        txtWelcome.Size = New Size(237, 23)
        txtWelcome.TabIndex = 2
        txtWelcome.Text = "Welcome, "
        txtWelcome.TextAlign = HorizontalAlignment.Center
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1189, 7)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(65, 56)
        ProfileBoxUpper.TabIndex = 1
        ProfileBoxUpper.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(59, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(527, 43)
        Label1.TabIndex = 0
        Label1.Text = "Baranggay International Library"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.Tomato
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
        BookHistoryBtn.BackColor = Color.White
        BookHistoryBtn.FlatAppearance.BorderSize = 0
        BookHistoryBtn.FlatStyle = FlatStyle.Flat
        BookHistoryBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BookHistoryBtn.ForeColor = Color.Blue
        BookHistoryBtn.Location = New Point(2, 244)
        BookHistoryBtn.Name = "BookHistoryBtn"
        BookHistoryBtn.Size = New Size(103, 60)
        BookHistoryBtn.TabIndex = 9
        BookHistoryBtn.Text = "Borrow History"
        BookHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' btnBookDashboard
        ' 
        btnBookDashboard.BackColor = Color.White
        btnBookDashboard.FlatAppearance.BorderSize = 0
        btnBookDashboard.FlatStyle = FlatStyle.Flat
        btnBookDashboard.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookDashboard.ForeColor = Color.Blue
        btnBookDashboard.Location = New Point(2, 324)
        btnBookDashboard.Name = "btnBookDashboard"
        btnBookDashboard.Size = New Size(103, 60)
        btnBookDashboard.TabIndex = 7
        btnBookDashboard.Text = "Book Dashboard"
        btnBookDashboard.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = Color.White
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutBtn.ForeColor = Color.Blue
        SignOutBtn.Location = New Point(-3, 454)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(108, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' InsertBooksBtn
        ' 
        InsertBooksBtn.BackColor = Color.White
        InsertBooksBtn.FlatAppearance.BorderSize = 0
        InsertBooksBtn.FlatStyle = FlatStyle.Flat
        InsertBooksBtn.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InsertBooksBtn.ForeColor = Color.Blue
        InsertBooksBtn.Location = New Point(0, 157)
        InsertBooksBtn.Name = "InsertBooksBtn"
        InsertBooksBtn.Size = New Size(105, 60)
        InsertBooksBtn.TabIndex = 1
        InsertBooksBtn.Text = "Manage" & vbCrLf & "Books" & vbCrLf
        InsertBooksBtn.UseVisualStyleBackColor = False
        ' 
        ' userPageBtn
        ' 
        userPageBtn.BackColor = Color.White
        userPageBtn.FlatAppearance.BorderSize = 0
        userPageBtn.FlatStyle = FlatStyle.Flat
        userPageBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userPageBtn.ForeColor = Color.Blue
        userPageBtn.Image = CType(resources.GetObject("userPageBtn.Image"), Image)
        userPageBtn.Location = New Point(0, 82)
        userPageBtn.Name = "userPageBtn"
        userPageBtn.Size = New Size(105, 60)
        userPageBtn.TabIndex = 0
        userPageBtn.Text = "Manage Users"
        userPageBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Location = New Point(10, 6)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(72, 25)
        refreshBtn.TabIndex = 5
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.DarkGreen
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
        MainPanel.ForeColor = Color.White
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 11.25F)
        Label9.Location = New Point(148, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 17)
        Label9.TabIndex = 21
        Label9.Text = "User ID"
        ' 
        ' txtUserID
        ' 
        txtUserID.BackColor = Color.DarkGreen
        txtUserID.BorderStyle = BorderStyle.FixedSingle
        txtUserID.ForeColor = Color.White
        txtUserID.Location = New Point(122, 157)
        txtUserID.Name = "txtUserID"
        txtUserID.ReadOnly = True
        txtUserID.Size = New Size(102, 26)
        txtUserID.TabIndex = 20
        txtUserID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 11.25F)
        Label8.Location = New Point(246, 406)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 17)
        Label8.TabIndex = 19
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 11.25F)
        Label7.Location = New Point(49, 406)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 17)
        Label7.TabIndex = 18
        Label7.Text = "User Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(153, 480)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 18)
        Label6.TabIndex = 17
        Label6.Text = "Access"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 11.25F)
        Label5.Location = New Point(243, 315)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 17)
        Label5.TabIndex = 16
        Label5.Text = "Suffix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 11.25F)
        Label4.Location = New Point(49, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 17)
        Label4.TabIndex = 15
        Label4.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 11.25F)
        Label3.Location = New Point(226, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 17)
        Label3.TabIndex = 14
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 11.25F)
        Label2.Location = New Point(56, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 17)
        Label2.TabIndex = 13
        Label2.Text = "First Name"
        ' 
        ' ProfileBoxMain
        ' 
        ProfileBoxMain.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ProfileBoxMain.ErrorImage = Nothing
        ProfileBoxMain.InitialImage = Nothing
        ProfileBoxMain.Location = New Point(97, 19)
        ProfileBoxMain.Name = "ProfileBoxMain"
        ProfileBoxMain.Size = New Size(148, 132)
        ProfileBoxMain.TabIndex = 4
        ProfileBoxMain.TabStop = False
        ' 
        ' updateBtn
        ' 
        updateBtn.Enabled = False
        updateBtn.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateBtn.Location = New Point(61, 521)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(232, 31)
        updateBtn.TabIndex = 12
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' comboAccess
        ' 
        comboAccess.BackColor = Color.DarkGreen
        comboAccess.FlatStyle = FlatStyle.Flat
        comboAccess.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        comboAccess.ForeColor = Color.White
        comboAccess.FormattingEnabled = True
        comboAccess.Items.AddRange(New Object() {"user", "admin"})
        comboAccess.Location = New Point(88, 451)
        comboAccess.Name = "comboAccess"
        comboAccess.Size = New Size(178, 26)
        comboAccess.TabIndex = 11
        comboAccess.Text = "user"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.DarkGreen
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(187, 377)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(155, 26)
        txtEmail.TabIndex = 10
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkGreen
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(15, 377)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(152, 26)
        txtUsername.TabIndex = 9
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSuffix
        ' 
        txtSuffix.BackColor = Color.DarkGreen
        txtSuffix.BorderStyle = BorderStyle.FixedSingle
        txtSuffix.ForeColor = Color.White
        txtSuffix.Location = New Point(187, 286)
        txtSuffix.Name = "txtSuffix"
        txtSuffix.ReadOnly = True
        txtSuffix.Size = New Size(155, 26)
        txtSuffix.TabIndex = 8
        txtSuffix.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMname
        ' 
        txtMname.BackColor = Color.DarkGreen
        txtMname.BorderStyle = BorderStyle.FixedSingle
        txtMname.ForeColor = Color.White
        txtMname.Location = New Point(15, 286)
        txtMname.Name = "txtMname"
        txtMname.ReadOnly = True
        txtMname.Size = New Size(152, 26)
        txtMname.TabIndex = 7
        txtMname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLname
        ' 
        txtLname.BackColor = Color.DarkGreen
        txtLname.BorderStyle = BorderStyle.FixedSingle
        txtLname.ForeColor = Color.White
        txtLname.Location = New Point(187, 215)
        txtLname.Name = "txtLname"
        txtLname.ReadOnly = True
        txtLname.Size = New Size(155, 26)
        txtLname.TabIndex = 6
        txtLname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFname
        ' 
        txtFname.BackColor = Color.DarkGreen
        txtFname.BorderStyle = BorderStyle.FixedSingle
        txtFname.ForeColor = Color.White
        txtFname.Location = New Point(15, 215)
        txtFname.Name = "txtFname"
        txtFname.ReadOnly = True
        txtFname.Size = New Size(152, 26)
        txtFname.TabIndex = 5
        txtFname.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(804, 19)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search User"
        searchBox.Size = New Size(345, 26)
        searchBox.TabIndex = 3
        ' 
        ' ewanTable
        ' 
        ewanTable.AllowUserToAddRows = False
        ewanTable.AllowUserToDeleteRows = False
        ewanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ewanTable.BackgroundColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ewanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ewanTable.Columns.AddRange(New DataGridViewColumn() {USER_ID, FULLNAME, USERNAME, EMAIL, ACCESS, Edit, Delete})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        ewanTable.DefaultCellStyle = DataGridViewCellStyle6
        ewanTable.Location = New Point(353, 51)
        ewanTable.Name = "ewanTable"
        ewanTable.ReadOnly = True
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        DataGridViewCellStyle7.SelectionForeColor = Color.Transparent
        ewanTable.RowsDefaultCellStyle = DataGridViewCellStyle7
        ewanTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ewanTable.Size = New Size(796, 481)
        ewanTable.TabIndex = 2
        ' 
        ' USER_ID
        ' 
        USER_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        USER_ID.DataPropertyName = "USER_ID"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        USER_ID.DefaultCellStyle = DataGridViewCellStyle1
        USER_ID.FillWeight = 426.3958F
        USER_ID.HeaderText = "UserID"
        USER_ID.MinimumWidth = 80
        USER_ID.Name = "USER_ID"
        USER_ID.ReadOnly = True
        USER_ID.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' FULLNAME
        ' 
        FULLNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FULLNAME.DataPropertyName = "FULLNAME"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        FULLNAME.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        USERNAME.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        EMAIL.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.NullValue = resources.GetObject("DataGridViewCellStyle5.NullValue")
        Edit.DefaultCellStyle = DataGridViewCellStyle5
        Edit.FillWeight = 17.2273083F
        Edit.HeaderText = "Edit"
        Edit.Image = CType(resources.GetObject("Edit.Image"), Image)
        Edit.ImageLayout = DataGridViewImageCellLayout.Zoom
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Resizable = DataGridViewTriState.False
        Edit.Width = 37
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
        Delete.Width = 55
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = SystemColors.ActiveCaptionText
        TimeLabel.Location = New Point(362, 19)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(131, 25)
        TimeLabel.TabIndex = 1
        TimeLabel.Text = "Time Now: "
        ' 
        ' TimeForTimer
        ' 
        TimeForTimer.Enabled = True
        TimeForTimer.Interval = 1000
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
    Friend WithEvents USER_ID As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAME As DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents ACCESS As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
