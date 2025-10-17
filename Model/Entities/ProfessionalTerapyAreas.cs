namespace Domain.Entities
{
    public class ProfessionalTerapyAreas
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Area { get; set; }
        public string? ProfessionalType { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}