# .NET 10 Minimal API Project

This is a simple Minimal API project built with .NET 10, demonstrating the core features of ASP.NET Core Minimal APIs.

## Features

- Simple API endpoints using the Minimal API syntax
- OpenAPI/Swagger documentation
- Dependency injection example with a Weather service
- Input validation with data annotations

## API Endpoints

- `GET /` - Returns a welcome message
- `GET /api/hello` - Returns a simple "Hello World" message as JSON
- `GET /api/time` - Returns the current UTC time
- `GET /api/weather` - Returns a list of weather forecasts from the injected service
- `POST /api/echo` - Echoes back the message you send

## How to Run

1. Make sure you have .NET 10 installed
2. Navigate to the project directory
3. Run the following command:

```bash
dotnet run --project MinimalApis
```

4. Open a browser and navigate to https://localhost:7001/swagger to view the Swagger UI

## Development Notes

This project demonstrates:

1. Setting up a Minimal API project structure
2. Registering and using dependency injection
3. Creating both GET and POST endpoints
4. Using OpenAPI/Swagger documentation
5. Simple model validation

Feel free to use this as a starting point for your own .NET 10 Minimal API projects!
