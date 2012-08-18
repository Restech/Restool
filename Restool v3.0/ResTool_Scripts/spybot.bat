@echo OFF
echo Installing Spybot Please Wait...
start /wait ../Install/spybotsd-setup.exe /SP- /silent /norestart

cd /D "C:\Program Files\Spybot - Search & Destroy"
pause
echo Updating Spybot Please Wait...
start /wait spybotsd.exe /autoupdate /autocheck