namespace Application.Commands
{
    public class MercadoPagoCheckoutViewModel
    {
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public string PayerName { get; set; } = string.Empty;
        public string PayerEmail { get; set; } = string.Empty;
        public string ClinicAddress { get; set; } = string.Empty;
    }
}
