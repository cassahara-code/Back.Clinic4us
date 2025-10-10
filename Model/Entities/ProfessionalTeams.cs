namespace Domain.Entities
{
    public class ProfessionalTeams
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Coordinators { get; set; }
        public string? Description { get; set; }
        public string? Entity { get; set; }
        public bool? FixedHours { get; set; }
        public string? ListOfPatients { get; set; }
        public bool? MainTeam { get; set; }
        public string? ProfessionaRegistration { get; set; }
        public bool? SpecificPatients { get; set; }
        public string? Title { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}