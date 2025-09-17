using Application.Commands;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IMercadoPagoService _mercadoPagoService;
        public PaymentController(IMercadoPagoService mercadoPagoService)
        {
            _mercadoPagoService = mercadoPagoService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] MercadoPagoPaymentViewModel model)
        {
            var paymentId = await _mercadoPagoService.CreatePaymentAsync(model.Amount, model.Description, model.PayerEmail);
            return Ok(new { PaymentId = paymentId });
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> CreateCheckout([FromBody] MercadoPagoCheckoutViewModel model)
        {
            var checkoutUrl = await _mercadoPagoService.CreateCheckoutAsync(model.Amount, model.Description, model.PayerName, model.PayerEmail, model.ClinicAddress);
            return Ok(new { CheckoutUrl = checkoutUrl });
        }
    }
}
