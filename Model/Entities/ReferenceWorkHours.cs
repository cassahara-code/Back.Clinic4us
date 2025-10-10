namespace Domain.Entities
{
    public class ReferenceWorkHours
    {
        public string Id { get; set; } = default!;
        public DateTime? Hour { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}