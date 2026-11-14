using ConsoleApp2;
using ConsoleApp2.Interfaces;
using DBRepository;
using DBRepository.Interfaces;
using DBRepository.Repositories;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Pipelines;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var config = builder.Configuration;
string? connectionString = config.GetConnectionString("DefaultConnection");
builder.Services.AddTransient<IDataService, DataService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
