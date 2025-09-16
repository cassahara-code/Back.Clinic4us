namespace Application.Commands.ViewModels
{
    public class PaymentRecurrenceViewModel
    {
        public long Id { get; set; }
        public int? PlansSubscritpionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? PaymentTransactionStatus { get; set; }
        public string? PaymentTransactionId { get; set; }
    }
}