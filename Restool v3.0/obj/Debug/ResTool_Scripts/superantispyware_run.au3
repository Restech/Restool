;###############  SUPER-ANTI-SPYWARE RUN


WinWaitActive("SUPERAntiSpyware Free Edition", "Scans your computer for Spyware", 15)
ControlClick("SUPERAntiSpyware Free Edition", "Scans your computer for Spyware", "Button11")
WinWaitActive("SUPERAntiSpyware Definition Update", "downloading updates", 15)
sleep(120000)
ControlClick("SUPERAntiSpyware Definition Update", "downloading updates", "Button1")
WinWaitActive("SUPERAntiSpyware Free Edition", "Scans your computer for Spyware", 15)
ControlClick("SUPERAntiSpyware Free Edition", "Scans your computer for Spyware", "Button3")
ControlClick("SUPERAntiSpyware Free Edition", "Scans your computer for Spyware", "Button1")
WinWaitActive("SUPERAntiSpyware Free Edition", "Scans all running items", 15)
ControlClick("SUPERAntiSpyware Free Edition", "Scans all running items", "Button23")
ControlClick("SUPERAntiSpyware Free Edition", "Scans all running items", "Button21")