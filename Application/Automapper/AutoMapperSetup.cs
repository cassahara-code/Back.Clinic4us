using Application.Commands.ViewModels;
using AutoMapper;
using Model.Entities;

namespace Application.Automapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Plans, PlanViewModel>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));
            CreateMap<PlanViewModel, Plans>();
            CreateMap<PlansBenefit, PlansBenefitViewModel>().ReverseMap();
            CreateMap<PlansSubscription, PlansSubscriptionViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UsersAddress, UsersAddressViewModel>().ReverseMap();
            CreateMap<PaymentRecurrence, PaymentRecurrenceViewModel>().ReverseMap();
        }
    }
}
