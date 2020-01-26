Imports Microsoft.VisualBasic.CompilerServices

Public Class frmMain
    Private Sub realtimeProcess_Tick(sender As Object, e As EventArgs) Handles realtimeProcess.Tick
        Dim maximumRAM As ULong = My.Computer.Info.TotalPhysicalMemory + My.Computer.Info.AvailableVirtualMemory
        Dim currentRAM As ULong = My.Computer.Info.AvailablePhysicalMemory + My.Computer.Info.AvailableVirtualMemory
        Dim RAMGetUsage As Double = ((maximumRAM - currentRAM) / 1024 / 1024)

        lblNoProcessText.Text = Conversions.ToString(Process.GetProcesses.Length)
        lblRAMUsageText.Text = RAMGetUsage.ToString("N0") & " MB"
    End Sub

    Private Sub btnFreeRAM_Click(sender As Object, e As EventArgs) Handles btnFreeRAM.Click
        mdProcess.freeRAM()
    End Sub

    Private Sub btnKillProcess_Click(sender As Object, e As EventArgs) Handles btnKillProcess.Click
        mdProcess.killProcesses()
    End Sub
End Class
