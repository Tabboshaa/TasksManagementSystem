using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TaskManagementSystem.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Inject Db Contect 
builder.Services.AddDbContext<TMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TMSDbConnectionString")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
