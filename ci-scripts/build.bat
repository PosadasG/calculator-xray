cd %~dp0
cd ..
cd src
nuget restore
MSBuild.exe SonarQube.Client.sln /t:Rebuild