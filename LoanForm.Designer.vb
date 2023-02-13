<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanForm))
        Me.gb_SearchClient = New System.Windows.Forms.GroupBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.tb_SearchClientName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_DurationNumber = New System.Windows.Forms.ComboBox()
        Me.cb_YearMonth = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_ShareCapital = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.tb_LoanAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cb_Interest = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SystemAccountsTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_LoanRateProfile = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tc_LoanProcess = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_NextStep3 = New System.Windows.Forms.Button()
        Me.btn_BackStep1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.btn_BackStep2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_NextStep2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.gb_SearchClient.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tc_LoanProcess.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_SearchClient
        '
        Me.gb_SearchClient.Controls.Add(Me.lbl_Name)
        Me.gb_SearchClient.Controls.Add(Me.tb_SearchClientName)
        Me.gb_SearchClient.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_SearchClient.Location = New System.Drawing.Point(26, 226)
        Me.gb_SearchClient.Name = "gb_SearchClient"
        Me.gb_SearchClient.Size = New System.Drawing.Size(405, 75)
        Me.gb_SearchClient.TabIndex = 0
        Me.gb_SearchClient.TabStop = False
        Me.gb_SearchClient.Text = "Filter Client"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(19, 32)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(69, 21)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "Name:"
        '
        'tb_SearchClientName
        '
        Me.tb_SearchClientName.Location = New System.Drawing.Point(107, 29)
        Me.tb_SearchClientName.Name = "tb_SearchClientName"
        Me.tb_SearchClientName.Size = New System.Drawing.Size(279, 30)
        Me.tb_SearchClientName.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_DurationNumber)
        Me.GroupBox3.Controls.Add(Me.cb_YearMonth)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(272, 354)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 94)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mode of Payment"
        '
        'cb_DurationNumber
        '
        Me.cb_DurationNumber.Enabled = False
        Me.cb_DurationNumber.FormattingEnabled = True
        Me.cb_DurationNumber.Items.AddRange(New Object() {"Month", "Year"})
        Me.cb_DurationNumber.Location = New System.Drawing.Point(25, 44)
        Me.cb_DurationNumber.Name = "cb_DurationNumber"
        Me.cb_DurationNumber.Size = New System.Drawing.Size(88, 29)
        Me.cb_DurationNumber.TabIndex = 2
        '
        'cb_YearMonth
        '
        Me.cb_YearMonth.FormattingEnabled = True
        Me.cb_YearMonth.Items.AddRange(New Object() {"Month", "Year"})
        Me.cb_YearMonth.Location = New System.Drawing.Point(119, 44)
        Me.cb_YearMonth.Name = "cb_YearMonth"
        Me.cb_YearMonth.Size = New System.Drawing.Size(121, 29)
        Me.cb_YearMonth.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_ShareCapital)
        Me.GroupBox5.Controls.Add(Me.btn_Calculate)
        Me.GroupBox5.Controls.Add(Me.tb_LoanAmount)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(135, 254)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(422, 162)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loan Amount"
        '
        'lbl_ShareCapital
        '
        Me.lbl_ShareCapital.AutoSize = True
        Me.lbl_ShareCapital.Location = New System.Drawing.Point(32, 48)
        Me.lbl_ShareCapital.Name = "lbl_ShareCapital"
        Me.lbl_ShareCapital.Size = New System.Drawing.Size(138, 21)
        Me.lbl_ShareCapital.TabIndex = 2
        Me.lbl_ShareCapital.Text = "Share Capital: "
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(274, 91)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(121, 45)
        Me.btn_Calculate.TabIndex = 1
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'tb_LoanAmount
        '
        Me.tb_LoanAmount.Location = New System.Drawing.Point(36, 100)
        Me.tb_LoanAmount.Name = "tb_LoanAmount"
        Me.tb_LoanAmount.Size = New System.Drawing.Size(214, 30)
        Me.tb_LoanAmount.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cb_Interest)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(25, 354)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(201, 94)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Interest"
        '
        'cb_Interest
        '
        Me.cb_Interest.FormattingEnabled = True
        Me.cb_Interest.Location = New System.Drawing.Point(27, 44)
        Me.cb_Interest.Name = "cb_Interest"
        Me.cb_Interest.Size = New System.Drawing.Size(121, 29)
        Me.cb_Interest.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "%"
        '
        'SystemAccountsTable
        '
        Me.SystemAccountsTable.AllowUserToAddRows = False
        Me.SystemAccountsTable.AllowUserToDeleteRows = False
        Me.SystemAccountsTable.AllowUserToResizeColumns = False
        Me.SystemAccountsTable.AllowUserToResizeRows = False
        Me.SystemAccountsTable.ColumnHeadersHeight = 30
        Me.SystemAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SystemAccountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SystemAccountsTable.Location = New System.Drawing.Point(26, 313)
        Me.SystemAccountsTable.MultiSelect = False
        Me.SystemAccountsTable.Name = "SystemAccountsTable"
        Me.SystemAccountsTable.ReadOnly = True
        Me.SystemAccountsTable.RowHeadersVisible = False
        Me.SystemAccountsTable.RowHeadersWidth = 51
        Me.SystemAccountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SystemAccountsTable.RowTemplate.Height = 24
        Me.SystemAccountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SystemAccountsTable.Size = New System.Drawing.Size(531, 261)
        Me.SystemAccountsTable.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_LoanRateProfile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 118)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Rate Profile"
        '
        'cb_LoanRateProfile
        '
        Me.cb_LoanRateProfile.FormattingEnabled = True
        Me.cb_LoanRateProfile.Location = New System.Drawing.Point(233, 50)
        Me.cb_LoanRateProfile.Name = "cb_LoanRateProfile"
        Me.cb_LoanRateProfile.Size = New System.Drawing.Size(253, 29)
        Me.cb_LoanRateProfile.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select Rate Profile:"
        '
        'tc_LoanProcess
        '
        Me.tc_LoanProcess.Controls.Add(Me.TabPage2)
        Me.tc_LoanProcess.Controls.Add(Me.TabPage3)
        Me.tc_LoanProcess.Controls.Add(Me.TabPage1)
        Me.tc_LoanProcess.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tc_LoanProcess.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_LoanProcess.Location = New System.Drawing.Point(12, 19)
        Me.tc_LoanProcess.Name = "tc_LoanProcess"
        Me.tc_LoanProcess.SelectedIndex = 0
        Me.tc_LoanProcess.Size = New System.Drawing.Size(708, 635)
        Me.tc_LoanProcess.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_NextStep3)
        Me.TabPage2.Controls.Add(Me.btn_BackStep1)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(700, 601)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_NextStep3
        '
        Me.btn_NextStep3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NextStep3.Location = New System.Drawing.Point(572, 520)
        Me.btn_NextStep3.Name = "btn_NextStep3"
        Me.btn_NextStep3.Size = New System.Drawing.Size(94, 56)
        Me.btn_NextStep3.TabIndex = 20
        Me.btn_NextStep3.Text = "Next"
        Me.btn_NextStep3.UseVisualStyleBackColor = True
        '
        'btn_BackStep1
        '
        Me.btn_BackStep1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackStep1.Location = New System.Drawing.Point(37, 520)
        Me.btn_BackStep1.Name = "btn_BackStep1"
        Me.btn_BackStep1.Size = New System.Drawing.Size(94, 56)
        Me.btn_BackStep1.TabIndex = 19
        Me.btn_BackStep1.Text = "Back"
        Me.btn_BackStep1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(700, 200)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_Submit)
        Me.TabPage3.Controls.Add(Me.btn_BackStep2)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(700, 601)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(586, 529)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(94, 56)
        Me.btn_Submit.TabIndex = 21
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'btn_BackStep2
        '
        Me.btn_BackStep2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackStep2.Location = New System.Drawing.Point(34, 529)
        Me.btn_BackStep2.Name = "btn_BackStep2"
        Me.btn_BackStep2.Size = New System.Drawing.Size(94, 56)
        Me.btn_BackStep2.TabIndex = 20
        Me.btn_BackStep2.Text = "Back"
        Me.btn_BackStep2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(700, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_NextStep2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.gb_SearchClient)
        Me.TabPage1.Controls.Add(Me.SystemAccountsTable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(700, 601)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_NextStep2
        '
        Me.btn_NextStep2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NextStep2.Location = New System.Drawing.Point(585, 518)
        Me.btn_NextStep2.Name = "btn_NextStep2"
        Me.btn_NextStep2.Size = New System.Drawing.Size(94, 56)
        Me.btn_NextStep2.TabIndex = 11
        Me.btn_NextStep2.Text = "Next"
        Me.btn_NextStep2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(719, 50)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'LoanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 659)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.tc_LoanProcess)
        Me.Name = "LoanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Form"
        Me.gb_SearchClient.ResumeLayout(False)
        Me.gb_SearchClient.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.SystemAccountsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tc_LoanProcess.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_SearchClient As GroupBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents tb_SearchClientName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tb_LoanAmount As TextBox
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents cb_YearMonth As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SystemAccountsTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_LoanRateProfile As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tc_LoanProcess As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_NextStep2 As Button
    Friend WithEvents btn_BackStep1 As Button
    Friend WithEvents btn_NextStep3 As Button
    Friend WithEvents btn_BackStep2 As Button
    Friend WithEvents btn_Submit As Button
    Friend WithEvents cb_DurationNumber As ComboBox
    Friend WithEvents cb_Interest As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lbl_ShareCapital As Label
End Class
