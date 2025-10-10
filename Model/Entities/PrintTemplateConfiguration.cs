namespace Domain.Entities
{
    public class PrintTemplateConfiguration
    {
        public string Id { get; set; } = default!;
        public string? Entity { get; set; }
        public string? File { get; set; }
        public string? Footer { get; set; }
        public string? Header { get; set; }
        public bool? Status { get; set; }
        public string? Tittle { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}