@echo off
cd /D "C:\Program Files\Spybot - Search & Destroy"
echo Updating Spybot Please Wait...
start /wait spybotsd.exe /autoupdate

start spybotsd.exe

exit