namespace Application.DTOs.Responses
{
    public class EntityResponse
    {
        public Guid Id { get; set; }
        public bool? Active { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressNeighborhood { get; set; }
        public string? AddressComplement { get; set; }
        public string? AddressDistrict { get; set; }
        public string? AddressNumber { get; set; }
        public string? AddressState { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressZipcode { get; set; }
        public string? CompanyName { get; set; }
        public bool? DefaultEntity { get; set; }
        public string? Document { get; set; }
        public string? Email { get; set; }
        public string? EntityNickName { get; set; }
        public string? FinalWorkHour { get; set; }
        public string? InitialWorkHour { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? PersonType { get; set; }
        public string? Phone { get; set; }
        public string? PhoneCodeArea { get; set; }
        public long? WhatsappNumber { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
