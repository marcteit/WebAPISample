FROM microsoft/aspnetcore
WORKDIR /app
COPY ./WebAPI/bin/Publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]