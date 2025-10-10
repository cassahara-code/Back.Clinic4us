namespace Domain.Entities
{
    public class PatientPeriodPayment
    {
        public string Id { get; set; } = default!;
        public string? Patient { get; set; }
        public string? Period { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}