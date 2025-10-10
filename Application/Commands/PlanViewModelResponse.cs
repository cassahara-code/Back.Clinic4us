using System;
using System.Collections.Generic;

namespace Application.Commands.ViewModels
{
    public class PlanViewModelResponse
    {
        public Guid Id { get; set; }
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnualyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public List<PlansBenefitViewModel>? PlansBenefits { get; set; }
    }
}