using Application.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class IoCExtensions
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            // Serviços de domínio
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IPlansSubscriptionService, PlansSubscriptionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUsersAddressService, UsersAddressService>();
            services.AddScoped<IPaymentRecurrenceService, PaymentRecurrenceService>();
        }
    }
}
