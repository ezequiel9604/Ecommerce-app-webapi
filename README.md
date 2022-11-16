
# Project's name: Ecommerce_app_webapi

## What the project is about:

This project is a back-end webapi written in C# ASP.NET 6 for an E-commerce app, it will serve data to another (front-end) project found in this github account. This project is coded following the Domain-Driven Design architecture 
and several patterns and principal that comes with the DDD architecture. This project was not made with the purpose to launch it in production but with the purpose to practice and master my skills as developer.

## Entity-Relationship Diagram:

![Entity-Relationship Diagram](https://raw.githubusercontent.com/ezequiel9604/Ecommerce-app-webapi/main/resources/ecommerce-app-webapi.png)

## Packages:
Before anything you will need to download these packages needed for the differents libraries that forms this project.

Library: ```bash ./API/```

```bash
	dotnet add package AutoMapper --version 12.0.0
	dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
	dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
```

Library: ```bash ./Domain/```

```bash
	dotnet add package AutoMapper --version 12.0.0
	dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
```

Library: ```bash ./Infrastructure/```

```bash
	dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
	dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
```

## Prepare the migrations:
To made the migrations to the database execute the following code:

```bash
	dotnet-ef migrations add InitialMigrations --project ..\Infrastructure.csproj --startup-project ..\..\API\API.csproj
	dotnet-ef database update --project ..\Infrastructure.csproj --startup-project ..\..\API\API.csproj
```

## Build and Run the app:
In order to run the app first you need to go to ./Ecommerce_app_webapi/API and then:

```bash
	dotnet build
	dotnet run
```

## Contributing
Pull requests are not welcome, please open an issue first to discuss what you want to change so I can see and decide if I want to include it.
