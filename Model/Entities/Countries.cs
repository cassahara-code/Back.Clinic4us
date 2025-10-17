namespace Domain.Entities
{
    public class Countries
    {
        public string Id { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string Creator { get; set; } = default!;
        public DateOnly? Modified_Date { get; set; }
        public DateOnly? Created_Date { get; set; }
        public string? Slug { get; set; }
    }
}
