namespace Domain.Entities
{
    public class PatientSupervisorTree
    {
        public string Id { get; set; } = default!;
        public bool? Ativo { get; set; }
        public string? Entity { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime? InitialDate { get; set; }
        public string? Patient { get; set; }
        public string? Supervised { get; set; }
        public string? Supervisor { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}