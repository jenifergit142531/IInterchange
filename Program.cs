using Microsoft.EntityFrameworkCore;
using webapi5.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<EmpContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EmpConnection")));

builder.Services
    .AddScoped<EmployeeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
