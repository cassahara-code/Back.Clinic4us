namespace Domain.Entities
{
    public class AccountsPaymentOrigin
    {
        public string Id { get; set; } = default!;
        public string? AccountType { get; set; }
        public bool Active { get; set; } = true;
        public string? Description { get; set; }
        public string? Entity { get; set; }
        public string? EntityAccount { get; set; }
        public decimal? FixedRate { get; set; }
        public string? PaymentType { get; set; }
        public decimal? PercentualRate { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
    }
}
