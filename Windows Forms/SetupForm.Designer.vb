<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupForm
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
        Me.GroupBox_Database_Details = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_Others = New System.Windows.Forms.RichTextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox_DatabasePassword = New System.Windows.Forms.GroupBox()
        Me.CheckBox_EncryptPassword = New System.Windows.Forms.CheckBox()
        Me.TextBox_DatabasePassword = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_NoPassword = New System.Windows.Forms.RadioButton()
        Me.RadioButton_MSAccess = New System.Windows.Forms.RadioButton()
        Me.Button_SearchFile = New System.Windows.Forms.Button()
        Me.Button_TestConnection = New System.Windows.Forms.Button()
        Me.OpenFileDialog_DataBaseFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox_Database_Details.SuspendLayout()
        Me.GroupBox_DatabasePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Database_Details
        '
        Me.GroupBox_Database_Details.Controls.Add(Me.RichTextBox_Others)
        Me.GroupBox_Database_Details.Controls.Add(Me.RadioButton3)
        Me.GroupBox_Database_Details.Controls.Add(Me.GroupBox_DatabasePassword)
        Me.GroupBox_Database_Details.Controls.Add(Me.RadioButton_MSAccess)
        Me.GroupBox_Database_Details.Controls.Add(Me.Button_SearchFile)
        Me.GroupBox_Database_Details.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Database_Details.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox_Database_Details.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_Database_Details.Name = "GroupBox_Database_Details"
        Me.GroupBox_Database_Details.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_Database_Details.Size = New System.Drawing.Size(506, 458)
        Me.GroupBox_Database_Details.TabIndex = 1
        Me.GroupBox_Database_Details.TabStop = False
        Me.GroupBox_Database_Details.Text = "Database Details"
        '
        'RichTextBox_Others
        '
        Me.RichTextBox_Others.Enabled = False
        Me.RichTextBox_Others.Location = New System.Drawing.Point(65, 317)
        Me.RichTextBox_Others.Name = "RichTextBox_Others"
        Me.RichTextBox_Others.Size = New System.Drawing.Size(390, 96)
        Me.RichTextBox_Others.TabIndex = 6
        Me.RichTextBox_Others.Text = ""
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(33, 286)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(343, 25)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Others (Custom Connection String):"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox_DatabasePassword
        '
        Me.GroupBox_DatabasePassword.Controls.Add(Me.CheckBox_EncryptPassword)
        Me.GroupBox_DatabasePassword.Controls.Add(Me.TextBox_DatabasePassword)
        Me.GroupBox_DatabasePassword.Controls.Add(Me.RadioButton2)
        Me.GroupBox_DatabasePassword.Controls.Add(Me.RadioButton_NoPassword)
        Me.GroupBox_DatabasePassword.Location = New System.Drawing.Point(47, 100)
        Me.GroupBox_DatabasePassword.Name = "GroupBox_DatabasePassword"
        Me.GroupBox_DatabasePassword.Size = New System.Drawing.Size(408, 168)
        Me.GroupBox_DatabasePassword.TabIndex = 4
        Me.GroupBox_DatabasePassword.TabStop = False
        Me.GroupBox_DatabasePassword.Text = "MS Access Database Password"
        '
        'CheckBox_EncryptPassword
        '
        Me.CheckBox_EncryptPassword.AutoSize = True
        Me.CheckBox_EncryptPassword.Enabled = False
        Me.CheckBox_EncryptPassword.Location = New System.Drawing.Point(162, 119)
        Me.CheckBox_EncryptPassword.Name = "CheckBox_EncryptPassword"
        Me.CheckBox_EncryptPassword.Size = New System.Drawing.Size(178, 25)
        Me.CheckBox_EncryptPassword.TabIndex = 6
        Me.CheckBox_EncryptPassword.Text = "Encrypt (Base64)"
        Me.CheckBox_EncryptPassword.UseVisualStyleBackColor = True
        '
        'TextBox_DatabasePassword
        '
        Me.TextBox_DatabasePassword.Enabled = False
        Me.TextBox_DatabasePassword.Location = New System.Drawing.Point(162, 83)
        Me.TextBox_DatabasePassword.Name = "TextBox_DatabasePassword"
        Me.TextBox_DatabasePassword.Size = New System.Drawing.Size(183, 30)
        Me.TextBox_DatabasePassword.TabIndex = 5
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(34, 84)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 25)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Password"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton_NoPassword
        '
        Me.RadioButton_NoPassword.AutoSize = True
        Me.RadioButton_NoPassword.Checked = True
        Me.RadioButton_NoPassword.Location = New System.Drawing.Point(34, 40)
        Me.RadioButton_NoPassword.Name = "RadioButton_NoPassword"
        Me.RadioButton_NoPassword.Size = New System.Drawing.Size(141, 25)
        Me.RadioButton_NoPassword.TabIndex = 3
        Me.RadioButton_NoPassword.TabStop = True
        Me.RadioButton_NoPassword.Text = "No Password"
        Me.RadioButton_NoPassword.UseVisualStyleBackColor = True
        '
        'RadioButton_MSAccess
        '
        Me.RadioButton_MSAccess.AutoSize = True
        Me.RadioButton_MSAccess.Checked = True
        Me.RadioButton_MSAccess.Location = New System.Drawing.Point(33, 45)
        Me.RadioButton_MSAccess.Name = "RadioButton_MSAccess"
        Me.RadioButton_MSAccess.Size = New System.Drawing.Size(132, 25)
        Me.RadioButton_MSAccess.TabIndex = 2
        Me.RadioButton_MSAccess.TabStop = True
        Me.RadioButton_MSAccess.Text = "MS Access:"
        Me.RadioButton_MSAccess.UseVisualStyleBackColor = True
        '
        'Button_SearchFile
        '
        Me.Button_SearchFile.Location = New System.Drawing.Point(181, 35)
        Me.Button_SearchFile.Name = "Button_SearchFile"
        Me.Button_SearchFile.Size = New System.Drawing.Size(211, 45)
        Me.Button_SearchFile.TabIndex = 1
        Me.Button_SearchFile.Text = "Search File (.mdb)"
        Me.Button_SearchFile.UseVisualStyleBackColor = True
        '
        'Button_TestConnection
        '
        Me.Button_TestConnection.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_TestConnection.Location = New System.Drawing.Point(178, 502)
        Me.Button_TestConnection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_TestConnection.Name = "Button_TestConnection"
        Me.Button_TestConnection.Size = New System.Drawing.Size(195, 38)
        Me.Button_TestConnection.TabIndex = 3
        Me.Button_TestConnection.Text = "Test Connection"
        Me.Button_TestConnection.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_DataBaseFile
        '
        Me.OpenFileDialog_DataBaseFile.FileName = "OpenFileDialog1"
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 568)
        Me.Controls.Add(Me.Button_TestConnection)
        Me.Controls.Add(Me.GroupBox_Database_Details)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First Time System Setup"
        Me.TopMost = True
        Me.GroupBox_Database_Details.ResumeLayout(False)
        Me.GroupBox_Database_Details.PerformLayout()
        Me.GroupBox_DatabasePassword.ResumeLayout(False)
        Me.GroupBox_DatabasePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_Database_Details As GroupBox
    Friend WithEvents Button_TestConnection As Button
    Friend WithEvents GroupBox_DatabasePassword As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton_NoPassword As RadioButton
    Friend WithEvents RadioButton_MSAccess As RadioButton
    Friend WithEvents Button_SearchFile As Button
    Friend WithEvents RichTextBox_Others As RichTextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox_EncryptPassword As CheckBox
    Friend WithEvents TextBox_DatabasePassword As TextBox
    Friend WithEvents OpenFileDialog_DataBaseFile As OpenFileDialog
End Class
