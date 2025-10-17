namespace Domain.Entities
{
    public class Scales
    {
        public string Id { get; set; } = default!;
        public string? Entities { get; set; }
        public string? Entity { get; set; }
        public string? Form { get; set; }
        public bool? PublicAccess { get; set; }
        public string? ScaleDescription { get; set; }
        public string? ScaleName { get; set; }
        public string? ScaleType { get; set; }
        public bool? Status { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}