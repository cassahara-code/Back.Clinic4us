namespace Domain.Entities
{
    public class TeamActivitiesBoard
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Description { get; set; }
        public string? Entity { get; set; }
        public bool? Filed { get; set; }
        public string? RestrictAccess { get; set; }
        public string? Title { get; set; }
        public string? UsersAccess { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}