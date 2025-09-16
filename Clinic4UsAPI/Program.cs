using Application.Automapper;
using Application.IRepositories;
using Application.IServices;
using Application.Services;
using Data.Context;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte ao UserSecrets
builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.
//IoCExtensions.RegistrarServicos(builder.Services);


builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IPlansSubscriptionService, PlansSubscriptionService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUsersAddressService, UsersAddressService>();
builder.Services.AddScoped<IPaymentRecurrenceService, PaymentRecurrenceService>();

builder.Services.AddScoped<IPlanRepository, PlanRepository>();
builder.Services.AddScoped<IPlansSubscriptionRepository, PlansSubscriptionRepository>();
builder.Services.AddScoped<IUsersAddressRepository, UsersAddressRepository>();
builder.Services.AddScoped<IPaymentRecurrenceRepository, PaymentRecurrenceRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<Clinic4UsDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(5, 7, 32)) // ajuste a versão conforme seu servidor MySQL
    ));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapperSetup>());
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
