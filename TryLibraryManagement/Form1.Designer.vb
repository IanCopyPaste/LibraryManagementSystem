<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtUsernameLog = New TextBox()
        txtPasswordLog = New TextBox()
        LogInButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        toSignUp = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsernameLog
        ' 
        txtUsernameLog.Anchor = AnchorStyles.None
        txtUsernameLog.BackColor = Color.White
        txtUsernameLog.BorderStyle = BorderStyle.None
        txtUsernameLog.Font = New Font("Tahoma", 11.25F)
        txtUsernameLog.ForeColor = Color.Black
        txtUsernameLog.Location = New Point(142, 219)
        txtUsernameLog.Name = "txtUsernameLog"
        txtUsernameLog.PlaceholderText = "Enter username"
        txtUsernameLog.Size = New Size(198, 19)
        txtUsernameLog.TabIndex = 0
        ' 
        ' txtPasswordLog
        ' 
        txtPasswordLog.Anchor = AnchorStyles.None
        txtPasswordLog.BackColor = Color.White
        txtPasswordLog.BorderStyle = BorderStyle.None
        txtPasswordLog.Font = New Font("Tahoma", 11.25F)
        txtPasswordLog.ForeColor = Color.Black
        txtPasswordLog.Location = New Point(142, 304)
        txtPasswordLog.Name = "txtPasswordLog"
        txtPasswordLog.PlaceholderText = "Enter password"
        txtPasswordLog.Size = New Size(207, 19)
        txtPasswordLog.TabIndex = 1
        txtPasswordLog.UseSystemPasswordChar = True
        ' 
        ' LogInButton
        ' 
        LogInButton.Anchor = AnchorStyles.None
        LogInButton.BackColor = Color.DarkSlateGray
        LogInButton.Cursor = Cursors.Hand
        LogInButton.FlatAppearance.BorderSize = 0
        LogInButton.FlatStyle = FlatStyle.Flat
        LogInButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInButton.ForeColor = Color.White
        LogInButton.Image = CType(resources.GetObject("LogInButton.Image"), Image)
        LogInButton.Location = New Point(129, 376)
        LogInButton.Name = "LogInButton"
        LogInButton.Padding = New Padding(0, 0, 59, 0)
        LogInButton.Size = New Size(211, 33)
        LogInButton.TabIndex = 2
        LogInButton.Text = "            Log In"
        LogInButton.TextImageRelation = TextImageRelation.ImageBeforeText
        LogInButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(121, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 4
        Label2.Text = "Enter username"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(193, 402)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 23)
        Label3.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.None
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(163, 402)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 6
        ' 
        ' toSignUp
        ' 
        toSignUp.Anchor = AnchorStyles.None
        toSignUp.AutoSize = True
        toSignUp.BackColor = Color.Transparent
        toSignUp.Cursor = Cursors.Hand
        toSignUp.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toSignUp.ForeColor = Color.DarkSlateGray
        toSignUp.Location = New Point(98, 495)
        toSignUp.Name = "toSignUp"
        toSignUp.Size = New Size(278, 16)
        toSignUp.TabIndex = 7
        toSignUp.Text = "Don't have an account yet? click here to sign up"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(toSignUp)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LogInButton)
        Panel1.Controls.Add(txtPasswordLog)
        Panel1.Controls.Add(txtUsernameLog)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(471, 530)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(110, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 25)
        Label1.TabIndex = 35
        Label1.Text = "Barangay International Library"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(79, 294)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(36, 34)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 34
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(79, 219)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 33
        PictureBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.Snow
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(310, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(39, 27)
        Button1.TabIndex = 29
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(193, 131)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 37)
        Label6.TabIndex = 10
        Label6.Text = "Log In"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(120, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 17)
        Label5.TabIndex = 9
        Label5.Text = "Enter Password"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(121, 195)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(243, 70)
        PictureBox2.TabIndex = 31
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(120, 280)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(243, 70)
        PictureBox3.TabIndex = 32
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(56, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(471, 530)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsernameLog As TextBox
    Friend WithEvents txtPasswordLog As TextBox
    Friend WithEvents LogInButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toSignUp As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label

End Class
