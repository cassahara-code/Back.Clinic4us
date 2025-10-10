namespace Domain.Entities
{
    public class PatientDiscounts
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? Comments { get; set; }
        public decimal? Discount { get; set; }
        public string? Entity { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Patient { get; set; }
        public string? PaymentId { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? ProfessionalTeam { get; set; }
        public string? ProfessionalType { get; set; }
        public string? ServiceType { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
