using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{

    [Table("plansSubscriptions")]
    public class PlansSubscription : Base
    {
        public long? PlansId { get; set; } // Corrigido para long?
        public long? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public string? PeriodType { get; set; }
        public decimal? PlanValue { get; set; }
        public string? PaymentStatus { get; set; }
        public int? PaymentId { get; set; }

        // Navigation properties
        public Plans? Plan { get; set; }
        public User? User { get; set; }
        public ICollection<PaymentRecurrence>? PaymentRecurrences { get; set; }
    }
}
