# dotnetcoreTDD
TDD Demo
# coreTDD

## create the solution file
``` 
dotnet new sln -n coreTDD
```

## create the Test & API  project
```
dotnet new xunit -n coreTDDTests
dotnet new webapi -n coreTDDApi
```

## add the projects to the solution file
```
cd coreTDD
dotnet sln add ./coreTDDUnit/coreTDDUnit.csproj
dotnet sln add ./coreTDDApi/coreTDDApi.csproj
```

## add the reference to the classib project  
```
dotnet add ./coreTDDUnit/coreTDDUnit.csproj reference ./coreTDDApi/coreTDDApi.csproj
```

## Add Coverage collection
```
dotnet add ./coreTDDUnit/coreTDDUnit.csproj package coverlet.msbuild 
dotnet test coreTDDUnit/coreTDDUnit.csproj /p:CollectCoverage=true
```

## Sample Coverage
```console
Microsoft (R) Test Execution Command Line Tool Version 16.0.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 4. Passed: 4. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.0129 Seconds

  Generating report 'C:\Om1Projs\coreTDD\coreTDDUnit\coverage.json'

+------------+--------+--------+--------+
| Module     | Line   | Branch | Method |
+------------+--------+--------+--------+
| coreTDDApi | 15.38% | 0%     | 25%    |
+------------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Total   | 15.38% | 0%     | 25%    |
+---------+--------+--------+--------+
```
