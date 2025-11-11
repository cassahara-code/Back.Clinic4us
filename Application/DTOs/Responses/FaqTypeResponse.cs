namespace Application.DTOs.Responses
{
    public class FaqTypeResponse
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}