<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.realtimeProcess = New System.Windows.Forms.Timer(Me.components)
        Me.btnFreeRAM = New System.Windows.Forms.Button()
        Me.btnKillProcess = New System.Windows.Forms.Button()
        Me.lblRAMUsage = New System.Windows.Forms.Label()
        Me.lblRAMUsageText = New System.Windows.Forms.Label()
        Me.lblNoProcessText = New System.Windows.Forms.Label()
        Me.lblNoProcesses = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'realtimeProcess
        '
        Me.realtimeProcess.Enabled = True
        '
        'btnFreeRAM
        '
        Me.btnFreeRAM.Location = New System.Drawing.Point(109, 114)
        Me.btnFreeRAM.Name = "btnFreeRAM"
        Me.btnFreeRAM.Size = New System.Drawing.Size(75, 23)
        Me.btnFreeRAM.TabIndex = 0
        Me.btnFreeRAM.Text = "Free RAM"
        Me.btnFreeRAM.UseVisualStyleBackColor = True
        '
        'btnKillProcess
        '
        Me.btnKillProcess.Location = New System.Drawing.Point(190, 114)
        Me.btnKillProcess.Name = "btnKillProcess"
        Me.btnKillProcess.Size = New System.Drawing.Size(92, 23)
        Me.btnKillProcess.TabIndex = 1
        Me.btnKillProcess.Text = "Kill Processes"
        Me.btnKillProcess.UseVisualStyleBackColor = True
        '
        'lblRAMUsage
        '
        Me.lblRAMUsage.AutoSize = True
        Me.lblRAMUsage.Location = New System.Drawing.Point(24, 59)
        Me.lblRAMUsage.Name = "lblRAMUsage"
        Me.lblRAMUsage.Size = New System.Drawing.Size(68, 13)
        Me.lblRAMUsage.TabIndex = 2
        Me.lblRAMUsage.Text = "RAM Usage:"
        '
        'lblRAMUsageText
        '
        Me.lblRAMUsageText.AutoSize = True
        Me.lblRAMUsageText.Location = New System.Drawing.Point(121, 59)
        Me.lblRAMUsageText.Name = "lblRAMUsageText"
        Me.lblRAMUsageText.Size = New System.Drawing.Size(13, 13)
        Me.lblRAMUsageText.TabIndex = 3
        Me.lblRAMUsageText.Text = "0"
        '
        'lblNoProcessText
        '
        Me.lblNoProcessText.AutoSize = True
        Me.lblNoProcessText.Location = New System.Drawing.Point(121, 36)
        Me.lblNoProcessText.Name = "lblNoProcessText"
        Me.lblNoProcessText.Size = New System.Drawing.Size(13, 13)
        Me.lblNoProcessText.TabIndex = 5
        Me.lblNoProcessText.Text = "0"
        '
        'lblNoProcesses
        '
        Me.lblNoProcesses.AutoSize = True
        Me.lblNoProcesses.Location = New System.Drawing.Point(24, 36)
        Me.lblNoProcesses.Name = "lblNoProcesses"
        Me.lblNoProcesses.Size = New System.Drawing.Size(91, 13)
        Me.lblNoProcesses.TabIndex = 4
        Me.lblNoProcesses.Text = "No. of Processes:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 149)
        Me.Controls.Add(Me.lblNoProcessText)
        Me.Controls.Add(Me.lblNoProcesses)
        Me.Controls.Add(Me.lblRAMUsageText)
        Me.Controls.Add(Me.lblRAMUsage)
        Me.Controls.Add(Me.btnKillProcess)
        Me.Controls.Add(Me.btnFreeRAM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optimizer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents realtimeProcess As Timer
    Friend WithEvents btnFreeRAM As Button
    Friend WithEvents btnKillProcess As Button
    Friend WithEvents lblRAMUsage As Label
    Friend WithEvents lblRAMUsageText As Label
    Friend WithEvents lblNoProcessText As Label
    Friend WithEvents lblNoProcesses As Label
End Class
