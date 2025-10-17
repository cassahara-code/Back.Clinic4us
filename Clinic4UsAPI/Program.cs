using Application.Automapper;
using Application.Commands.ViewModels;
using Application.IRepositories;
using Application.IServices;
using Application.Services;
using Application.Validators;
using Clinic4Us.Data.Repositories;
using Data.Context;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Application.DTOs.Requests;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte ao UserSecrets
builder.Configuration.AddUserSecrets<Program>();

// Configura o DbContext para usar MySQL
builder.Services.AddDbContext<Clinic4UsDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36)), // Ajuste a versão conforme necessário
        mySqlOptions => mySqlOptions.EnableStringComparisonTranslations()
    )
);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        // Se precisar enviar cookies/credenciais, use SetIsOriginAllowed(_ => true).AllowCredentials()
        // e substitua AllowAnyOrigin por uma lista explícita de origens.
    });
});

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
builder.Services.AddScoped<ILandPageRepository, LandPageRepository>();

// Registrando PlansBenefit
builder.Services.AddScoped<IPlansBenefitRepository, PlansBenefitRepository>();
builder.Services.AddScoped<IPlansBenefitService, PlansBenefitService>();
builder.Services.AddScoped<IValidator<CreatePlansBenefitRequest>, CreatePlansBenefitRequestValidator>();
builder.Services.AddScoped<IValidator<UpdatePlansBenefitRequest>, UpdatePlansBenefitRequestValidator>();

// Registrando Benefits
builder.Services.AddScoped<IBenefitsRepository, BenefitsRepository>();
builder.Services.AddScoped<IBenefitsService, BenefitsService>();
builder.Services.AddScoped<IValidator<CreateBenefitRequest>, CreateBenefitRequestValidator>();
builder.Services.AddScoped<IValidator<UpdateBenefitRequest>, UpdateBenefitRequestValidator>();

builder.Services.AddScoped<IValidator<PlanViewModel>, PlanViewModelValidator>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapperSetup>());
// Não é necessário AddHttpClient para SDK MercadoPago
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
// Habilita CORS
app.UseCors("DefaultCors");


app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
