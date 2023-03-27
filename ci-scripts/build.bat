cd %~dp0
cd ..
cd src
nuget restore
MSBuild.exe Calculator.sln /t:Rebuild