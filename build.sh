dotnet restore
dotnet publish -o bin/Publish

pushd WebAPI/bin/Publish
zip -r ./deploy-package.zip ./*
popd
