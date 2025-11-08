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
        Label1 = New Label()
        Label2 = New Label()
        fnameBox = New TextBox()
        lnameBox = New TextBox()
        mnameBox = New TextBox()
        suffBox = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        usernamBox = New TextBox()
        passwordBox = New TextBox()
        CpasswordBox = New TextBox()
        SignUpbtn = New Button()
        LinkLabel1 = New LinkLabel()
        toLogIn = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 23)
        Label1.TabIndex = 4
        Label1.Text = "Library Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(304, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 23)
        Label2.TabIndex = 5
        Label2.Text = "SIGN UP"
        ' 
        ' fnameBox
        ' 
        fnameBox.Location = New Point(12, 91)
        fnameBox.Name = "fnameBox"
        fnameBox.PlaceholderText = "Enter firstname"
        fnameBox.Size = New Size(165, 27)
        fnameBox.TabIndex = 6
        ' 
        ' lnameBox
        ' 
        lnameBox.Location = New Point(12, 143)
        lnameBox.Name = "lnameBox"
        lnameBox.PlaceholderText = "Enter lastname"
        lnameBox.Size = New Size(165, 27)
        lnameBox.TabIndex = 7
        ' 
        ' mnameBox
        ' 
        mnameBox.Location = New Point(210, 91)
        mnameBox.Name = "mnameBox"
        mnameBox.PlaceholderText = "Enter middlename"
        mnameBox.Size = New Size(165, 27)
        mnameBox.TabIndex = 8
        ' 
        ' suffBox
        ' 
        suffBox.Location = New Point(210, 143)
        suffBox.Name = "suffBox"
        suffBox.PlaceholderText = "Enter suffix"
        suffBox.Size = New Size(165, 27)
        suffBox.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(261, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 13)
        Label3.TabIndex = 10
        Label3.Text = "(optional)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(261, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 13)
        Label4.TabIndex = 11
        Label4.Text = "(optional)"
        ' 
        ' usernamBox
        ' 
        usernamBox.Location = New Point(82, 223)
        usernamBox.Name = "usernamBox"
        usernamBox.PlaceholderText = "Create username"
        usernamBox.Size = New Size(232, 27)
        usernamBox.TabIndex = 12
        ' 
        ' passwordBox
        ' 
        passwordBox.Location = New Point(82, 274)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "Create password"
        passwordBox.Size = New Size(232, 27)
        passwordBox.TabIndex = 13
        passwordBox.UseSystemPasswordChar = True
        ' 
        ' CpasswordBox
        ' 
        CpasswordBox.Location = New Point(82, 323)
        CpasswordBox.Name = "CpasswordBox"
        CpasswordBox.PlaceholderText = "Confirm password"
        CpasswordBox.Size = New Size(232, 27)
        CpasswordBox.TabIndex = 14
        CpasswordBox.UseSystemPasswordChar = True
        ' 
        ' SignUpbtn
        ' 
        SignUpbtn.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpbtn.Location = New Point(158, 366)
        SignUpbtn.Name = "SignUpbtn"
        SignUpbtn.Size = New Size(75, 28)
        SignUpbtn.TabIndex = 15
        SignUpbtn.Text = "SignUp"
        SignUpbtn.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(94, 409)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 16
        ' 
        ' toLogIn
        ' 
        toLogIn.AutoSize = True
        toLogIn.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toLogIn.ForeColor = SystemColors.MenuHighlight
        toLogIn.Location = New Point(94, 409)
        toLogIn.Name = "toLogIn"
        toLogIn.Size = New Size(210, 16)
        toLogIn.TabIndex = 17
        toLogIn.Text = "already have an account? click here"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(usernamBox)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(CpasswordBox)
        Panel1.Controls.Add(SignUpbtn)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(toLogIn)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(suffBox)
        Panel1.Controls.Add(mnameBox)
        Panel1.Controls.Add(lnameBox)
        Panel1.Controls.Add(fnameBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 434)
        Panel1.TabIndex = 18
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 434)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents lnameBox As TextBox
    Friend WithEvents mnameBox As TextBox
    Friend WithEvents suffBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents usernamBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents CpasswordBox As TextBox
    Friend WithEvents SignUpbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents toLogIn As Label
    Friend WithEvents Panel1 As Panel
End Class
