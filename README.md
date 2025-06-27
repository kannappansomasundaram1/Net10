# .NET 10 Trial Projects

This repository contains several .NET 10 sample projects and scripts demonstrating various features of .NET.

## Project Structure

- **Extensions/** - Demonstrates C# extension methods and properties
- **Field/** - Shows the use of the `field` keyword in property setters
- **MinimalApis/** - A minimal API project showcasing .NET's lightweight web API framework
- **Nullable/** - A project demonstrating C# nullable reference types
- **script/** - Contains C# script files that can be run directly

## Scripts

### script.cs

A simple script demonstrating the Humanizer package to format dates in a human-readable way.

```bash
dotnet run script/script.cs
```

### webapp.cs

A minimal web application that responds with "Hello World!" at the `/hello` endpoint.

```bash
dotnet run script/webapp.cs
```

## Extensions Project

Demonstrates extension methods and properties in C#.

### How to run:

```bash
cd Extensions
dotnet run
```

## Field Project

Shows usage of the `field` keyword in property setters, a new feature in .NET 10.

### How to run:

```bash
cd Field
dotnet run
```

## MinimalApis Project

A minimal API web application with endpoint routing and Swagger integration.

### How to run:

```bash
cd MinimalApis
dotnet run
```

## Nullable Project

A compiled project showing nullable reference types.

### How to run:

```bash
cd Nullable
dotnet run
```

## Prerequisites

- .NET 10 SDK
- dotnet-script tool (for running script files)


## Notes

This repository is for educational and experimental purposes to explore .NET 10 features.
