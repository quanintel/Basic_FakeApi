using AutoMapper;
using Bogus;
using EFCore.BulkExtensions;
using FakeApi.Common;
using FakeApi.Data;
using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FakeApi.Services;

public class WarehouseService
{
    // private readonly IMapper _mapper;
    // private readonly FakeContext _dbContext;
    // private readonly ILogger<WarehouseService> _logger;
    //
    // public WarehouseService(FakeContext dbContext, ILogger<WarehouseService> logger, IMapper mapper)
    // {
    //     _dbContext = dbContext;
    //     _logger = logger;
    //     _mapper = mapper;
    // }
    //
    // public async Task<(List<WarehouseDto> listData, long totalCount)> Get(ApiInput input)
    // {
    //     var query = _dbContext.WareHouse.AsNoTracking();
    //     var total = await query.Select(x => x.Id).LongCountAsync();
    //     var list = await query.GetQueryByInput(input).ToListAsync();
    //     return (_mapper.Map<List<WarehouseDto>>(list), total);
    // }
    //
    // public async Task FakeData(int record)
    // {
    //     var itemName = new[]
    //     {
    //         "HHN_Kho xét nghiệm huyết học",
    //         "HHN_Kho xét nghiệm sinh hóa",
    //         "HHN_Kho xét nghiệm nước tiểu",
    //         "HHN_Kho xét nghiệm khác"
    //     };
    //     var list = new Faker<Warehouse>("vi")
    //         .RuleFor(p => p.LastedUpdated, DateTime.Now)
    //         .RuleFor(p => p.Id, Guid.NewGuid)
    //
    //         .RuleFor(p => p.StoreId, Guid.NewGuid)
    //         .RuleFor(p => p.StoreCode, f => $"HHN_S0{f.Random.Int(0, 99)}")
    //         .RuleFor(p => p.StoreNameL, f => itemName[f.Random.Number(0, 3)])
    //         .RuleFor(p => p.StoreNameE, f => itemName[f.Random.Number(0, 3)])
    //         .RuleFor(p => p.CostCentreId, Guid.NewGuid)
    //         .RuleFor(p => p.CostCentreCode, f => $"{f.Random.Int(0000, 1100)}.{f.Random.Int(0000, 15555)}")
    //         .RuleFor(p => p.CompanyCode, "HHN")
    //         .RuleFor(p => p.StoreTypeRcd, "S")
    //         .RuleFor(p => p.AllowSalesFlag, f => f.Random.Int(0, 1))
    //         .RuleFor(p => p.AllowNegativeStockFlag, f => f.Random.Int(0, 1))
    //         .RuleFor(p => p.AutomaticStoreIssueReceiptFlag, f => f.Random.Int(0, 1))
    //         .RuleFor(p => p.LockDuringStockCheckFlag, f => f.Random.Int(0, 1));
    //
    //     var rs = list.Generate(record);
    //     await _dbContext.BulkInsertAsync(rs);
    // }
}