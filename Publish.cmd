@echo off
setlocal

set /p PUBLISH=Publish to NuGet ? [Y/n]
if "%PUBLISH%" NEQ "Y" goto :done

msbuild /t:Publish cassandra-sharp.targets || goto :done

:done
endlocal
goto :eof
