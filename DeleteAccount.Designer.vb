<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteAccount
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SearchAccount = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_SearchUsername = New System.Windows.Forms.TextBox()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.SelectedAccount = New System.Windows.Forms.GroupBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.SearchAccount.SuspendLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectedAccount.SuspendLayout()
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
        Me.SearchAccount.Text = "Search Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SystemAccountsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SystemAccountsTable.ColumnHeadersHeight = 30
        Me.SystemAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SystemAccountsTable.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.SystemAccountsTable.Size = New System.Drawing.Size(404, 226)
        Me.SystemAccountsTable.TabIndex = 0
        Me.SystemAccountsTable.TabStop = False
        '
        'SelectedAccount
        '
        Me.SelectedAccount.Controls.Add(Me.lbl_Username)
        Me.SelectedAccount.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedAccount.Location = New System.Drawing.Point(12, 346)
        Me.SelectedAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectedAccount.Name = "SelectedAccount"
        Me.SelectedAccount.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectedAccount.Size = New System.Drawing.Size(404, 93)
        Me.SelectedAccount.TabIndex = 2
        Me.SelectedAccount.TabStop = False
        Me.SelectedAccount.Text = "Selected Account"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(25, 40)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(106, 22)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username:"
        '
        'btn_Delete
        '
        Me.btn_Delete.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(139, 471)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(160, 46)
        Me.btn_Delete.TabIndex = 6
        Me.btn_Delete.Text = "Deactivate"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'DeleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 554)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.SelectedAccount)
        Me.Controls.Add(Me.SystemAccountsTable)
        Me.Controls.Add(Me.SearchAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteAccount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deactivate User Account Form"
        Me.SearchAccount.ResumeLayout(False)
        Me.SearchAccount.PerformLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectedAccount.ResumeLayout(False)
        Me.SelectedAccount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchAccount As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_SearchUsername As TextBox
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents SelectedAccount As GroupBox
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_Delete As Button
End Class
