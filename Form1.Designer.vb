<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxFtpAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.HostLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TitleForm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.TextBoxUsername.Location = New System.Drawing.Point(138, 139)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(224, 22)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxFtpAddress
        '
        Me.TextBoxFtpAddress.Location = New System.Drawing.Point(138, 296)
        Me.TextBoxFtpAddress.Name = "TextBoxFtpAddress"
        Me.TextBoxFtpAddress.Size = New System.Drawing.Size(224, 22)
        Me.TextBoxFtpAddress.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(138, 216)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(224, 22)
        Me.TextBoxPassword.TabIndex = 2
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(207, 366)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConnect.TabIndex = 3
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(56, 142)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(76, 16)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Username :"
        '
        'HostLabel
        '
        Me.HostLabel.AutoSize = True
        Me.HostLabel.Location = New System.Drawing.Point(91, 299)
        Me.HostLabel.Name = "HostLabel"
        Me.HostLabel.Size = New System.Drawing.Size(41, 16)
        Me.HostLabel.TabIndex = 5
        Me.HostLabel.Text = "Host :"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(59, 219)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(73, 16)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "Password :"
        '
        'TitleForm
        '
        Me.TitleForm.AutoSize = True
        Me.TitleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleForm.Location = New System.Drawing.Point(143, 68)
        Me.TitleForm.Name = "TitleForm"
        Me.TitleForm.Size = New System.Drawing.Size(219, 32)
        Me.TitleForm.TabIndex = 7
        Me.TitleForm.Text = "FTP Connection"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 478)
        Me.Controls.Add(Me.TitleForm)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.HostLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxFtpAddress)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxFtpAddress As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents HostLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TitleForm As Label
End Class
