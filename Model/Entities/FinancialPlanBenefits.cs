namespace Domain.Entities
{
    public class FinancialPlanBenefits
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? Benefit { get; set; }
        public string? Description { get; set; }
        public bool? Discount { get; set; }
        public string? DiscountProfessionalSe { get; set; }
        public decimal? DiscountValue { get; set; }
        public string? Entity { get; set; }
        public string? FinantialPlanBenefitTyp { get; set; }
        public string? LastUserEditor { get; set; }
        public string? Notes { get; set; }
        public int? RecurrenceByPeriod { get; set; }
        public int? SessionsQuantityGroup { get; set; }
        public int? SessionsQuantityIndivid { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
