#!/bin/bash

#build handlers
dotnet restore
dotnet publish -c release

#create deployment package
pushd WebAPI/bin/release/netcoreapp1.0/publish
zip -r ./deploy-package.zip ./*
popd
