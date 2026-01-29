using Application.Interfaces;
using Application.UseCases;
using AuthService.Validators;
using Domain;
using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.DependencyInjection;
using Interface_Adapters.Auth;
using Interface_Adapters.DTOs;
using Interface_Adapters.Mappers;
using Interface_Adapters.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.InfrastructureServices(builder.Configuration);

// Fix for CS0311 and CS0305: Specify the generic type arguments for IAuthRepository
builder.Services.AddScoped<IAuthRepository<User, AuthResult>, AuthRepository>();
builder.Services.AddScoped<RegisterUseCase<RegisterUserDto, AuthResult>>();
builder.Services.AddScoped<IMapper<RegisterUserDto, User>, Mapper>();


// Fix for CS1503: Correct the argument passed to AddValidatorsFromAssemblyContaining
builder.Services.AddValidatorsFromAssemblyContaining<RegisterValidator>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();


// CORS policy
builder.Services.AddCors(policyBuilder => policyBuilder.AddDefaultPolicy(policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
