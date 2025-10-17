namespace Domain.Entities
{
    public class AccountsPayableType
    {
        public string Id { get; set; } = default!;
        public bool Active { get; set; } = true;
        public string? Description { get; set; }
        public string? Entity { get; set; }
        public string? Parent { get; set; }
        public string? Type { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
