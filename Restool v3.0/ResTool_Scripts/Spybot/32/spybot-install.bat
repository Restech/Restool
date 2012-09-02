@echo OFF
echo Installing Spybot Please Wait...
cd /d C:\
cd "%userprofile%\desktop\restech"
start /wait spybot.exe /SP- /silent /norestart

cd /D "C:\Program Files\Spybot - Search & Destroy"
echo Updating Spybot Please Wait...
start /wait spybotsd.exe /autoupdate

start spybotsd.exe

exit