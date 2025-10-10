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
            // Mapeamentos legados (ViewModels)
            CreateMap<Plans, PlanViewModelResponse>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));
            CreateMap<PlanViewModelResponse, Plans>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits))
                .ForMember(dest => dest.PlansSubscriptions, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            CreateMap<Plans, PlanViewModel>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));
            CreateMap<PlanViewModel, Plans>();
            CreateMap<PlansBenefit, PlansBenefitViewModel>().ReverseMap();
            CreateMap<PlansSubscription, PlansSubscriptionViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UsersAddress, UsersAddressViewModel>().ReverseMap();
            CreateMap<PaymentRecurrence, PaymentRecurrenceViewModel>().ReverseMap();

            // Novos mapeamentos para DTOs
            CreateMap<Plans, PlanResponse>()
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));
            CreateMap<PlansBenefit, PlanBenefitResponse>();

            // Benefits
            CreateMap<Benefits, BenefitResponse>();
            CreateMap<CreateBenefitRequest, Benefits>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateBenefitRequest, Benefits>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            // Request DTOs para Entity
            CreateMap<CreatePlanRequest, Plans>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.PlansSubscriptions, opt => opt.Ignore())
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));

            CreateMap<UpdatePlanRequest, Plans>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.PlansSubscriptions, opt => opt.Ignore())
                .ForMember(dest => dest.PlansBenefits, opt => opt.MapFrom(src => src.PlansBenefits));

            // PlanBenefit mappings
            CreateMap<CreatePlanBenefitRequest, PlansBenefit>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.PlanId, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Plan, opt => opt.Ignore());

            CreateMap<UpdatePlanBenefitRequest, PlansBenefit>()
                .ForMember(dest => dest.PlanId, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Plan, opt => opt.Ignore());

            // Novos mapeamentos para CRUD direto de PlansBenefit
            CreateMap<CreatePlansBenefitRequest, PlansBenefit>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Plan, opt => opt.Ignore());

            CreateMap<UpdatePlansBenefitRequest, PlansBenefit>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Plan, opt => opt.Ignore());
        }
    }
}
