namespace Domain.Entities
{
    public class ServiceTypes
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Description { get; set; }
        public bool? FreeHour { get; set; }
        public int? PackageAmount { get; set; }
        public string? ProfessionalType { get; set; }
        public string? Service { get; set; }
        public bool? VisibleOnSchedule { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}