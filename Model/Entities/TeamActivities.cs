namespace Domain.Entities
{
    public class TeamActivities
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? ActivityDescription { get; set; }
        public string? ActivityTitle { get; set; }
        public bool? Blocked { get; set; }
        public string? Board { get; set; }
        public string? Comments { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? Filed { get; set; }
        public string? Logs { get; set; }
        public string? Patient { get; set; }
        public string? Priority { get; set; }
        public string? Requesting { get; set; }
        public string? Responsible { get; set; }
        public string? Status { get; set; }
        public DateTime? TargetDate { get; set; }
        public string? Creator { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}