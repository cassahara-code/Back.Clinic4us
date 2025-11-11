namespace Application.DTOs.Requests
{
    public class UpdateFaqTypeRequest
    {
        public string? Type { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Slug { get; set; }
    }
}