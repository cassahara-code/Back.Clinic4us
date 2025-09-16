using Clinic4Us.Domain.Model;
using System;

namespace Model.Entities
{
    public class PaymentRecurrence :Base
    {
        public int? PlansSubscritpionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? PaymentTransactionStatus { get; set; }
        public string? PaymentTransactionId { get; set; }

        // Navigation property
        public PlansSubscription? PlansSubscription { get; set; }
    }
}
