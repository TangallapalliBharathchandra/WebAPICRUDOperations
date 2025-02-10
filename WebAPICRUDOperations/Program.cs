using Microsoft.EntityFrameworkCore;
using WebAPICRUDOperations.Models;
using WebAPICRUDOperations.Services;
 // Add this using directive

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with SQL Server connection string
builder.Services.AddDbContext<HeroDataDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<IOurHeroService, OurHeroService>();
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
