FROM microsoft/aspnetcore
WORKDIR /app
COPY ./WebAPI/bin/Debug/netcoreapp1.1/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]