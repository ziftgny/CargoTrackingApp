using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IKargoService), typeof(KargoManager));
builder.Services.AddScoped(typeof(IKargoDal), typeof(EfKargoDal));
builder.Services.AddScoped(typeof(ICalisanService), typeof(CalisanManager));
builder.Services.AddScoped(typeof(ICalisanDal), typeof(EfCalisanDal));
builder.Services.AddScoped(typeof(IMusteriService), typeof(MusteriManager));
builder.Services.AddScoped(typeof(IMusteriDal), typeof(EfMusteriDal));
builder.Services.AddDbContext<CargoTrackingDatabaseContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
