namespace Domain.Entities
{
    public class PatientPlans
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public int? AutonumericId { get; set; }
        public bool? Blocked { get; set; }
        public string? ChangeLogs { get; set; }
        public DateTime? FinalDate { get; set; }
        public string? FinalNotes { get; set; }
        public int? FinalQualityScale { get; set; }
        public string? Goal { get; set; }
        public int? GoalQualityScale { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Justify { get; set; }
        public int? JustifyQualityScale { get; set; }
        public string? Metric { get; set; }
        public string? ModifiedUser { get; set; }
        public string? Notes { get; set; }
        public string? ParentPlan { get; set; }
        public string? Patient { get; set; }
        public string? PatientDiagnosis { get; set; }
        public string? PlanPeriod { get; set; }
        public string? PlanTitle { get; set; }
        public string? Priority { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? ProfessionalTeam { get; set; }
        public string? ProfessionalType { get; set; }
        public int? SessionsQuantity { get; set; }
        public string? Status { get; set; }
        public string? TerapyArea { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}