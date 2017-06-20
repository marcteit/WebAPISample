docker kill WebAPISample
docker rm WebAPISample
docker rmi webapisample
docker build -t webapisample .
docker run -d -p 8000:80 --name WebAPISample -e "MyValue=HelloContainer" -e "DatabaseConnection__Server=controlerepresentante" -e "DatabaseConnection__Port=3306" --network foo webapisample
