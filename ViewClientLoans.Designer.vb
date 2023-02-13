<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewClientLoans
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SearchAccount = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_SearchClientName = New System.Windows.Forms.TextBox()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.grpbx_SelectedClient = New System.Windows.Forms.GroupBox()
        Me.lbl_ClientID = New System.Windows.Forms.Label()
        Me.lbl_ClientName = New System.Windows.Forms.Label()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.SearchAccount.SuspendLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbx_SelectedClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchAccount
        '
        Me.SearchAccount.Controls.Add(Me.Label1)
        Me.SearchAccount.Controls.Add(Me.tb_SearchClientName)
        Me.SearchAccount.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAccount.Location = New System.Drawing.Point(12, 12)
        Me.SearchAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchAccount.Name = "SearchAccount"
        Me.SearchAccount.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchAccount.Size = New System.Drawing.Size(404, 81)
        Me.SearchAccount.TabIndex = 0
        Me.SearchAccount.TabStop = False
        Me.SearchAccount.Text = "Search Client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'tb_SearchClientName
        '
        Me.tb_SearchClientName.Location = New System.Drawing.Point(108, 29)
        Me.tb_SearchClientName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_SearchClientName.Name = "tb_SearchClientName"
        Me.tb_SearchClientName.Size = New System.Drawing.Size(221, 30)
        Me.tb_SearchClientName.TabIndex = 0
        '
        'SystemAccountsTable
        '
        Me.SystemAccountsTable.AllowUserToAddRows = False
        Me.SystemAccountsTable.AllowUserToDeleteRows = False
        Me.SystemAccountsTable.AllowUserToResizeColumns = False
        Me.SystemAccountsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SystemAccountsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SystemAccountsTable.ColumnHeadersHeight = 30
        Me.SystemAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SystemAccountsTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.SystemAccountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SystemAccountsTable.Location = New System.Drawing.Point(12, 98)
        Me.SystemAccountsTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SystemAccountsTable.MultiSelect = False
        Me.SystemAccountsTable.Name = "SystemAccountsTable"
        Me.SystemAccountsTable.ReadOnly = True
        Me.SystemAccountsTable.RowHeadersVisible = False
        Me.SystemAccountsTable.RowHeadersWidth = 51
        Me.SystemAccountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SystemAccountsTable.RowTemplate.Height = 24
        Me.SystemAccountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SystemAccountsTable.Size = New System.Drawing.Size(460, 226)
        Me.SystemAccountsTable.TabIndex = 0
        Me.SystemAccountsTable.TabStop = False
        '
        'grpbx_SelectedClient
        '
        Me.grpbx_SelectedClient.Controls.Add(Me.lbl_ClientID)
        Me.grpbx_SelectedClient.Controls.Add(Me.lbl_ClientName)
        Me.grpbx_SelectedClient.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_SelectedClient.Location = New System.Drawing.Point(12, 346)
        Me.grpbx_SelectedClient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpbx_SelectedClient.Name = "grpbx_SelectedClient"
        Me.grpbx_SelectedClient.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpbx_SelectedClient.Size = New System.Drawing.Size(460, 119)
        Me.grpbx_SelectedClient.TabIndex = 2
        Me.grpbx_SelectedClient.TabStop = False
        Me.grpbx_SelectedClient.Text = "Selected Client"
        '
        'lbl_ClientID
        '
        Me.lbl_ClientID.AutoSize = True
        Me.lbl_ClientID.Location = New System.Drawing.Point(21, 35)
        Me.lbl_ClientID.Name = "lbl_ClientID"
        Me.lbl_ClientID.Size = New System.Drawing.Size(91, 22)
        Me.lbl_ClientID.TabIndex = 2
        Me.lbl_ClientID.Text = "Client ID:"
        '
        'lbl_ClientName
        '
        Me.lbl_ClientName.AutoSize = True
        Me.lbl_ClientName.Location = New System.Drawing.Point(21, 72)
        Me.lbl_ClientName.Name = "lbl_ClientName"
        Me.lbl_ClientName.Size = New System.Drawing.Size(128, 22)
        Me.lbl_ClientName.TabIndex = 1
        Me.lbl_ClientName.Text = "Client Name:"
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(184, 485)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(113, 46)
        Me.btn_Edit.TabIndex = 6
        Me.btn_Edit.Text = "View"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'ViewClientLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 569)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.grpbx_SelectedClient)
        Me.Controls.Add(Me.SystemAccountsTable)
        Me.Controls.Add(Me.SearchAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewClientLoans"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client List"
        Me.SearchAccount.ResumeLayout(False)
        Me.SearchAccount.PerformLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbx_SelectedClient.ResumeLayout(False)
        Me.grpbx_SelectedClient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchAccount As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_SearchClientName As TextBox
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents grpbx_SelectedClient As GroupBox
    Friend WithEvents lbl_ClientName As Label
    Friend WithEvents btn_Edit As Button
    Friend WithEvents lbl_ClientID As Label
End Class
