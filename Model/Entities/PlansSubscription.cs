using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class PlansSubscription : Base
    {
        public int? PlansId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string? PeriodType { get; set; }
        public decimal? PlanValue { get; set; }
        public string? PaymentStatus { get; set; }
        public int? PaymentId { get; set; }

        // Navigation properties
        public Plan? Plan { get; set; }
        public User? User { get; set; }
        public ICollection<PaymentRecurrence>? PaymentRecurrences { get; set; }
    }
}
