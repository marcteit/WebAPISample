FROM microsoft/aspnetcore
WORKDIR /app
COPY ./WebAPI/bin/Debug/netcoreapp1.0/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]