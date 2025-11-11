namespace Application.DTOs.Requests
{
    public class CreateFaqTypeRequest
    {
        public string? Type { get; set; }
        public string? Creator { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}