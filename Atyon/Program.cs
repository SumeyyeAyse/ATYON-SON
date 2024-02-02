using Atyon.DTO;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//services.AddScoped<IUnitOfWork, UnitOfWork>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Scaffold - DbContext "Server=.;Database=atyon;Trusted_Connection=false;User Id=atyon;Password=1;" Microsoft.EntityFrameworkCore.SqlServer - f - DataAnnotations - Project "Atyon.Data" - OutputDir "DTO" - Schemas "dbo" - Context "AtyonDataContext"

builder.Services.AddDbContext<AtyonDataContext>(options => options.UseSqlServer("Server = .; Database = atyon; Trusted_Connection = false; User Id = atyon; Password = 1"));

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
