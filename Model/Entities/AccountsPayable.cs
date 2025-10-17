namespace Domain.Entities
{
    public class AccountsPayable
    {
        public string Id { get; set; } = default!;
        public string? AccontsPaymentOrigin { get; set; }
        public string? Account { get; set; }
        public string? AccountsPayableType { get; set; }
        public bool Active { get; set; } = true;
        public string? Comments { get; set; }
        public DateOnly? DateToPay { get; set; }
        public decimal? DefinitiveValue { get; set; }
        public decimal? DefinitiveValueWithoutS { get; set; }
        public string? Description { get; set; }
        public string? Entity { get; set; }
        public bool NotConsiderInDRE { get; set; } = false;
        public string? OperationType { get; set; }
        public string? Parent { get; set; }
        public DateOnly? PaymentDate { get; set; }
        public bool PaymentStatus { get; set; } = false;
        public decimal? PredictedValue { get; set; }
        public decimal? PredictedValueWithoutS { get; set; }
        public int? Recurrence { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
