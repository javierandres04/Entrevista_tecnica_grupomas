using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VehiclesSales.Core.Interfaces;
using VehiclesSales.Infraestructure.Data;
using VehiclesSales.Infraestructure.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Dependencias repos
builder.Services.AddScoped<IVehiculoRepo, VehiculoRepo>();

builder.Services.AddDbContext<VentaVehiculosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VentaVehiculos"))
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
