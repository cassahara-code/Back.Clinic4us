using Clinic4Us.Domain.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("paymentrecurrence")]
    public class PaymentRecurrence : Base
    {
        public long? PlansSubscritpionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? PaymentTransactionStatus { get; set; }
        public string? PaymentTransactionId { get; set; }

        // Navigation property
        public PlansSubscription? PlansSubscription { get; set; }
    }
}
