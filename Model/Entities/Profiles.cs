namespace Domain.Entities
{
    public class Profiles
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public bool? AdmClient { get; set; }
        public bool? OwnerClient { get; set; }
        public bool? OwnerPlatform { get; set; }
        public bool? Professional { get; set; }
        public string? Description { get; set; }
        public string? Profile { get; set; }
        public string? ProfileType { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}