using System;
using System.Collections.Generic;

namespace Application.Commands.ViewModels
{
    public class PlanViewModel
    {
        public string? Id { get; set; }
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnnuallyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public List<PlansBenefitViewModel>? PlansBenefits { get; set; }
    }
}