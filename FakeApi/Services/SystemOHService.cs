using AutoMapper;
using FakeApi.Common;
using FakeApi.Data;
using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FakeApi.Services;

public class SystemOHService
{
    private readonly IMapper _mapper;
    private readonly FakeContext _dbContext;
    private readonly ILogger<SystemOHService> _logger;

    public SystemOHService(FakeContext dbContext, ILogger<SystemOHService> logger, IMapper mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<(List<CompanyDto> listData, long totalCount)> GetCompany(ApiInput input)
    {
        var query = _dbContext.Company.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<CompanyDto>>(list), total);
    }

    public async Task<(List<HospitalDto> listData, long totalCount)> GetHospital(ApiInput input)
    {
        var query = _dbContext.Hospital.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<HospitalDto>>(list), total);
    }

    public async Task<(List<MomentTypeDto> listData, long totalCount)> GetMomentType(ApiInput input)
    {
        var query = _dbContext.MomentType.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<MomentTypeDto>>(list), total);
    }

    public async Task<(List<ProductDto> listData, long totalCount)> GetProduct(ApiInput input)
    {
        var query = _dbContext.Product.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<ProductDto>>(list), total);
    }

    public async Task<(List<UnitDto> listData, long totalCount)> GetUnit(ApiInput input)
    {
        var query = _dbContext.Unit.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<UnitDto>>(list), total);
    }

    public async Task<(List<WarehouseDto> listData, long totalCount)> GetWareHouse(ApiInput input)
    {
        var query = _dbContext.WareHouse.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<WarehouseDto>>(list), total);
    }

    public async Task<(List<WarehouseProductDto> listData, long totalCount)> GetWareHouseProduct(ApiInput input)
    {
        var query = _dbContext.WarehouseProduct.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<WarehouseProductDto>>(list), total);
    }
    
    public async Task<(List<WarehouseTransactionHistoryDto> listData, long totalCount)> GetWarehouseTransactionHistory(ApiInput input)
    {
        var query = _dbContext.WarehouseTransactionHistory.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<WarehouseTransactionHistoryDto>>(list), total);
    }
    
    public async Task<(List<WarehouseInputDto> listData, long totalCount)> GetWarehouseInput(ApiInput input)
    {
        var query = _dbContext.WarehouseInput.AsNoTracking();
        var total = await query.Select(x => x.Id).LongCountAsync();
        var list = await query.GetQueryByInput(input).ToListAsync();
        return (_mapper.Map<List<WarehouseInputDto>>(list), total);
    }
}