namespace Application.DTOs.Requests
{
    public class CreateFaqRequest
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? FaqType { get; set; }
        public string? Creator { get; set; }
    }
}