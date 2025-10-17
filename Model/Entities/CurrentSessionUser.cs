namespace Domain.Entities
{
    public class CurrentSessionUser
    {
        public string Id { get; set; } = default!;
        public string? Entity { get; set; }
        public string? Profile { get; set; }
        public string? User { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
