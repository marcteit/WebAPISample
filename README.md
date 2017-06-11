### Run in container
- Publish de application
```
dotnet publish
```
- Build the container image
```
docker build -t webapisample .
```
- Run the container
```
docker run -d -p 8000:80 --name WebAPISample -e "MyValue=HelloContainer" -e "DatabaseConnection__Server=controlerepresentante" -e "DatabaseConnection__Port=3306" --network foo webapisample
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