@echo off
rem �������� ���� ��� ���������� SimpleCSharpApp.exe,
rem � ������� ������������� ������������ �� ��������.
"c:\Users\Papa Dima\source\repos\SimpleCSharpAPP\bin\Debug\SimpleCSharpApp.exe"
@if "%ERRORLEVEL%" == "1" goto success
:fail
rem ���������� ��������� �������,
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
rem ���������� ������� ���������,
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
rem ������ �������,
echo All Done.