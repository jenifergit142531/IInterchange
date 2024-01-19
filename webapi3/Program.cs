using Microsoft.EntityFrameworkCore;
using webapi3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MydbfirstContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ParkingConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
