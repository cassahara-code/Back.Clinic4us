using Application.Commands.ViewModels;
using AutoMapper;
using Model.Entities;

namespace Application.Automapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            // ViewModels (legado)
            CreateMap<Plans, PlanViewModel>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));

            CreateMap<PlanViewModel, Plans>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .AfterMap((src, dest) =>
                {
                    if (dest.PlansBenefits == null) return;
                    var planId = dest.Id;
                    foreach (var b in dest.PlansBenefits)
                    {
                        b.PlanId = planId;
                    }
                });

            CreateMap<PlansBenefit, PlansBenefitViewModel>().ReverseMap();
            CreateMap<PlansSubscription, PlansSubscriptionViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UsersAddress, UsersAddressViewModel>().ReverseMap();
            CreateMap<PaymentRecurrence, PaymentRecurrenceViewModel>().ReverseMap();

            // Entities DTOs
            CreateMap<Entities, Application.DTOs.Responses.EntityResponse>();
            CreateMap<Application.DTOs.Requests.CreateEntityRequest, Entities>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Application.DTOs.Requests.UpdateEntityRequest, Entities>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
