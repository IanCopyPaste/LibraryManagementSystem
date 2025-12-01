<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpOtpCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpOtpCode))
        Label1 = New Label()
        txtOtpCode = New TextBox()
        btnSendCode = New Button()
        btnResendCode = New Button()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(81, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 50)
        Label1.TabIndex = 0
        Label1.Text = "Your Verification Code is " & vbCrLf & "Sent To Email!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtOtpCode
        ' 
        txtOtpCode.Anchor = AnchorStyles.None
        txtOtpCode.BorderStyle = BorderStyle.None
        txtOtpCode.Font = New Font("Tahoma", 11.25F)
        txtOtpCode.Location = New Point(71, 160)
        txtOtpCode.Name = "txtOtpCode"
        txtOtpCode.PlaceholderText = "6 Digit Code"
        txtOtpCode.Size = New Size(216, 19)
        txtOtpCode.TabIndex = 1
        ' 
        ' btnSendCode
        ' 
        btnSendCode.Anchor = AnchorStyles.None
        btnSendCode.BackColor = Color.DarkSlateGray
        btnSendCode.FlatAppearance.BorderSize = 0
        btnSendCode.FlatStyle = FlatStyle.Flat
        btnSendCode.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSendCode.ForeColor = Color.White
        btnSendCode.Location = New Point(71, 293)
        btnSendCode.Name = "btnSendCode"
        btnSendCode.Size = New Size(216, 33)
        btnSendCode.TabIndex = 3
        btnSendCode.Text = "Enter Code"
        btnSendCode.UseVisualStyleBackColor = False
        ' 
        ' btnResendCode
        ' 
        btnResendCode.Anchor = AnchorStyles.None
        btnResendCode.BackColor = Color.DarkSlateGray
        btnResendCode.FlatAppearance.BorderSize = 0
        btnResendCode.FlatStyle = FlatStyle.Flat
        btnResendCode.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnResendCode.ForeColor = Color.White
        btnResendCode.Location = New Point(149, 194)
        btnResendCode.Name = "btnResendCode"
        btnResendCode.Size = New Size(91, 21)
        btnResendCode.TabIndex = 4
        btnResendCode.Text = "Resend Code"
        btnResendCode.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(51, 136)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(255, 70)
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(51, 127)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 17)
        Label11.TabIndex = 39
        Label11.Text = "Enter Code"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(50, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 40
        Label2.Text = "Didn't get code?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' SignUpOtpCode
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(362, 363)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(btnResendCode)
        Controls.Add(btnSendCode)
        Controls.Add(txtOtpCode)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        Margin = New Padding(4)
        MinimumSize = New Size(378, 402)
        Name = "SignUpOtpCode"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Enter OTP Code"
        TopMost = True
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOtpCode As TextBox
    Friend WithEvents btnSendCode As Button
    Friend WithEvents btnResendCode As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
