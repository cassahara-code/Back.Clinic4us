using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("planssubscriptions")]
    public class PlansSubscription : Base
    {
        public Guid? PlansId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public string? PeriodType { get; set; }
        public decimal? PlanValue { get; set; }
        public string? PaymentStatus { get; set; }
        public Guid? PaymentId { get; set; }
        public string? PlansSubscriptionscol { get; set; }

        // Navigation properties
        public Plans? Plan { get; set; }
        public User? User { get; set; }
        public ICollection<PaymentRecurrence>? PaymentRecurrences { get; set; }
    }
}
