namespace Application.DTOs.Responses
{
    public class FaqResponse
    {
        public Guid? Id { get; set; }
        public bool? Active { get; set; }
        public string? Answer { get; set; }
        public string? FaqType { get; set; }
        public string? Question { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}