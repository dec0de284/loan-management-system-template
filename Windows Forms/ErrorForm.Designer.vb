<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorForm
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
        Me.GroupBox_Error_Details = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_Error = New System.Windows.Forms.RichTextBox()
        Me.Label_Error = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox_Error_Details.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Error_Details
        '
        Me.GroupBox_Error_Details.Controls.Add(Me.LinkLabel1)
        Me.GroupBox_Error_Details.Controls.Add(Me.Label_Error)
        Me.GroupBox_Error_Details.Controls.Add(Me.RichTextBox_Error)
        Me.GroupBox_Error_Details.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Error_Details.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox_Error_Details.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_Error_Details.Name = "GroupBox_Error_Details"
        Me.GroupBox_Error_Details.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_Error_Details.Size = New System.Drawing.Size(720, 458)
        Me.GroupBox_Error_Details.TabIndex = 1
        Me.GroupBox_Error_Details.TabStop = False
        Me.GroupBox_Error_Details.Text = "Error Details"
        '
        'RichTextBox_Error
        '
        Me.RichTextBox_Error.Enabled = False
        Me.RichTextBox_Error.Location = New System.Drawing.Point(31, 98)
        Me.RichTextBox_Error.Name = "RichTextBox_Error"
        Me.RichTextBox_Error.Size = New System.Drawing.Size(666, 339)
        Me.RichTextBox_Error.TabIndex = 6
        Me.RichTextBox_Error.Text = ""
        '
        'Label_Error
        '
        Me.Label_Error.AutoSize = True
        Me.Label_Error.Location = New System.Drawing.Point(27, 37)
        Me.Label_Error.Name = "Label_Error"
        Me.Label_Error.Size = New System.Drawing.Size(314, 21)
        Me.Label_Error.TabIndex = 7
        Me.Label_Error.Text = "Please report the following error at:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(27, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(670, 21)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/dec0de284/loan-management-system-template/issues"
        '
        'ErrorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 494)
        Me.Controls.Add(Me.GroupBox_Error_Details)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Error"
        Me.TopMost = True
        Me.GroupBox_Error_Details.ResumeLayout(False)
        Me.GroupBox_Error_Details.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_Error_Details As GroupBox
    Friend WithEvents RichTextBox_Error As RichTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label_Error As Label
End Class
