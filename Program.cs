using Microsoft.EntityFrameworkCore;
using webapi2.Context;
using webapi2.Models;
using webapi2.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<RentalContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RentalConnection"));
    
    
    });

//DI Services

builder.Services.AddTransient<IPlayer, PlayerGenerator>();
builder.Services.AddTransient<IPlayer, BetterPlayerGenerator>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
