<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDashboardForAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookDashboardForAdmin))
        TopPanel = New Panel()
        Panel1 = New Panel()
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
        Label3 = New Label()
        txtSearchList = New TextBox()
        Label2 = New Label()
        flowPanelRecords = New FlowLayoutPanel()
        TopPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = SystemColors.ActiveCaption
        TopPanel.Controls.Add(Panel1)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
        TopPanel.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ProfileBoxUpper)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1266, 74)
        Panel1.TabIndex = 3
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
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1178, 3)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(76, 68)
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.Zoom
        ProfileBoxUpper.TabIndex = 14
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
        Label1.Size = New Size(907, 53)
        Label1.TabIndex = 13
        Label1.Text = "Barangay International Library - Book Dashboard"
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
        SidePanel.TabIndex = 3
        ' 
        ' BookHistoryBtn
        ' 
        BookHistoryBtn.BackColor = Color.Green
        BookHistoryBtn.Cursor = Cursors.Hand
        BookHistoryBtn.FlatAppearance.BorderSize = 0
        BookHistoryBtn.FlatStyle = FlatStyle.Flat
        BookHistoryBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        BookHistoryBtn.ForeColor = Color.White
        BookHistoryBtn.Image = CType(resources.GetObject("BookHistoryBtn.Image"), Image)
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
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
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
        SignOutBtn.ForeColor = Color.White
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
        InsertBooksBtn.ForeColor = Color.White
        InsertBooksBtn.Image = CType(resources.GetObject("InsertBooksBtn.Image"), Image)
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
        userPageBtn.ForeColor = Color.White
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
        MainPanel.BackColor = Color.AntiqueWhite
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(txtSearchList)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(flowPanelRecords)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(105, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1161, 563)
        MainPanel.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Text", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(621, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 23)
        Label3.TabIndex = 32
        Label3.Text = "Search"
        ' 
        ' txtSearchList
        ' 
        txtSearchList.Cursor = Cursors.Hand
        txtSearchList.Font = New Font("Rockwell", 11.25F)
        txtSearchList.Location = New Point(690, 17)
        txtSearchList.Name = "txtSearchList"
        txtSearchList.PlaceholderText = "Search List"
        txtSearchList.Size = New Size(432, 25)
        txtSearchList.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGreen
        Label2.Image = My.Resources.Resources._3700471_book_books_education_library_literature_reading_study_108741
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(34, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(356, 39)
        Label2.TabIndex = 24
        Label2.Text = "        Book Collections:"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' flowPanelRecords
        ' 
        flowPanelRecords.AutoScroll = True
        flowPanelRecords.BackColor = Color.LightGreen
        flowPanelRecords.Location = New Point(34, 59)
        flowPanelRecords.Name = "flowPanelRecords"
        flowPanelRecords.Size = New Size(1088, 465)
        flowPanelRecords.TabIndex = 23
        ' 
        ' BookDashboardForAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "BookDashboardForAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard - Book Dashboard"
        TopPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
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
    Friend WithEvents flowPanelRecords As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchList As TextBox
End Class
