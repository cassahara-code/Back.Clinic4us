namespace Domain.Entities
{
    public class TherapeuticResource
    {
        public string Id { get; set; } = default!;
        public string? Description { get; set; }
        public string? Resource { get; set; }
        public string? ResourceType { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}