namespace Domain.Entities
{
    public class ProfessionalsSchedules
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public bool? AllDay { get; set; }
        public DateTime? DateTimeFinal { get; set; }
        public DateTime? DateTimeInitial { get; set; }
        public string? DaysOfWeek { get; set; }
        public string? EditUser { get; set; }
        public string? Entity { get; set; }
        public decimal? EventProfessionalPaym { get; set; }
        public decimal? EventValueTotalAll { get; set; }
        public decimal? EventValueTotalUnit { get; set; }
        public decimal? EventValueUnit { get; set; }
        public decimal? EventValueUnitDiscount { get; set; }
        public string? FreeHourColor { get; set; }
        public string? Notes { get; set; }
        public string? ParentSchedule { get; set; }
        public string? PatiencePresenceColor { get; set; }
        public string? Patient { get; set; }
        public string? PatientInjunction { get; set; }
        public string? PatientConfirmation { get; set; }
        public string? PatientConfirmationCol { get; set; }
        public string? PatientPayment { get; set; }
        public string? PatientPresence { get; set; }
        public bool? PaymentByInjunction { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentDiscount { get; set; }
        public decimal? PaymentFinalValue { get; set; }
        public bool? PaymentStatus { get; set; }
        public bool? ProfessionalPaymentInd { get; set; }
        public string? ProfessionalRegistration { get; set; }
        public string? ProfessionalTeam { get; set; }
        public string? ReasonToCancel { get; set; }
        public int? ScheduleOccurrenceNumber { get; set; }
        public string? ScheduleStatusComment { get; set; }
        public string? ScheduleType { get; set; }
        public string? ServiceType { get; set; }
        public string? StatusDisplay { get; set; }
        public string? Subject { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}