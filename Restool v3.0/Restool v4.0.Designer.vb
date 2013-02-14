<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUI
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
        Me.tabControls = New System.Windows.Forms.TabControl()
        Me.VirusRemoval = New System.Windows.Forms.TabPage()
        Me.WindowsRepair = New System.Windows.Forms.TabPage()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.lblWindowsVersion = New System.Windows.Forms.Label()
        Me.bComboFix = New System.Windows.Forms.Button()
        Me.bMalwarebytes = New System.Windows.Forms.Button()
        Me.Spybot = New System.Windows.Forms.Button()
        Me.bSuperAntiSpyware = New System.Windows.Forms.Button()
        Me.bEset = New System.Windows.Forms.Button()
        Me.bHouseCall = New System.Windows.Forms.Button()
        Me.bMalwarebytesRootkit = New System.Windows.Forms.Button()
        Me.bOTL = New System.Windows.Forms.Button()
        Me.bUninstall = New System.Windows.Forms.Button()
        Me.bMultipleAV = New System.Windows.Forms.Button()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.listServer = New System.Windows.Forms.ComboBox()
        Me.NIUTools = New System.Windows.Forms.TabPage()
        Me.bMSE = New System.Windows.Forms.Button()
        Me.bMcAfee = New System.Windows.Forms.Button()
        Me.bCiscoNAC = New System.Windows.Forms.Button()
        Me.bCisco = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabControls.SuspendLayout()
        Me.VirusRemoval.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.NIUTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControls
        '
        Me.tabControls.Controls.Add(Me.VirusRemoval)
        Me.tabControls.Controls.Add(Me.WindowsRepair)
        Me.tabControls.Controls.Add(Me.Maintenance)
        Me.tabControls.Controls.Add(Me.NIUTools)
        Me.tabControls.Location = New System.Drawing.Point(5, 12)
        Me.tabControls.Name = "tabControls"
        Me.tabControls.SelectedIndex = 0
        Me.tabControls.Size = New System.Drawing.Size(838, 406)
        Me.tabControls.TabIndex = 0
        '
        'VirusRemoval
        '
        Me.VirusRemoval.Controls.Add(Me.bUninstall)
        Me.VirusRemoval.Controls.Add(Me.bOTL)
        Me.VirusRemoval.Controls.Add(Me.bMalwarebytesRootkit)
        Me.VirusRemoval.Controls.Add(Me.bHouseCall)
        Me.VirusRemoval.Controls.Add(Me.bEset)
        Me.VirusRemoval.Controls.Add(Me.bSuperAntiSpyware)
        Me.VirusRemoval.Controls.Add(Me.Spybot)
        Me.VirusRemoval.Controls.Add(Me.bMalwarebytes)
        Me.VirusRemoval.Controls.Add(Me.bComboFix)
        Me.VirusRemoval.Location = New System.Drawing.Point(4, 22)
        Me.VirusRemoval.Name = "VirusRemoval"
        Me.VirusRemoval.Padding = New System.Windows.Forms.Padding(3)
        Me.VirusRemoval.Size = New System.Drawing.Size(830, 380)
        Me.VirusRemoval.TabIndex = 0
        Me.VirusRemoval.Text = "Virus Removal"
        Me.VirusRemoval.UseVisualStyleBackColor = True
        '
        'WindowsRepair
        '
        Me.WindowsRepair.Location = New System.Drawing.Point(4, 22)
        Me.WindowsRepair.Name = "WindowsRepair"
        Me.WindowsRepair.Padding = New System.Windows.Forms.Padding(3)
        Me.WindowsRepair.Size = New System.Drawing.Size(830, 380)
        Me.WindowsRepair.TabIndex = 1
        Me.WindowsRepair.Text = "Windows Repair"
        Me.WindowsRepair.UseVisualStyleBackColor = True
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.bCisco)
        Me.Maintenance.Controls.Add(Me.bMultipleAV)
        Me.Maintenance.Location = New System.Drawing.Point(4, 22)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Size = New System.Drawing.Size(830, 380)
        Me.Maintenance.TabIndex = 2
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'lblWindowsVersion
        '
        Me.lblWindowsVersion.AutoSize = True
        Me.lblWindowsVersion.Location = New System.Drawing.Point(2, 425)
        Me.lblWindowsVersion.Name = "lblWindowsVersion"
        Me.lblWindowsVersion.Size = New System.Drawing.Size(103, 13)
        Me.lblWindowsVersion.TabIndex = 1
        Me.lblWindowsVersion.Text = "Version Of Windows"
        '
        'bComboFix
        '
        Me.bComboFix.Location = New System.Drawing.Point(7, 7)
        Me.bComboFix.Name = "bComboFix"
        Me.bComboFix.Size = New System.Drawing.Size(128, 35)
        Me.bComboFix.TabIndex = 0
        Me.bComboFix.Text = "Combo Fix"
        Me.bComboFix.UseVisualStyleBackColor = True
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
        'Spybot
        '
        Me.Spybot.Location = New System.Drawing.Point(7, 93)
        Me.Spybot.Name = "Spybot"
        Me.Spybot.Size = New System.Drawing.Size(128, 35)
        Me.Spybot.TabIndex = 2
        Me.Spybot.Text = "Spybot"
        Me.Spybot.UseVisualStyleBackColor = True
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
        'bEset
        '
        Me.bEset.Location = New System.Drawing.Point(7, 175)
        Me.bEset.Name = "bEset"
        Me.bEset.Size = New System.Drawing.Size(128, 35)
        Me.bEset.TabIndex = 4
        Me.bEset.Text = "Eset Online Scanner"
        Me.bEset.UseVisualStyleBackColor = True
        '
        'bHouseCall
        '
        Me.bHouseCall.Location = New System.Drawing.Point(7, 216)
        Me.bHouseCall.Name = "bHouseCall"
        Me.bHouseCall.Size = New System.Drawing.Size(128, 35)
        Me.bHouseCall.TabIndex = 5
        Me.bHouseCall.Text = "Trend Micro Housecall"
        Me.bHouseCall.UseVisualStyleBackColor = True
        '
        'bMalwarebytesRootkit
        '
        Me.bMalwarebytesRootkit.Location = New System.Drawing.Point(7, 257)
        Me.bMalwarebytesRootkit.Name = "bMalwarebytesRootkit"
        Me.bMalwarebytesRootkit.Size = New System.Drawing.Size(128, 35)
        Me.bMalwarebytesRootkit.TabIndex = 6
        Me.bMalwarebytesRootkit.Text = "Malwarebytes Anti-Rootkit"
        Me.bMalwarebytesRootkit.UseVisualStyleBackColor = True
        '
        'bOTL
        '
        Me.bOTL.Location = New System.Drawing.Point(7, 298)
        Me.bOTL.Name = "bOTL"
        Me.bOTL.Size = New System.Drawing.Size(128, 35)
        Me.bOTL.TabIndex = 7
        Me.bOTL.Text = "OTL by OldTimer"
        Me.bOTL.UseVisualStyleBackColor = True
        '
        'bUninstall
        '
        Me.bUninstall.Location = New System.Drawing.Point(7, 339)
        Me.bUninstall.Name = "bUninstall"
        Me.bUninstall.Size = New System.Drawing.Size(128, 35)
        Me.bUninstall.TabIndex = 8
        Me.bUninstall.Text = "Uninstall Removal Tools"
        Me.bUninstall.UseVisualStyleBackColor = True
        '
        'bMultipleAV
        '
        Me.bMultipleAV.Location = New System.Drawing.Point(7, 7)
        Me.bMultipleAV.Name = "bMultipleAV"
        Me.bMultipleAV.Size = New System.Drawing.Size(128, 35)
        Me.bMultipleAV.TabIndex = 6
        Me.bMultipleAV.Text = "Multiple Antivirus Check"
        Me.bMultipleAV.UseVisualStyleBackColor = True
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Location = New System.Drawing.Point(2, 445)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(44, 13)
        Me.lblMemory.TabIndex = 2
        Me.lblMemory.Text = "Memory"
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.Location = New System.Drawing.Point(2, 465)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(29, 13)
        Me.lblCPU.TabIndex = 3
        Me.lblCPU.Text = "CPU"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(2, 485)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(58, 13)
        Me.lblIP.TabIndex = 4
        Me.lblIP.Text = "IP Address"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(2, 505)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(38, 13)
        Me.lblServer.TabIndex = 5
        Me.lblServer.Text = "Server"
        '
        'listServer
        '
        Me.listServer.FormattingEnabled = True
        Me.listServer.Location = New System.Drawing.Point(46, 505)
        Me.listServer.MaxDropDownItems = 2
        Me.listServer.Name = "listServer"
        Me.listServer.Size = New System.Drawing.Size(121, 21)
        Me.listServer.TabIndex = 17
        '
        'NIUTools
        '
        Me.NIUTools.Controls.Add(Me.bCiscoNAC)
        Me.NIUTools.Controls.Add(Me.bMcAfee)
        Me.NIUTools.Controls.Add(Me.bMSE)
        Me.NIUTools.Location = New System.Drawing.Point(4, 22)
        Me.NIUTools.Name = "NIUTools"
        Me.NIUTools.Padding = New System.Windows.Forms.Padding(3)
        Me.NIUTools.Size = New System.Drawing.Size(830, 380)
        Me.NIUTools.TabIndex = 3
        Me.NIUTools.Text = "NIU Tools"
        Me.NIUTools.UseVisualStyleBackColor = True
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
        'bMcAfee
        '
        Me.bMcAfee.Location = New System.Drawing.Point(7, 48)
        Me.bMcAfee.Name = "bMcAfee"
        Me.bMcAfee.Size = New System.Drawing.Size(128, 35)
        Me.bMcAfee.TabIndex = 8
        Me.bMcAfee.Text = "NIU McAfee Install"
        Me.bMcAfee.UseVisualStyleBackColor = True
        '
        'bCiscoNAC
        '
        Me.bCiscoNAC.Location = New System.Drawing.Point(7, 89)
        Me.bCiscoNAC.Name = "bCiscoNAC"
        Me.bCiscoNAC.Size = New System.Drawing.Size(128, 35)
        Me.bCiscoNAC.TabIndex = 9
        Me.bCiscoNAC.Text = "Cisco NAC"
        Me.bCiscoNAC.UseVisualStyleBackColor = True
        '
        'bCisco
        '
        Me.bCisco.Location = New System.Drawing.Point(7, 48)
        Me.bCisco.Name = "bCisco"
        Me.bCisco.Size = New System.Drawing.Size(128, 35)
        Me.bCisco.TabIndex = 8
        Me.bCisco.Text = "CCleaner"
        Me.bCisco.UseVisualStyleBackColor = True
        '
        'NewUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 528)
        Me.Controls.Add(Me.listServer)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblCPU)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblWindowsVersion)
        Me.Controls.Add(Me.tabControls)
        Me.Name = "NewUI"
        Me.Text = "ResTool New UI"
        Me.tabControls.ResumeLayout(False)
        Me.VirusRemoval.ResumeLayout(False)
        Me.Maintenance.ResumeLayout(False)
        Me.NIUTools.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControls As System.Windows.Forms.TabControl
    Friend WithEvents VirusRemoval As System.Windows.Forms.TabPage
    Friend WithEvents WindowsRepair As System.Windows.Forms.TabPage
    Friend WithEvents Maintenance As System.Windows.Forms.TabPage
    Friend WithEvents lblWindowsVersion As System.Windows.Forms.Label
    Friend WithEvents Spybot As System.Windows.Forms.Button
    Friend WithEvents bMalwarebytes As System.Windows.Forms.Button
    Friend WithEvents bComboFix As System.Windows.Forms.Button
    Friend WithEvents bEset As System.Windows.Forms.Button
    Friend WithEvents bSuperAntiSpyware As System.Windows.Forms.Button
    Friend WithEvents bHouseCall As System.Windows.Forms.Button
    Friend WithEvents bOTL As System.Windows.Forms.Button
    Friend WithEvents bMalwarebytesRootkit As System.Windows.Forms.Button
    Friend WithEvents bUninstall As System.Windows.Forms.Button
    Friend WithEvents bMultipleAV As System.Windows.Forms.Button
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents listServer As System.Windows.Forms.ComboBox
    Friend WithEvents NIUTools As System.Windows.Forms.TabPage
    Friend WithEvents bMcAfee As System.Windows.Forms.Button
    Friend WithEvents bMSE As System.Windows.Forms.Button
    Friend WithEvents bCisco As System.Windows.Forms.Button
    Friend WithEvents bCiscoNAC As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
