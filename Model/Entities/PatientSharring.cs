namespace Domain.Entities
{
    public class PatientSharring
    {
        public string Id { get; set; } = default!;
        public string? Patient { get; set; }
        public string? ProfessionalRegistrator { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}