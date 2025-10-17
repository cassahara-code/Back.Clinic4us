namespace Domain.Entities
{
    public class HealthPlans
    {
        public string Id { get; set; } = default!;
        public string? ANS { get; set; }
        public string? Category { get; set; }
        public string? Company { get; set; }
        public bool? Status { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
