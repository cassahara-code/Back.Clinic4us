namespace Application.Commands.ViewModels
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? DocumentType { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Active { get; set; }
    }
}