<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_CreateAccount
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_ShowPassword = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.Controls.Add(Me.cb_ShowPassword)
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
        Me.GroupBox1.Size = New System.Drawing.Size(472, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
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
        'textbox_ConfirmPassword
        '
        Me.textbox_ConfirmPassword.Location = New System.Drawing.Point(203, 113)
        Me.textbox_ConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_ConfirmPassword.MaxLength = 255
        Me.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword"
        Me.textbox_ConfirmPassword.Size = New System.Drawing.Size(241, 30)
        Me.textbox_ConfirmPassword.TabIndex = 4
        Me.textbox_ConfirmPassword.UseSystemPasswordChar = True
        '
        'textbox_Password
        '
        Me.textbox_Password.Location = New System.Drawing.Point(203, 78)
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
        Me.textbox_Username.Location = New System.Drawing.Point(203, 42)
        Me.textbox_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Username.MaxLength = 255
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
        Me.button_Submit.Location = New System.Drawing.Point(198, 228)
        Me.button_Submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(117, 38)
        Me.button_Submit.TabIndex = 3
        Me.button_Submit.Text = "Submit"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'form_CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 302)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_CreateAccount"
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
    Friend WithEvents cb_ShowPassword As CheckBox
End Class
