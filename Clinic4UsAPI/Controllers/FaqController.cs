
using Application.Commands.ViewModels;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaqController : ControllerBase
    {
        private readonly IFaqService _service;

        public FaqController(IFaqService service)
        {
            _service = service;
        }

        // Helper para obter o ID do usuário autenticado
        private Guid GetCurrentUserId()
        {
            var claim = User.FindFirst(ClaimTypes.NameIdentifier)
                        ?? User.FindFirst("sub")
                        ?? User.FindFirst("uid");

            return claim != null && Guid.TryParse(claim.Value, out var id) ? id : Guid.Empty;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faqs = await _service.GetAllAsync();
            return Ok(faqs);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var faq = await _service.GetByIdAsync(id);
            return faq == null ? NotFound($"FAQ com ID {id} não encontrada") : Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FaqViewModel viewModel)
        {
            try
            {
                //var userId = GetCurrentUserId();
                //if (userId == Guid.Empty)
                //    return Unauthorized("Usuário não autenticado");

                viewModel.Creator =Guid.Parse("844ed7d1-e759-4f67-a377-da8bdd58e8cb");
                viewModel.CreatedDate = DateTime.UtcNow;
                
                var result = await _service.AddAsync(viewModel);
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] FaqViewModel viewModel)
        {
            if (id != viewModel.Id)
                return BadRequest("ID da URL deve corresponder ao ID do corpo da requisição");

            try
            {
                var userId = GetCurrentUserId();
                if (userId == Guid.Empty)
                    return Unauthorized("Usuário não autenticado");

                viewModel.ModifiedDate = DateTime.UtcNow;
                
                var result = await _service.UpdateAsync(viewModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _service.DeleteAsync(id);
                return result ? NoContent() : NotFound($"FAQ com ID {id} não encontrada");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }
    }
}
