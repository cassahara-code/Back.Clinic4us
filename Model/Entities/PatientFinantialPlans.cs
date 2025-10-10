namespace Domain.Entities
{
    public class PatientFinantialPlans
    {
        public string? Id { get; set; }
        public DateTime? CancellationDate { get; set; }
        public bool? CancellationDocument { get; set; }
        public string? CancellationText { get; set; }
        public string? CancellationResponsible { get; set; }
        public string? CancellationUser { get; set; }
        public DateTime? ExpirationDate_MayBeEstimated { get; set; }
        public string? FinantialPlan { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Patient { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
