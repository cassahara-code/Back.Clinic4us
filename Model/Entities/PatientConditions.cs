namespace Domain.Entities
{
    public class PatientConditions
    {
        public string Id { get; set; } = default!;
        public string? Condition { get; set; }
        public string? Description { get; set; }
        public int? Value { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
