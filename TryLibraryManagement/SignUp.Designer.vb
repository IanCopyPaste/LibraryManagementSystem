<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        fnameBox = New TextBox()
        lnameBox = New TextBox()
        mnameBox = New TextBox()
        suffBox = New TextBox()
        usernamBox = New TextBox()
        passwordBox = New TextBox()
        CpasswordBox = New TextBox()
        SignUpbtn = New Button()
        LinkLabel1 = New LinkLabel()
        toLogIn = New Label()
        Panel1 = New Panel()
        Label13 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        confirmLbl = New Label()
        emailBox = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' fnameBox
        ' 
        fnameBox.Anchor = AnchorStyles.None
        fnameBox.BorderStyle = BorderStyle.None
        fnameBox.Font = New Font("Tahoma", 11.25F)
        fnameBox.Location = New Point(95, 151)
        fnameBox.Name = "fnameBox"
        fnameBox.PlaceholderText = "Enter firstname"
        fnameBox.Size = New Size(165, 19)
        fnameBox.TabIndex = 6
        ' 
        ' lnameBox
        ' 
        lnameBox.Anchor = AnchorStyles.None
        lnameBox.BorderStyle = BorderStyle.None
        lnameBox.Font = New Font("Tahoma", 11.25F)
        lnameBox.Location = New Point(87, 218)
        lnameBox.Name = "lnameBox"
        lnameBox.PlaceholderText = "Enter lastname"
        lnameBox.Size = New Size(165, 19)
        lnameBox.TabIndex = 7
        ' 
        ' mnameBox
        ' 
        mnameBox.Anchor = AnchorStyles.None
        mnameBox.BorderStyle = BorderStyle.None
        mnameBox.Font = New Font("Tahoma", 11.25F)
        mnameBox.Location = New Point(359, 151)
        mnameBox.Name = "mnameBox"
        mnameBox.PlaceholderText = "Enter middlename"
        mnameBox.Size = New Size(184, 19)
        mnameBox.TabIndex = 8
        ' 
        ' suffBox
        ' 
        suffBox.Anchor = AnchorStyles.None
        suffBox.BorderStyle = BorderStyle.None
        suffBox.Font = New Font("Tahoma", 11.25F)
        suffBox.Location = New Point(359, 218)
        suffBox.Name = "suffBox"
        suffBox.PlaceholderText = "Enter suffix"
        suffBox.Size = New Size(184, 19)
        suffBox.TabIndex = 9
        ' 
        ' usernamBox
        ' 
        usernamBox.Anchor = AnchorStyles.None
        usernamBox.BorderStyle = BorderStyle.None
        usernamBox.Font = New Font("Tahoma", 11.25F)
        usernamBox.Location = New Point(87, 315)
        usernamBox.Name = "usernamBox"
        usernamBox.PlaceholderText = "Create username"
        usernamBox.Size = New Size(193, 19)
        usernamBox.TabIndex = 12
        ' 
        ' passwordBox
        ' 
        passwordBox.Anchor = AnchorStyles.None
        passwordBox.BorderStyle = BorderStyle.None
        passwordBox.Font = New Font("Tahoma", 11.25F)
        passwordBox.Location = New Point(359, 315)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "Create password"
        passwordBox.Size = New Size(184, 19)
        passwordBox.TabIndex = 13
        passwordBox.UseSystemPasswordChar = True
        ' 
        ' CpasswordBox
        ' 
        CpasswordBox.Anchor = AnchorStyles.None
        CpasswordBox.BorderStyle = BorderStyle.None
        CpasswordBox.Font = New Font("Tahoma", 11.25F)
        CpasswordBox.Location = New Point(359, 380)
        CpasswordBox.Name = "CpasswordBox"
        CpasswordBox.PlaceholderText = "Confirm password"
        CpasswordBox.Size = New Size(184, 19)
        CpasswordBox.TabIndex = 14
        CpasswordBox.UseSystemPasswordChar = True
        ' 
        ' SignUpbtn
        ' 
        SignUpbtn.Anchor = AnchorStyles.None
        SignUpbtn.BackColor = Color.DarkSlateGray
        SignUpbtn.Cursor = Cursors.Hand
        SignUpbtn.FlatAppearance.BorderSize = 0
        SignUpbtn.FlatStyle = FlatStyle.Flat
        SignUpbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SignUpbtn.ForeColor = Color.White
        SignUpbtn.Location = New Point(166, 507)
        SignUpbtn.Name = "SignUpbtn"
        SignUpbtn.Size = New Size(310, 33)
        SignUpbtn.TabIndex = 15
        SignUpbtn.Text = "Sign Up"
        SignUpbtn.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.None
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(395, 413)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 16
        ' 
        ' toLogIn
        ' 
        toLogIn.Anchor = AnchorStyles.None
        toLogIn.AutoSize = True
        toLogIn.BackColor = Color.Snow
        toLogIn.Cursor = Cursors.Hand
        toLogIn.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toLogIn.ForeColor = Color.DarkSlateGray
        toLogIn.Location = New Point(215, 555)
        toLogIn.Name = "toLogIn"
        toLogIn.Size = New Size(211, 16)
        toLogIn.TabIndex = 17
        toLogIn.Text = "Already have an account? click here"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(confirmLbl)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(usernamBox)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(CpasswordBox)
        Panel1.Controls.Add(SignUpbtn)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(toLogIn)
        Panel1.Controls.Add(suffBox)
        Panel1.Controls.Add(mnameBox)
        Panel1.Controls.Add(lnameBox)
        Panel1.Controls.Add(fnameBox)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(643, 588)
        Panel1.TabIndex = 18
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(343, 357)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 17)
        Label13.TabIndex = 53
        Label13.Text = "Confirm Password*"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(343, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 17)
        Label8.TabIndex = 52
        Label8.Text = "Password*"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(71, 357)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 17)
        Label7.TabIndex = 49
        Label7.Text = "Email*"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(71, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 47
        Label3.Text = "Username*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(72, 194)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 17)
        Label6.TabIndex = 45
        Label6.Text = "Lastname*"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(343, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 17)
        Label4.TabIndex = 43
        Label4.Text = "Suffix"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(343, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 17)
        Label2.TabIndex = 41
        Label2.Text = "Middlename"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(265, 83)
        Label12.Name = "Label12"
        Label12.Size = New Size(99, 32)
        Label12.TabIndex = 39
        Label12.Text = "Sign Up"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(72, 127)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 17)
        Label11.TabIndex = 38
        Label11.Text = "Firstname*"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(200, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 25)
        Label1.TabIndex = 36
        Label1.Text = "Barangay International Library"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(146, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.LightCoral
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(569, 374)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 32)
        Button1.TabIndex = 28
        Button1.UseVisualStyleBackColor = False
        ' 
        ' confirmLbl
        ' 
        confirmLbl.Anchor = AnchorStyles.None
        confirmLbl.AutoSize = True
        confirmLbl.FlatStyle = FlatStyle.System
        confirmLbl.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmLbl.ForeColor = Color.White
        confirmLbl.Location = New Point(380, 414)
        confirmLbl.Name = "confirmLbl"
        confirmLbl.Size = New Size(146, 14)
        confirmLbl.TabIndex = 27
        confirmLbl.Text = "Password Do Not Match!!"
        confirmLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' emailBox
        ' 
        emailBox.Anchor = AnchorStyles.None
        emailBox.BorderStyle = BorderStyle.None
        emailBox.Font = New Font("Tahoma", 11.25F)
        emailBox.Location = New Point(85, 380)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "@gmail.com"
        emailBox.Size = New Size(195, 19)
        emailBox.TabIndex = 18
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(73, 127)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 70)
        PictureBox2.TabIndex = 37
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(343, 127)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(220, 70)
        PictureBox3.TabIndex = 40
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(343, 194)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(220, 70)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(73, 194)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(220, 70)
        PictureBox5.TabIndex = 44
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.None
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(71, 291)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(220, 70)
        PictureBox6.TabIndex = 46
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(71, 357)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(220, 70)
        PictureBox7.TabIndex = 48
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.None
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Location = New Point(343, 291)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(220, 70)
        PictureBox8.TabIndex = 50
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.None
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.Location = New Point(343, 357)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(220, 70)
        PictureBox9.TabIndex = 51
        PictureBox9.TabStop = False
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(643, 588)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents lnameBox As TextBox
    Friend WithEvents mnameBox As TextBox
    Friend WithEvents suffBox As TextBox
    Friend WithEvents usernamBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents CpasswordBox As TextBox
    Friend WithEvents SignUpbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toLogIn As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents emailBox As TextBox
    Friend WithEvents confirmLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
End Class
