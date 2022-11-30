# Install .NET 7 SDK

https://dotnet.microsoft.com/en-us/download/dotnet/7.0

## Install Docker Desktop

https://www.docker.com/products/docker-desktop/

## Install Microsoft EntityFrameworkCore (https://learn.microsoft.com/en-us/ef/core/get-started/overview/install)

dotnet add package Microsoft.EntityFrameworkCore

## Setup docker container (user=root)

docker run -p 3333:3306 --name db -e MYSQL_ROOT_PASSWORD=secret -d mysql:latest

## Verify that container is running

docker ps

## Add MySql Entity EntityFrameworkCore package to project

dotnet add package MySql.EntityFrameworkCore

## Build and run

dotnet build && dotnet run

## Output should be a table of publishers and books
