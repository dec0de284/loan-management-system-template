<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCapitalShareForm
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
        Me.gb_ClientDetails = New System.Windows.Forms.GroupBox()
        Me.lbl_OldShareCapital = New System.Windows.Forms.Label()
        Me.tb_ShareCapital = New System.Windows.Forms.TextBox()
        Me.lbl_AddShareCapital = New System.Windows.Forms.Label()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_ClientName = New System.Windows.Forms.Label()
        Me.lbl_ClientID = New System.Windows.Forms.Label()
        Me.gb_ClientDetails.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_ClientDetails
        '
        Me.gb_ClientDetails.Controls.Add(Me.lbl_OldShareCapital)
        Me.gb_ClientDetails.Controls.Add(Me.tb_ShareCapital)
        Me.gb_ClientDetails.Controls.Add(Me.lbl_AddShareCapital)
        Me.gb_ClientDetails.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ClientDetails.Location = New System.Drawing.Point(12, 156)
        Me.gb_ClientDetails.Name = "gb_ClientDetails"
        Me.gb_ClientDetails.Size = New System.Drawing.Size(513, 169)
        Me.gb_ClientDetails.TabIndex = 0
        Me.gb_ClientDetails.TabStop = False
        Me.gb_ClientDetails.Text = "Share Capital Details"
        '
        'lbl_OldShareCapital
        '
        Me.lbl_OldShareCapital.AutoSize = True
        Me.lbl_OldShareCapital.Location = New System.Drawing.Point(53, 53)
        Me.lbl_OldShareCapital.Name = "lbl_OldShareCapital"
        Me.lbl_OldShareCapital.Size = New System.Drawing.Size(182, 22)
        Me.lbl_OldShareCapital.TabIndex = 8
        Me.lbl_OldShareCapital.Text = "Old Share Capital: "
        '
        'tb_ShareCapital
        '
        Me.tb_ShareCapital.Location = New System.Drawing.Point(244, 102)
        Me.tb_ShareCapital.MaxLength = 11
        Me.tb_ShareCapital.Name = "tb_ShareCapital"
        Me.tb_ShareCapital.Size = New System.Drawing.Size(205, 30)
        Me.tb_ShareCapital.TabIndex = 7
        '
        'lbl_AddShareCapital
        '
        Me.lbl_AddShareCapital.AutoSize = True
        Me.lbl_AddShareCapital.Location = New System.Drawing.Point(53, 105)
        Me.lbl_AddShareCapital.Name = "lbl_AddShareCapital"
        Me.lbl_AddShareCapital.Size = New System.Drawing.Size(185, 22)
        Me.lbl_AddShareCapital.TabIndex = 4
        Me.lbl_AddShareCapital.Text = "Add Share Capital:"
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(193, 343)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(137, 52)
        Me.btn_Submit.TabIndex = 2
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_ClientName)
        Me.GroupBox2.Controls.Add(Me.lbl_ClientID)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 138)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected Client"
        '
        'lbl_ClientName
        '
        Me.lbl_ClientName.AutoSize = True
        Me.lbl_ClientName.Location = New System.Drawing.Point(35, 85)
        Me.lbl_ClientName.Name = "lbl_ClientName"
        Me.lbl_ClientName.Size = New System.Drawing.Size(133, 22)
        Me.lbl_ClientName.TabIndex = 3
        Me.lbl_ClientName.Text = "Client Name: "
        '
        'lbl_ClientID
        '
        Me.lbl_ClientID.AutoSize = True
        Me.lbl_ClientID.Location = New System.Drawing.Point(35, 44)
        Me.lbl_ClientID.Name = "lbl_ClientID"
        Me.lbl_ClientID.Size = New System.Drawing.Size(96, 22)
        Me.lbl_ClientID.TabIndex = 2
        Me.lbl_ClientID.Text = "Client ID: "
        '
        'AddCapitalShareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.gb_ClientDetails)
        Me.Name = "AddCapitalShareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Share Capital Form"
        Me.gb_ClientDetails.ResumeLayout(False)
        Me.gb_ClientDetails.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_ClientDetails As GroupBox
    Friend WithEvents lbl_AddShareCapital As Label
    Friend WithEvents tb_ShareCapital As TextBox
    Friend WithEvents btn_Submit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_ClientName As Label
    Friend WithEvents lbl_ClientID As Label
    Friend WithEvents lbl_OldShareCapital As Label
End Class
