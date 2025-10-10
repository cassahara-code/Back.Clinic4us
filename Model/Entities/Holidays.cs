namespace Domain.Entities
{
    public class Holidays
    {
        public string? Id { get; set; }
        public DateOnly? Day { get; set; }
        public string? HolidayTitle { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
