<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.ReportContainer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportContainer
        '
        Me.ReportContainer.ActiveViewIndex = -1
        Me.ReportContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportContainer.Location = New System.Drawing.Point(0, 0)
        Me.ReportContainer.Name = "ReportContainer"
        Me.ReportContainer.Size = New System.Drawing.Size(741, 503)
        Me.ReportContainer.TabIndex = 0
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 503)
        Me.Controls.Add(Me.ReportContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportContainer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
