using System.Data;
using AutoMapper;
using Bogus;
using EFCore.BulkExtensions;
using FakeApi.Common;
using FakeApi.Data;
using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using FakeApi.Data.Entities;
using FakeApi.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FakeApi.Services;

public class ProductService
{
    // private readonly IMapper _mapper;
    // private readonly FakeContext _dbContext;
    // private readonly ILogger<ProductService> _logger;
    //
    // public ProductService(FakeContext dbContext, ILogger<ProductService> logger, IMapper mapper)
    // {
    //     _dbContext = dbContext;
    //     _logger = logger;
    //     _mapper = mapper;
    // }
    //
    // public async Task<(List<ProductDto> listData, long totalCount)> Get(ApiInput input)
    // {
    //     var query = _dbContext.Product.AsNoTracking();
    //     var total = await query.Select(x => x.Id).LongCountAsync();
    //     var list = await query.GetQueryByInput(input).ToListAsync();
    //     return (_mapper.Map<List<ProductDto>>(list), total);
    // }
    //
    // public async Task FakeData(int record)
    // {
    //     var itemName = new[]
    //     {
    //         "Kim bướm lấy máu 2 đầu 23G", "Găng tay nilon 1 chiếc Medico tiệt trùng",
    //         "Kim chọc hút tủy xương Bone marrow, biopsy 13G/ BTS-13100 , SURELOCK",
    //         "Thủy tinh thể nhân tạo Vivity toric/ DFT415/ Alcon/ Mỹ (1 Cái/ Hộp)",
    //         "Catheter chuyển phôi Tulip/ #4000, 25/hộp, IVF, Gynetics - Bỉ (Catheter chuyển phôi Tulip/ #4000,)/ Gynetics 4000 (#4000 Tulip S)/ OLEA"
    //     };
    //     var list = new Faker<Product>("vi")
    //         .RuleFor(p => p.LastedUpdated, DateTime.Now)
    //         .RuleFor(p => p.Id, Guid.NewGuid)
    //         
    //         .RuleFor(p => p.ItemId, Guid.NewGuid)
    //         .RuleFor(p => p.ItemGroupId, Guid.NewGuid)
    //         .RuleFor(p => p.ItemCode,
    //             f => $"BA.{f.Random.Number(0, 5)}.{f.Random.Number(0, 5)}.{f.Random.Number(0, 5)}")
    //         .RuleFor(p => p.ItemNameE, f => itemName[f.Random.Number(0, 3)])
    //         .RuleFor(p => p.ItemNameL, f => itemName[f.Random.Number(0, 3)])
    //         .RuleFor(p => p.Uom, f => $"UM-{f.UniqueIndex}")
    //         .RuleFor(p => p.ItemTypeRcd, f => $"INV-{f.UniqueIndex}")
    //         .RuleFor(p => p.SubItemTypeRcd, f => $"STK-{f.UniqueIndex}")
    //         
    //         .RuleFor(p => p.UserChargeableFlag, f => f.Random.Number(0, 2))
    //         .RuleFor(p => p.VariablePriceFlag, f => f.Random.Number(0, 2))
    //         .RuleFor(p => p.MandatoryCaregiverFlat, f => f.Random.Number(0, 2))
    //         .RuleFor(p => p.IpdChargeableFlag, f => f.Random.Number(0, 2))
    //         .RuleFor(p => p.OpdChargeableFlag, f => f.Random.Number(0, 2));
    //     var rs = list.Generate(record);
    //     await _dbContext.BulkInsertAsync(rs);
    // }
}