cd %~dp0
cd ..
cd nuget
nuget push pdf.sharp-netstandard-mpl-agpl.4.2.0.nupkg -Source http://server.com:8081/artifactory/api/nuget/devops-nuget-dev-local  -username admin -password "TOKEN"  
