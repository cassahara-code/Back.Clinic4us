using Application.Commands.ViewModels;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Clinic4UsAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _service;
        public PlanController(IPlanService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PlanViewModel viewModel) => Ok(await _service.AddAsync(viewModel));

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PlanViewModel viewModel) => Ok(await _service.UpdateAsync(viewModel));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => Ok(await _service.DeleteAsync(id));
    }
}
