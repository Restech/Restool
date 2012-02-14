;###############  NORTON REMOVAL TOOL
WinWaitActive("Norton Removal Tool", "This tool will stop")
ControlClick("Norton Removal Tool", "This tool will stop", "Button2")
WinWaitActive("Norton Removal Tool", "Licensing")
ControlClick("Norton Removal Tool", "Licensing", "Button1")
ControlClick("Norton Removal Tool", "Licensing", "Button4")