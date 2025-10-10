namespace Domain.Entities
{
    public class CalcResultForms
    {
        public string Id { get; set; } = default!;
        public bool Active { get; set; } = true;
        public string? Description { get; set; }
        public string? Entities { get; set; }
        public bool Public { get; set; } = false;
        public string? ResultPage { get; set; }
        public string? Title { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
