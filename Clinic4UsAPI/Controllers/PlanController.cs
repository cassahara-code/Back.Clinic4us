using Application.Commands.ViewModels;
using Application.DTOs.Requests;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using System.Security.Claims;

namespace Clinic4UsAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _service;

        public PlanController(IPlanService service) => _service = service;

        // Helper para obter o ID do usuário autenticado a partir do token
        private Guid GetCurrentUserId()
        {
            var claim = User.FindFirst(ClaimTypes.NameIdentifier)
                        ?? User.FindFirst("sub")
                        ?? User.FindFirst("uid");

            return claim != null && Guid.TryParse(claim.Value, out var id) ? id : Guid.Empty;
        }

        #region Endpoints Legacy (ViewModels) - Mantidos para compatibilidade
        
        [HttpGet("legacy")]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("legacy/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost("legacy")]
        public async Task<IActionResult> Add([FromBody] PlanViewModel viewModel)
        {
            try
            {
                var user = GetCurrentUserId();
                var result = await _service.AddAsync(viewModel);
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
        }

        [HttpPut("legacy")]
        public async Task<IActionResult> Update([FromBody] PlanViewModel viewModel)
        {
            try
            {
                var result = await _service.UpdateAsync(viewModel);
                return Ok(result);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
        }

        [HttpDelete("legacy/{id}")]
        public async Task<IActionResult> Delete(Guid id) => Ok(await _service.DeleteAsync(id));

        #endregion

        #region Endpoints com DTOs (Recomendados)

        /// <summary>
        /// Obtém todos os planos
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllPlans()
        {
            var plans = await _service.GetAllPlansAsync();
            return Ok(plans);
        }

        /// <summary>
        /// Obtém todos os planos com benefícios
        /// </summary>
        [HttpGet("with-benefits")]
        public async Task<IActionResult> GetAllPlansWithBenefits()
        {
            var plans = await _service.GetPlansWithBenefitsAsync();
            return Ok(plans);
        }

        /// <summary>
        /// Obtém um plano por ID
        /// </summary>
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetPlanById(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest("ID deve ser informado");

            var plan = await _service.GetPlanByIdAsync(id);
            return plan == null ? NotFound($"Plano com codigo {id} não encontrado") : Ok(plan);
        }

        /// <summary>
        /// Verifica se um plano existe
        /// </summary>
        [HttpGet("{id:Guid}/exists")]
        public async Task<IActionResult> PlanExists(Guid id)
        {
            var exists = await _service.PlanExistsAsync(id);
            return Ok(new { exists });
        }

        /// <summary>
        /// Cria um novo plano
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreatePlan([FromBody] CreatePlanRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var createdBy = GetCurrentUserId();
                if (createdBy == Guid.Empty)
                    return Unauthorized("Usuário não autenticado");

                var plan = await _service.CreatePlanAsync(request, createdBy);
                return CreatedAtAction(nameof(GetPlanById), new { id = plan.Id }, plan);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        /// <summary>
        /// Atualiza um plano existente
        /// </summary>
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdatePlan(Guid id, [FromBody] UpdatePlanRequest request)
        {
            if (id != request.Id)
                return BadRequest("ID da URL deve corresponder ao ID do corpo da requisição");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var updatedBy = GetCurrentUserId();
                if (updatedBy == Guid.Empty)
                    return Unauthorized("Usuário não autenticado");

                var plan = await _service.UpdatePlanAsync(request, updatedBy);
                return Ok(plan);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        /// <summary>
        /// Exclui um plano
        /// </summary>
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeletePlan(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest("ID deve ser maior que zero");

            try
            {
                var deleted = await _service.DeletePlanAsync(id);
                return deleted ? NoContent() : NotFound($"Plano com ID {id} não encontrado");
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        #endregion
    }
}
