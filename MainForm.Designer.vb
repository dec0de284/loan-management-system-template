<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.cMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.smAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.aSignIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.aCreateAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.aDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.aSignOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.smLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.cAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.smTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tLoanForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.tPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRateProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.rMonthly = New System.Windows.Forms.ToolStripMenuItem()
        Me.rYearly = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cMenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cMenuStrip
        '
        Me.cMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smAccount, Me.smLogs, Me.smClient, Me.smTransactions, Me.smReports})
        Me.cMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.cMenuStrip.Name = "cMenuStrip"
        Me.cMenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.cMenuStrip.Size = New System.Drawing.Size(1123, 30)
        Me.cMenuStrip.TabIndex = 0
        Me.cMenuStrip.Text = "MenuStrip1"
        '
        'smAccount
        '
        Me.smAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aSignIn, Me.aCreateAccount, Me.aDelete, Me.aSignOut})
        Me.smAccount.Name = "smAccount"
        Me.smAccount.Size = New System.Drawing.Size(77, 26)
        Me.smAccount.Text = "Account"
        '
        'aSignIn
        '
        Me.aSignIn.Name = "aSignIn"
        Me.aSignIn.Size = New System.Drawing.Size(254, 26)
        Me.aSignIn.Text = "Sign In"
        '
        'aCreateAccount
        '
        Me.aCreateAccount.Name = "aCreateAccount"
        Me.aCreateAccount.Size = New System.Drawing.Size(254, 26)
        Me.aCreateAccount.Text = "Create User Account"
        '
        'aDelete
        '
        Me.aDelete.Name = "aDelete"
        Me.aDelete.Size = New System.Drawing.Size(254, 26)
        Me.aDelete.Text = "Deactivate User Account"
        '
        'aSignOut
        '
        Me.aSignOut.Enabled = False
        Me.aSignOut.Name = "aSignOut"
        Me.aSignOut.Size = New System.Drawing.Size(254, 26)
        Me.aSignOut.Text = "Sign Out"
        '
        'smLogs
        '
        Me.smLogs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuditLogToolStripMenuItem, Me.UserAccountsToolStripMenuItem, Me.ClientsToolStripMenuItem})
        Me.smLogs.Name = "smLogs"
        Me.smLogs.Size = New System.Drawing.Size(55, 26)
        Me.smLogs.Text = "View"
        '
        'AuditLogToolStripMenuItem
        '
        Me.AuditLogToolStripMenuItem.Name = "AuditLogToolStripMenuItem"
        Me.AuditLogToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.AuditLogToolStripMenuItem.Text = "Audit Log"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ClientsToolStripMenuItem.Text = "Client List"
        '
        'smClient
        '
        Me.smClient.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cAdd, Me.cDelete})
        Me.smClient.Name = "smClient"
        Me.smClient.Size = New System.Drawing.Size(61, 26)
        Me.smClient.Text = "Client"
        '
        'cAdd
        '
        Me.cAdd.Name = "cAdd"
        Me.cAdd.Size = New System.Drawing.Size(205, 26)
        Me.cAdd.Text = "Add Client"
        '
        'cDelete
        '
        Me.cDelete.Name = "cDelete"
        Me.cDelete.Size = New System.Drawing.Size(205, 26)
        Me.cDelete.Text = "Deactivate Client"
        '
        'smTransactions
        '
        Me.smTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tLoanForm, Me.tPayment, Me.LoanRateProfileToolStripMenuItem})
        Me.smTransactions.Name = "smTransactions"
        Me.smTransactions.Size = New System.Drawing.Size(104, 26)
        Me.smTransactions.Text = "Transactions"
        '
        'tLoanForm
        '
        Me.tLoanForm.Name = "tLoanForm"
        Me.tLoanForm.Size = New System.Drawing.Size(205, 26)
        Me.tLoanForm.Text = "Loan Form"
        '
        'tPayment
        '
        Me.tPayment.Name = "tPayment"
        Me.tPayment.Size = New System.Drawing.Size(205, 26)
        Me.tPayment.Text = "Loan Payment"
        '
        'LoanRateProfileToolStripMenuItem
        '
        Me.LoanRateProfileToolStripMenuItem.Name = "LoanRateProfileToolStripMenuItem"
        Me.LoanRateProfileToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.LoanRateProfileToolStripMenuItem.Text = "Loan Rate Profile"
        '
        'smReports
        '
        Me.smReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rMonthly, Me.rYearly})
        Me.smReports.Name = "smReports"
        Me.smReports.Size = New System.Drawing.Size(74, 26)
        Me.smReports.Text = "Reports"
        '
        'rMonthly
        '
        Me.rMonthly.Name = "rMonthly"
        Me.rMonthly.Size = New System.Drawing.Size(195, 26)
        Me.rMonthly.Text = "Monthly Report"
        '
        'rYearly
        '
        Me.rYearly.Name = "rYearly"
        Me.rYearly.Size = New System.Drawing.Size(195, 26)
        Me.rYearly.Text = "Yearly Report"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "mdb"
        Me.OpenFileDialog.Filter = "Database|BMPCLoanDB.mdb"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(861, 633)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1123, 663)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cMenuStrip)
        Me.MainMenuStrip = Me.cMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Text = "Loan Manager System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cMenuStrip.ResumeLayout(False)
        Me.cMenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cMenuStrip As MenuStrip
    Friend WithEvents smAccount As ToolStripMenuItem
    Friend WithEvents aSignIn As ToolStripMenuItem
    Friend WithEvents aSignOut As ToolStripMenuItem
    Friend WithEvents aCreateAccount As ToolStripMenuItem
    Friend WithEvents aDelete As ToolStripMenuItem
    Friend WithEvents smClient As ToolStripMenuItem
    Friend WithEvents cAdd As ToolStripMenuItem
    Friend WithEvents smTransactions As ToolStripMenuItem
    Friend WithEvents tLoanForm As ToolStripMenuItem
    Friend WithEvents tPayment As ToolStripMenuItem
    Friend WithEvents smReports As ToolStripMenuItem
    Friend WithEvents rMonthly As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents LoanRateProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cDelete As ToolStripMenuItem
    Friend WithEvents rYearly As ToolStripMenuItem
    Friend WithEvents smLogs As ToolStripMenuItem
    Friend WithEvents AuditLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
End Class
