using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
string? connString = builder.Configuration.GetConnectionString("PostgreSqlConnection");


//Add services to the container
builder.Services.AddDbContext<CommandContext>(options =>
{
    options.UseNpgsql(connString);
});

builder.Services.AddControllers();




var app = builder.Build();

//Configure the HTTP request pipeline.
app.MapControllers();


app.MapGet("/", () => "Hello World!");

app.Run();
