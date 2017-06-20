WebAPISample
------------

# Build
```
./build.sh
```

# Run
## Self-hosted

### Debug in Visual Studio Code
- Change the WebAPI target framework at ```WebAPI/WebAPI.csproj``` to ```netcoreapp1.1```.
- Change the WebAPI dll path at ```.vscode/launch.json```.
- Hit ```F5```.

### Command line
```
dotnet run -p WebAPI/WebAPI.csproj
```

## Container

### Run in container
- Change the WebAPI target framework at ```WebAPI/WebAPI.csproj``` to ```netcoreapp1.1```.
- Run the docker script
```
./docker.sh
```

### Connecting Containers
In order to communicate between containers you must first add them to the same network.
Once that`s done, they can use the container-name to communicate.

- Create a network
```
docker network create foo
```
- Connect the containers to the network
```
docker network connect foo WebAPISample
```

## Serverless
- Change the WebAPI target framework at ```WebAPI/WebAPI.csproj``` to ```netcoreapp1.0```.
- Deploy using Serverless
```
sls deploy
```