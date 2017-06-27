# Using dotnet ( platform agnostic .NetCore web api on docker)

# Using aspnetcore 
FROM microsoft/aspnetcore-build

WORKDIR /app
copy ./publish .

ENV ASPNETCORE_URLS http://+:80
EXPOSE 80

# ENTRYPOINT
ENTRYPOINT ["dotnet" , "LightsApi.dll"]

