using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RubiksCube.Models;
using RubiksCube.Services;

namespace RubiksCube.Controllers;

[Route("[controller]")]
public class CubeController(ILogger<CubeController> logger) : ControllerBase
{

    [HttpPost("rotate")]
    public IActionResult Rotate([FromBody] CubeRequestModel model)
    {
        //  logger.LogInformation(JsonConvert.SerializeObject(model));
        RotationService.Rotate(model, logger);
        return Ok(model);
    }

}
