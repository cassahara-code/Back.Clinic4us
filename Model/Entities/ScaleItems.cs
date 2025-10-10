namespace Domain.Entities
{
    public class ScaleItems
    {
        public string Id { get; set; } = default!;
        public decimal? FinalValue { get; set; }
        public decimal? InitialValue { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemTitle { get; set; }
        public string? Scale { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}