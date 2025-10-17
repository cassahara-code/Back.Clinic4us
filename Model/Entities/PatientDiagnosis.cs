namespace Domain.Entities
{
    public class PatientDiagnosis
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? CidDescription { get; set; }
        public string? CidId { get; set; }
        public string? CidSubcategory { get; set; }
        public string? Comments { get; set; }
        public string? ModifiedUser { get; set; }
        public string? Patient { get; set; }
        public bool? PatientCidStatusIsValid { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
