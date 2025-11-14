<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YourBorrowedBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YourBorrowedBooks))
        TopPanel = New Panel()
        PictureBox1 = New PictureBox()
        ProfileBoxUpper = New PictureBox()
        Label1 = New Label()
        SidePanel = New Panel()
        btnYourBooks = New Button()
        SignOutBtn = New Button()
        userPageBtn = New Button()
        MainPanel = New Panel()
        Label2 = New Label()
        ewanFLow = New FlowLayoutPanel()
        TopPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).BeginInit()
        SidePanel.SuspendLayout()
        MainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.Brown
        TopPanel.Controls.Add(PictureBox1)
        TopPanel.Controls.Add(ProfileBoxUpper)
        TopPanel.Controls.Add(Label1)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1266, 74)
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
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' ProfileBoxUpper
        ' 
        ProfileBoxUpper.ErrorImage = CType(resources.GetObject("ProfileBoxUpper.ErrorImage"), Image)
        ProfileBoxUpper.Location = New Point(1178, 3)
        ProfileBoxUpper.Name = "ProfileBoxUpper"
        ProfileBoxUpper.Size = New Size(76, 68)
        ProfileBoxUpper.SizeMode = PictureBoxSizeMode.StretchImage
        ProfileBoxUpper.TabIndex = 17
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
        Label1.Size = New Size(928, 53)
        Label1.TabIndex = 16
        Label1.Text = "Baranggay International Library - Borrowed Books"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.Salmon
        SidePanel.Controls.Add(btnYourBooks)
        SidePanel.Controls.Add(SignOutBtn)
        SidePanel.Controls.Add(userPageBtn)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 74)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(134, 563)
        SidePanel.TabIndex = 2
        ' 
        ' btnYourBooks
        ' 
        btnYourBooks.BackColor = Color.Brown
        btnYourBooks.Cursor = Cursors.Hand
        btnYourBooks.FlatAppearance.BorderSize = 0
        btnYourBooks.FlatStyle = FlatStyle.Flat
        btnYourBooks.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnYourBooks.ForeColor = Color.White
        btnYourBooks.Image = CType(resources.GetObject("btnYourBooks.Image"), Image)
        btnYourBooks.Location = New Point(0, 104)
        btnYourBooks.Name = "btnYourBooks"
        btnYourBooks.Size = New Size(134, 60)
        btnYourBooks.TabIndex = 9
        btnYourBooks.Text = " Your Books"
        btnYourBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnYourBooks.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.BackColor = Color.Brown
        SignOutBtn.FlatAppearance.BorderSize = 0
        SignOutBtn.FlatStyle = FlatStyle.Flat
        SignOutBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutBtn.ForeColor = SystemColors.ControlLightLight
        SignOutBtn.Image = My.Resources.Resources.sign_out_icon_icons_com_69908
        SignOutBtn.Location = New Point(0, 472)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(134, 60)
        SignOutBtn.TabIndex = 2
        SignOutBtn.Text = "Sign Out"
        SignOutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SignOutBtn.UseVisualStyleBackColor = False
        ' 
        ' userPageBtn
        ' 
        userPageBtn.BackColor = Color.Brown
        userPageBtn.FlatAppearance.BorderSize = 0
        userPageBtn.FlatStyle = FlatStyle.Flat
        userPageBtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userPageBtn.ForeColor = SystemColors.ControlLightLight
        userPageBtn.Image = My.Resources.Resources.dashboard_icon_1829891
        userPageBtn.Location = New Point(0, 19)
        userPageBtn.Name = "userPageBtn"
        userPageBtn.Size = New Size(134, 60)
        userPageBtn.TabIndex = 0
        userPageBtn.Text = "Book Dashboard"
        userPageBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        userPageBtn.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Tomato
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(ewanFLow)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(134, 74)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1132, 563)
        MainPanel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Image = My.Resources.Resources._3700471_book_books_education_library_literature_reading_study_108741
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(36, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(413, 39)
        Label2.TabIndex = 26
        Label2.Text = "        Books You Borrowed:"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' ewanFLow
        ' 
        ewanFLow.AutoScroll = True
        ewanFLow.BackColor = Color.Brown
        ewanFLow.Location = New Point(36, 59)
        ewanFLow.Name = "ewanFLow"
        ewanFLow.Size = New Size(1086, 465)
        ewanFLow.TabIndex = 22
        ' 
        ' YourBorrowedBooks
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 637)
        Controls.Add(MainPanel)
        Controls.Add(SidePanel)
        Controls.Add(TopPanel)
        Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "YourBorrowedBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "w"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfileBoxUpper, ComponentModel.ISupportInitialize).EndInit()
        SidePanel.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents userPageBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ewanFLow As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProfileBoxUpper As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYourBooks As Button
    Friend WithEvents Label2 As Label
End Class
