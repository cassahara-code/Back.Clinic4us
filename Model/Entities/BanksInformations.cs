namespace Domain.Entities
{
    public class BanksInformations
    {
        public string Id { get; set; } = default!;
        public string? Cid { get; set; }
        public int? Code { get; set; }
        public string? Name { get; set; }
        public string? Creator { get; set; }
        public DateOnly? ModifiedDate { get; set; }
        public DateOnly? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
