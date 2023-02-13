<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAccountCreation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.textbox_Password = New System.Windows.Forms.TextBox()
        Me.textbox_Username = New System.Windows.Forms.TextBox()
        Me.label_ConfirmPassword = New System.Windows.Forms.Label()
        Me.label_Password = New System.Windows.Forms.Label()
        Me.label_Username = New System.Windows.Forms.Label()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textbox_ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.textbox_Password)
        Me.GroupBox1.Controls.Add(Me.textbox_Username)
        Me.GroupBox1.Controls.Add(Me.label_ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.label_Password)
        Me.GroupBox1.Controls.Add(Me.label_Username)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(607, 422)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Account Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(219, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "[✗ ] invalid"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(219, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "[✗ ] at least 4 characters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(219, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "[✗ ] password doesn't match"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(219, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "[✗ ] one uppercase letter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(219, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "[✗ ] at least 11 characters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(219, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "[✗ ] at least three numbers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(219, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "[✗ ] one special character"
        '
        'textbox_ConfirmPassword
        '
        Me.textbox_ConfirmPassword.Location = New System.Drawing.Point(223, 325)
        Me.textbox_ConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_ConfirmPassword.MaxLength = 255
        Me.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword"
        Me.textbox_ConfirmPassword.Size = New System.Drawing.Size(241, 30)
        Me.textbox_ConfirmPassword.TabIndex = 4
        Me.textbox_ConfirmPassword.UseSystemPasswordChar = True
        '
        'textbox_Password
        '
        Me.textbox_Password.Location = New System.Drawing.Point(223, 152)
        Me.textbox_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Password.MaxLength = 255
        Me.textbox_Password.Name = "textbox_Password"
        Me.textbox_Password.Size = New System.Drawing.Size(241, 30)
        Me.textbox_Password.TabIndex = 4
        Me.textbox_Password.UseSystemPasswordChar = True
        '
        'textbox_Username
        '
        Me.textbox_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.textbox_Username.Location = New System.Drawing.Point(223, 42)
        Me.textbox_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Username.MaxLength = 255
        Me.textbox_Username.Name = "textbox_Username"
        Me.textbox_Username.Size = New System.Drawing.Size(241, 30)
        Me.textbox_Username.TabIndex = 3
        '
        'label_ConfirmPassword
        '
        Me.label_ConfirmPassword.AutoSize = True
        Me.label_ConfirmPassword.Location = New System.Drawing.Point(14, 325)
        Me.label_ConfirmPassword.Name = "label_ConfirmPassword"
        Me.label_ConfirmPassword.Size = New System.Drawing.Size(176, 22)
        Me.label_ConfirmPassword.TabIndex = 2
        Me.label_ConfirmPassword.Text = "Confirm Password:"
        '
        'label_Password
        '
        Me.label_Password.AutoSize = True
        Me.label_Password.Location = New System.Drawing.Point(96, 154)
        Me.label_Password.Name = "label_Password"
        Me.label_Password.Size = New System.Drawing.Size(100, 22)
        Me.label_Password.TabIndex = 1
        Me.label_Password.Text = "Password:"
        '
        'label_Username
        '
        Me.label_Username.AutoSize = True
        Me.label_Username.Location = New System.Drawing.Point(91, 46)
        Me.label_Username.Name = "label_Username"
        Me.label_Username.Size = New System.Drawing.Size(106, 22)
        Me.label_Username.TabIndex = 0
        Me.label_Username.Text = "Username:"
        '
        'button_Submit
        '
        Me.button_Submit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Submit.Location = New System.Drawing.Point(246, 461)
        Me.button_Submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(117, 38)
        Me.button_Submit.TabIndex = 3
        Me.button_Submit.Text = "Next"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'UserAccountCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 527)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserAccountCreation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account Creation Form"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textbox_ConfirmPassword As TextBox
    Friend WithEvents textbox_Password As TextBox
    Friend WithEvents textbox_Username As TextBox
    Friend WithEvents label_ConfirmPassword As Label
    Friend WithEvents label_Password As Label
    Friend WithEvents label_Username As Label
    Friend WithEvents button_Submit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
