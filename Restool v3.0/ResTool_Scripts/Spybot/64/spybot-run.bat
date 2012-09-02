@echo off
cd /D "C:\Program Files (x86)\Spybot - Search & Destroy"
echo Updating Spybot Please Wait...
start /wait spybotsd.exe /autoupdate

start spybotsd.exe

exit