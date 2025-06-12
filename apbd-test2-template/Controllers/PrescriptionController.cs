using apbd_test2_template.Models.DTOs;
using apbd_test2_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_test2_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrescriptionController(IPrescriptionService prescriptionService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePrescriptionDto dto)
    {
        try
        {
            var id = await prescriptionService.CreatePrescriptionAsync(dto);
            return Created($"api/prescription/{id}", new { id });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}