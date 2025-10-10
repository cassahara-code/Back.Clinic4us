namespace Domain.Entities
{
    public class DocumentType
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public bool? FieldDocumentExpedition { get; set; }
        public bool? MainDocument { get; set; }
        public int? MaxCharacter { get; set; }
        public int? MinCharacter { get; set; }
        public string? Type { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
