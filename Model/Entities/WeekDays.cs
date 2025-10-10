namespace Domain.Entities
{
    public class WeekDays
    {
        public string Id { get; set; } = default!;
        public int? CalcNumber { get; set; }
        public string? DayOfWeek { get; set; }
        public string? DayOfWeekPortuguese { get; set; }
        public int? NumberDay { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}