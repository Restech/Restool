<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResTool))
        Me.tabControls = New System.Windows.Forms.TabControl()
        Me.VirusRemoval = New System.Windows.Forms.TabPage()
        Me.bSophosAV = New System.Windows.Forms.Button()
        Me.wbVirusRemoval = New System.Windows.Forms.WebBrowser()
        Me.bUninstall = New System.Windows.Forms.Button()
        Me.bHousecall = New System.Windows.Forms.Button()
        Me.bEset = New System.Windows.Forms.Button()
        Me.bSuperAntiSpyware = New System.Windows.Forms.Button()
        Me.bSpybot = New System.Windows.Forms.Button()
        Me.bMalwarebytes = New System.Windows.Forms.Button()
        Me.bComboFix = New System.Windows.Forms.Button()
        Me.Rootkit = New System.Windows.Forms.TabPage()
        Me.wbRootkit = New System.Windows.Forms.WebBrowser()
        Me.bSophos = New System.Windows.Forms.Button()
        Me.bTDSS = New System.Windows.Forms.Button()
        Me.bMalwarebytesRootkit = New System.Windows.Forms.Button()
        Me.NIUTools = New System.Windows.Forms.TabPage()
        Me.bNIUwireless = New System.Windows.Forms.Button()
        Me.wbNIU = New System.Windows.Forms.WebBrowser()
        Me.bRemoveCiscoNAC = New System.Windows.Forms.Button()
        Me.bCiscoNAC = New System.Windows.Forms.Button()
        Me.bMcAfee = New System.Windows.Forms.Button()
        Me.bMSE = New System.Windows.Forms.Button()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.bMSCONFIG = New System.Windows.Forms.Button()
        Me.wbMaintenance = New System.Windows.Forms.WebBrowser()
        Me.bCCleaner = New System.Windows.Forms.Button()
        Me.WindowsRepair = New System.Windows.Forms.TabPage()
        Me.bWindowAIO = New System.Windows.Forms.Button()
        Me.wbWindowsRepair = New System.Windows.Forms.WebBrowser()
        Me.bFixIt = New System.Windows.Forms.Button()
        Me.bSFC = New System.Windows.Forms.Button()
        Me.AVRemoval = New System.Windows.Forms.TabPage()
        Me.bKasperskyRemoval = New System.Windows.Forms.Button()
        Me.bAvastRemoval = New System.Windows.Forms.Button()
        Me.bTrendRemoval = New System.Windows.Forms.Button()
        Me.bAVGRemoval = New System.Windows.Forms.Button()
        Me.bMcAfeeRemoval = New System.Windows.Forms.Button()
        Me.bNortonRemoval = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.bMultipleAV = New System.Windows.Forms.Button()
        Me.lblWindowsVersion = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.cbTutorial = New System.Windows.Forms.CheckBox()
        Me.tabControls.SuspendLayout()
        Me.VirusRemoval.SuspendLayout()
        Me.Rootkit.SuspendLayout()
        Me.NIUTools.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.WindowsRepair.SuspendLayout()
        Me.AVRemoval.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControls
        '
        Me.tabControls.Controls.Add(Me.VirusRemoval)
        Me.tabControls.Controls.Add(Me.Rootkit)
        Me.tabControls.Controls.Add(Me.NIUTools)
        Me.tabControls.Controls.Add(Me.Maintenance)
        Me.tabControls.Controls.Add(Me.WindowsRepair)
        Me.tabControls.Controls.Add(Me.AVRemoval)
        Me.tabControls.Location = New System.Drawing.Point(5, 12)
        Me.tabControls.Name = "tabControls"
        Me.tabControls.SelectedIndex = 0
        Me.tabControls.Size = New System.Drawing.Size(973, 464)
        Me.tabControls.TabIndex = 0
        '
        'VirusRemoval
        '
        Me.VirusRemoval.Controls.Add(Me.bSophosAV)
        Me.VirusRemoval.Controls.Add(Me.wbVirusRemoval)
        Me.VirusRemoval.Controls.Add(Me.bUninstall)
        Me.VirusRemoval.Controls.Add(Me.bHousecall)
        Me.VirusRemoval.Controls.Add(Me.bEset)
        Me.VirusRemoval.Controls.Add(Me.bSuperAntiSpyware)
        Me.VirusRemoval.Controls.Add(Me.bSpybot)
        Me.VirusRemoval.Controls.Add(Me.bMalwarebytes)
        Me.VirusRemoval.Controls.Add(Me.bComboFix)
        Me.VirusRemoval.Location = New System.Drawing.Point(4, 22)
        Me.VirusRemoval.Name = "VirusRemoval"
        Me.VirusRemoval.Padding = New System.Windows.Forms.Padding(3)
        Me.VirusRemoval.Size = New System.Drawing.Size(965, 438)
        Me.VirusRemoval.TabIndex = 0
        Me.VirusRemoval.Text = "Virus Removal"
        Me.VirusRemoval.UseVisualStyleBackColor = True
        '
        'bSophosAV
        '
        Me.bSophosAV.Location = New System.Drawing.Point(8, 257)
        Me.bSophosAV.Name = "bSophosAV"
        Me.bSophosAV.Size = New System.Drawing.Size(128, 35)
        Me.bSophosAV.TabIndex = 10
        Me.bSophosAV.Text = "Sophos AV"
        Me.bSophosAV.UseVisualStyleBackColor = True
        '
        'wbVirusRemoval
        '
        Me.wbVirusRemoval.Location = New System.Drawing.Point(142, 7)
        Me.wbVirusRemoval.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbVirusRemoval.Name = "wbVirusRemoval"
        Me.wbVirusRemoval.Size = New System.Drawing.Size(817, 425)
        Me.wbVirusRemoval.TabIndex = 9
        Me.wbVirusRemoval.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bUninstall
        '
        Me.bUninstall.Location = New System.Drawing.Point(8, 298)
        Me.bUninstall.Name = "bUninstall"
        Me.bUninstall.Size = New System.Drawing.Size(128, 35)
        Me.bUninstall.TabIndex = 8
        Me.bUninstall.Text = "Uninstall Removal Tools"
        Me.bUninstall.UseVisualStyleBackColor = True
        '
        'bHousecall
        '
        Me.bHousecall.Location = New System.Drawing.Point(7, 216)
        Me.bHousecall.Name = "bHousecall"
        Me.bHousecall.Size = New System.Drawing.Size(128, 35)
        Me.bHousecall.TabIndex = 5
        Me.bHousecall.Text = "Trend Micro Housecall"
        Me.bHousecall.UseVisualStyleBackColor = True
        '
        'bEset
        '
        Me.bEset.Location = New System.Drawing.Point(7, 175)
        Me.bEset.Name = "bEset"
        Me.bEset.Size = New System.Drawing.Size(128, 35)
        Me.bEset.TabIndex = 4
        Me.bEset.Text = "Eset Online Scanner"
        Me.bEset.UseVisualStyleBackColor = True
        '
        'bSuperAntiSpyware
        '
        Me.bSuperAntiSpyware.Location = New System.Drawing.Point(7, 134)
        Me.bSuperAntiSpyware.Name = "bSuperAntiSpyware"
        Me.bSuperAntiSpyware.Size = New System.Drawing.Size(128, 35)
        Me.bSuperAntiSpyware.TabIndex = 3
        Me.bSuperAntiSpyware.Text = "SuperAntiSpyware"
        Me.bSuperAntiSpyware.UseVisualStyleBackColor = True
        '
        'bSpybot
        '
        Me.bSpybot.Location = New System.Drawing.Point(7, 93)
        Me.bSpybot.Name = "bSpybot"
        Me.bSpybot.Size = New System.Drawing.Size(128, 35)
        Me.bSpybot.TabIndex = 2
        Me.bSpybot.Text = "Spybot"
        Me.bSpybot.UseVisualStyleBackColor = True
        '
        'bMalwarebytes
        '
        Me.bMalwarebytes.Location = New System.Drawing.Point(7, 48)
        Me.bMalwarebytes.Name = "bMalwarebytes"
        Me.bMalwarebytes.Size = New System.Drawing.Size(128, 39)
        Me.bMalwarebytes.TabIndex = 1
        Me.bMalwarebytes.Text = "Malwarebytes"
        Me.bMalwarebytes.UseVisualStyleBackColor = True
        '
        'bComboFix
        '
        Me.bComboFix.Location = New System.Drawing.Point(7, 7)
        Me.bComboFix.Name = "bComboFix"
        Me.bComboFix.Size = New System.Drawing.Size(129, 35)
        Me.bComboFix.TabIndex = 0
        Me.bComboFix.Text = "Combo Fix"
        Me.bComboFix.UseVisualStyleBackColor = True
        '
        'Rootkit
        '
        Me.Rootkit.Controls.Add(Me.wbRootkit)
        Me.Rootkit.Controls.Add(Me.bSophos)
        Me.Rootkit.Controls.Add(Me.bTDSS)
        Me.Rootkit.Controls.Add(Me.bMalwarebytesRootkit)
        Me.Rootkit.Location = New System.Drawing.Point(4, 22)
        Me.Rootkit.Name = "Rootkit"
        Me.Rootkit.Size = New System.Drawing.Size(965, 438)
        Me.Rootkit.TabIndex = 4
        Me.Rootkit.Text = "Rootkit"
        Me.Rootkit.UseVisualStyleBackColor = True
        '
        'wbRootkit
        '
        Me.wbRootkit.Location = New System.Drawing.Point(141, 7)
        Me.wbRootkit.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRootkit.Name = "wbRootkit"
        Me.wbRootkit.Size = New System.Drawing.Size(817, 425)
        Me.wbRootkit.TabIndex = 10
        Me.wbRootkit.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bSophos
        '
        Me.bSophos.Location = New System.Drawing.Point(7, 89)
        Me.bSophos.Name = "bSophos"
        Me.bSophos.Size = New System.Drawing.Size(128, 35)
        Me.bSophos.TabIndex = 9
        Me.bSophos.Text = "Sophos"
        Me.bSophos.UseVisualStyleBackColor = True
        '
        'bTDSS
        '
        Me.bTDSS.Location = New System.Drawing.Point(7, 48)
        Me.bTDSS.Name = "bTDSS"
        Me.bTDSS.Size = New System.Drawing.Size(128, 35)
        Me.bTDSS.TabIndex = 8
        Me.bTDSS.Text = "TDSS"
        Me.bTDSS.UseVisualStyleBackColor = True
        '
        'bMalwarebytesRootkit
        '
        Me.bMalwarebytesRootkit.Location = New System.Drawing.Point(7, 7)
        Me.bMalwarebytesRootkit.Name = "bMalwarebytesRootkit"
        Me.bMalwarebytesRootkit.Size = New System.Drawing.Size(128, 35)
        Me.bMalwarebytesRootkit.TabIndex = 7
        Me.bMalwarebytesRootkit.Text = "Malwarebytes Anti-Rootkit"
        Me.bMalwarebytesRootkit.UseVisualStyleBackColor = True
        '
        'NIUTools
        '
        Me.NIUTools.Controls.Add(Me.bNIUwireless)
        Me.NIUTools.Controls.Add(Me.wbNIU)
        Me.NIUTools.Controls.Add(Me.bRemoveCiscoNAC)
        Me.NIUTools.Controls.Add(Me.bCiscoNAC)
        Me.NIUTools.Controls.Add(Me.bMcAfee)
        Me.NIUTools.Controls.Add(Me.bMSE)
        Me.NIUTools.Location = New System.Drawing.Point(4, 22)
        Me.NIUTools.Name = "NIUTools"
        Me.NIUTools.Padding = New System.Windows.Forms.Padding(3)
        Me.NIUTools.Size = New System.Drawing.Size(965, 438)
        Me.NIUTools.TabIndex = 3
        Me.NIUTools.Text = "NIU Tools"
        Me.NIUTools.UseVisualStyleBackColor = True
        '
        'bNIUwireless
        '
        Me.bNIUwireless.Location = New System.Drawing.Point(8, 171)
        Me.bNIUwireless.Name = "bNIUwireless"
        Me.bNIUwireless.Size = New System.Drawing.Size(128, 35)
        Me.bNIUwireless.TabIndex = 12
        Me.bNIUwireless.Text = "Setup NIUwireless"
        Me.bNIUwireless.UseVisualStyleBackColor = True
        '
        'wbNIU
        '
        Me.wbNIU.Location = New System.Drawing.Point(142, 6)
        Me.wbNIU.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbNIU.Name = "wbNIU"
        Me.wbNIU.Size = New System.Drawing.Size(817, 425)
        Me.wbNIU.TabIndex = 11
        Me.wbNIU.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bRemoveCiscoNAC
        '
        Me.bRemoveCiscoNAC.Location = New System.Drawing.Point(7, 130)
        Me.bRemoveCiscoNAC.Name = "bRemoveCiscoNAC"
        Me.bRemoveCiscoNAC.Size = New System.Drawing.Size(128, 35)
        Me.bRemoveCiscoNAC.TabIndex = 10
        Me.bRemoveCiscoNAC.Text = "Cisco NAC Removal"
        Me.bRemoveCiscoNAC.UseVisualStyleBackColor = True
        '
        'bCiscoNAC
        '
        Me.bCiscoNAC.Location = New System.Drawing.Point(7, 89)
        Me.bCiscoNAC.Name = "bCiscoNAC"
        Me.bCiscoNAC.Size = New System.Drawing.Size(128, 35)
        Me.bCiscoNAC.TabIndex = 9
        Me.bCiscoNAC.Text = "Cisco NAC Install"
        Me.bCiscoNAC.UseVisualStyleBackColor = True
        '
        'bMcAfee
        '
        Me.bMcAfee.Location = New System.Drawing.Point(7, 48)
        Me.bMcAfee.Name = "bMcAfee"
        Me.bMcAfee.Size = New System.Drawing.Size(128, 35)
        Me.bMcAfee.TabIndex = 8
        Me.bMcAfee.Text = "NIU McAfee Install"
        Me.bMcAfee.UseVisualStyleBackColor = True
        '
        'bMSE
        '
        Me.bMSE.Location = New System.Drawing.Point(7, 7)
        Me.bMSE.Name = "bMSE"
        Me.bMSE.Size = New System.Drawing.Size(128, 35)
        Me.bMSE.TabIndex = 7
        Me.bMSE.Text = "Microsoft Security Essentials"
        Me.bMSE.UseVisualStyleBackColor = True
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.bMSCONFIG)
        Me.Maintenance.Controls.Add(Me.wbMaintenance)
        Me.Maintenance.Controls.Add(Me.bCCleaner)
        Me.Maintenance.Location = New System.Drawing.Point(4, 22)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Size = New System.Drawing.Size(965, 438)
        Me.Maintenance.TabIndex = 2
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'bMSCONFIG
        '
        Me.bMSCONFIG.Location = New System.Drawing.Point(7, 48)
        Me.bMSCONFIG.Name = "bMSCONFIG"
        Me.bMSCONFIG.Size = New System.Drawing.Size(128, 35)
        Me.bMSCONFIG.TabIndex = 11
        Me.bMSCONFIG.Text = "MSConfig"
        Me.bMSCONFIG.UseVisualStyleBackColor = True
        '
        'wbMaintenance
        '
        Me.wbMaintenance.Location = New System.Drawing.Point(141, 7)
        Me.wbMaintenance.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMaintenance.Name = "wbMaintenance"
        Me.wbMaintenance.Size = New System.Drawing.Size(817, 425)
        Me.wbMaintenance.TabIndex = 10
        Me.wbMaintenance.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bCCleaner
        '
        Me.bCCleaner.Location = New System.Drawing.Point(7, 7)
        Me.bCCleaner.Name = "bCCleaner"
        Me.bCCleaner.Size = New System.Drawing.Size(128, 35)
        Me.bCCleaner.TabIndex = 8
        Me.bCCleaner.Text = "CCleaner"
        Me.bCCleaner.UseVisualStyleBackColor = True
        '
        'WindowsRepair
        '
        Me.WindowsRepair.Controls.Add(Me.bWindowAIO)
        Me.WindowsRepair.Controls.Add(Me.wbWindowsRepair)
        Me.WindowsRepair.Controls.Add(Me.bFixIt)
        Me.WindowsRepair.Controls.Add(Me.bSFC)
        Me.WindowsRepair.Location = New System.Drawing.Point(4, 22)
        Me.WindowsRepair.Name = "WindowsRepair"
        Me.WindowsRepair.Padding = New System.Windows.Forms.Padding(3)
        Me.WindowsRepair.Size = New System.Drawing.Size(965, 438)
        Me.WindowsRepair.TabIndex = 1
        Me.WindowsRepair.Text = "Windows Repair"
        Me.WindowsRepair.UseVisualStyleBackColor = True
        '
        'bWindowAIO
        '
        Me.bWindowAIO.Location = New System.Drawing.Point(7, 89)
        Me.bWindowAIO.Name = "bWindowAIO"
        Me.bWindowAIO.Size = New System.Drawing.Size(128, 35)
        Me.bWindowAIO.TabIndex = 12
        Me.bWindowAIO.Text = "All In One Repair"
        Me.bWindowAIO.UseVisualStyleBackColor = True
        '
        'wbWindowsRepair
        '
        Me.wbWindowsRepair.Location = New System.Drawing.Point(141, 7)
        Me.wbWindowsRepair.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbWindowsRepair.Name = "wbWindowsRepair"
        Me.wbWindowsRepair.Size = New System.Drawing.Size(817, 425)
        Me.wbWindowsRepair.TabIndex = 11
        Me.wbWindowsRepair.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bFixIt
        '
        Me.bFixIt.Location = New System.Drawing.Point(7, 48)
        Me.bFixIt.Name = "bFixIt"
        Me.bFixIt.Size = New System.Drawing.Size(128, 35)
        Me.bFixIt.TabIndex = 10
        Me.bFixIt.Text = "Microsoft Fix It"
        Me.bFixIt.UseVisualStyleBackColor = True
        '
        'bSFC
        '
        Me.bSFC.Location = New System.Drawing.Point(7, 7)
        Me.bSFC.Name = "bSFC"
        Me.bSFC.Size = New System.Drawing.Size(128, 35)
        Me.bSFC.TabIndex = 9
        Me.bSFC.Text = "System File Checker"
        Me.bSFC.UseVisualStyleBackColor = True
        '
        'AVRemoval
        '
        Me.AVRemoval.Controls.Add(Me.bKasperskyRemoval)
        Me.AVRemoval.Controls.Add(Me.bAvastRemoval)
        Me.AVRemoval.Controls.Add(Me.bTrendRemoval)
        Me.AVRemoval.Controls.Add(Me.bAVGRemoval)
        Me.AVRemoval.Controls.Add(Me.bMcAfeeRemoval)
        Me.AVRemoval.Controls.Add(Me.bNortonRemoval)
        Me.AVRemoval.Controls.Add(Me.WebBrowser1)
        Me.AVRemoval.Controls.Add(Me.bMultipleAV)
        Me.AVRemoval.Location = New System.Drawing.Point(4, 22)
        Me.AVRemoval.Name = "AVRemoval"
        Me.AVRemoval.Size = New System.Drawing.Size(965, 438)
        Me.AVRemoval.TabIndex = 5
        Me.AVRemoval.Text = "Anti Virus Removal"
        Me.AVRemoval.UseVisualStyleBackColor = True
        '
        'bKasperskyRemoval
        '
        Me.bKasperskyRemoval.Location = New System.Drawing.Point(7, 253)
        Me.bKasperskyRemoval.Name = "bKasperskyRemoval"
        Me.bKasperskyRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bKasperskyRemoval.TabIndex = 18
        Me.bKasperskyRemoval.Text = "Kaspersky"
        Me.bKasperskyRemoval.UseVisualStyleBackColor = True
        '
        'bAvastRemoval
        '
        Me.bAvastRemoval.Location = New System.Drawing.Point(7, 212)
        Me.bAvastRemoval.Name = "bAvastRemoval"
        Me.bAvastRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bAvastRemoval.TabIndex = 17
        Me.bAvastRemoval.Text = "Avast"
        Me.bAvastRemoval.UseVisualStyleBackColor = True
        '
        'bTrendRemoval
        '
        Me.bTrendRemoval.Location = New System.Drawing.Point(7, 171)
        Me.bTrendRemoval.Name = "bTrendRemoval"
        Me.bTrendRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bTrendRemoval.TabIndex = 16
        Me.bTrendRemoval.Text = "Trend Micro"
        Me.bTrendRemoval.UseVisualStyleBackColor = True
        '
        'bAVGRemoval
        '
        Me.bAVGRemoval.Location = New System.Drawing.Point(7, 130)
        Me.bAVGRemoval.Name = "bAVGRemoval"
        Me.bAVGRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bAVGRemoval.TabIndex = 15
        Me.bAVGRemoval.Text = "AVG"
        Me.bAVGRemoval.UseVisualStyleBackColor = True
        '
        'bMcAfeeRemoval
        '
        Me.bMcAfeeRemoval.Location = New System.Drawing.Point(7, 89)
        Me.bMcAfeeRemoval.Name = "bMcAfeeRemoval"
        Me.bMcAfeeRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bMcAfeeRemoval.TabIndex = 14
        Me.bMcAfeeRemoval.Text = "McAfee"
        Me.bMcAfeeRemoval.UseVisualStyleBackColor = True
        '
        'bNortonRemoval
        '
        Me.bNortonRemoval.Location = New System.Drawing.Point(7, 48)
        Me.bNortonRemoval.Name = "bNortonRemoval"
        Me.bNortonRemoval.Size = New System.Drawing.Size(128, 35)
        Me.bNortonRemoval.TabIndex = 13
        Me.bNortonRemoval.Text = "Norton"
        Me.bNortonRemoval.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(141, 7)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(817, 425)
        Me.WebBrowser1.TabIndex = 12
        Me.WebBrowser1.Url = New System.Uri("http://intranet.restech.niu.edu", System.UriKind.Absolute)
        '
        'bMultipleAV
        '
        Me.bMultipleAV.Location = New System.Drawing.Point(7, 7)
        Me.bMultipleAV.Name = "bMultipleAV"
        Me.bMultipleAV.Size = New System.Drawing.Size(128, 35)
        Me.bMultipleAV.TabIndex = 7
        Me.bMultipleAV.Text = "Multiple Antivirus Check"
        Me.bMultipleAV.UseVisualStyleBackColor = True
        '
        'lblWindowsVersion
        '
        Me.lblWindowsVersion.AutoSize = True
        Me.lblWindowsVersion.Location = New System.Drawing.Point(2, 479)
        Me.lblWindowsVersion.Name = "lblWindowsVersion"
        Me.lblWindowsVersion.Size = New System.Drawing.Size(103, 13)
        Me.lblWindowsVersion.TabIndex = 1
        Me.lblWindowsVersion.Text = "Version Of Windows"
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Location = New System.Drawing.Point(2, 499)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(44, 13)
        Me.lblMemory.TabIndex = 2
        Me.lblMemory.Text = "Memory"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(2, 521)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(58, 13)
        Me.lblIP.TabIndex = 4
        Me.lblIP.Text = "IP Address"
        '
        'cbTutorial
        '
        Me.cbTutorial.AutoSize = True
        Me.cbTutorial.Location = New System.Drawing.Point(887, 11)
        Me.cbTutorial.Name = "cbTutorial"
        Me.cbTutorial.Size = New System.Drawing.Size(91, 17)
        Me.cbTutorial.TabIndex = 13
        Me.cbTutorial.Text = "Tutorial Mode"
        Me.cbTutorial.UseVisualStyleBackColor = True
        '
        'ResTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 542)
        Me.Controls.Add(Me.cbTutorial)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblWindowsVersion)
        Me.Controls.Add(Me.tabControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResTool"
        Me.Text = "ResTool v4.0 - Extreme Beta, Things Will Break"
        Me.tabControls.ResumeLayout(False)
        Me.VirusRemoval.ResumeLayout(False)
        Me.Rootkit.ResumeLayout(False)
        Me.NIUTools.ResumeLayout(False)
        Me.Maintenance.ResumeLayout(False)
        Me.WindowsRepair.ResumeLayout(False)
        Me.AVRemoval.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControls As System.Windows.Forms.TabControl
    Friend WithEvents VirusRemoval As System.Windows.Forms.TabPage
    Friend WithEvents WindowsRepair As System.Windows.Forms.TabPage
    Friend WithEvents Maintenance As System.Windows.Forms.TabPage
    Friend WithEvents lblWindowsVersion As System.Windows.Forms.Label
    Friend WithEvents bSpybot As System.Windows.Forms.Button
    Friend WithEvents bMalwarebytes As System.Windows.Forms.Button
    Friend WithEvents bComboFix As System.Windows.Forms.Button
    Friend WithEvents bEset As System.Windows.Forms.Button
    Friend WithEvents bSuperAntiSpyware As System.Windows.Forms.Button
    Friend WithEvents bHousecall As System.Windows.Forms.Button
    Friend WithEvents bUninstall As System.Windows.Forms.Button
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents NIUTools As System.Windows.Forms.TabPage
    Friend WithEvents bMcAfee As System.Windows.Forms.Button
    Friend WithEvents bMSE As System.Windows.Forms.Button
    Friend WithEvents bCCleaner As System.Windows.Forms.Button
    Friend WithEvents bCiscoNAC As System.Windows.Forms.Button
    Friend WithEvents wbVirusRemoval As System.Windows.Forms.WebBrowser
    Friend WithEvents Rootkit As System.Windows.Forms.TabPage
    Friend WithEvents bMalwarebytesRootkit As System.Windows.Forms.Button
    Friend WithEvents bSophos As System.Windows.Forms.Button
    Friend WithEvents bTDSS As System.Windows.Forms.Button
    Friend WithEvents bSophosAV As System.Windows.Forms.Button
    Friend WithEvents bRemoveCiscoNAC As System.Windows.Forms.Button
    Friend WithEvents AVRemoval As System.Windows.Forms.TabPage
    Friend WithEvents bMultipleAV As System.Windows.Forms.Button
    Friend WithEvents bFixIt As System.Windows.Forms.Button
    Friend WithEvents wbWindowsRepair As System.Windows.Forms.WebBrowser
    Friend WithEvents wbRootkit As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents wbNIU As System.Windows.Forms.WebBrowser
    Friend WithEvents wbMaintenance As System.Windows.Forms.WebBrowser
    Friend WithEvents bNIUwireless As System.Windows.Forms.Button
    Friend WithEvents bNortonRemoval As System.Windows.Forms.Button
    Friend WithEvents bMcAfeeRemoval As System.Windows.Forms.Button
    Friend WithEvents bAVGRemoval As System.Windows.Forms.Button
    Friend WithEvents bTrendRemoval As System.Windows.Forms.Button
    Friend WithEvents bAvastRemoval As System.Windows.Forms.Button
    Friend WithEvents bKasperskyRemoval As System.Windows.Forms.Button
    Friend WithEvents bSFC As System.Windows.Forms.Button
    Friend WithEvents bMSCONFIG As System.Windows.Forms.Button
    Friend WithEvents bWindowAIO As System.Windows.Forms.Button
    Friend WithEvents cbTutorial As System.Windows.Forms.CheckBox
End Class
