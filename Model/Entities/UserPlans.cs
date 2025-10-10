namespace Domain.Entities
{
    public class UserPlans
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public DateTime? ContractDate { get; set; }
        public int? ContractedPeriodMonth { get; set; }
        public string? DescriptionPlan { get; set; }
        public DateTime? DueDate { get; set; }
        public string? IdPlan { get; set; }
        public decimal? PlanPromoValue { get; set; }
        public string? PlanTitle { get; set; }
        public decimal? PlanValue { get; set; }
        public string? User { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}