Imports Microsoft.Win32
Public Class Hub

    Private Sub bxHub_TextChanged(sender As Object, e As EventArgs) Handles bxHub.TextChanged
        If Me.bxHub.Text = Block.lblKey.Text Then
            Application.Exit()

        ElseIf Me.bxHub.Text = lblPower.Text Then
            'Shutdown pc: power
            System.Diagnostics.Process.Start("shutdown", "-s -t 10")

        ElseIf Me.bxHub.Text = lblHold.Text Then
            'Startup: hold
            Try
                Dim rKey As RegistryKey
                rKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                rKey.SetValue(Application.ProductName, Application.ExecutablePath)
                rKey.Close()
                Me.Close()
            Catch ex As Exception

            End Try
        ElseIf Me.bxHub.Text = lblRelease.Text Then
            'Undo Startup: release
            Try
                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.DeleteValue(Application.ProductName, False)
                regKey.Close()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class