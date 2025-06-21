using APDB_Kolokwium_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace APDB_Kolokwium_template.Controllers;

[ApiController]
[Route("/api")]
public class Controller(IDbService service) : ControllerBase
{
    [HttpGet]
    [Route("/assignments")]
    public async Task<IActionResult> GetAssignments()
    {
        try
        {
            return Ok(await service.GetAssignments());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
    