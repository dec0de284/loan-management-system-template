<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadBar = New System.Windows.Forms.ProgressBar()
        Me.LoadingText = New System.Windows.Forms.Label()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(632, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loan Management Application System"
        '
        'LoadBar
        '
        Me.LoadBar.Location = New System.Drawing.Point(9, 201)
        Me.LoadBar.Margin = New System.Windows.Forms.Padding(2)
        Me.LoadBar.Name = "LoadBar"
        Me.LoadBar.Size = New System.Drawing.Size(632, 35)
        Me.LoadBar.TabIndex = 2
        '
        'LoadingText
        '
        Me.LoadingText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingText.AutoSize = True
        Me.LoadingText.Location = New System.Drawing.Point(12, 182)
        Me.LoadingText.Name = "LoadingText"
        Me.LoadingText.Size = New System.Drawing.Size(291, 17)
        Me.LoadingText.TabIndex = 3
        Me.LoadingText.Text = "Checking file 'BMPCLoanDB.mdb' if it exists..."
        Me.LoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoadingText)
        Me.Controls.Add(Me.LoadBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadBar As ProgressBar
    Friend WithEvents LoadingText As Label
    Friend WithEvents LoadTimer As Timer
End Class
