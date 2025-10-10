namespace Application.Commands.ViewModels
{
    public class UsersAddressViewModel
    {
        public long Id { get; set; }
        public Guid? UserId { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? PostalCode { get; set; }
        public string? Neighborhood { get; set; }
        public bool? MainAddress { get; set; }
        public bool? Active { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}