<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbTimeout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCamera = New System.Windows.Forms.TextBox()
        Me.pbVideo = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pbVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(71, 10)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(100, 20)
        Me.tbUser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paasword"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Timeout"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(71, 36)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbPassword.TabIndex = 4
        '
        'tbTimeout
        '
        Me.tbTimeout.Location = New System.Drawing.Point(71, 64)
        Me.tbTimeout.Name = "tbTimeout"
        Me.tbTimeout.Size = New System.Drawing.Size(100, 20)
        Me.tbTimeout.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Camera"
        '
        'tbCamera
        '
        Me.tbCamera.Location = New System.Drawing.Point(71, 116)
        Me.tbCamera.Name = "tbCamera"
        Me.tbCamera.Size = New System.Drawing.Size(100, 20)
        Me.tbCamera.TabIndex = 7
        '
        'pbVideo
        '
        Me.pbVideo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbVideo.Location = New System.Drawing.Point(178, 13)
        Me.pbVideo.Name = "pbVideo"
        Me.pbVideo.Size = New System.Drawing.Size(1055, 609)
        Me.pbVideo.TabIndex = 8
        Me.pbVideo.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 143)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(156, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnVideo
        '
        Me.btnVideo.Location = New System.Drawing.Point(16, 173)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(155, 23)
        Me.btnVideo.TabIndex = 10
        Me.btnVideo.Text = "Video"
        Me.btnVideo.UseVisualStyleBackColor = True
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(72, 90)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(100, 20)
        Me.tbAddress.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Address"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 634)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVideo)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.pbVideo)
        Me.Controls.Add(Me.tbCamera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTimeout)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbTimeout As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCamera As TextBox
    Friend WithEvents pbVideo As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnVideo As Button
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label5 As Label
End Class
