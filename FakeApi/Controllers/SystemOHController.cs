using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using FakeApi.ImportJson;
using FakeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SystemOHController : ControllerBase
{
    private readonly ILogger<SystemOHController> _logger;
    private readonly SystemOHService _service;
    private readonly ExecuteImport _serviceImport;

    public SystemOHController(ILogger<SystemOHController> logger, SystemOHService service, ExecuteImport serviceImport)
    {
        _logger = logger;
        _service = service;
        _serviceImport = serviceImport;
    }

    [HttpGet]
    [Route("ImportJson")]
    public async Task<IActionResult> ImportJson()
    {
        await _serviceImport.ReadFile<CompanyDto, Company>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/CompanyDataJson.json");
        await _serviceImport.ReadFile<ProductDto, Product>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/ProductDataJson.json");
        await _serviceImport.ReadFile<MomentTypeDto, MomentType>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/MomentTypeDataJson.json");
        
        await _serviceImport.ReadFile<UnitDto, Unit>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/UnitDataJson.json");
        await _serviceImport.ReadFile<WarehouseDto, Warehouse>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/WarehouseDataJson.json");
        await _serviceImport.ReadFile<WarehouseProductDto, WarehouseProduct>("/Volumes/Data/Code/FakeApi/FakeApi/ImportJson/WarehouseProductDataJson.json");
        return Ok(1);
    }

    [HttpGet]
    [Route("GetCompany")]
    public async Task<IActionResult> GetCompany([FromQuery] ApiInput input)
    {
        input.ToDate = null;
        input.FromDate = null;
        var (listData, totalCount) = await _service.GetCompany(input);
        var rs = new ApiResponseOH<CompanyDto>
        {
            Entries = new ApiResponseOHBody<CompanyDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetHospital")]
    public async Task<IActionResult> GetHospital([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetHospital(input);
        var rs = new ApiResponseOH<HospitalDto>
        {
            Entries = new ApiResponseOHBody<HospitalDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetMomentType")]
    public async Task<IActionResult> GetMomentType([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetMomentType(input);
        var rs = new ApiResponseOH<MomentTypeDto>
        {
            Entries = new ApiResponseOHBody<MomentTypeDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetProduct")]
    public async Task<IActionResult> GetProduct([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetProduct(input);
        var rs = new ApiResponseOH<ProductDto>
        {
            Entries = new ApiResponseOHBody<ProductDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetUnit")]
    public async Task<IActionResult> GetUnit([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetUnit(input);
        var rs = new ApiResponseOH<UnitDto>
        {
            Entries = new ApiResponseOHBody<UnitDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetWareHouse")]
    public async Task<IActionResult> GetWareHouse([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetWareHouse(input);
        var rs = new ApiResponseOH<WarehouseDto>
        {
            Entries = new ApiResponseOHBody<WarehouseDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }

    [HttpGet]
    [Route("GetWarehouseProduct")]
    public async Task<IActionResult> GetWarehouseProduct([FromQuery] ApiInput input)
    {
        var (listData, totalCount) = await _service.GetWareHouseProduct(input);
        var rs = new ApiResponseOH<WarehouseProductDto>
        {
            Entries = new ApiResponseOHBody<WarehouseProductDto>
            {
                Entry = listData
            }
        };
        return Ok(rs);
    }
}