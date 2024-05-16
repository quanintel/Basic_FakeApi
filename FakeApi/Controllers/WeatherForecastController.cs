using FakeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // private readonly ILogger<WeatherForecastController> _logger;
    // private readonly WeatherForecastService _service;
    //
    // public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService service)
    // {
    //     _logger = logger;
    //     _service = service;
    // }
    //
    // [HttpGet]
    // [Route("GetAll")]
    // public async Task<IActionResult> Get()
    // {
    //     var list = await _service.Get();
    //     return Ok(list);
    // }
    //
    // [HttpGet]
    // [Route("FakeData")]
    // public async Task<IActionResult> FakeData()
    // {
    //     await _service.FakeData();
    //     return Ok(1);
    // }
}