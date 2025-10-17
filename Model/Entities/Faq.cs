namespace Domain.Entities
{
    public class Faq
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? Answer { get; set; }
        public string? FaqType { get; set; }
        public string? Question { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
