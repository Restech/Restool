			WinWaitActive("Windows Resource Kit Tools Setup Wizard", "Welcome to the Windows Resource Kit")
			ControlClick("Windows Resource Kit Tools Setup Wizard", "Welcome to the Windows Resource Kit", "Button1")
			WinWaitActive("Windows Resource Kit Tools Setup Wizard", "END-USER LICENSE AGREEMENT")
			ControlClick("Windows Resource Kit Tools Setup Wizard", "END-USER LICENSE AGREEMENT", "Button2")
			ControlClick("Windows Resource Kit Tools Setup Wizard", "END-USER LICENSE AGREEMENT", "Button4")
			WinWaitActive("Windows Resource Kit Tools Setup Wizard", "Available &space on local hard drives:")
			Send("{ENTER}")
			WinWaitActive("Windows Resource Kit Tools Setup Wizard", "Click Finish to exit the setup wizard.")
			ControlClick("Windows Resource Kit Tools Setup Wizard", "Click Finish to exit the setup wizard.", "Button1")

	