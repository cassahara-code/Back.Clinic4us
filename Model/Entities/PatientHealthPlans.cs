namespace Domain.Entities
{
    public class PatientHealthPlans
    {
        public string Id { get; set; } = default!;
        public string? HealthPlan { get; set; }
        public string? Patient { get; set; }
        public bool? Refundable { get; set; }
        public bool? Status { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}