using apbd_test2_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_test2_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientController(IPatientService patientService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await patientService.GetPatientDetailsAsync(id);
        return result is null ? NotFound() : Ok(result);
    }
}