using Application.Commands.ViewModels;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using AutoMapper;
using Model.Entities;
using Domain.Entities;

namespace Application.Automapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            // Entity mappings
            CreateMap<Entities, EntityResponse>();
            CreateMap<CreateEntityRequest, Entities>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Creator, opt => opt.Ignore())
                .ForMember(dest => dest.CreatorUser, opt => opt.Ignore());

            CreateMap<UpdateEntityRequest, Entities>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Creator, opt => opt.Ignore())
                .ForMember(dest => dest.CreatorUser, opt => opt.Ignore());

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

            // FAQ
            CreateMap<Domain.Entities.Faq, FaqResponse>();
            CreateMap<CreateFaqRequest, Domain.Entities.Faq>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore());
            CreateMap<UpdateFaqRequest, Domain.Entities.Faq>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore());

            CreateMap<Domain.Entities.FaqTypes, FaqTypeResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.Creator))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug));
        }
    }
}
