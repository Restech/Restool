If @OSVersion <> "WIN_XP" Then
		If MsgBox(1, "Warning", "This Will Reboot The Computer, Click OK To Continue") = 1 Then
			RunWait(@ComSpec & " /c " & "netsh winsock reset")
			RunWait(@ComSpec & " /c " & "netsh int ip reset resetlog.txt")
			RunWait(@ComSpec & " /c " & "netsh winhttp reset proxy")
			RunWait(@ComSpec & " /c " & "ipconfig /flushdns")
			RunWait(@ComSpec & " /c " & 'netsh int ip set address "local area connection" dhcp')
			RunWait(@ComSpec & " /c " & 'netsh int ip set dns "local area connection" dhcp')
			RegWrite("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", "REG_DWORD", "0xFFFFFFFF")
			RegWrite("HKLM64\SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", "REG_DWORD", "0xFFFFFFFF")
			Shutdown(2)
		EndIf
EndIf
If @OSVersion = "WIN_XP" Then
		If MsgBox(1, "Warning", "This Will Reboot The Computer, Click OK To Continue") = 1 Then
			RunWait(@ComSpec & " /c " & "netsh winsock reset")
			RunWait(@ComSpec & " /c " & "netsh int ip reset resetlog.txt")
			RunWait(@ComSpec & " /c " & "ipconfig /flushdns")
			RunWait(@ComSpec & " /c " & 'netsh int ip set address "local area connection" dhcp')
			RunWait(@ComSpec & " /c " & 'netsh int ip set dns "local area connection" dhcp')
			Shutdown(2)
		EndIf
EndIf