using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MercadoPagoCallbackController : ControllerBase
    {
        private readonly ILogger<MercadoPagoCallbackController> _logger;
        public MercadoPagoCallbackController(ILogger<MercadoPagoCallbackController> logger)
        {
            _logger = logger;
        }

        [HttpGet("success")]
        public IActionResult Success([FromQuery] string payment_id, [FromQuery] string status, [FromQuery] string merchant_order_id)
        {
            _logger.LogInformation($"Pagamento aprovado. PaymentId: {payment_id}, Status: {status}, MerchantOrderId: {merchant_order_id}");
            // Aqui você pode salvar no banco, atualizar status, etc.
            return Ok(new { payment_id, status, merchant_order_id });
        }

        [HttpGet("failure")]
        public IActionResult Failure([FromQuery] string payment_id, [FromQuery] string status, [FromQuery] string merchant_order_id)
        {
            _logger.LogWarning($"Pagamento falhou. PaymentId: {payment_id}, Status: {status}, MerchantOrderId: {merchant_order_id}");
            return BadRequest(new { payment_id, status, merchant_order_id });
        }
    }
}
