namespace Domain.Entities
{
    public class PatientPayments
    {
        public string Id { get; set; } = default!;
        public string? PatientPaymentsCol { get; set; }
        public string? Comments { get; set; }
        public bool? ConciliationChecked { get; set; }
        public DateTime? ConciliationCheckedDate { get; set; }
        public string? ConciliationCheckedUser { get; set; }
        public DateTime? Date { get; set; }
        public string? Invoice { get; set; }
        public string? InvoiceUrl { get; set; }
        public decimal? OriginalValue { get; set; }
        public string? Patient { get; set; }
        public decimal? PatientTotalValue { get; set; }
        public string? PaymentType1 { get; set; }
        public string? PaymentType2 { get; set; }
        public decimal? PaymentValue1 { get; set; }
        public decimal? PaymentValue2 { get; set; }
        public string? ProfessionalSchedules { get; set; }
        public string? ReceiptProof { get; set; }
        public bool? Reverted { get; set; }
        public string? RevertedJustify { get; set; }
        public string? RevertedUser { get; set; }
        public string? TransactionNumber { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}