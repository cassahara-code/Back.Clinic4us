using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("plans")]
    public class Plans : Base
    {
        public bool? Active { get; set; }
        public int? ContractedPeriodMonth { get; set; }
        public string? Description { get; set; }
        public DateTime? FinalValidity { get; set; }
        public string? Image { get; set; }
        public bool? InitialPlan { get; set; }
        public DateTime? InitialValidity { get; set; }
        public string? Logs { get; set; }
        public int? NumberEntities { get; set; }
        public int? NumberPatients { get; set; }
        public int? NumberUsers { get; set; }
        public decimal? PlanPromoValue { get; set; }
        public string? PlanTitle { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnnuallyValue { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Slug { get; set; }

        // Navigation properties
        public ICollection<PlansBenefit>? PlansBenefits { get; set; }
        public ICollection<PlansSubscription>? PlansSubscriptions { get; set; }
    }
}
