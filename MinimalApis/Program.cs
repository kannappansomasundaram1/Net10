using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidation(); // Add validation services
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Define API endpoints
app.MapGet("/", () => "Hello, Minimal API in .NET 10!");


// Add a weather endpoint that uses the service


// Add a POST endpoint
app.MapPost("/api/echo", (EchoRequest request) => new { Message = $"Echo: {request.Message} for {request.Name}" })
    .WithName("EchoMessage")
    .WithOpenApi();

app.Run();


public record EchoRequest([Required]string Message, [Required]string Name);
