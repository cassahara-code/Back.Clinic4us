using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class Plan : Base
    {
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnualyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        // Navigation property
        public ICollection<PlansSubscription>? PlansSubscriptions { get; set; }
    }
}
