namespace Domain.Entities
{
    public class PatientNotes
    {
        public string Id { get; set; } = default!;
        public string? Note { get; set; }
        public string? PatientId { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}