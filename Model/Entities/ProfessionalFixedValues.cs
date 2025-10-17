namespace Domain.Entities
{
    public class ProfessionalFixedValues
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Entity { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Professional { get; set; }
        public decimal? Value { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}