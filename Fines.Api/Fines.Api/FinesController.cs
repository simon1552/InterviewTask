using Fines.Core.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Fines.Api;

[Route("api/[controller]")]
[ApiController]
public class FinesController(IFinesService finesService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<FinesResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<FinesResponse>>> GetFines()
    {
        var fines = await finesService.GetFinesAsync();
        return Ok(fines);
    }
}
