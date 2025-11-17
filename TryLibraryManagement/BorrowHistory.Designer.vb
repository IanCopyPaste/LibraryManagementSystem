<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowHistory))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TopPanel = New Panel()
        PictureBox1 = New PictureBox()
        ProfileBoxUpper = New PictureBox()
        Label1 = New Label()
        SidePanel = New Panel()
        BookHistoryBtn = New Button()
        Button1 = New Button()
        SignOutBtn = New Button()
        InsertBooksBtn = New Button()
        userPageBtn = New Button()
        MainPanel = New Panel()
        TimeLabel = New Label()
        btnClearBorrow = New Button()
        txtEmail = New TextBox()
        Label3 = New Label()
        BorrowTable = New DataGridView()
        BorrowID = New DataGridViewTextBoxColumn()
        UserID = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        BookBorrowed = New DataGridViewTextBoxColumn()
        BorrowDate = New DataGridViewTextBoxColumn()
        DueDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Refresh = New Button()
        btnSend = New Button()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        Timer1 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        TopPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(BorrowTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.Green
        TopPanel.Controls.Add(PictureBox1)
        TopPanel.Controls.Add(ProfileBoxUpper)
        TopPanel.Controls.Add(Label1)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1271, 74)
        TopPanel.TabIndex = 1
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
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1178, 3)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(76, 68)
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.Zoom
        ProfileBoxUpper.TabIndex = 11
        ProfileBoxUpper.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Text Semibold", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(67, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(895, 53)
        Label1.TabIndex = 10
        Label1.Text = "Barangay International Library - Borrow History"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.LightGreen
        SidePanel.Controls.Add(BookHistoryBtn)
        SidePanel.Controls.Add(Button1)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Controls.Add(InsertBooksBtn)
        SidePanel.Controls.Add(userPageBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(105, 563)
        SidePanel.TabIndex = 2
        ' 
        ' BookHistoryBtn
        ' 
        BookHistoryBtn.BackColor = Color.Green
        BookHistoryBtn.Cursor = Cursors.Hand
        BookHistoryBtn.FlatAppearance.BorderSize = 0
        BookHistoryBtn.FlatStyle = FlatStyle.Flat
        BookHistoryBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        BookHistoryBtn.ForeColor = SystemColors.ControlLightLight
        BookHistoryBtn.Image = My.Resources.Resources.ic_history_128_28522
        BookHistoryBtn.Location = New Point(0, 186)
        BookHistoryBtn.Name = "BookHistoryBtn"
        BookHistoryBtn.Size = New Size(108, 60)
        BookHistoryBtn.TabIndex = 9
        BookHistoryBtn.Text = "Borrow History"
        BookHistoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        BookHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Image = My.Resources.Resources.dashboard_icon_182989
        Button1.Location = New Point(0, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 60)
        Button1.TabIndex = 7
        Button1.Text = "Book Dash" & vbCrLf & "Board"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = Color.Green
        SignOutBtn.Cursor = Cursors.Hand
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        SignOutBtn.ForeColor = SystemColors.ControlLightLight
        SignOutBtn.Image = My.Resources.Resources.sign_out_icon_icons_com_69908
        SignOutBtn.Location = New Point(0, 472)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(108, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' InsertBooksBtn
        ' 
        InsertBooksBtn.BackColor = Color.Green
        InsertBooksBtn.Cursor = Cursors.Hand
        InsertBooksBtn.FlatAppearance.BorderSize = 0
        InsertBooksBtn.FlatStyle = FlatStyle.Flat
        InsertBooksBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        InsertBooksBtn.ForeColor = SystemColors.ControlLightLight
        InsertBooksBtn.Image = My.Resources.Resources._28_122665
        InsertBooksBtn.Location = New Point(0, 104)
        InsertBooksBtn.Name = "InsertBooksBtn"
        InsertBooksBtn.Size = New Size(108, 60)
        InsertBooksBtn.TabIndex = 1
        InsertBooksBtn.Text = "Manage" & vbCrLf & "Books" & vbCrLf
        InsertBooksBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        InsertBooksBtn.UseVisualStyleBackColor = False
        ' 
        ' userPageBtn
        ' 
        userPageBtn.BackColor = Color.Green
        userPageBtn.Cursor = Cursors.Hand
        userPageBtn.FlatAppearance.BorderSize = 0
        userPageBtn.FlatStyle = FlatStyle.Flat
        userPageBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        userPageBtn.ForeColor = SystemColors.ControlLightLight
        userPageBtn.Image = My.Resources.Resources.User_Group_80_icon_icons_com_57247
        userPageBtn.Location = New Point(0, 19)
        userPageBtn.Name = "userPageBtn"
        userPageBtn.Size = New Size(105, 60)
        userPageBtn.TabIndex = 0
        userPageBtn.Text = "Manage Users"
        userPageBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Snow
        MainPanel.Controls.Add(TimeLabel)
        MainPanel.Controls.Add(btnClearBorrow)
        MainPanel.Controls.Add(txtEmail)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(BorrowTable)
        MainPanel.Controls.Add(Refresh)
        MainPanel.Controls.Add(btnSend)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(RichTextBox1)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1166, 563)
        MainPanel.TabIndex = 3
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = Color.DarkGreen
        TimeLabel.Location = New Point(475, 11)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(124, 25)
        TimeLabel.TabIndex = 13
        TimeLabel.Text = "Time Now:"
        ' 
        ' btnClearBorrow
        ' 
        btnClearBorrow.BackColor = Color.Green
        btnClearBorrow.Cursor = Cursors.Hand
        btnClearBorrow.FlatAppearance.BorderSize = 0
        btnClearBorrow.FlatStyle = FlatStyle.Flat
        btnClearBorrow.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClearBorrow.ForeColor = Color.White
        btnClearBorrow.Image = My.Resources.Resources.Letter_X_icon_34793__1_
        btnClearBorrow.Location = New Point(334, 6)
        btnClearBorrow.Name = "btnClearBorrow"
        btnClearBorrow.Size = New Size(135, 35)
        btnClearBorrow.TabIndex = 12
        btnClearBorrow.Text = "Clear Table"
        btnClearBorrow.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClearBorrow.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Gainsboro
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = Color.Black
        txtEmail.Location = New Point(19, 95)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "@gmail.com"
        txtEmail.Size = New Size(296, 25)
        txtEmail.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(19, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 18)
        Label3.TabIndex = 10
        Label3.Text = "To :"
        ' 
        ' BorrowTable
        ' 
        BorrowTable.AllowUserToAddRows = False
        BorrowTable.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.ForestGreen
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen
        BorrowTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        BorrowTable.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BorrowTable.BackgroundColor = Color.LimeGreen
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Rockwell", 11.25F, FontStyle.Italic)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BorrowTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BorrowTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BorrowTable.Columns.AddRange(New DataGridViewColumn() {BorrowID, UserID, Email, BookBorrowed, BorrowDate, DueDate, Status})
        BorrowTable.Cursor = Cursors.Hand
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Green
        DataGridViewCellStyle3.Font = New Font("Sitka Banner", 12.7499981F, FontStyle.Bold Or FontStyle.Italic)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        BorrowTable.DefaultCellStyle = DataGridViewCellStyle3
        BorrowTable.GridColor = Color.Green
        BorrowTable.Location = New Point(334, 47)
        BorrowTable.Name = "BorrowTable"
        BorrowTable.ReadOnly = True
        BorrowTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        BorrowTable.Size = New Size(807, 482)
        BorrowTable.TabIndex = 9
        ' 
        ' BorrowID
        ' 
        BorrowID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BorrowID.DataPropertyName = "BorrowID"
        BorrowID.HeaderText = "BorrowID"
        BorrowID.Name = "BorrowID"
        BorrowID.ReadOnly = True
        ' 
        ' UserID
        ' 
        UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        UserID.DataPropertyName = "UserID"
        UserID.HeaderText = "UserID"
        UserID.Name = "UserID"
        UserID.ReadOnly = True
        ' 
        ' Email
        ' 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Email.DataPropertyName = "Email"
        Email.HeaderText = "Email"
        Email.Name = "Email"
        Email.ReadOnly = True
        ' 
        ' BookBorrowed
        ' 
        BookBorrowed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BookBorrowed.DataPropertyName = "Book_Borrowed"
        BookBorrowed.HeaderText = "Book Borrowed"
        BookBorrowed.Name = "BookBorrowed"
        BookBorrowed.ReadOnly = True
        ' 
        ' BorrowDate
        ' 
        BorrowDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        BorrowDate.DataPropertyName = "Borrowed_On"
        BorrowDate.HeaderText = "BorrowDate"
        BorrowDate.Name = "BorrowDate"
        BorrowDate.ReadOnly = True
        ' 
        ' DueDate
        ' 
        DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DueDate.DataPropertyName = "Due_Date"
        DueDate.HeaderText = "DueDate"
        DueDate.Name = "DueDate"
        DueDate.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Status.DataPropertyName = "Statuss"
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' Refresh
        ' 
        Refresh.BackColor = Color.Transparent
        Refresh.Cursor = Cursors.Hand
        Refresh.FlatAppearance.BorderSize = 0
        Refresh.FlatStyle = FlatStyle.Flat
        Refresh.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Refresh.Image = My.Resources.Resources.restart_icon_135251
        Refresh.Location = New Point(0, 6)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(44, 38)
        Refresh.TabIndex = 8
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' btnSend
        ' 
        btnSend.BackColor = Color.Green
        btnSend.Cursor = Cursors.Hand
        btnSend.FlatAppearance.BorderSize = 0
        btnSend.FlatStyle = FlatStyle.Flat
        btnSend.Font = New Font("Rockwell", 14.25F, FontStyle.Bold)
        btnSend.ForeColor = Color.White
        btnSend.Location = New Point(58, 408)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(220, 34)
        btnSend.TabIndex = 7
        btnSend.Text = "Send to Email"
        btnSend.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(19, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 18)
        Label2.TabIndex = 6
        Label2.Text = "Message to returnees :"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Gainsboro
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Location = New Point(19, 149)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(296, 224)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = "Type you message here....."
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' BorrowHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1271, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Name = "BorrowHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard - Borrow History"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(BorrowTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents BookHistoryBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents InsertBooksBtn As Button
    Friend WithEvents userPageBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnSend As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Refresh As Button
    Friend WithEvents BorrowTable As DataGridView
    Friend WithEvents BorrowID As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents BookBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearBorrow As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
