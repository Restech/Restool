;###############  CCLEANER SCRIPT
	
			WinWaitActive("Installer Language", "Please select a language")
			ControlClick("Installer Language", "Please select a language", "Button1")
			WinWaitActive("CCleaner v2.36 Setup", "Welcome to the")
			ControlClick("CCleaner v2.36 Setup", "Welcome to the", "Button2")
			WinWaitActive("CCleaner v2.36 Setup", "Please review the license")
			ControlClick("CCleaner v2.36 Setup", "Please review the license", "Button2")
			WinWaitActive("CCleaner v2.36 Setup", "Choose the folder")
			Send("{ENTER}")
			WinWaitActive("CCleaner v2.36 Setup", "Select any additional options")
			ControlClick("CCleaner v2.36 Setup", "Select any additional options", "Button8")
			ControlClick("CCleaner v2.36 Setup", "Select any additional options", "Button9")
			ControlClick("CCleaner v2.36 Setup", "Select any additional options", "Button2")
			WinWaitActive("CCleaner v2.36 Setup", "Completing the CCleaner")
			ControlClick("CCleaner v2.36 Setup", "Completing the CCleaner", "Button4")
			ControlClick("CCleaner v2.36 Setup", "Completing the CCleaner", "Button2")
			
