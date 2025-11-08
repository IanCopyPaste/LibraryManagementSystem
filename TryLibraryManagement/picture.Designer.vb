<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class picture
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
        PictureBox1 = New PictureBox()
        pathCheck = New Button()
        Photo = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(306, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 182)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pathCheck
        ' 
        pathCheck.Location = New Point(627, 135)
        pathCheck.Name = "pathCheck"
        pathCheck.Size = New Size(80, 29)
        pathCheck.TabIndex = 1
        pathCheck.Text = "checkPath"
        pathCheck.UseVisualStyleBackColor = True
        ' 
        ' Photo
        ' 
        Photo.FileName = "OpenFileDialog1"
        ' 
        ' picture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pathCheck)
        Controls.Add(PictureBox1)
        Name = "picture"
        Text = "picture"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pathCheck As Button
    Friend WithEvents Photo As OpenFileDialog
End Class
