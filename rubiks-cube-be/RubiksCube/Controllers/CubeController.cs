using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RubiksCube.Models;

namespace RubiksCube.Controllers;

[Route("[controller]")]
public class CubeController(ILogger<CubeController> logger) : ControllerBase
{

    [HttpPost("rotate")]
    public IActionResult Rotate([FromBody] CubeRotationModel model)
    {
        logger.LogInformation(JsonConvert.SerializeObject(model));
        return Ok(model.Cube);
    }

}
