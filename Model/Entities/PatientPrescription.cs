namespace Domain.Entities
{
    public class PatientPrescription
    {
        public string Id { get; set; } = default!;
        public string? Content { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? Localization { get; set; }
        public string? Patient { get; set; }
        public string? PrintTemplate { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public bool? Status { get; set; }
        public string? Title { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}