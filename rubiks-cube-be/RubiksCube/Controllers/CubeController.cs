using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RubiksCube.Models;
using RubiksCube.Services;

namespace RubiksCube.Controllers;

[Route("[controller]")]
public class CubeController(ILogger<CubeController> logger) : ControllerBase
{

    [HttpPost("rotate")]
    public IActionResult Rotate([FromBody] CubeRotationModel model)
    {
        RotationService.Rotate(model);
        string logMessage = $"rotatedCube: {JsonConvert.SerializeObject(model)}";
        logger.LogInformation(logMessage);
        return Ok(model.Cube);
    }

}
