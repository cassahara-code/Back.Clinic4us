using MercadoPago.Client.Preapproval;

namespace Application.Services
{
    internal class PreapprovalAutoRecurringRequest : PreApprovalAutoRecurringCreateRequest
    {
        public int Frequency { get; set; }
        public string FrequencyType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public string CurrencyId { get; set; }
    }
}