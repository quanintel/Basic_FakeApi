using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using FakeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HospitalController : ControllerBase
{
    // private readonly ILogger<HospitalController> _logger;
    // private readonly HospitalService _service;
    //
    // public HospitalController(ILogger<HospitalController> logger, HospitalService service)
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
    //     var rs = new ApiResponse<HospitalDto>
    //     {
    //         Items = new ApiResponseBody<HospitalDto>
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