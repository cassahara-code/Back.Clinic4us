using Application.DTOs.Requests;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace Clinic4UsAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlansBenefitController : ControllerBase
    {
        private readonly IPlansBenefitService _service;

        public PlansBenefitController(IPlansBenefitService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] Guid? planId)
        {
            var items = await _service.GetAllAsync(planId);
            return Ok(items);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("ID deve ser informado");

            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound($"Benefício com ID {id} não encontrado") : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePlansBenefitRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var createdBy = Guid.NewGuid();
                var result = await _service.CreateAsync(request, createdBy);
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePlansBenefitRequest request)
        {
            if (id == Guid.Empty || id != request.Id) return BadRequest("ID inválido");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var updatedBy = Guid.NewGuid();
                var result = await _service.UpdateAsync(request, updatedBy);
                return Ok(result);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("ID inválido");

            try
            {
                var deleted = await _service.DeleteAsync(id);
                return deleted ? NoContent() : NotFound($"Benefício com ID {id} não encontrado");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor", detail = ex.Message });
            }
        }
    }
}
