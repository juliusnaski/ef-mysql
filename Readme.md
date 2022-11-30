# install .NET 7 SDK

https://dotnet.microsoft.com/en-us/download/dotnet/7.0

## Install Docker Desktop

https://www.docker.com/products/docker-desktop/

## Install Microsoft EntityFrameworkCore (https://learn.microsoft.com/en-us/ef/core/get-started/overview/install)

dotnet add package Microsoft.EntityFrameworkCore

## Setup docker container (user=root)

docker run -p 3333:3306 --name db -e MYSQL_ROOT_PASSWORD=secret -d mysql:latest

## verify that container is running

docker ps

## add MySql Entity EntityFrameworkCore package to project

dotnet add package MySql.EntityFrameworkCore

## build and run

dotnet build
dotnet run

## output should be a table of publishers and books
