namespace Application.Commands.ViewModels
{
    public class PaymentRecurrenceViewModel
    {
        public Guid Id { get; set; }
        public Guid? PlansSubscritpionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? PaymentTransactionStatus { get; set; }
        public string? PaymentTransactionId { get; set; }
    }
}