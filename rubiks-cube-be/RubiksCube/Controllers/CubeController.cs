using Microsoft.AspNetCore.Mvc;
using RubiksCube.Models;
using RubiksCube.Services;

namespace RubiksCube.Controllers;

[Route("[controller]")]
public class CubeController() : ControllerBase
{

    [HttpPost("rotate")]
    public IActionResult Rotate([FromBody] CubeRotationModel model)
    {
        RotationService.Rotate(model);
        return Ok(model.Cube);
    }

}
