Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scriptsCheck()
    End Sub
    '################################ONLINE VIRUS SCANNER FUNCTIONS#######################
    'COMBOFIX
    Private Sub combofix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combofix.Click
        Dim address As String = "http://restech.niu.edu/cf.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\cf.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub
    'MALWAREBYTES
    Private Sub malwarebytes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles malwarebytes.Click
        Dim file As String = ""
        If findArchitecture() = 64 Then
            file = "C:\Program Files (x86)\Malwarebytes' Anti-Malware\mbam.exe"
        ElseIf findArchitecture() = 32 Then
            file = "C:\Program Files\Malwarebytes' Anti-Malware\mbam.exe"
        End If
        If System.IO.File.Exists(file) = True Then
            Dim updateinfo As New ProcessStartInfo
            updateinfo.FileName = file
            updateinfo.Arguments = "/updateshowdialog"
            Dim updateProcess As Process = System.Diagnostics.Process.Start(updateinfo)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\malwarebytes_run.exe")
            updateProcess.EnableRaisingEvents = True
            AddHandler updateProcess.Exited, AddressOf malwarebytesScan
        Else
            Dim address As String = "http://restech.niu.edu/malwarebytes.exe"
            Dim fileDownload As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mb.exe"
            My.Computer.Network.DownloadFile(address, fileDownload, "", "", True, 10, True)
            Process.Start(fileDownload)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\malwarebytes_install.exe")
        End If
    End Sub
    Private Sub malwarebytesScan()
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "C:\Program Files (x86)\Malwarebytes' Anti-Malware"
        ElseIf findArchitecture() = 32 Then
            path = "C:\Program Files\Malwarebytes' Anti-Malware"
        End If
        Dim scan As New ProcessStartInfo
        scan.FileName = path & "\mbam.exe"
        scan.Arguments = "/fullscan"
        Process.Start(scan)
    End Sub

    'SPYBOT
    Private Sub spybot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spybot.Click
        Dim path As String = ""
        Dim address As String = "http://restech.niu.edu/spybot.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\spybot.exe"
        If findArchitecture() = 64 Then
            path = "C:\Program Files (x86)\Spybot - Search & Destroy\SpyBotSD.exe"
        Else
            path = "C:\Program Files\Spybot - Search & Destroy\SpyBotSD.exe"
        End If
        If System.IO.File.Exists(path) = True Then
            If findArchitecture() = 64 Then
                Process.Start("C:\Program Files (x86)\Spybot - Search & Destroy\unins000.exe")
            Else
                Process.Start("C:\Program Files\Spybot - Search & Destroy\unins000.exe")
            End If
            Dim callInstall As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\spybot_run.exe")
            callInstall.EnableRaisingEvents = True
            AddHandler callInstall.Exited, AddressOf installSpybot
        Else
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\spybot_install.exe")
        End If
    End Sub
    Private Sub installSpybot()
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\spybot.exe"
        Process.Start(file)
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\spybot_install.exe")
    End Sub
    'ESET
    Private Sub eset_online_scanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eset_online_scanner.Click
        Dim address As String = "http://download.eset.com/special/eos/esetsmartinstaller_enu.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\eset.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\eset_run.exe")
    End Sub

    'FSECURE
    Private Sub Fsecure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fsecure.Click
        Process.Start("http://www.f-secure.com/en_EMEA-Labs/security-threats/tools/online-scanner")
    End Sub

    'HOUSECALL
    Private Sub Housecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Housecall.Click
        Dim address As String = ""
        Dim file As String = ""
        If findArchitecture() = 64 Then
            address = "http://go.trendmicro.com/housecall7/HousecallLauncher64.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\housecall64bit.exe"
        End If
        If findArchitecture() = 32 Then
            address = "http://go.trendmicro.com/housecall7/HousecallLauncher.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\housecall32bit.exe"
        End If
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub

    'SUPER-ANTI-SPYWARE
    Private Sub superantispyware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles superantispyware.Click
        Dim path As String = "C:\Program Files\Superantispyware"
        If isInstalled(path) = "yup" Then
            Process.Start(path & "\SUPERAntiSpyware.exe")
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\superantispyware_run.exe")
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = "http://restech.niu.edu/sas.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\sas.exe"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\superantispyware_install.exe")
        End If
    End Sub

    'BITDEFENDER
    Private Sub Bitdefender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bitdefender.Click
        Process.Start("http://www.bitdefender.com/scanner/online/free.html")
    End Sub

    '###############################  REMOVAL TOOLS  ####################################
    Private Sub norton_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles norton_removal.Click
        Dim address As String = "ftp://ftp.symantec.com/public/english_us_canada/removal_tools/Norton_Removal_Tool.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\nrt.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\norton_removal.exe")
    End Sub

    Private Sub kaspersky_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaspersky_removal.Click
        Dim address As String = "http://restech.niu.edu/krt.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\krt.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
        'Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\kaspersky_removal.exe")
    End Sub

    Private Sub mcafee_product_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcafee_product_removal.Click
        Dim address As String = "http://restech.niu.edu/mcpr.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcpr.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub

    Private Sub avg_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avg_removal.Click
        Process.Start("http://www.avg.com/us-en/utilities")
        'Dim address As String = ""
        'Dim file As String = ""
        ''If findArchitecture() = 64 Then
        'address = "http://download.avg.com/filedir/util/avg_arm_sup_____.dir/avgremover.exe"
        'file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avg_removerx64.exe"
        'End If
        'If findArchitecture() = 32 Then
        'address = "http://download.avg.com/filedir/util/avg_arm_sup_____.dir/avgremover.exe"
        'file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avg_removerx86.exe"
        'End If
        'My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        'Process.Start(file)
    End Sub

    Private Sub trendmicro_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trendmicro_removal.Click
        Dim address As String = ""
        Dim file As String = ""
        Dim OS As String = GetOSVersion()
        If OS.Contains("XP") = False Then
            If findArchitecture() = 64 Then
                address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/64bit.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_64.exe"
            End If
            If findArchitecture() = 32 Then
                address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/32bit.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_32.exe.exe"
            End If
        Else
            address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/32bit.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_xp.exe"
        End If

        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub

    Private Sub avast_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avast_removal.Click
        Process.Start("http://www.avast.com/uninstall-utility")
        'Dim address As String = "http://files.avast.com/files/eng/aswclear.exe"
        'Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avast_removal.exe"
        'My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        'Process.Start(file)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsVersion.Click
        Dim version As String = GetOSVersion()
        MessageBox.Show(version)
    End Sub


    '################################  OS INFORMATION FUNCTIONS #######################
    Private Function findArchitecture()
        Dim dir As New IO.DirectoryInfo("C:\Program Files (x86)")
        Dim bit As Integer = 0
        If dir.Exists Then
            bit = 64
        Else
            bit = 32
        End If
        Return bit
    End Function

    Private Function GetOSVersion()
        Dim osInfo As String = Environment.OSVersion.ToString()
        osInfo = osInfo.Replace("Microsoft Windows NT ", "")
        Dim pos As Integer = osInfo.IndexOf("Service Pack")
        Dim servicePackInfo As String = osInfo.Substring(pos, 14)
        servicePackInfo = servicePackInfo.Replace("Service Pack ", "")
        If osInfo.StartsWith("5.1") Then
            Return "Windows XP Service Pack " & servicePackInfo
        ElseIf osInfo.StartsWith("6.0") Then
            Return "Windows Vista Service Pack " & servicePackInfo
        ElseIf osInfo.StartsWith("6.1") Then
            Return "Windows 7 Service Pack " & servicePackInfo
        Else
            Return 0
        End If
    End Function

    Private Function isInstalled(ByVal path As String)
        Dim dir As New IO.DirectoryInfo(path)
        If dir.Exists Then
            Return "yup"
        Else
            Return "nope"
        End If
    End Function

    Private Function scriptsCheck()
        Dim dir As New IO.DirectoryInfo(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts")
        If dir.Exists Then
            Return True
        Else
            MessageBox.Show("The required 'Scripts' folder is not present. The tool may not work correctly.  Make sure the 'application files' folder is in the same directory as ResTool.")
            Return False
        End If
    End Function
    '###############################  MISC TOOLS  #################################
    Private Sub ccleaner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccleaner.Click
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "C:\Program Files (x86)\CCleaner"
        ElseIf findArchitecture() = 32 Then
            path = "C:\Program Files\CCleaner"
        End If
        If isInstalled(path) = "yup" Then
            Dim runInfo As New ProcessStartInfo
            runInfo.FileName = path & "\ccleaner.exe"
            runInfo.Arguments = "/auto"
            Dim ccleanerRun As Process = System.Diagnostics.Process.Start(runInfo)
            ccleanerRun.EnableRaisingEvents = True
            AddHandler ccleanerRun.Exited, AddressOf ccleanerFinished
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = "http://restech.niu.edu/ccleaner.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\ccln.exe"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Dim installCCleaner As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\ccleaner.exe")
            installCCleaner.EnableRaisingEvents = True
            AddHandler installCCleaner.Exited, AddressOf runCCleaner
        End If
    End Sub
    Private Sub runCCleaner()
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "C:\Program Files (x86)\CCleaner"
        ElseIf findArchitecture() = 32 Then
            path = "C:\Program Files\CCleaner"
        End If
        Dim runInfo As New ProcessStartInfo
        runInfo.FileName = path & "\ccleaner.exe"
        runInfo.Arguments = "/auto"
        Dim ccleanerRun As Process = System.Diagnostics.Process.Start(runInfo)
        ccleanerRun.EnableRaisingEvents = True
        AddHandler ccleanerRun.Exited, AddressOf ccleanerFinished
    End Sub
    Private Sub ccleanerFinished()
        MessageBox.Show("Cleaned A Bunch Of Junk")
    End Sub

    '###############################  MISC TOOLS  #################################
    'MCAFEE INSTALL
    Private Sub mcafee_install_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcafee_install.Click
        Dim address As String = "http://restech.niu.edu/mcafee.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcafee.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub

    'NAC INSTALL
    Private Sub nac_install_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nac_install.Click
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "C:\Program Files (x86)\Cisco\Cisco NAC Agent"
        ElseIf findArchitecture() = 32 Then
            path = "C:\Program Files\Cisco\Cisco NAC Agent"
        End If
        If isInstalled(path) = "yup" Then
            MessageBox.Show("Cisco NAC is currently installed.  Please run the removal tool first.")
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = "http://restech.niu.edu/nac.msi"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\nac.msi"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\nac_install.exe")
        End If
    End Sub

    'SECURITY ESSENTIALS INSTALL
    Private Sub msse_install_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msse_install.Click
        Dim OS As String = GetOSVersion()
        Dim address As String = ""
        Dim file As String = ""
        If OS.Contains("XP") = False Then
            If findArchitecture() = 64 Then
                address = "http://restech.niu.edu/mse7x64.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mse7x64.exe"
            End If
            If findArchitecture() = 32 Then
                address = "http://restech.niu.edu/mse7x86.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mse7x86.exe"
            End If
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\msse_install.exe")
        Else
            address = "http://restech.niu.edu/msexp.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\msexp.exe"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\msse_install.exe")
        End If
    End Sub

    'NAC REMOVAL
    Private Sub nac_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nac_removal.Click
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\nac_removal.exe")
    End Sub

    'WINSOCK
    Private Sub winsock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles winsock.Click
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\winsock.exe")
    End Sub

    'RESET PERMISSIONS
    Private Sub reset_permissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_permissions.Click
        Dim OS As String = GetOSVersion()
        If OS.Contains("Windows 7") = True Then
            MessageBox.Show("Reset Permissions Does Not Work For Windows 7.")
        Else
            If findArchitecture() = 64 Then
                If System.IO.File.Exists("C:\Program Files (x86)\Windows Resource Kits\Tools\subinacl.exe") = True Then
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions64.bat")
                Else
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\subinacl.msi")
                    Dim resetPermissions As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions.exe")
                    resetPermissions.EnableRaisingEvents = True
                    AddHandler resetPermissions.Exited, AddressOf resetRun
                End If
            Else
                If System.IO.File.Exists("C:\Program Files\Windows Resource Kits\Tools\subinacl.exe") = True Then
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions32.bat")
                Else
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\subinacl.msi")
                    Dim resetPermissions As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions.exe")
                    resetPermissions.EnableRaisingEvents = True
                    AddHandler resetPermissions.Exited, AddressOf resetRun
                End If
            End If

        End If
    End Sub
    Private Sub resetRun()
        If findArchitecture() = 64 Then
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions64.bat")
        Else
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions32.bat")
        End If
    End Sub

    'WINDOWS UPDATE FIX
    Private Sub windowsupdatefix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles windowsupdatefix.Click
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\windows_update_fix.exe")
    End Sub

    'SYSTEM FILE CHECKER
    Private Sub systemfilecheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles systemfilecheck.Click
        Dim runInfo As New ProcessStartInfo
        runInfo.FileName = "C:\windows\system32\sfc.exe"
        runInfo.Arguments = "/scannow"
        Dim checkRun As Process = System.Diagnostics.Process.Start(runInfo)
        checkRun.EnableRaisingEvents = True
        AddHandler checkRun.Exited, AddressOf checkFinished
    End Sub
    Private Sub checkFinished()
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\sfc_smallerizer.bat")
    End Sub


    Private Sub niu_mcafee_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles niu_mcafee_removal.Click
        MessageBox.Show("This feature is not available in this BETA.  :(")
    End Sub
End Class
