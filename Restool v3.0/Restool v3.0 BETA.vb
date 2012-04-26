Public Class Form1
    'List of Server addresses
    Public server1 As String = "http://restech.niu.edu/"
    Public server2 As String = "http://servx.zapto.org/Restool/apps/"
    Public serverSelect As String                   'This is the server currently selected
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scriptsCheck()
        'Set IP in Title
        Me.Text = "ResTool v3.0.1 BETA - IP: " & System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName().ToString).AddressList(0).ToString()
        'Load Server Options
        ServerList1.Items.AddRange(New Object() {"Restech", "Test"})
        ServerList1.SelectedIndex = 0                   ' Set Restech to be default server

        'Check Server Status
        checkServerStatus(server1, Status1)
        checkServerStatus(server2, Status2)
    End Sub
    '################################ONLINE VIRUS SCANNER FUNCTIONS#######################
    'COMBOFIX
    Private Sub combofix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combofix.Click
        Dim address As String = serverSelect & "cf.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\cf.exe"
        fileStarter(address, file, "cf.exe", )
    End Sub
    'MALWAREBYTES
    Private Sub malwarebytes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles malwarebytes.Click
        Dim file As String = ""
        If findArchitecture() = 64 Then
            file = "%HOMEDRIVE%\Program Files (x86)\Malwarebytes' Anti-Malware\mbam.exe"
        ElseIf findArchitecture() = 32 Then
            file = "%HOMEDRIVE%\Program Files\Malwarebytes' Anti-Malware\mbam.exe"
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
            Dim address As String = serverSelect & "malwarebytes.exe"
            Dim fileDownload As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mb.exe"
            My.Computer.Network.DownloadFile(address, fileDownload, "", "", True, 10, True)
            Process.Start(fileDownload)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\malwarebytes_install.exe")
        End If
    End Sub
    Private Sub malwarebytesScan()
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "%HOMEDRIVE%\Program Files (x86)\Malwarebytes' Anti-Malware"
        ElseIf findArchitecture() = 32 Then
            path = "%HOMEDRIVE%\Program Files\Malwarebytes' Anti-Malware"
        End If
        Dim scan As New ProcessStartInfo
        scan.FileName = path & "\mbam.exe"
        scan.Arguments = "/fullscan"
        Process.Start(scan)
    End Sub

    'SPYBOT
    Private Sub spybot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spybot.Click
        Dim path As String = ""
        Dim address As String = serverSelect & "spybot.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\spybot.exe"
        If findArchitecture() = 64 Then
            path = "%HOMEDRIVE%\Program Files (x86)\Spybot - Search & Destroy\SpyBotSD.exe"
        Else
            path = "%HOMEDRIVE%\Program Files\Spybot - Search & Destroy\SpyBotSD.exe"
        End If
        If System.IO.File.Exists(path) = True Then
            ' Check Architecture for existance and then uninstall if uninstaller exists
            If findArchitecture() = 64 Then
                Process.Start("%HOMEDRIVE%\Program Files (x86)\Spybot - Search & Destroy\unins000.exe")
            Else
                Process.Start("%HOMEDRIVE%\Program Files\Spybot - Search & Destroy\unins000.exe")
            End If
            Dim callInstall As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\spybot_run.exe")
            callInstall.EnableRaisingEvents = True
            AddHandler callInstall.Exited, AddressOf installSpybot
        Else
            ' Otherwise Download and install
            fileStarter(address, file, "spybot.exe", "spybot_install.exe")
        End If
    End Sub
    Private Sub installSpybot()
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\spybot.exe"
        Process.Start(file)
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\spybot_install.exe")
    End Sub
    'ESET
    Private Sub eset_online_scanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eset_online_scanner.Click
        ' Download Eset
        Dim address As String = "http://download.eset.com/special/eos/esetsmartinstaller_enu.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\eset.exe"

        fileStarter(address, file, "eset.exe", "eset_run.exe")
    End Sub

    'FSECURE    - This is a useless app. Need to remove soon.
    Private Sub Fsecure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fsecure.Click
        Process.Start("http://www.f-secure.com/en_EMEA-Labs/security-threats/tools/online-scanner")
    End Sub

    'HOUSECALL
    Private Sub Housecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Housecall.Click
        Dim address As String = ""
        Dim file As String = ""
        Dim fileName As String = ""
        If findArchitecture() = 64 Then
            address = "http://go.trendmicro.com/housecall7/HousecallLauncher64.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\housecall64bit.exe"
            fileName = "housecall64bit.exe"
        End If
        If findArchitecture() = 32 Then
            address = "http://go.trendmicro.com/housecall7/HousecallLauncher.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\housecall32bit.exe"
            fileName = "housecall32bit.exe"
        End If
        fileStarter(address, file, fileName, )
    End Sub

    'SUPER-ANTI-SPYWARE
    Private Sub superantispyware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles superantispyware.Click
        Dim path As String = "%HOMEDRIVE%\Program Files\Superantispyware"
        If isInstalled(path) = "yup" Then
            Process.Start(path & "\SUPERAntiSpyware.exe")
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\superantispyware_run.exe")
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = serverSelect & "sas.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\sas.exe"
            fileStarter(address, file, "sas.exe", "superantispyware_install.exe")
            'My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            'Process.Start(file)
            'Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\superantispyware_install.exe")
        End If
    End Sub

    'BITDEFENDER
    Private Sub Bitdefender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bitdefender.Click
        Process.Start("http://quickscan.bitdefender.com/")
    End Sub

    '###############################  REMOVAL TOOLS  ####################################
    ' Norton Removal tool
    Private Sub norton_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles norton_removal.Click
        Dim address As String = "ftp://ftp.symantec.com/public/english_us_canada/removal_tools/Norton_Removal_Tool.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\nrt.exe"
        fileStarter(address, file, "nrt.exe", "norton_removal.exe")
    End Sub

    ' Kaspersky Removal Tool
    Private Sub kaspersky_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaspersky_removal.Click
        Dim address As String = serverSelect & "krt.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\krt.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        fileStarter(address, file, "krt.exe", )
        'Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\kaspersky_removal.exe")  ## Does this script work? Need to ask Evan
    End Sub

    ' McAfee Removal Tool
    Private Sub mcafee_product_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcafee_product_removal.Click
        Dim address As String = serverSelect & "mcpr.exe"
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcpr.exe"
        fileStarter(address, file, "mcpr.exe", )
    End Sub

    ' AVG Removal Tool
    Private Sub avg_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avg_removal.Click
        Dim address As String
        Dim file As String
        Dim name As String
        If findArchitecture() = 64 Then
            address = server2 & "avgr64.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avgr64.exe"
            name = "avgr64.exe"
        ElseIf findArchitecture() = 32 Then
            address = server2 & "avgr86.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avgr86.exe"
            name = "avgr86.exe"
        End If
        fileStarter(address, file, name, )
    End Sub

    ' TrendMicro Removal Tool
    Private Sub trendmicro_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trendmicro_removal.Click
        Dim address As String = ""
        Dim file As String = ""
        Dim name As String = ""
        Dim OS As String = GetOSVersion()
        If OS.Contains("XP") = False Then
            If findArchitecture() = 64 Then
                address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/64bit.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_64.exe"
                name = "tmdiag_64.exe"
            End If
            If findArchitecture() = 32 Then
                address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/32bit.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_32.exe"
                name = "tmdiag_32.exe"
            End If
        Else
            address = "http://solutionfile.trendmicro.com/solutionfile/EN-1037161/32bit.exe"
            file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\tmdiag_xp.exe"
            name = "tmdiag_xp.exe"
        End If

        fileStarter(address, file, name, )
    End Sub

    Private Sub avast_removal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avast_removal.Click
        'Send to AVAST Uninstaller Webpage
        Process.Start("http://www.avast.com/uninstall-utility")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsVersion.Click
        Dim version As String = GetOSVersion()
        MessageBox.Show(version)
    End Sub


    '################################  OS INFORMATION FUNCTIONS #######################
    Private Function findArchitecture()
        Dim dir As New IO.DirectoryInfo("%HOMEDRIVE%\Program Files (x86)")
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
            path = "%HOMEDRIVE%\Program Files (x86)\CCleaner"
        ElseIf findArchitecture() = 32 Then
            path = "%HOMEDRIVE%\Program Files\CCleaner"
        End If
        If isInstalled(path) = "yup" Then
            Dim runInfo As New ProcessStartInfo
            runInfo.FileName = path & "\ccleaner.exe"
            runInfo.Arguments = "/auto"
            Dim ccleanerRun As Process = System.Diagnostics.Process.Start(runInfo)
            ccleanerRun.EnableRaisingEvents = True
            AddHandler ccleanerRun.Exited, AddressOf ccleanerFinished
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = serverSelect & "ccleaner.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\ccln.exe"
            Try
                My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Catch ex As Exception
                MsgBox("File Download cancelled")
                Return
            End Try
            Try
                Process.Start(file)
            Catch ex As Exception
                MsgBox("Epic Fail. Program can't Install or Run")
                Return
            End Try
            Dim installCCleaner As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\ccleaner.exe")
            installCCleaner.EnableRaisingEvents = True
            AddHandler installCCleaner.Exited, AddressOf runCCleaner
        End If
    End Sub
    Private Sub fileStarter(ByRef address As String, ByRef file As String, ByRef fileName As String, Optional ByRef scriptName As String = Nothing)
        ' Download File
        Try
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Catch ex As Exception
            MsgBox("ResFail #1. Can't Download File")
            Return
        End Try

        If String.IsNullOrEmpty(scriptName) Then
            ' Setup new Process configs
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo

            ' Script and download storage
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.WorkingDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            processStartInfo.FileName = fileName

            ' Check version of Windows and ask for admin if higher then Vista
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            ' Start Process and script
            Try
                System.Diagnostics.Process.Start(processStartInfo)
            Catch ex As Exception
                MsgBox("ResFail #2. Can't Run the Program (w/o Script)")
                Return
            End Try
        Else
            ' Setup new Process configs
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            Dim processStartInfo_script As System.Diagnostics.ProcessStartInfo

            ' Script and download storage
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.WorkingDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            processStartInfo.FileName = fileName
            processStartInfo_script = New System.Diagnostics.ProcessStartInfo()
            processStartInfo_script.WorkingDirectory = Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts"
            processStartInfo_script.FileName = scriptName

            ' Check version of Windows and ask for admin if higher then Vista
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
                processStartInfo_script.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            ' Start process and script
            Try
                System.Diagnostics.Process.Start(processStartInfo)
            Catch ex As Exception
                MsgBox("ResFail #3. Can't run the Program (w/ Script)")
            End Try
            Try
                System.Diagnostics.Process.Start(processStartInfo_script)
            Catch ex As Exception
                MsgBox("ResFail #4. Can't run the Script")
            End Try
        End If
    End Sub
    Private Sub runCCleaner()
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "%HOMEDRIVE%\Program Files (x86)\CCleaner"
        ElseIf findArchitecture() = 32 Then
            path = "%HOMEDRIVE%\Program Files\CCleaner"
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
        Dim address As String = "http://restech.niu.edu/mcafee.exe"                 'Keep this in restech since its never updated anyways
        Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcafee.exe"
        My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Process.Start(file)
    End Sub

    'NAC INSTALL
    Private Sub nac_install_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nac_install.Click
        Dim path As String = ""
        If findArchitecture() = 64 Then
            path = "%HOMEDRIVE%\Program Files (x86)\Cisco\Cisco NAC Agent"
        ElseIf findArchitecture() = 32 Then
            path = "%HOMEDRIVE%\Program Files\Cisco\Cisco NAC Agent"
        End If
        If isInstalled(path) = "yup" Then
            MessageBox.Show("Cisco NAC is currently installed.  Please run the removal tool first.")
        ElseIf isInstalled(path) = "nope" Then
            Dim address As String = "http://restech.niu.edu/nac.msi"                    'Keep this in restech since its maintained by NIU
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
                address = serverSelect & "mse7x64.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mse7x64.exe"
            End If
            If findArchitecture() = 32 Then
                address = serverSelect & "mse7x86.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mse7x86.exe"
            End If
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\msse_install.exe")
        Else
            address = serverSelect & "msexp.exe"
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
                If System.IO.File.Exists("%HOMEDRIVE%\Program Files (x86)\Windows Resource Kits\Tools\subinacl.exe") = True Then
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions64.bat")
                Else
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\subinacl.msi")
                    Dim resetPermissions As Process = System.Diagnostics.Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\reset_permissions.exe")
                    resetPermissions.EnableRaisingEvents = True
                    AddHandler resetPermissions.Exited, AddressOf resetRun
                End If
            Else
                If System.IO.File.Exists("%HOMEDRIVE%\Program Files\Windows Resource Kits\Tools\subinacl.exe") = True Then
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
        'runInfo.FileName = "C:\windows\system32\sfc.exe"
        runInfo.FileName = "%WINDIR%\System32\sfc.exe"      'Use Enviormental variable instead
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

    Private Sub ServerList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerList1.SelectedIndexChanged
        If ServerList1.SelectedIndex.Equals(0) Then
            serverSelect = server1
        End If
        If ServerList1.SelectedIndex.Equals(1) Then
            serverSelect = server2
        End If
    End Sub
    Private Sub checkServerStatus(ByVal server As String, ByRef serverTitle As Label)
        Dim url As New System.Uri(server)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            serverTitle.Text = "Live"
            serverTitle.ForeColor = Color.Green
        Catch ex As Exception
            req = Nothing
            serverTitle.Text = "Down"
            serverTitle.ForeColor = Color.Red
        End Try
    End Sub
End Class
