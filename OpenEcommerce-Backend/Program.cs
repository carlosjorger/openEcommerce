using Application;
using Application.Common.Interfaces;
using Application.TodoProduct.Repository;
using Backend.Domain.Models;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
var corsConfiguration = "_corsConfiguration";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
builder.Services.AddDbContext<ProductDb>(
    options =>
    options.UseNpgsql(connectionString)
);
builder.Services.AddDbContexts();
builder.Services.AddMediatRConfiguration();
builder.Services.AddBusiness();
builder.Services.AddCors(options => {
    options.AddPolicy(name:corsConfiguration,
        builder=>{
            builder.WithOrigins("*");
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(corsConfiguration);
app.MapControllers();

app.Run();
