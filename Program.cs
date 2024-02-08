using HousingProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();

builder.Services.AddDbContext<HouseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HouseConnection"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//add CORS - Cross origin resource sharing policy

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
