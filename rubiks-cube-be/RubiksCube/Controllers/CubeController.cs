using Microsoft.AspNetCore.Mvc;
using RubiksCube.Models;
using RubiksCube.Services;

namespace RubiksCube.Controllers;

[Route("[controller]")]
public class CubeController() : ControllerBase
{

    [HttpPost("rotate")]
    public IActionResult Rotate([FromBody] CubeRequestModel model)
    {
        RotationService.Rotate(model);
        return Ok(model.Cube);
    }

}
