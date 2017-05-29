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
docker run -d -p 8000:80 --name WebAPISample webapisample
```
