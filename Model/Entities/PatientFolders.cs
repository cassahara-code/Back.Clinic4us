namespace Domain.Entities
{
    public class PatientFolders
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Entity { get; set; }
        public string? FolderName { get; set; }
        public bool? ViewInFiles { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}