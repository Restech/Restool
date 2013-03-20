@echo on
echo Flushing the DNS...
ipconfig.exe /flushdns
echo Releasing the IP...
ipconfig.exe /release
echo Renewing the IP...
ipconfig.exe /renew

echo Finished!

pause