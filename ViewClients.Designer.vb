<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewClients
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
        Me.tb_SearchUsername = New System.Windows.Forms.TextBox()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SearchAccount.SuspendLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchAccount
        '
        Me.SearchAccount.Controls.Add(Me.Label1)
        Me.SearchAccount.Controls.Add(Me.tb_SearchUsername)
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
        'tb_SearchUsername
        '
        Me.tb_SearchUsername.Location = New System.Drawing.Point(143, 30)
        Me.tb_SearchUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_SearchUsername.Name = "tb_SearchUsername"
        Me.tb_SearchUsername.Size = New System.Drawing.Size(221, 30)
        Me.tb_SearchUsername.TabIndex = 0
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
        Me.SystemAccountsTable.Size = New System.Drawing.Size(725, 353)
        Me.SystemAccountsTable.TabIndex = 0
        Me.SystemAccountsTable.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(453, 466)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(250, 25)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Show Deactivated Clients"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ViewClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 508)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.SystemAccountsTable)
        Me.Controls.Add(Me.SearchAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewClients"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clients"
        Me.SearchAccount.ResumeLayout(False)
        Me.SearchAccount.PerformLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchAccount As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_SearchUsername As TextBox
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
End Class
