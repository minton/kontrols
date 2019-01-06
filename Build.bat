MSBuild.exe .\src\kontrols.sln /t:Rebuild /p:Configuration=Release
copy "C:\Dev\kontrols\src\kontrols\bin\Release\kontrols.dll" "C:\Dev\kontrols\nuget\lib\net45\kontrols.dll"
nuget.exe pack "C:\dev\kontrols\nuget\kontrols.nuspec"
