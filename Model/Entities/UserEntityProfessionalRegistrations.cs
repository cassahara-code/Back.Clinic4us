namespace Domain.Entities
{
    public class UserEntityProfessionalRegistrations
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressComplement { get; set; }
        public string? AddressDistrict { get; set; }
        public string? AddressNumber { get; set; }
        public string? AddressState { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressZipCode { get; set; }
        public string? BankAccount { get; set; }
        public string? BankAccountDigit { get; set; }
        public string? BankCode { get; set; }
        public string? BankPix { get; set; }
        public string? Document { get; set; }
        public string? DocumentProfessional { get; set; }
        public string? Entity { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? ListProfiles { get; set; }
        public string? Name { get; set; }
        public string? PhoneCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfessionalType { get; set; }
        public string? User { get; set; }
        public string? UserNickName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Slug { get; set; }
    }
}