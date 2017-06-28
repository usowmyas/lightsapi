# lightsapi

.NET Core web api ( C# microservice for windows , linux , mac )

Prereqs : 
1) Visual Studio Code ( with C# for visual studio Code and Docker extensions )
2) dotnet cmdline : https://docs.microsoft.com/en-us/dotnet/core/tools/ 

# To Build lights api 

dotnet restore

dotnet build

dotnet publish -o ./publish

# To build lights api docker 

docker build -t lightsapi .

docker run -p 8181:80 lightsapi 

OR can directly can run using cmd without having to build   : docker run -p 8080:80 usowmyas/lightsapi:ver0.0.0



