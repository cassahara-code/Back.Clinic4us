namespace Domain.Entities
{
    public class ProfessionalServicesValues
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public int? FixedHours { get; set; }
        public decimal? FixedHoursTotalValue { get; set; }
        public decimal? ProfessionalPaymentInc { get; set; }
        public decimal? ProfessionalPaymentVal { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? ProfessionalTeam { get; set; }
        public string? ServiceType { get; set; }
        public decimal? ServiceValue { get; set; }
        public int? SessionTimeHour { get; set; }
        public int? SessionTimeMinutes { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}