namespace Domain.Entities
{
    public class Cids
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? CidDescription { get; set; }
        public string? CidSubCategory { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
