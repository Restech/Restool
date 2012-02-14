cd /d "%ProgramFiles%\Windows Resource Kits\Tools"
subinacl /subkeyreg HKEY_LOCAL_MACHINE /grant=administrators=f /grant=system=f
subinacl /subkeyreg HKEY_CURRENT_USER /grant=administrators=f /grant=system=f
subinacl /subkeyreg HKEY_CLASSES_ROOT /grant=administrators=f /grant=system=f
subinacl /subdirectories %SystemDrive%\ /grant=administrators=f /grant=system=f