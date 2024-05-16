using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using FakeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehouseController : ControllerBase
{
    // private readonly ILogger<WarehouseController> _logger;
    // private readonly WarehouseService _service;
    //
    // public WarehouseController(ILogger<WarehouseController> logger, WarehouseService service)
    // {
    //     _logger = logger;
    //     _service = service;
    // }
    //
    // [HttpGet]
    // [Route("GetAll")]
    // public async Task<IActionResult> Get([FromQuery] ApiInput input)
    // {
    //     var (listData, totalCount) = await _service.Get(input);
    //     var rs = new ApiResponse<WarehouseDto>
    //     {
    //         Items = new ApiResponseBody<WarehouseDto>
    //         {
    //             Total = totalCount,
    //             Item = listData
    //         }
    //     };
    //     return Ok(rs);
    // }
    //
    // [HttpGet]
    // [Route("FakeData")]
    // public async Task<IActionResult> FakeData([FromQuery] int record)
    // {
    //     await _service.FakeData(record);
    //     return Ok(1);
    // }
}