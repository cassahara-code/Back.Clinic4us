namespace Domain.Entities
{
    public class ExternalStorage
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? BucketName { get; set; }
        public string? BucketRegion { get; set; }
        public string? CompanyStorage { get; set; }
        public string? FileNamePrefix { get; set; }
        public string? FileType { get; set; }
        public string? FolderStructure { get; set; }
        public string? InputText { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
