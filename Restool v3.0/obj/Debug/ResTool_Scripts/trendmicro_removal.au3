;###############  TREND MICRO REMOVAL TOOL
WinWaitActive("Trend Micro Diagnostic Toolkit", "Select which troubleshooting data")
ControlClick("Trend Micro Diagnostic Toolkit", "Select which troubleshooting data", "SysTabControl321")
ControlClick("Trend Micro Diagnostic Toolkit", "Delete the security update files from this computer", "Button7")
ControlClick("Trend Micro Diagnostic Toolkit", "You are about to uninstall the software", "Button1")
WinWaitActive("Trend Micro Diagnostic Toolkit", "You must restart your computer")
ControlClick("Trend Micro Diagnostic Toolkit", "You must restart your computer", "Button1")