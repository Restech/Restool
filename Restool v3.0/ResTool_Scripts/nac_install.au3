;###############  NAC INSTALL

WinWaitActive("Cisco NAC Agent", "The InstallShield", 15)
ControlClick("Cisco NAC Agent", "The InstallShield", "Button1")
WinWaitActive("Cisco NAC Agent", "Please read the following", 15)
ControlClick("Cisco NAC Agent", "Please read the following", "Button3")
ControlClick("Cisco NAC Agent", "Please read the following", "Button5")
WinWaitActive("Cisco NAC Agent", "Choose the setup type", 15)
ControlClick("Cisco NAC Agent", "Choose the setup type", "Button5")
WinWaitActive("Cisco NAC Agent", "The wizard is ready to begin installation", 15)
ControlClick("Cisco NAC Agent", "The wizard is ready to begin installation", "Button1")
WinWaitActive("Cisco NAC Agent", "The InstallShield Wizard has successfully", 180)
ControlClick("Cisco NAC Agent", "The InstallShield Wizard has successfully", "Button1")