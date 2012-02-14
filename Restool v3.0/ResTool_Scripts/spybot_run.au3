;###############  SPYBOT RUN
WinWaitActive("Uninstall Application", "You have chosen to uninstall")
				ControlClick("Uninstall Application", "You have chosen to uninstall", "Button1")
				WinWaitActive("Spybot - Search & Destroy Uninstall", "If you just want")
				ControlClick("Spybot - Search & Destroy Uninstall", "If you just want", "Button1")
				WinWaitActive("Spybot - Search & Destroy Uninstall", "Some elements could not be")
				Send("{ENTER}")
				Sleep(1000)
				Send("{ENTER}")

