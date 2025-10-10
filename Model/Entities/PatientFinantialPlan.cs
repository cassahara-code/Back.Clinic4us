namespace Domain.Entities
{
    public class PatientFinantialPlan
    {
        public string? Id { get; set; }
        public string? Patient { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
