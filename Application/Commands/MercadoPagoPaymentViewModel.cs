namespace Application.Commands
{
    public class MercadoPagoPaymentViewModel
    {
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public string PayerEmail { get; set; } = string.Empty;
    }
}
