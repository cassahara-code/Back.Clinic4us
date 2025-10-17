namespace Domain.Entities
{
    public class Configs
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? TittleSite { get; set; }
        public string? UrlPlatform { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
