using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clinic4UsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaqTypesController : ControllerBase
    {
        private readonly IFaqTypesService _service;

        public FaqTypesController(IFaqTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateFaqTypeRequest request)
        {
            var response = await _service.AddAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateFaqTypeRequest request)
        {
            if (Guid.Empty == id) return BadRequest();
            var response = await _service.UpdateAsync(id, request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}