;###############  ESET RUN


WinWaitActive("Terms of use", "End User License", 15)
ControlClick("Terms of use", "End User License", "Button2")
ControlClick("Terms of use", "End User License", "Button1")
WinWaitActive("ESET Online Scanner", "Please click the Start button", 1080)
ControlClick("ESET Online Scanner", "Please click the Start button", "Button12")