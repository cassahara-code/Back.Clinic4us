namespace Application.DTOs.Requests
{
    public class UpdateBenefitRequest
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
