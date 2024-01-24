using Microsoft.EntityFrameworkCore;
using webapi4.Models;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();


builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddDbContext<BookContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeedConnection"));
});




/*builder.Services.AddDbContext<>
    
    (options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeedConnection"));
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
