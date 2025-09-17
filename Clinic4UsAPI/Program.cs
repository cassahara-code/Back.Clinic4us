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

// Configura o DbContext para usar MySQL
builder.Services.AddDbContext<Clinic4UsDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36)) // Ajuste a versão conforme necessário
    )
);

// Add services to the container.
//IoCExtensions.RegistrarServicos(builder.Services);


builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IPlansSubscriptionService, PlansSubscriptionService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUsersAddressService, UsersAddressService>();
builder.Services.AddScoped<IPaymentRecurrenceService, PaymentRecurrenceService>();
builder.Services.AddScoped<IMercadoPagoService, MercadoPagoService>();

builder.Services.AddScoped<IPlanRepository, PlanRepository>();
builder.Services.AddScoped<IPlansSubscriptionRepository, PlansSubscriptionRepository>();
builder.Services.AddScoped<IUsersAddressRepository, UsersAddressRepository>();
builder.Services.AddScoped<IPaymentRecurrenceRepository, PaymentRecurrenceRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapperSetup>());
// Não é necessário AddHttpClient para SDK MercadoPago
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
