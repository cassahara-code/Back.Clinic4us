namespace Domain.Entities
{
    public class PatientPaymentInjunction
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Description { get; set; }
        public DateTime? FinalDate { get; set; }
        public string? Identification { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Patient { get; set; }
        public string? ProfessionalTeam { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}