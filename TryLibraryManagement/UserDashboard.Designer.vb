<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDashboard))
        TopPanel = New Panel()
        PictureBox1 = New PictureBox()
        updateProfileBtn = New Button()
        Label7 = New Label()
        profileBtn = New Button()
        userIDlbl = New Label()
        txtWelcome = New TextBox()
        ProfileBoxUpper = New PictureBox()
        SidePanel = New Panel()
        btnYourBooks = New Button()
        Button1 = New Button()
        SignOutBtn = New Button()
        MainPanel = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        txtSearchList = New TextBox()
        PictureBox3 = New PictureBox()
        flowPanelRecords = New FlowLayoutPanel()
        OpenFileDialog1 = New OpenFileDialog()
        TopPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.DarkSlateGray
        TopPanel.Controls.Add(PictureBox1)
        TopPanel.Controls.Add(updateProfileBtn)
        TopPanel.Controls.Add(Label7)
        TopPanel.Controls.Add(profileBtn)
        TopPanel.Controls.Add(userIDlbl)
        TopPanel.Controls.Add(txtWelcome)
        TopPanel.Controls.Add(ProfileBoxUpper)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
        TopPanel.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(58, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' updateProfileBtn
        ' 
        updateProfileBtn.BackColor = Color.DarkSlateGray
        updateProfileBtn.Cursor = Cursors.Hand
        updateProfileBtn.FlatAppearance.BorderColor = Color.Black
        updateProfileBtn.FlatStyle = FlatStyle.Flat
        updateProfileBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        updateProfileBtn.ForeColor = Color.White
        updateProfileBtn.Image = CType(resources.GetObject("updateProfileBtn.Image"), Image)
        updateProfileBtn.Location = New Point(1069, 12)
        updateProfileBtn.Name = "updateProfileBtn"
        updateProfileBtn.Size = New Size(99, 46)
        updateProfileBtn.TabIndex = 15
        updateProfileBtn.Text = " Update" & vbCrLf & " Profile"
        updateProfileBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        updateProfileBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(66, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(388, 37)
        Label7.TabIndex = 14
        Label7.Text = "Barangay International Library"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' profileBtn
        ' 
        profileBtn.BackColor = Color.DarkSlateGray
        profileBtn.Cursor = Cursors.Hand
        profileBtn.FlatAppearance.BorderColor = Color.Black
        profileBtn.FlatStyle = FlatStyle.Flat
        profileBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        profileBtn.ForeColor = Color.White
        profileBtn.Image = CType(resources.GetObject("profileBtn.Image"), Image)
        profileBtn.Location = New Point(1154, 12)
        profileBtn.Name = "profileBtn"
        profileBtn.Size = New Size(105, 46)
        profileBtn.TabIndex = 14
        profileBtn.Text = "  Upload " & vbCrLf & " Profile"
        profileBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        profileBtn.UseVisualStyleBackColor = False
        ' 
        ' userIDlbl
        ' 
        userIDlbl.AutoSize = True
        userIDlbl.BackColor = Color.Transparent
        userIDlbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        userIDlbl.ForeColor = Color.White
        userIDlbl.Location = New Point(826, 44)
        userIDlbl.Name = "userIDlbl"
        userIDlbl.Size = New Size(63, 20)
        userIDlbl.TabIndex = 13
        userIDlbl.Text = "UserID: "
        ' 
        ' txtWelcome
        ' 
        txtWelcome.BackColor = Color.DarkSlateGray
        txtWelcome.BorderStyle = BorderStyle.None
        txtWelcome.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        txtWelcome.ForeColor = Color.WhiteSmoke
        txtWelcome.Location = New Point(826, 10)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.ReadOnly = True
        txtWelcome.Size = New Size(237, 32)
        txtWelcome.TabIndex = 12
        txtWelcome.Text = "Welcome, "
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1174, 3)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(76, 68)
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.Zoom
        ProfileBoxUpper.TabIndex = 11
        ProfileBoxUpper.TabStop = False
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.CadetBlue
        SidePanel.Controls.Add(btnYourBooks)
        SidePanel.Controls.Add(Button1)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(134, 563)
        SidePanel.TabIndex = 3
        ' 
        ' btnYourBooks
        ' 
        btnYourBooks.BackColor = Color.DarkSlateGray
        btnYourBooks.Cursor = Cursors.Hand
        btnYourBooks.FlatAppearance.BorderSize = 0
        btnYourBooks.FlatStyle = FlatStyle.Flat
        btnYourBooks.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnYourBooks.ForeColor = Color.White
        btnYourBooks.Image = CType(resources.GetObject("btnYourBooks.Image"), Image)
        btnYourBooks.Location = New Point(0, 104)
        btnYourBooks.Name = "btnYourBooks"
        btnYourBooks.Size = New Size(134, 60)
        btnYourBooks.TabIndex = 8
        btnYourBooks.Text = " Your Books"
        btnYourBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnYourBooks.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.dashboard_icon_182989
        Button1.Location = New Point(0, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 60)
        Button1.TabIndex = 7
        Button1.Text = "Book DashBoard"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = Color.DarkSlateGray
        SignOutBtn.Cursor = Cursors.Hand
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        SignOutBtn.ForeColor = Color.White
        SignOutBtn.Image = CType(resources.GetObject("SignOutBtn.Image"), Image)
        SignOutBtn.Location = New Point(0, 472)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(134, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Snow
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(txtSearchList)
        MainPanel.Controls.Add(PictureBox3)
        MainPanel.Controls.Add(flowPanelRecords)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(134, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1132, 563)
        MainPanel.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Image = My.Resources.Resources._3700471_book_books_education_library_literature_reading_study_108741
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(36, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(284, 37)
        Label2.TabIndex = 34
        Label2.Text = "        Book Collections:"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(848, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 33
        Label3.Text = "Search:"
        ' 
        ' txtSearchList
        ' 
        txtSearchList.BorderStyle = BorderStyle.None
        txtSearchList.Cursor = Cursors.Hand
        txtSearchList.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txtSearchList.Location = New Point(925, 19)
        txtSearchList.Name = "txtSearchList"
        txtSearchList.PlaceholderText = "Search List"
        txtSearchList.Size = New Size(182, 18)
        txtSearchList.TabIndex = 24
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(913, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 59)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 44
        PictureBox3.TabStop = False
        ' 
        ' flowPanelRecords
        ' 
        flowPanelRecords.AutoScroll = True
        flowPanelRecords.BackColor = Color.DarkSlateGray
        flowPanelRecords.ForeColor = Color.Transparent
        flowPanelRecords.Location = New Point(36, 59)
        flowPanelRecords.Name = "flowPanelRecords"
        flowPanelRecords.Size = New Size(1086, 465)
        flowPanelRecords.TabIndex = 4
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MinimumSize = New Size(1282, 676)
        Name = "UserDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Dashboard"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents btnYourBooks As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents flowPanelRecords As FlowLayoutPanel
    Friend WithEvents updateProfileBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents userIDlbl As Label
    Friend WithEvents txtWelcome As TextBox
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSearchList As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
