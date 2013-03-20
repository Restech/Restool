Imports System
Imports Microsoft.Win32

Public Class ResTool
    'List of Server addresses
    Private serverList(0 To 2) As String ' List of servers stored in an array.
    Public serverSelect As String ' This is the server currently selected
    Public desktop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Path to the users desktop
    Public restechFolder As String = desktop & "\ResTech" 'Path to the ResTech folder
    Public programFiles32 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) 'Program Files 32-bit machines
    Public programFiles64 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) 'Program Files 64-bit machine
    Public colorRan = Color.Crimson

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum

    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Private Sub ResTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        serverList(0) = "http://restech.niu.edu/"
        serverList(1) = "http://servx.zapto.org/Restool/apps/"
        serverList(2) = "http://restool.codyengel.com/apps/"
        lblIP.Text = "IP: " & System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName().ToString).AddressList(0).ToString()
        pollServer()
        lblWindowsVersion.Text = "Operating System: " & GetOSVersion()
        lblMemory.Text = "Memory: " & Math.Round((My.Computer.Info.TotalPhysicalMemory / 1048576), 0) & "mb"

    End Sub

    '##################################################################################
    '# AV Functions
    '##################################################################################

    '##################################################################################
    '#            bComboFix
    '# Use:       Run CobmoFix
    '##################################################################################
    Private Sub bComboFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bComboFix.Click
        If cbTutorial.Checked = True Then ' Check if tutorial mode is enabled.
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/combofix.html")
        Else
            'Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            wbVirusRemoval.Navigate("http://www.bleepingcomputer.com/combofix/how-to-use-combofix") 'Navigates to how to.
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Dim address As String = serverSelect & "cf.exe"
            Dim file As String = restechFolder & "\cf.exe"
            fileStarter(address, file, "cf.exe", )
        End If
        bComboFix.ForeColor = colorRan
    End Sub

    '##################################################################################
    '#            bMalwarebytes
    '# Use:       Run Malwarebytes
    '##################################################################################
    Private Sub bMalwarebytes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMalwarebytes.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/malwarebytes.html")
        Else
            wbVirusRemoval.Navigate("http://www.malwarebytes.org/products/malwarebytes_free/") 'Navigates to how to.
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            'Check if Malwarebytes was installed previously, if it is update the definitions and scan.
            Dim file As String = ""
            If findArchitecture() = 64 Then
                file = programFiles64 & "\Malwarebytes' Anti-Malware\mbam.exe"
            ElseIf findArchitecture() = 32 Then
                file = programFiles32 & "\Malwarebytes' Anti-Malware\mbam.exe"
            End If
            If System.IO.File.Exists(file) = True Then
                Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\Malwarebytes\malwarebytes-run.bat")
            Else
                'Download and install Malwarebytes
                Dim address As String = serverSelect & "malwarebytes.exe"
                Dim fileDownload As String = restechFolder & "\malwarebytes.exe"
                fileStarter(address, fileDownload, "malwarebytes.exe", "\Malwarebytes\malwarebytes-install.bat")
            End If
        End If
        bMalwarebytes.ForeColor = colorRan
    End Sub

    '##################################################################################
    '#            bSpybot
    '# Use:       Run Spybot
    '##################################################################################
    Private Sub Spybot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSpybot.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/spybot.html")
        Else
            wbVirusRemoval.Navigate("http://www.safer-networking.org/dl/") 'Navigates to how to
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Dim file As String = ""
            If findArchitecture() = 64 Then
                file = programFiles64 & "\Spybot - Search & Destroy\SpyBotSD.exe"
            Else
                file = programFiles32 & "\Spybot - Search & Destroy\SpyBotSD.exe"
            End If
            If System.IO.File.Exists(file) = True Then
                ' Check Architecture for existance and then update & run
                If findArchitecture() = 64 Then
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\Spybot\64\spybot-run.bat")
                Else
                    Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\Spybot\32\spybot-run.bat")
                End If
            Else
                ' Otherwise Download and install
                Dim address As String = serverSelect & "spybot.exe"
                Dim fileDownload As String = restechFolder & "\spybot.exe"
                'My.Computer.Network.DownloadFile(address, fileDownload, "", "", True, 10, True)
                If findArchitecture() = 64 Then
                    fileStarter(address, fileDownload, "spybot.exe", "\Spybot\64\spybot-install.bat")
                Else
                    fileStarter(address, fileDownload, "spybot.exe", "\Spybot\32\spybot-install.bat")
                End If
            End If
        End If
        bSpybot.ForeColor = colorRan
    End Sub
    '##################################################################################
    '#            bSuperAntiSpyware
    '# Use:       Run Spybot
    '##################################################################################
    Private Sub bSuperAntiSpyware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSuperAntiSpyware.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/superantispyware.html")
        Else
            wbVirusRemoval.Navigate("http://www.superantispyware.com/") 'Navigates to how to
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Dim path As String = programFiles32 & "\Superantispyware" 'It installs into Program Files by default!
            If isInstalled(path) = "yup" Then
                Process.Start(path & "\SUPERAntiSpyware.exe")
                Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\superantispyware_run.exe")
            ElseIf isInstalled(path) = "nope" Then
                Dim address As String = serverSelect & "sas.exe"
                Dim file As String = restechFolder & "\sas.exe"
                fileStarter(address, file, "sas.exe", "superantispyware_install.exe")
            End If
        End If
        bSuperAntiSpyware.ForeColor = colorRan
    End Sub
    '##################################################################################
    '#            bEset
    '# Use:       Run ESET
    '##################################################################################
    Private Sub bEset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEset.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/eset.html")
        Else
            wbVirusRemoval.Navigate("http://www.eset.com/us/") 'Navigates to how to
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            ' Download Eset
            Dim address As String = "http://download.eset.com/special/eos/esetsmartinstaller_enu.exe"
            Dim file As String = restechFolder & "\eset.exe"

            fileStarter(address, file, "eset.exe", "eset_run.exe")
        End If
        bEset.ForeColor = colorRan
    End Sub
    '##################################################################################
    '#            bHouseCall
    '# Use:       Run Housecall
    '##################################################################################
    Private Sub bHousecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHousecall.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/housecall.html")
        Else
            wbVirusRemoval.Navigate("http://housecall.trendmicro.com/")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Dim address As String = ""
            Dim file As String = ""
            Dim fileName As String = ""
            If findArchitecture() = 64 Then
                address = "http://go.trendmicro.com/housecall7/HousecallLauncher64.exe"
                file = restechFolder & "\housecall64bit.exe"
                fileName = "housecall64bit.exe"
            End If
            If findArchitecture() = 32 Then
                address = "http://go.trendmicro.com/housecall7/HousecallLauncher.exe"
                file = restechFolder & "\housecall32bit.exe"
                fileName = "housecall32bit.exe"
            End If
            fileStarter(address, file, fileName, )
        End If
        bHousecall.ForeColor = colorRan
    End Sub
    '##################################################################################
    '#            bSophosAV
    '# Use:       Run Sophos Anti Virus.
    '##################################################################################
    Private Sub bSophosAV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSophosAV.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/sophosav.html")
        Else
            wbVirusRemoval.Navigate("http://www.sophos.com/en-us/products/free-tools/virus-removal-tool.aspx")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbVirusRemoval.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            startProgram(Environment.CurrentDirectory() & "/Application Files/Sophos Virus Removal Tool.exe", "")
        End If
        bSophosAV.ForeColor = colorRan
    End Sub

    '##################################################################################
    '# Rootkit Functions
    '##################################################################################

    '##################################################################################
    '#            bMalwarebytesRootkit
    '# Use:       Run MalwarebytesRootkit
    '##################################################################################
    Private Sub bMalwarebytesRootkit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMalwarebytesRootkit.Click

        If cbTutorial.Checked = True Then
            wbRootkit.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/mbar.html")
        Else
            wbRootkit.Navigate("http://www.malwarebytes.org/products/mbar/")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbRootkit.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            startProgram(Environment.CurrentDirectory() & "\Application Files\Rootkit Detection\Malwarebytes Anti-Rootkit\mbar.exe", "")
        End If
    End Sub
    '##################################################################################
    '#            bTDSS
    '# Use:       Run TDSS
    '##################################################################################
    Private Sub bTDSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTDSS.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/tdss.html")
        Else
            wbRootkit.Navigate("http://support.kaspersky.com/5350")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbRootkit.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            startProgram(Environment.CurrentDirectory() & "\Application Files\Rootkit Detection\TDSSKiller.exe", "")
        End If
    End Sub
    '##################################################################################
    '#            bSophos
    '# Use:       Run Sophos
    '##################################################################################
    Private Sub bSophos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSophos.Click

        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/sophos.html")
        Else
            'Run Sophos
            wbRootkit.Navigate("http://www.sophos.com/en-us/products/free-tools/virus-removal-tool.aspx")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbRootkit.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            startProgram(Environment.CurrentDirectory() & "\Application Files\Rootkit Detection\Sophos Anti-Rootkit.exe", "")
        End If
    End Sub

    '##################################################################################
    '# Windows Repair
    '##################################################################################

    '##################################################################################
    '#            bFixIt
    '# Use:       Load Microsoft Fix It
    '##################################################################################
    Private Sub bFixIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFixIt.Click

        If cbTutorial.Checked = True Then
            wbWindowsRepair.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/fixit.html")
        Else
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbWindowsRepair.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            wbWindowsRepair.Navigate("http://support.microsoft.com/fixit/")
        End If
    End Sub

    '##################################################################################
    '#            bSFC
    '# Use:       Run SFC
    '##################################################################################
    Private Sub bSFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSFC.Click

        If cbTutorial.Checked = True Then
            wbWindowsRepair.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/sfc.html")
        Else
            Dim runInfo As New ProcessStartInfo()
            runInfo.FileName = "%WINDIR%\System32\sfc.exe"      'Use Enviormental variable instead
            runInfo.Arguments = "/scannow"
            Dim checkRun As Process = System.Diagnostics.Process.Start(runInfo)
            checkRun.EnableRaisingEvents = True
            'AddHandler checkRun.Exited, AddressOf checkFinished
            checkRun.WaitForExit()
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\sfc_smallerizer.bat")
        End If
    End Sub
    Private Sub checkFinished() 'Can be removed after testing.
        Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\sfc_smallerizer.bat")
    End Sub

    '##################################################################################
    '#            bWindowsAIO
    '# Use:       Run All In One Repair
    '##################################################################################
    Private Sub bWindowAIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bWindowAIO.Click

        If cbTutorial.Checked = True Then
            wbWindowsRepair.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/windows-aio.html")
        Else
            wbWindowsRepair.Navigate("http://www.tweaking.com/content/page/windows_repair_all_in_one.html")
            'Zoom in on website, 80%
            Dim MyWeb As Object = wbWindowsRepair.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Try
                Process.Start(Environment.CurrentDirectory() & "\Application Files\Windows Tools\All In One Repair\Repair_Windows.exe")
            Catch ex As Exception
                MsgBox("Unable to start All In One Repair. Make sure the file exists.")
            End Try
        End If
    End Sub

    '##################################################################################
    '# Maintenance
    '##################################################################################

    '##################################################################################
    '#            bCCleaner
    '# Use:       Run CCleaner
    '##################################################################################
    Private Sub bCCleaner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCCleaner.Click

        If cbTutorial.Checked = True Then
            wbWindowsRepair.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/ccleaner.html")
        Else
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

    '##################################################################################
    '#           bMSCONFIG
    '# Use:      Starts MSConfig
    '##################################################################################
    Private Sub bMSCONFIG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMSCONFIG.Click

        If cbTutorial.Checked = True Then
            wbWindowsRepair.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/msconfig.html")
        Else
            Process.Start("msconfig") ' Start msconfig
        End If
    End Sub

    '##################################################################################
    '# NIU Tools
    '##################################################################################

    '##################################################################################
    '#           bMSE
    '# Use:      Installs Microsoft Security Essentials
    '##################################################################################
    Private Sub bMSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMSE.Click

        If cbTutorial.Checked = True Then
            MsgBox("This installs Microsoft Security Essentials.")
        Else
            Dim OS As String = GetOSVersion()
            Dim address As String = ""
            Dim file As String = ""
            If OS.Contains("XP") = False Then
                If findArchitecture() = 64 Then
                    Try
                        address = serverSelect & "mse7x64.exe"
                        file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mse7x64.exe"
                    Catch ex As Exception
                        MsgBox("ResFail #1. Can't Download File")
                        Return
                    End Try
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
        End If
    End Sub

    '##################################################################################
    '#           bMcAfee
    '# Use:      Installs McAfee, unfortunately.
    '##################################################################################
    Private Sub bMcAfee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMcAfee.Click

        If cbTutorial.Checked = True Then
            MsgBox("This installs McAfee.")
        Else
            Dim address As String = "http://restech.niu.edu/mcafee.exe"                 'Keep this in restech since its never updated anyways
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcafee.exe"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            Process.Start(file)
        End If
    End Sub

    '##################################################################################
    '#           bCiscoNAC
    '# Use:      Installs Cisco NAC
    '##################################################################################
    Private Sub bCiscoNAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCiscoNAC.Click

        If cbTutorial.Checked = True Then
            MsgBox("This installs Cisco NAC.")
        Else
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
        End If
    End Sub

    '##################################################################################
    '#           bRemoveCiscoNAC
    '# Use:      Installs Cisco NAC
    '##################################################################################
    Private Sub bRemoveCiscoNAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRemoveCiscoNAC.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes Cisco NAC from the computer, including removing (most) registry keys.")
        Else
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\nac_removal.exe")
        End If
    End Sub

    Private Sub bNIUwireless_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNIUwireless.Click

        If cbTutorial.Checked = True Then
            MsgBox("This imports the NIU Wireless profile.")
        Else
            Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\NIUwireless\WirelessConfig.bat")
        End If
    End Sub

    '##################################################################################
    '# AV Removal
    '##################################################################################

    '##################################################################################
    '#            bMultipleAV
    '# Use:       Checks for multiple anti-virus programs.
    '##################################################################################
    Private Sub bMultipleAV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMultipleAV.Click

        If cbTutorial.Checked = True Then
            ' Display tutorial instead of running the program/script.
        Else
            Dim programFiles As String = ""
            If findArchitecture() = 64 Then
                programFiles = programFiles64 'If it's 64-bit
            ElseIf findArchitecture() = 32 Then
                programFiles = programFiles32 ' If it's 32-bit
            End If
            MsgBox("This isn't officially supported yet.", , "Error 37!")
            'If System.IO.File.Exists(programFiles & "\malwarebytes.exe") = True Then

            'End If
        End If
    End Sub

    '##################################################################################
    '#            bNortonRemoval
    '# Use:       Removes Norton
    '##################################################################################
    Private Sub bNortonRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNortonRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes Norton from the computer.")
        Else
            Dim address As String = "ftp://ftp.symantec.com/public/english_us_canada/removal_tools/Norton_Removal_Tool.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\nrt.exe"
            fileStarter(address, file, "nrt.exe", "norton_removal.exe")
        End If
    End Sub

    '##################################################################################
    '#            bMcAfeeRemoval
    '# Use:       Removes McAfee
    '##################################################################################
    Private Sub bMcAfeeRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMcAfeeRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes McAfee (not NIUs version) from the computer.")
        Else
            Dim address As String = serverSelect & "mcpr.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mcpr.exe"
            fileStarter(address, file, "mcpr.exe", )
        End If
    End Sub

    '##################################################################################
    '#            bAVGRemoval
    '# Use:       Removes McAfee
    '##################################################################################
    Private Sub bAVGRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAVGRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes AVG from the computer.")
        Else
            Dim address As String
            Dim file As String
            Dim name As String
            If findArchitecture() = 64 Then
                address = serverSelect & "avgr64.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avgr64.exe"
                name = "avgr64.exe"
            ElseIf findArchitecture() = 32 Then
                address = serverSelect & "avgr86.exe"
                file = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\avgr86.exe"
                name = "avgr86.exe"
                fileStarter(address, file, name, )
            End If
        End If
    End Sub

    '##################################################################################
    '#            bTrendRemoval
    '# Use:       Removes Trend Micro
    '##################################################################################
    Private Sub bTrendRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTrendRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes Trend Micro from the computer.")
        Else
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
        End If
    End Sub

    '##################################################################################
    '#            bAvast
    '# Use:       Removes Avast
    '##################################################################################
    Private Sub bAvastRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAvastRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This loads a page for the Avast removal tool.")
        Else
            wbVirusRemoval.Navigate("http://www.avast.com/uninstall-utility")
        End If
    End Sub

    '##################################################################################
    '#            bKasperskyRemoval
    '# Use:       Removes Avast
    '##################################################################################
    Private Sub bKasperskyRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKasperskyRemoval.Click

        If cbTutorial.Checked = True Then
            MsgBox("This removes Kaspersky from the computer. from the computer.")
        Else
            Dim address As String = serverSelect & "krt.exe"
            Dim file As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\krt.exe"
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
            fileStarter(address, file, "krt.exe", )
            'Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\kaspersky_removal.exe")  ## Does this script work? Need to ask Evan
        End If
    End Sub

    '############################### Random Buttons ###################################

    '##################################################################################
    '#            Uninstall Removal Tools
    '# Use:       Uninstalls removal tools that were installed, leaves those that were
    '#            installed previously.
    '##################################################################################
    Private Sub bUninstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUninstall.Click
        If cbTutorial.Checked = True Then
            wbVirusRemoval.Navigate("file:///" & Environment.CurrentDirectory() & "/Application Files/Tutorials/uninstaller.html")
        Else
            wbVirusRemoval.DocumentText = "<h2>Programs are currently being uninstalled.</h2><p>Please pay attention to any UAC prompts that may pop up.</p>"
            Dim resFail5 As String = "ResFail #5. Can't Uninstall "
            Dim uninstallPath As String = ""
            If findArchitecture() = 64 Then
                uninstallPath = programFiles64 'If it's 64-bit
            ElseIf findArchitecture() = 32 Then
                uninstallPath = programFiles32 ' If it's 32-bit
            End If
            '###########################################################
            'Start uninstalling the programs.
            '###########################################################
            Try
                Dim background As String = My.Computer.FileSystem.ReadAllText(desktop + "/ResTech/bg.txt")
                MsgBox("You changed the background, don't forget to change it back!")
            Catch ex As Exception

            End Try

            'Uninstall Malwarebytes
            If System.IO.File.Exists(restechFolder & "\malwarebytes.exe") = True Then
                Try
                    resRemover(uninstallPath & "\MalwareBytes' Anti-Malware\unins000.exe", "\malwarebytes.exe")
                Catch ex As Exception
                    MsgBox(resFail5 & "Malwarebytes")
                    Return
                End Try
            End If
            'Uninstall Spybot
            If System.IO.File.Exists(restechFolder & "\spybot.exe") = True Then
                Try
                    resRemover(uninstallPath & "\Spybot - Search & Destroy\unins000.exe", "\spybot.exe")
                Catch ex As Exception
                    MsgBox(resFail5 & "Spybot")
                End Try
            End If
            'Uninstall ESET
            If System.IO.File.Exists(restechFolder & "\eset.exe") = True Then
                Try
                    resRemover(uninstallPath & "\ESET\ESET Online Scanner\OnlineScannerUninstaller.exe", "\eset.exe")
                Catch ex As Exception
                    MsgBox(resFail5 & "Eset")
                End Try
            End If
            'Uninstall SUPERAntiSpyware
            If System.IO.File.Exists(restechFolder & "\sas.exe") = True Then
                Try
                    resRemover(programFiles32 & "\SuperAntiSpyware\Uninstall.exe", "\sas.exe")
                Catch ex As Exception
                    MsgBox(resFail5 & "SUPERAntiSpyware")
                End Try
            End If
        End If
    End Sub

    '##################################################################################
    '#            resRemover
    '# Use:       Function used to uninstall a scan as well as delete the download file.
    '# Note:      This should ONLY be used for the Uninstall Removal Tools button!
    '##################################################################################
    Private Sub resRemover(ByVal path As String, ByVal downloadFile As String)
        Try
            Dim pInfo As New ProcessStartInfo()
            pInfo.FileName = path
            Dim p As Process = Process.Start(pInfo)
            p.WaitForExit()
            My.Computer.FileSystem.DeleteFile(restechFolder & downloadFile)
        Catch ex As Exception
            My.Computer.FileSystem.DeleteFile(restechFolder & downloadFile)
        End Try
    End Sub

    '##################################################################################
    '# Other Functions
    '#
    '# These are functions that the user doesn't interact with.
    '##################################################################################

    '##################################################################################
    '#           fileStarter
    '# Use:      Downloads and runs a program.
    '##################################################################################
    Private Sub fileStarter(ByRef address As String, ByRef file As String, ByRef fileName As String, Optional ByRef scriptName As String = Nothing)
        ' Check the server status before attempting to download.
        pollServer()
        ' Download File
        Try
            My.Computer.Network.DownloadFile(address, file, "", "", True, 10, True)
        Catch ex As Exception
            MsgBox("ResFail #1. Can't Download File")
            Return
        End Try

        startProgram(fileName, scriptName)
    End Sub

    '##################################################################################
    '#           startProgram
    '# Use:      Starts a program.
    '##################################################################################
    Private Sub startProgram(ByVal fileName As String, ByVal scriptName As String)
        '#Taken from fileStarter
        If String.IsNullOrEmpty(scriptName) Then
            ' Setup new Process configs
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo

            ' Script and download storage
            processStartInfo = New System.Diagnostics.ProcessStartInfo()
            processStartInfo.WorkingDirectory = restechFolder
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
            processStartInfo.WorkingDirectory = restechFolder
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
                Process.Start(Environment.CurrentDirectory() & "\Application Files\ResTool_Scripts\" & scriptName)
                System.Diagnostics.Process.Start(processStartInfo_script)
            Catch ex As Exception
                MsgBox("ResFail #4. Can't run the Script")
            End Try
        End If
    End Sub

    '##################################################################################
    '#           findArchitecture
    '# Use:      Detects if it's 32-bit or 64-bit.
    '# Returns:  Architecture type as an int.
    '##################################################################################
    Private Function findArchitecture()
        Dim bit As Integer = 0
        If IntPtr.Size() = 8 Then
            bit = 64
        Else
            bit = 32
        End If
        Return bit
    End Function

    '##################################################################################
    '#           GetOSVersion
    '# Use:      Detects the version of the operating system.
    '# Returns:  Version of the operation system as a string.
    '# ToDo:     Should show service pack information in the future.
    '##################################################################################
    Private Function GetOSVersion()
        Dim osInfo As String = Environment.OSVersion.ToString()
        Dim servicePack As String = Environment.OSVersion.ServicePack
        osInfo = osInfo.Replace("Microsoft Windows NT ", "")
        Dim pos As Integer = osInfo.IndexOf("Service Pack")
        'Dim servicePackInfo As String = osInfo.Substring(pos, 14)
        'servicePackInfo = servicePackInfo.Replace("Service Pack ", "")
        If osInfo.StartsWith("5.1") Then
            Return "Windows XP " & findArchitecture() & "-bit " & servicePack
        ElseIf osInfo.StartsWith("6.0") Then
            Return "Windows Vista " & findArchitecture() & "-bit " & servicePack
        ElseIf osInfo.StartsWith("6.1") Then
            Return "Windows 7 " & findArchitecture() & "-bit " & servicePack
        Else
            Return osInfo
        End If
    End Function

    '##################################################################################
    '#            isInstalled
    '# Use:       This detects if a program is already installed.
    '# Returns:   Yup or Nope
    '# ToDo:      Return something less stupid. <3 U EVAN!
    '##################################################################################
    Private Function isInstalled(ByVal path As String)
        Dim dir As New IO.DirectoryInfo(path)
        If dir.Exists Then
            Return "yup"
        Else
            Return "nope"
        End If
    End Function

    '##################################################################################
    '#        Poll Server
    '# Use:   Checks for an active internet connection, if one exists it finds a server
    '#        that is currently up to download files from.
    '##################################################################################
    Private Sub pollServer()
        If My.Computer.Network.IsAvailable = True Then
            serverSelect = getServer()
            If (serverSelect = "Error") Then
                MsgBox("We were unable to connect to any file severs, please check the internet connection or contact a system administrator.")
            End If
        Else
            MsgBox("Your computer is not connected to the internet, please plug the computer into a light blue ethernet cable and restart ResTool.")
        End If
    End Sub

    '##################################################################################
    '#        getServer
    '# Use:   Sets the server to the first one it's able to connect to.
    '##################################################################################
    Private Function getServer() As String
        Dim server As String
        For Each item In serverList
            Dim url As New System.Uri(item)
            Dim req As System.Net.WebRequest
            req = System.Net.WebRequest.Create(url)
            Dim resp As System.Net.WebResponse
            Try
                resp = req.GetResponse()
                resp.Close()
                req = Nothing
                server = item
                Return item
            Catch ex As Exception
                req = Nothing 'Do nothing
            End Try
        Next
        Return "Error" 'If it's unable to connect, it returns an error.
    End Function

    Private Sub cbTutorial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTutorial.CheckedChanged
        If cbTutorial.Checked = True Then
            MsgBox("Tutorial Mode Enabled." & vbCrLf & "You will not be able to use ResTool to clean the computer until this is unchecked!")
        Else
            MsgBox("Tutorial Mode Disabled." & vbCrLf & "You can now use ResTool to fix the computer.")
        End If
    End Sub
End Class