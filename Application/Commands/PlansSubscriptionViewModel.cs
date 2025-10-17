namespace Application.Commands.ViewModels
{
    public class PlansSubscriptionViewModel
    {
        public long Id { get; set; }
        public Guid? PlansId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public string? PeriodType { get; set; }
        public decimal? PlanValue { get; set; }
        public string? PaymentStatus { get; set; }
        public Guid? PaymentId { get; set; }
    }
}