using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("plans")]
    public class Plans : Base
    {
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnualyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }

        // Navigation properties
        public ICollection<PlansBenefit>? PlansBenefits { get; set; }
        public ICollection<PlansSubscription>? PlansSubscriptions { get; set; }
    }
}
