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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        toSignUp = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsernameLog
        ' 
        txtUsernameLog.BackColor = Color.White
        txtUsernameLog.BorderStyle = BorderStyle.FixedSingle
        txtUsernameLog.Font = New Font("Tahoma", 11.25F)
        txtUsernameLog.ForeColor = Color.Black
        txtUsernameLog.Location = New Point(95, 214)
        txtUsernameLog.Name = "txtUsernameLog"
        txtUsernameLog.PlaceholderText = "Enter username"
        txtUsernameLog.Size = New Size(207, 26)
        txtUsernameLog.TabIndex = 0
        ' 
        ' txtPasswordLog
        ' 
        txtPasswordLog.BackColor = Color.White
        txtPasswordLog.BorderStyle = BorderStyle.FixedSingle
        txtPasswordLog.Font = New Font("Tahoma", 11.25F)
        txtPasswordLog.ForeColor = Color.Black
        txtPasswordLog.Location = New Point(95, 282)
        txtPasswordLog.Name = "txtPasswordLog"
        txtPasswordLog.PlaceholderText = "Enter password"
        txtPasswordLog.Size = New Size(207, 26)
        txtPasswordLog.TabIndex = 1
        txtPasswordLog.UseSystemPasswordChar = True
        ' 
        ' LogInButton
        ' 
        LogInButton.BackColor = Color.Green
        LogInButton.Cursor = Cursors.Hand
        LogInButton.FlatAppearance.BorderSize = 0
        LogInButton.FlatStyle = FlatStyle.Flat
        LogInButton.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogInButton.ForeColor = Color.White
        LogInButton.Location = New Point(117, 334)
        LogInButton.Name = "LogInButton"
        LogInButton.Size = New Size(160, 28)
        LogInButton.TabIndex = 2
        LogInButton.Text = "Log In"
        LogInButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 66)
        Label1.TabIndex = 3
        Label1.Text = "       Barangay" & vbCrLf & "        International Library"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(95, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 17)
        Label2.TabIndex = 4
        Label2.Text = "Enter username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(162, 382)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 23)
        Label3.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(132, 382)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 6
        ' 
        ' toSignUp
        ' 
        toSignUp.AutoSize = True
        toSignUp.BackColor = Color.Transparent
        toSignUp.Cursor = Cursors.Hand
        toSignUp.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toSignUp.ForeColor = Color.DarkGreen
        toSignUp.Location = New Point(55, 388)
        toSignUp.Name = "toSignUp"
        toSignUp.Size = New Size(278, 16)
        toSignUp.TabIndex = 7
        toSignUp.Text = "Don't have an account yet? click here to sign up"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(toSignUp)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LogInButton)
        Panel1.Controls.Add(txtPasswordLog)
        Panel1.Controls.Add(txtUsernameLog)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 434)
        Panel1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gainsboro
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.LightCoral
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(308, 281)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 27)
        Button1.TabIndex = 29
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Rockwell", 20.25F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(154, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 33)
        Label6.TabIndex = 10
        Label6.Text = "Log In"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(95, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 17)
        Label5.TabIndex = 9
        Label5.Text = "Enter Password"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(398, 434)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsernameLog As TextBox
    Friend WithEvents txtPasswordLog As TextBox
    Friend WithEvents LogInButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toSignUp As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button

End Class
