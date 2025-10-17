namespace Domain.Entities
{
    public class EntityAccounts
    {
        public string? Id { get; set; }
        public string? AccountDescription { get; set; }
        public string? AccountTitle { get; set; }
        public bool? Active { get; set; }
        public string? Bank { get; set; }
        public long? BankAccount { get; set; }
        public int? BankAccountDigit { get; set; }
        public string? Entity { get; set; }
        public string? PixKey { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
