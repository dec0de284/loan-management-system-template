<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditAccountDetails
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
        Me.gb_RoleAccess = New System.Windows.Forms.GroupBox()
        Me.access_User = New System.Windows.Forms.RadioButton()
        Me.access_Administrator = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textbox_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.textbox_Password = New System.Windows.Forms.TextBox()
        Me.textbox_Username = New System.Windows.Forms.TextBox()
        Me.label_ConfirmPassword = New System.Windows.Forms.Label()
        Me.label_Password = New System.Windows.Forms.Label()
        Me.label_Username = New System.Windows.Forms.Label()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_RoleID = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.cb_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.gb_RoleAccess.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_RoleAccess
        '
        Me.gb_RoleAccess.Controls.Add(Me.access_User)
        Me.gb_RoleAccess.Controls.Add(Me.access_Administrator)
        Me.gb_RoleAccess.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_RoleAccess.Location = New System.Drawing.Point(12, 126)
        Me.gb_RoleAccess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_RoleAccess.Name = "gb_RoleAccess"
        Me.gb_RoleAccess.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_RoleAccess.Size = New System.Drawing.Size(283, 98)
        Me.gb_RoleAccess.TabIndex = 0
        Me.gb_RoleAccess.TabStop = False
        Me.gb_RoleAccess.Text = "Role Access"
        '
        'access_User
        '
        Me.access_User.AutoSize = True
        Me.access_User.Location = New System.Drawing.Point(24, 62)
        Me.access_User.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.access_User.Name = "access_User"
        Me.access_User.Size = New System.Drawing.Size(155, 26)
        Me.access_User.TabIndex = 1
        Me.access_User.TabStop = True
        Me.access_User.Text = "User Account"
        Me.access_User.UseVisualStyleBackColor = True
        '
        'access_Administrator
        '
        Me.access_Administrator.AutoSize = True
        Me.access_Administrator.Location = New System.Drawing.Point(24, 30)
        Me.access_Administrator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.access_Administrator.Name = "access_Administrator"
        Me.access_Administrator.Size = New System.Drawing.Size(239, 26)
        Me.access_Administrator.TabIndex = 0
        Me.access_Administrator.TabStop = True
        Me.access_Administrator.Text = "Administrator Account"
        Me.access_Administrator.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_ShowPassword)
        Me.GroupBox1.Controls.Add(Me.textbox_ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.textbox_Password)
        Me.GroupBox1.Controls.Add(Me.textbox_Username)
        Me.GroupBox1.Controls.Add(Me.label_ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.label_Password)
        Me.GroupBox1.Controls.Add(Me.label_Username)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(472, 193)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'textbox_ConfirmPassword
        '
        Me.textbox_ConfirmPassword.Location = New System.Drawing.Point(203, 113)
        Me.textbox_ConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword"
        Me.textbox_ConfirmPassword.Size = New System.Drawing.Size(241, 30)
        Me.textbox_ConfirmPassword.TabIndex = 4
        Me.textbox_ConfirmPassword.UseSystemPasswordChar = True
        '
        'textbox_Password
        '
        Me.textbox_Password.Location = New System.Drawing.Point(203, 78)
        Me.textbox_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Password.Name = "textbox_Password"
        Me.textbox_Password.Size = New System.Drawing.Size(241, 30)
        Me.textbox_Password.TabIndex = 4
        Me.textbox_Password.UseSystemPasswordChar = True
        '
        'textbox_Username
        '
        Me.textbox_Username.Location = New System.Drawing.Point(203, 42)
        Me.textbox_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Username.Name = "textbox_Username"
        Me.textbox_Username.Size = New System.Drawing.Size(241, 30)
        Me.textbox_Username.TabIndex = 3
        '
        'label_ConfirmPassword
        '
        Me.label_ConfirmPassword.AutoSize = True
        Me.label_ConfirmPassword.Location = New System.Drawing.Point(20, 114)
        Me.label_ConfirmPassword.Name = "label_ConfirmPassword"
        Me.label_ConfirmPassword.Size = New System.Drawing.Size(176, 22)
        Me.label_ConfirmPassword.TabIndex = 2
        Me.label_ConfirmPassword.Text = "Confirm Password:"
        '
        'label_Password
        '
        Me.label_Password.AutoSize = True
        Me.label_Password.Location = New System.Drawing.Point(96, 80)
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
        Me.button_Submit.Location = New System.Drawing.Point(197, 438)
        Me.button_Submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(117, 38)
        Me.button_Submit.TabIndex = 3
        Me.button_Submit.Text = "Submit"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_RoleID)
        Me.GroupBox2.Controls.Add(Me.lbl_Username)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(402, 111)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected Account"
        '
        'lbl_RoleID
        '
        Me.lbl_RoleID.AutoSize = True
        Me.lbl_RoleID.Location = New System.Drawing.Point(20, 70)
        Me.lbl_RoleID.Name = "lbl_RoleID"
        Me.lbl_RoleID.Size = New System.Drawing.Size(124, 22)
        Me.lbl_RoleID.TabIndex = 1
        Me.lbl_RoleID.Text = "Role Access:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(20, 36)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(106, 22)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username:"
        '
        'cb_ShowPassword
        '
        Me.cb_ShowPassword.AutoSize = True
        Me.cb_ShowPassword.Location = New System.Drawing.Point(203, 148)
        Me.cb_ShowPassword.Name = "cb_ShowPassword"
        Me.cb_ShowPassword.Size = New System.Drawing.Size(171, 26)
        Me.cb_ShowPassword.TabIndex = 5
        Me.cb_ShowPassword.Text = "Show Password"
        Me.cb_ShowPassword.UseVisualStyleBackColor = True
        '
        'EditAccountDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 502)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_RoleAccess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditAccountDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account Details Form"
        Me.TopMost = True
        Me.gb_RoleAccess.ResumeLayout(False)
        Me.gb_RoleAccess.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_RoleAccess As GroupBox
    Friend WithEvents access_User As RadioButton
    Friend WithEvents access_Administrator As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textbox_ConfirmPassword As TextBox
    Friend WithEvents textbox_Password As TextBox
    Friend WithEvents textbox_Username As TextBox
    Friend WithEvents label_ConfirmPassword As Label
    Friend WithEvents label_Password As Label
    Friend WithEvents label_Username As Label
    Friend WithEvents button_Submit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_RoleID As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents cb_ShowPassword As CheckBox
End Class
