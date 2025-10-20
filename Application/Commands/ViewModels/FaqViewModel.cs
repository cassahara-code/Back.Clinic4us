namespace Application.Commands.ViewModels
{
    public class FaqViewModel
    {
        public Guid Id { get; set; }
        public bool? Active { get; set; }
        public string? Answer { get; set; }
        public Guid? FaqType { get; set; }
        public string? Question { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}