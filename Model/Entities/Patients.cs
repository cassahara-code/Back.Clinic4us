namespace Domain.Entities
{
    public class Patients
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
        public bool? CompleteRegister { get; set; }
        public string? CreateUserTo { get; set; }
        public string? Entity { get; set; }
        public string? ModifiedUser { get; set; }
        public string? Notes { get; set; }
        public DateTime? PatientBirthDate { get; set; }
        public int? PatientBirthDay { get; set; }
        public int? PatientBirthMonth { get; set; }
        public string? PatientCountry { get; set; }
        public string? PatientDocument { get; set; }
        public string? PatientDocumentExped { get; set; }
        public string? PatientDocumentType { get; set; }
        public string? PatientEmail { get; set; }
        public string? PatientGender { get; set; }
        public bool? PatientIsResponsible { get; set; }
        public string? PatientName { get; set; }
        public string? PatientNativeLanguage { get; set; }
        public string? PatientPhone { get; set; }
        public string? PatientPhoneCode { get; set; }
        public string? PatientPicture { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? ProfissionalRegistration { get; set; }
        public string? RegisterAprovedBy { get; set; }
        public DateTime? RegisterAprovedDate { get; set; }
        public string? RegisterOrigin { get; set; }
        public string? RemovedBy { get; set; }
        public DateTime? RemovedIn { get; set; }
        public string? RemovedReason { get; set; }
        public string? ResponsibleDocument1 { get; set; }
        public string? ResponsibleDocument2 { get; set; }
        public string? ResponsibleDocumentT { get; set; }
        public string? ResponsibleEmail1 { get; set; }
        public string? ResponsibleEmail2 { get; set; }
        public string? ResponsibleFinance { get; set; }
        public string? ResponsibleName1 { get; set; }
        public string? ResponsibleName2 { get; set; }
        public string? ResponsiblePhone1 { get; set; }
        public string? ResponsiblePhone2 { get; set; }
        public string? ResponsiblePhoneCode { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}