// Amandus, 20240212: Programmer Test Net Core Junior
// A simple web api built using Net 8, without using a database

var builder = WebApplication.CreateBuilder(args);

// get connection string from appsettings
var strCon = builder.Configuration.GetConnectionString("DefaultConnection");

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

app.MapControllers();

// a custom api used to display connection strings
// here does not use the controller
app.MapGet("/api/settings", () => "Connection strings: " + strCon);

app.Run();
