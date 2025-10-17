using Application.DTOs.Requests;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntitiesController : ControllerBase
    {
        private readonly IEntitiesService _service;

        public EntitiesController(IEntitiesService service)
        {
            _service = service;
        }

        private long GetCurrentUserId()
        {
            var claim = User.FindFirst(ClaimTypes.NameIdentifier)
                        ?? User.FindFirst("sub")
                        ?? User.FindFirst("uid");
            return claim != null && long.TryParse(claim.Value, out var id) ? id : 0;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("ID inválido");
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEntityRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            //var userId = GetCurrentUserId();
           
           var  userId = Guid.Parse("844ed7d1-e759-4f67-a377-da8bdd58e8cb");
            if (Guid.Empty == userId) return Unauthorized();
            var result = await _service.CreateAsync(request, userId);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateEntityRequest request)
        {
            if (id != request.Id) return BadRequest("IDs não conferem");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            //var userId = GetCurrentUserId();
            var userId = Guid.Parse("844ed7d1-e759-4f67-a377-da8bdd58e8cb");
            if (userId == Guid.Empty) return Unauthorized();
            var result = await _service.UpdateAsync(request, userId);
            return Ok(result);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("ID inválido");
            var deleted = await _service.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
