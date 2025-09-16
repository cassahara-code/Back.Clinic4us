namespace Application.Commands.ViewModels
{
    public class PlanViewModel
    {
        public long Id { get; set; }
        public string? PlanTitle { get; set; }
        public string? Description { get; set; }
        public decimal? MonthlyValue { get; set; }
        public decimal? AnualyValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}