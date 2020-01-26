Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Module mdProcess

    <DllImport("kernel32.dll", EntryPoint:="QueryDosDevice")>
    Private Function DosDevice(ByVal name As String, ByVal path As StringBuilder, ByVal length As UInteger) As UInteger
        'reference calling
    End Function

    <DllImport("psapi.dll", EntryPoint:="GetProcessImageFileName")>
    Private Function ProcessFileName(ByVal handle As IntPtr, ByVal name As StringBuilder, ByVal size As UInteger) As UInteger
        'reference calling
    End Function

    <DllImport("kernel32.dll", EntryPoint:="SetProcessWorkingSetSize")>
    Private Function SetWorkingSet(ByVal handle As IntPtr, ByVal minimum As Integer, ByVal maximum As Integer) As Boolean
        'refference calling
    End Function

    Private Function processLocation(ByVal handle As IntPtr) As String
        Dim intTick As New StringBuilder(512)
        If ProcessFileName(handle, intTick, 512) > 0 Then
            Dim P As String = intTick.ToString
            For Each D As String In Environment.GetLogicalDrives
                If DosDevice(D.Substring(0, 2), intTick, 512) > 0 Then
                    If P.StartsWith(intTick.ToString) Then
                        Return Path.GetFullPath(D & P.Remove(0, intTick.Length)).ToLower
                    End If
                End If
            Next
        End If
        Return String.Empty
    End Function

    Function freeRAM() As Integer
        Dim intTick As Integer
        For Each myProccess As Process In Process.GetProcesses
            Try
                If SetWorkingSet(myProccess.Handle, -1, -1) Then
                    intTick += 1
                End If
            Catch
                'Dim ex As Exception
                'MessageBox.Show("ERROR: " + ex.ToString)
            End Try
        Next
        Return intTick
    End Function

    Function killProcesses() As Integer
        Dim intTick As Integer
        Dim processExclusions As String() = {Environment.SystemDirectory.ToLower, Path.GetDirectoryName(Environment.SystemDirectory).ToLower}
        Dim currentProcess As String = processLocation(Process.GetCurrentProcess.Handle)

        For Each P As Process In Process.GetProcesses
            Try
                Dim Location As String = processLocation(P.Handle)
                If Not String.IsNullOrEmpty(Location) And Not Location = currentProcess Then
                    If Array.IndexOf(processExclusions, Path.GetDirectoryName(Location)) = -1 Then
                        P.Kill()
                        intTick += 1
                    End If
                End If
            Catch
                'Dim ex As Exception
                'MessageBox.Show("ERROR: " + ex.ToString)
            End Try
        Next

        Return intTick
    End Function

End Module
