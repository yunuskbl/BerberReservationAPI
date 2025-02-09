using BerberReservationAPI.APPLICATION.Managers;
using BerberReservationAPI.DOMAIN.Interfaces;
using BerberReservationAPI.DOMAIN;
using BerberReservationAPI.PERSISTENCE.ContextClasses;
using Microsoft.EntityFrameworkCore;
using BerberReservationAPI.INFRASTRUCTURE.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContextServices();
builder.Services.AddServices();
builder.Services.AddCors();
builder.Services.AddControllers();

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
