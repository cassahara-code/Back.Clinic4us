namespace Domain.Entities
{
    public class PatientContracts
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? CancelMotivation { get; set; }
        public string? Comments { get; set; }
        public string? ContractType { get; set; }
        public string? Entity { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? LastEditor { get; set; }
        public string? Patient { get; set; }
        public DateTime? SubscriptionDate { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
