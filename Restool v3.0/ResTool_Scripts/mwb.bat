@echo off
TITLE Malwarebytes Installation
echo Installing Malwarebytes Please Wait...
cd "%userprofile%\desktop\restech"
start /wait mb.exe /SP- /silent /norestart
echo Updating Malwarebytes Please Wait...
echo.
echo If prompted to install a new version of Malwarebytes, DON'T DO IT! (:
start /wait mbam.exe /update
start mbam.exe /scan -full