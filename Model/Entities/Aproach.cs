namespace Domain.Entities
{
    public class Aproach
    {
        public string Id { get; set; } = default!;
        public string? AproachText { get; set; }
        public string? Description { get; set; }
        public string? ProfessionalType { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
