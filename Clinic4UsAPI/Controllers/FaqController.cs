using Application.DTOs.Requests;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaqController : ControllerBase
    {
        private readonly IFaqService _faqService;
        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _faqService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _faqService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFaqRequest request)
        {
            var result = await _faqService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFaqRequest request)
        {
            var result = await _faqService.UpdateAsync(request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await _faqService.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}