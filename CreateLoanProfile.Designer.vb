<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateLoanProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateLoanProfile))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tc_ProfileCreationProcess = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_NextStep2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_ProfileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_BackStep1 = New System.Windows.Forms.Button()
        Me.InterestRateGrid = New System.Windows.Forms.DataGridView()
        Me.InterestRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_NextStep3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_DeleteInterestRate = New System.Windows.Forms.Button()
        Me.btn_EditInterestRate = New System.Windows.Forms.Button()
        Me.btn_AddInterestRate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_InterestRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_BackStep2 = New System.Windows.Forms.Button()
        Me.dgv_LoanDuration = New System.Windows.Forms.DataGridView()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variety = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_DeleteLoanDuration = New System.Windows.Forms.Button()
        Me.btn_EditLoanDuration = New System.Windows.Forms.Button()
        Me.btn_AddLoanDuration = New System.Windows.Forms.Button()
        Me.rb_VarietyYear = New System.Windows.Forms.RadioButton()
        Me.rb_VarietyMonth = New System.Windows.Forms.RadioButton()
        Me.tb_LoanDuration = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tc_ProfileCreationProcess.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.InterestRateGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_LoanDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_ProfileCreationProcess
        '
        Me.tc_ProfileCreationProcess.Controls.Add(Me.TabPage1)
        Me.tc_ProfileCreationProcess.Controls.Add(Me.TabPage3)
        Me.tc_ProfileCreationProcess.Controls.Add(Me.TabPage2)
        Me.tc_ProfileCreationProcess.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tc_ProfileCreationProcess.Location = New System.Drawing.Point(12, 12)
        Me.tc_ProfileCreationProcess.Name = "tc_ProfileCreationProcess"
        Me.tc_ProfileCreationProcess.SelectedIndex = 0
        Me.tc_ProfileCreationProcess.Size = New System.Drawing.Size(608, 564)
        Me.tc_ProfileCreationProcess.TabIndex = 0
        Me.tc_ProfileCreationProcess.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btn_NextStep2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'btn_NextStep2
        '
        Me.btn_NextStep2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NextStep2.Location = New System.Drawing.Point(471, 462)
        Me.btn_NextStep2.Name = "btn_NextStep2"
        Me.btn_NextStep2.Size = New System.Drawing.Size(94, 56)
        Me.btn_NextStep2.TabIndex = 2
        Me.btn_NextStep2.Text = "Next"
        Me.btn_NextStep2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_ProfileName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_ID)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 161)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Profile Details"
        '
        'tb_ProfileName
        '
        Me.tb_ProfileName.Location = New System.Drawing.Point(198, 95)
        Me.tb_ProfileName.Name = "tb_ProfileName"
        Me.tb_ProfileName.Size = New System.Drawing.Size(197, 30)
        Me.tb_ProfileName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Profile Name:"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(39, 46)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(134, 22)
        Me.lbl_ID.TabIndex = 0
        Me.lbl_ID.Text = "Profile ID: N/A"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.btn_BackStep1)
        Me.TabPage3.Controls.Add(Me.InterestRateGrid)
        Me.TabPage3.Controls.Add(Me.btn_NextStep3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(600, 535)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'btn_BackStep1
        '
        Me.btn_BackStep1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackStep1.Location = New System.Drawing.Point(27, 462)
        Me.btn_BackStep1.Name = "btn_BackStep1"
        Me.btn_BackStep1.Size = New System.Drawing.Size(94, 56)
        Me.btn_BackStep1.TabIndex = 4
        Me.btn_BackStep1.Text = "Back"
        Me.btn_BackStep1.UseVisualStyleBackColor = True
        '
        'InterestRateGrid
        '
        Me.InterestRateGrid.AllowUserToAddRows = False
        Me.InterestRateGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.NullValue = Nothing
        Me.InterestRateGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InterestRateGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.InterestRateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InterestRateGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InterestRate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InterestRateGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.InterestRateGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InterestRateGrid.Location = New System.Drawing.Point(27, 222)
        Me.InterestRateGrid.MultiSelect = False
        Me.InterestRateGrid.Name = "InterestRateGrid"
        Me.InterestRateGrid.RowHeadersVisible = False
        Me.InterestRateGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.NullValue = Nothing
        Me.InterestRateGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InterestRateGrid.RowTemplate.DefaultCellStyle.Format = "#0.00%"
        Me.InterestRateGrid.RowTemplate.DefaultCellStyle.NullValue = Nothing
        Me.InterestRateGrid.RowTemplate.Height = 24
        Me.InterestRateGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InterestRateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InterestRateGrid.ShowEditingIcon = False
        Me.InterestRateGrid.Size = New System.Drawing.Size(193, 209)
        Me.InterestRateGrid.TabIndex = 3
        '
        'InterestRate
        '
        Me.InterestRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InterestRate.HeaderText = "Interest Rate"
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InterestRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btn_NextStep3
        '
        Me.btn_NextStep3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NextStep3.Location = New System.Drawing.Point(471, 462)
        Me.btn_NextStep3.Name = "btn_NextStep3"
        Me.btn_NextStep3.Size = New System.Drawing.Size(94, 56)
        Me.btn_NextStep3.TabIndex = 2
        Me.btn_NextStep3.Text = "Next"
        Me.btn_NextStep3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_DeleteInterestRate)
        Me.GroupBox2.Controls.Add(Me.btn_EditInterestRate)
        Me.GroupBox2.Controls.Add(Me.btn_AddInterestRate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_InterestRate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(259, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loan Interest Details"
        '
        'btn_DeleteInterestRate
        '
        Me.btn_DeleteInterestRate.Location = New System.Drawing.Point(201, 95)
        Me.btn_DeleteInterestRate.Name = "btn_DeleteInterestRate"
        Me.btn_DeleteInterestRate.Size = New System.Drawing.Size(90, 46)
        Me.btn_DeleteInterestRate.TabIndex = 6
        Me.btn_DeleteInterestRate.Text = "Delete"
        Me.btn_DeleteInterestRate.UseVisualStyleBackColor = True
        '
        'btn_EditInterestRate
        '
        Me.btn_EditInterestRate.Location = New System.Drawing.Point(112, 95)
        Me.btn_EditInterestRate.Name = "btn_EditInterestRate"
        Me.btn_EditInterestRate.Size = New System.Drawing.Size(72, 46)
        Me.btn_EditInterestRate.TabIndex = 5
        Me.btn_EditInterestRate.Text = "Edit"
        Me.btn_EditInterestRate.UseVisualStyleBackColor = True
        '
        'btn_AddInterestRate
        '
        Me.btn_AddInterestRate.Location = New System.Drawing.Point(23, 95)
        Me.btn_AddInterestRate.Name = "btn_AddInterestRate"
        Me.btn_AddInterestRate.Size = New System.Drawing.Size(72, 46)
        Me.btn_AddInterestRate.TabIndex = 4
        Me.btn_AddInterestRate.Text = "Add"
        Me.btn_AddInterestRate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "%"
        '
        'tb_InterestRate
        '
        Me.tb_InterestRate.Location = New System.Drawing.Point(171, 45)
        Me.tb_InterestRate.MaxLength = 4
        Me.tb_InterestRate.Name = "tb_InterestRate"
        Me.tb_InterestRate.Size = New System.Drawing.Size(74, 30)
        Me.tb_InterestRate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Interest Rate:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(600, 250)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btn_BackStep2)
        Me.TabPage2.Controls.Add(Me.dgv_LoanDuration)
        Me.TabPage2.Controls.Add(Me.btn_Submit)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 535)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "TabPage2"
        '
        'btn_BackStep2
        '
        Me.btn_BackStep2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackStep2.Location = New System.Drawing.Point(24, 462)
        Me.btn_BackStep2.Name = "btn_BackStep2"
        Me.btn_BackStep2.Size = New System.Drawing.Size(94, 56)
        Me.btn_BackStep2.TabIndex = 4
        Me.btn_BackStep2.Text = "Back"
        Me.btn_BackStep2.UseVisualStyleBackColor = True
        '
        'dgv_LoanDuration
        '
        Me.dgv_LoanDuration.AllowUserToAddRows = False
        Me.dgv_LoanDuration.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_LoanDuration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_LoanDuration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LoanDuration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Duration, Me.Variety})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_LoanDuration.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_LoanDuration.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_LoanDuration.Location = New System.Drawing.Point(24, 236)
        Me.dgv_LoanDuration.Name = "dgv_LoanDuration"
        Me.dgv_LoanDuration.ReadOnly = True
        Me.dgv_LoanDuration.RowHeadersVisible = False
        Me.dgv_LoanDuration.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_LoanDuration.RowTemplate.Height = 24
        Me.dgv_LoanDuration.RowTemplate.ReadOnly = True
        Me.dgv_LoanDuration.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_LoanDuration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LoanDuration.Size = New System.Drawing.Size(240, 214)
        Me.dgv_LoanDuration.TabIndex = 3
        '
        'Duration
        '
        Me.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        Me.Duration.ReadOnly = True
        Me.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Variety
        '
        Me.Variety.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Variety.HeaderText = "Variety"
        Me.Variety.Name = "Variety"
        Me.Variety.ReadOnly = True
        Me.Variety.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Variety.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(478, 462)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(94, 56)
        Me.btn_Submit.TabIndex = 2
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_DeleteLoanDuration)
        Me.GroupBox3.Controls.Add(Me.btn_EditLoanDuration)
        Me.GroupBox3.Controls.Add(Me.btn_AddLoanDuration)
        Me.GroupBox3.Controls.Add(Me.rb_VarietyYear)
        Me.GroupBox3.Controls.Add(Me.rb_VarietyMonth)
        Me.GroupBox3.Controls.Add(Me.tb_LoanDuration)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(284, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 214)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loan Profile Details"
        '
        'btn_DeleteLoanDuration
        '
        Me.btn_DeleteLoanDuration.Location = New System.Drawing.Point(194, 142)
        Me.btn_DeleteLoanDuration.Name = "btn_DeleteLoanDuration"
        Me.btn_DeleteLoanDuration.Size = New System.Drawing.Size(90, 46)
        Me.btn_DeleteLoanDuration.TabIndex = 9
        Me.btn_DeleteLoanDuration.Text = "Delete"
        Me.btn_DeleteLoanDuration.UseVisualStyleBackColor = True
        '
        'btn_EditLoanDuration
        '
        Me.btn_EditLoanDuration.Location = New System.Drawing.Point(105, 142)
        Me.btn_EditLoanDuration.Name = "btn_EditLoanDuration"
        Me.btn_EditLoanDuration.Size = New System.Drawing.Size(72, 46)
        Me.btn_EditLoanDuration.TabIndex = 8
        Me.btn_EditLoanDuration.Text = "Edit"
        Me.btn_EditLoanDuration.UseVisualStyleBackColor = True
        '
        'btn_AddLoanDuration
        '
        Me.btn_AddLoanDuration.Location = New System.Drawing.Point(16, 142)
        Me.btn_AddLoanDuration.Name = "btn_AddLoanDuration"
        Me.btn_AddLoanDuration.Size = New System.Drawing.Size(72, 46)
        Me.btn_AddLoanDuration.TabIndex = 7
        Me.btn_AddLoanDuration.Text = "Add"
        Me.btn_AddLoanDuration.UseVisualStyleBackColor = True
        '
        'rb_VarietyYear
        '
        Me.rb_VarietyYear.AutoSize = True
        Me.rb_VarietyYear.Location = New System.Drawing.Point(160, 99)
        Me.rb_VarietyYear.Name = "rb_VarietyYear"
        Me.rb_VarietyYear.Size = New System.Drawing.Size(94, 26)
        Me.rb_VarietyYear.TabIndex = 4
        Me.rb_VarietyYear.Text = "Year(s)"
        Me.rb_VarietyYear.UseVisualStyleBackColor = True
        '
        'rb_VarietyMonth
        '
        Me.rb_VarietyMonth.AutoSize = True
        Me.rb_VarietyMonth.Checked = True
        Me.rb_VarietyMonth.Location = New System.Drawing.Point(25, 99)
        Me.rb_VarietyMonth.Name = "rb_VarietyMonth"
        Me.rb_VarietyMonth.Size = New System.Drawing.Size(112, 26)
        Me.rb_VarietyMonth.TabIndex = 3
        Me.rb_VarietyMonth.TabStop = True
        Me.rb_VarietyMonth.Text = "Month(s)"
        Me.rb_VarietyMonth.UseVisualStyleBackColor = True
        '
        'tb_LoanDuration
        '
        Me.tb_LoanDuration.Location = New System.Drawing.Point(132, 50)
        Me.tb_LoanDuration.MaxLength = 2
        Me.tb_LoanDuration.Name = "tb_LoanDuration"
        Me.tb_LoanDuration.Size = New System.Drawing.Size(91, 30)
        Me.tb_LoanDuration.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Duration:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(600, 250)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(608, 32)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'CreateLoanProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 588)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tc_ProfileCreationProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateLoanProfile"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Profile Creation Form"
        Me.TopMost = True
        Me.tc_ProfileCreationProcess.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.InterestRateGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_LoanDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_ProfileCreationProcess As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_NextStep2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_ProfileName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_NextStep3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_InterestRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_BackStep1 As Button
    Friend WithEvents InterestRateGrid As DataGridView
    Friend WithEvents btn_DeleteInterestRate As Button
    Friend WithEvents btn_EditInterestRate As Button
    Friend WithEvents btn_AddInterestRate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_BackStep2 As Button
    Friend WithEvents dgv_LoanDuration As DataGridView
    Friend WithEvents btn_Submit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb_VarietyYear As RadioButton
    Friend WithEvents rb_VarietyMonth As RadioButton
    Friend WithEvents tb_LoanDuration As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents InterestRate As DataGridViewTextBoxColumn
    Friend WithEvents Duration As DataGridViewTextBoxColumn
    Friend WithEvents Variety As DataGridViewTextBoxColumn
    Friend WithEvents btn_DeleteLoanDuration As Button
    Friend WithEvents btn_EditLoanDuration As Button
    Friend WithEvents btn_AddLoanDuration As Button
End Class
