using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IMercadoPagoService
    {
        Task<string> CreatePaymentAsync(decimal amount, string description, string payerEmail);
        Task<string> CreateCheckoutAsync(decimal amount, string description, string payerName, string payerEmail, string clinicAddress);
    }
}
