using Application.Commands.ViewModels;
using AutoMapper;
using Model.Entities;

namespace Application.Automapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Plan, PlanViewModel>().ReverseMap();
            CreateMap<PlansSubscription, PlansSubscriptionViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UsersAddress, UsersAddressViewModel>().ReverseMap();
            CreateMap<PaymentRecurrence, PaymentRecurrenceViewModel>().ReverseMap();
        }
    }
}
