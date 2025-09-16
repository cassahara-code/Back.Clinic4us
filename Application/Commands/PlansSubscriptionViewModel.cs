namespace Application.Commands.ViewModels
{
    public class PlansSubscriptionViewModel
    {
        public long Id { get; set; }
        public int? PlansId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string? PeriodType { get; set; }
        public decimal? PlanValue { get; set; }
        public string? PaymentStatus { get; set; }
        public int? PaymentId { get; set; }
    }
}