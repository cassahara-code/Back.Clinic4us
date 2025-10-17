namespace Domain.Entities
{
    public class PatientFiles
    {
        public string? Id { get; set; }
        public string? File { get; set; }
        public string? Name { get; set; }
        public string? Patient { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
