namespace Domain.Entities
{
    public class ProfessionalAvailability
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public DateTime? FinalHour { get; set; }
        public bool? HollidayWork { get; set; }
        public DateTime? InitialHour { get; set; }
        public string? Notes { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? WeekDay { get; set; }
        public int? WeekDayNumber { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}