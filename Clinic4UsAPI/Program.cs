using Data.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Infra;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte ao UserSecrets
builder.Configuration.AddUserSecrets<Program>();

// Configura o DbContext para usar MySQL
builder.Services.AddDbContext<Clinic4UsDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString,
        ServerVersion.Create(8, 0, 36, ServerType.MySql),
        mySqlOptions => mySqlOptions.EnableRetryOnFailure()
    );
});

// CORS: permite o front em http://localhost:3000
builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultCors", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

// Register all services using IoC Extensions
builder.Services.RegistrarServicos();

// ASP.NET Core Features
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
// Habilita CORS
app.UseCors("DefaultCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
