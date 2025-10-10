namespace Domain.Entities
{
    public class TherapeuticResourceType
    {
        public string Id { get; set; } = default!;
        public string? ResourceType { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}