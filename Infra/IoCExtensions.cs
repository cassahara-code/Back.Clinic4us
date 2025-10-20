
using Application.IRepositories;
using Application.IServices;
using Application.Services;
using Application.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Application.Commands.ViewModels;
using Clinic4Us.Data.Repositories;
using Data.Repositories;
using Application.Automapper;

namespace Infra
{
    public static class IoCExtensions
    {
        public static IServiceCollection RegistrarServicos(this IServiceCollection services)
        {
            // Serviços de domínio
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IPlansSubscriptionService, PlansSubscriptionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUsersAddressService, UsersAddressService>();
            services.AddScoped<IPaymentRecurrenceService, PaymentRecurrenceService>();
            services.AddScoped<IMercadoPagoService, MercadoPagoService>();
            services.AddScoped<IEntitiesService, EntitiesService>();

            // Repositórios
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IPlansSubscriptionRepository, PlansSubscriptionRepository>();
            services.AddScoped<IUsersAddressRepository, UsersAddressRepository>();
            services.AddScoped<IPaymentRecurrenceRepository, PaymentRecurrenceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILandPageRepository, LandPageRepository>();
            services.AddScoped<IEntitiesRepository, EntitiesRepository>();

            // Validadores FluentValidation
            services.AddScoped<IValidator<PlanViewModel>, PlanViewModelValidator>();

            // AutoMapper
            services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapperSetup>());

          

            return services;
        }
    }
}
