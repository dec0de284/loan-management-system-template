<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditClientForm
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
        Me.tb_ClientContactNumber = New System.Windows.Forms.TextBox()
        Me.tb_ClientAddress = New System.Windows.Forms.TextBox()
        Me.tb_ClientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_CoMakerContactNumber = New System.Windows.Forms.TextBox()
        Me.tb_CoMakerAddress = New System.Windows.Forms.TextBox()
        Me.tb_CoMakerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_ClientName = New System.Windows.Forms.Label()
        Me.lbl_ClientID = New System.Windows.Forms.Label()
        Me.gb_ClientDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_ClientDetails
        '
        Me.gb_ClientDetails.Controls.Add(Me.tb_ClientContactNumber)
        Me.gb_ClientDetails.Controls.Add(Me.tb_ClientAddress)
        Me.gb_ClientDetails.Controls.Add(Me.tb_ClientName)
        Me.gb_ClientDetails.Controls.Add(Me.Label3)
        Me.gb_ClientDetails.Controls.Add(Me.Label2)
        Me.gb_ClientDetails.Controls.Add(Me.Label1)
        Me.gb_ClientDetails.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ClientDetails.Location = New System.Drawing.Point(12, 156)
        Me.gb_ClientDetails.Name = "gb_ClientDetails"
        Me.gb_ClientDetails.Size = New System.Drawing.Size(513, 226)
        Me.gb_ClientDetails.TabIndex = 0
        Me.gb_ClientDetails.TabStop = False
        Me.gb_ClientDetails.Text = "Client Details"
        '
        'tb_ClientContactNumber
        '
        Me.tb_ClientContactNumber.Location = New System.Drawing.Point(242, 160)
        Me.tb_ClientContactNumber.MaxLength = 11
        Me.tb_ClientContactNumber.Name = "tb_ClientContactNumber"
        Me.tb_ClientContactNumber.Size = New System.Drawing.Size(205, 30)
        Me.tb_ClientContactNumber.TabIndex = 7
        '
        'tb_ClientAddress
        '
        Me.tb_ClientAddress.Location = New System.Drawing.Point(171, 105)
        Me.tb_ClientAddress.MaxLength = 255
        Me.tb_ClientAddress.Name = "tb_ClientAddress"
        Me.tb_ClientAddress.Size = New System.Drawing.Size(276, 30)
        Me.tb_ClientAddress.TabIndex = 6
        '
        'tb_ClientName
        '
        Me.tb_ClientName.Location = New System.Drawing.Point(171, 50)
        Me.tb_ClientName.MaxLength = 255
        Me.tb_ClientName.Name = "tb_ClientName"
        Me.tb_ClientName.Size = New System.Drawing.Size(276, 30)
        Me.tb_ClientName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_CoMakerContactNumber)
        Me.GroupBox1.Controls.Add(Me.tb_CoMakerAddress)
        Me.GroupBox1.Controls.Add(Me.tb_CoMakerName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 238)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Co-Maker Details"
        '
        'tb_CoMakerContactNumber
        '
        Me.tb_CoMakerContactNumber.Location = New System.Drawing.Point(237, 171)
        Me.tb_CoMakerContactNumber.MaxLength = 11
        Me.tb_CoMakerContactNumber.Name = "tb_CoMakerContactNumber"
        Me.tb_CoMakerContactNumber.Size = New System.Drawing.Size(205, 30)
        Me.tb_CoMakerContactNumber.TabIndex = 7
        '
        'tb_CoMakerAddress
        '
        Me.tb_CoMakerAddress.Location = New System.Drawing.Point(166, 116)
        Me.tb_CoMakerAddress.MaxLength = 255
        Me.tb_CoMakerAddress.Name = "tb_CoMakerAddress"
        Me.tb_CoMakerAddress.Size = New System.Drawing.Size(276, 30)
        Me.tb_CoMakerAddress.TabIndex = 6
        '
        'tb_CoMakerName
        '
        Me.tb_CoMakerName.Location = New System.Drawing.Point(166, 61)
        Me.tb_CoMakerName.MaxLength = 255
        Me.tb_CoMakerName.Name = "tb_CoMakerName"
        Me.tb_CoMakerName.Size = New System.Drawing.Size(276, 30)
        Me.tb_CoMakerName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Name:"
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(193, 638)
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
        'EditClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 707)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_ClientDetails)
        Me.Name = "EditClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Client Form"
        Me.gb_ClientDetails.ResumeLayout(False)
        Me.gb_ClientDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_ClientDetails As GroupBox
    Friend WithEvents tb_ClientAddress As TextBox
    Friend WithEvents tb_ClientName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_CoMakerAddress As TextBox
    Friend WithEvents tb_CoMakerName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_ClientContactNumber As TextBox
    Friend WithEvents tb_CoMakerContactNumber As TextBox
    Friend WithEvents btn_Submit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_ClientName As Label
    Friend WithEvents lbl_ClientID As Label
End Class
