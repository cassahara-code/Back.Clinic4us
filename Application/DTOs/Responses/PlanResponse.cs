namespace Application.DTOs.Responses
{
    public class PlanResponse
    {
        public Guid Id { get; set; }
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnualyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public List<PlanBenefitResponse>? PlansBenefits { get; set; }
    }

    public class PlanBenefitResponse
    {
        public Guid Id { get; set; }
        public Guid? PlanId { get; set; }
        public string? ItenDescription { get; set; }
        public bool? Covered { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}