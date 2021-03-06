# MauiApp1
This slightly modified "getting started on MAUI" sample app is based on
https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app
and seeks to mimic a "realistic" structure of project dependencies
including a "pure" .NET 6 class library:
```
MauiApp1 --> MauiLib1 --> ClassLibrary1
```
Currently, late January 2022, the .NET 6 class library seems to prevent
publishing on Windows using ```dotnet publish``` as discussed in the comments
of this issue: https://github.com/dotnet/maui/issues/4329.

Packaging ClassLibrary1 in a nuget package, and adding that to
MauiLib1 solves the issue - 
see the [nuget branch](https://github.com/Dbquity/MauiApp1/tree/nuget)
for an updated MauiLib1.csproj and the comments to the issue above for more detail.
