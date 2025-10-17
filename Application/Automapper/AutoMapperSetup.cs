using Application.Commands.ViewModels;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using AutoMapper;
using Model.Entities;

namespace Application.Automapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Plans, PlanViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));

            CreateMap<PlanViewModel, Plans>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));

            CreateMap<PlansBenefit, PlansBenefitViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PlanId, opt => opt.MapFrom(src => src.PlanId));

            CreateMap<PlansBenefitViewModel, PlansBenefit>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PlanId, opt => opt.MapFrom(src => src.PlanId));

            CreateMap<PlansSubscription, PlansSubscriptionViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UsersAddress, UsersAddressViewModel>().ReverseMap();
            CreateMap<PaymentRecurrence, PaymentRecurrenceViewModel>().ReverseMap();

            // Entities DTOs
            CreateMap<Entities, EntityResponse>();
            CreateMap<CreateEntityRequest, Entities>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateEntityRequest, Entities>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
