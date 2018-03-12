@echo off

for /d %%d in (Assets\praca-*) do (
echo %%~nxd
7za a -tzip %%~nxd.zip Assets\%%~nxd
%SystemRoot%\explorer.exe /select,"%%~nxd.zip"
)

pause