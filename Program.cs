using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using products_api.Data;
var builder = WebApplication.CreateBuilder(args);

var stringConnection = builder.Configuration.GetConnectionString("AppDbContext");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(stringConnection ?? throw new InvalidOperationException("Connection string not found.")));

// Add services to the container.

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
