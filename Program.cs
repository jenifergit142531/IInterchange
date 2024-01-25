using Microsoft.EntityFrameworkCore;
using webapi6.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ProContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
