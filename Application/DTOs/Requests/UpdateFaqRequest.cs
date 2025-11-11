namespace Application.DTOs.Requests
{
    public class UpdateFaqRequest
    {
        public Guid? Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public Guid? FaqType { get; set; }
    }
}