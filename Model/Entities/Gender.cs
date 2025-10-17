namespace Domain.Entities
{
    public class Gender
    {
        public string Id { get; set; } = default!;
        public string? Abbreviation { get; set; }
        public string? GenderName { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
