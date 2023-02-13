<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.SelectedAccount = New System.Windows.Forms.GroupBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_SearchUsername = New System.Windows.Forms.TextBox()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectedAccount.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SystemAccountsTable
        '
        Me.SystemAccountsTable.AllowUserToAddRows = False
        Me.SystemAccountsTable.AllowUserToDeleteRows = False
        Me.SystemAccountsTable.AllowUserToResizeColumns = False
        Me.SystemAccountsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SystemAccountsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.SystemAccountsTable.ColumnHeadersHeight = 30
        Me.SystemAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SystemAccountsTable.DefaultCellStyle = DataGridViewCellStyle8
        Me.SystemAccountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SystemAccountsTable.Location = New System.Drawing.Point(12, 127)
        Me.SystemAccountsTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SystemAccountsTable.MultiSelect = False
        Me.SystemAccountsTable.Name = "SystemAccountsTable"
        Me.SystemAccountsTable.ReadOnly = True
        Me.SystemAccountsTable.RowHeadersVisible = False
        Me.SystemAccountsTable.RowHeadersWidth = 51
        Me.SystemAccountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SystemAccountsTable.RowTemplate.Height = 24
        Me.SystemAccountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SystemAccountsTable.Size = New System.Drawing.Size(404, 197)
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
        Me.SelectedAccount.Size = New System.Drawing.Size(404, 90)
        Me.SelectedAccount.TabIndex = 2
        Me.SelectedAccount.TabStop = False
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(18, 38)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(15, 22)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = ":"
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(153, 471)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(113, 46)
        Me.btn_Edit.TabIndex = 6
        Me.btn_Edit.Text = "Submit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_SearchUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(404, 98)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'tb_SearchUsername
        '
        Me.tb_SearchUsername.Location = New System.Drawing.Point(22, 46)
        Me.tb_SearchUsername.Name = "tb_SearchUsername"
        Me.tb_SearchUsername.Size = New System.Drawing.Size(357, 30)
        Me.tb_SearchUsername.TabIndex = 0
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.SelectedAccount)
        Me.Controls.Add(Me.SystemAccountsTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectedAccount.ResumeLayout(False)
        Me.SelectedAccount.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents SelectedAccount As GroupBox
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_Edit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_SearchUsername As TextBox
End Class
