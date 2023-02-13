<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YearlyReportFormFilter
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.btn_GenerateReport = New System.Windows.Forms.Button()
        Me.SearchAccount.SuspendLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchAccount
        '
        Me.SearchAccount.Controls.Add(Me.ComboBox1)
        Me.SearchAccount.Controls.Add(Me.Label1)
        Me.SearchAccount.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAccount.Location = New System.Drawing.Point(12, 12)
        Me.SearchAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchAccount.Name = "SearchAccount"
        Me.SearchAccount.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchAccount.Size = New System.Drawing.Size(274, 83)
        Me.SearchAccount.TabIndex = 0
        Me.SearchAccount.TabStop = False
        Me.SearchAccount.Text = "Filter Year Result"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(99, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 29)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year:"
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
        Me.SystemAccountsTable.Location = New System.Drawing.Point(12, 117)
        Me.SystemAccountsTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SystemAccountsTable.MultiSelect = False
        Me.SystemAccountsTable.Name = "SystemAccountsTable"
        Me.SystemAccountsTable.ReadOnly = True
        Me.SystemAccountsTable.RowHeadersVisible = False
        Me.SystemAccountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SystemAccountsTable.RowTemplate.Height = 24
        Me.SystemAccountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SystemAccountsTable.Size = New System.Drawing.Size(666, 370)
        Me.SystemAccountsTable.TabIndex = 0
        Me.SystemAccountsTable.TabStop = False
        '
        'btn_GenerateReport
        '
        Me.btn_GenerateReport.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GenerateReport.Location = New System.Drawing.Point(224, 508)
        Me.btn_GenerateReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_GenerateReport.Name = "btn_GenerateReport"
        Me.btn_GenerateReport.Size = New System.Drawing.Size(217, 46)
        Me.btn_GenerateReport.TabIndex = 7
        Me.btn_GenerateReport.Text = "Generate Report"
        Me.btn_GenerateReport.UseVisualStyleBackColor = True
        '
        'YearlyReportFormFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 569)
        Me.Controls.Add(Me.btn_GenerateReport)
        Me.Controls.Add(Me.SystemAccountsTable)
        Me.Controls.Add(Me.SearchAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "YearlyReportFormFilter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yearly Report Form Filter"
        Me.SearchAccount.ResumeLayout(False)
        Me.SearchAccount.PerformLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchAccount As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents btn_GenerateReport As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
