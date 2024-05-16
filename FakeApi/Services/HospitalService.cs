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

public class HospitalService
{
    // private readonly IMapper _mapper;
    // private readonly FakeContext _dbContext;
    // private readonly ILogger<HospitalService> _logger;
    //
    // public HospitalService(FakeContext dbContext, ILogger<HospitalService> logger, IMapper mapper)
    // {
    //     _dbContext = dbContext;
    //     _logger = logger;
    //     _mapper = mapper;
    // }
    //
    // public async Task<(List<HospitalDto> listData, long totalCount)> Get(ApiInput input)
    // {
    //     var query = _dbContext.Hospital.AsNoTracking();
    //     var total = await query.Select(x => x.Id).LongCountAsync();
    //     var list = await query.GetQueryByInput(input).ToListAsync();
    //     return (_mapper.Map<List<HospitalDto>>(list), total);
    // }
    //
    // public async Task FakeData(int record)
    // {
    //     var list = new Faker<Hospital>("vi")
    //         .RuleFor(p => p.Id, Guid.NewGuid)
    //         .RuleFor(p => p.LastedUpdated, DateTime.Now)
    //         .RuleFor(p => p.CompanyId, new Guid("FA414405-AC08-4AF6-8080-001FCC640E53"))
    //         .RuleFor(p => p.CompanyCode, "HHN")
    //         .RuleFor(p => p.CompanyNameE, f => $"Viện {f.UniqueIndex}")
    //         .RuleFor(p => p.CompanyNameL, f => $"Viện {f.UniqueIndex}")
    //         .RuleFor(p => p.AddressLine1E, f => f.Address.Country())
    //         .RuleFor(p => p.AddressLine1L, f => f.Address.Country())
    //         .RuleFor(p => p.AddressLine2E, f => f.Address.Country())
    //         .RuleFor(p => p.AddressLine2L, f => f.Address.Country())
    //         .RuleFor(p => p.AddressLine3E, f => f.Address.Country())
    //         .RuleFor(p => p.AddressLine3L, f => f.Address.Country())
    //         .RuleFor(p => p.City, "Hà Nội")
    //         .RuleFor(p => p.PostCode, "Hà Nội")
    //         .RuleFor(p => p.ActiveFlag, f => f.Random.Int(1, 3))
    //         .RuleFor(p => p.ExternalFacilityId, Guid.NewGuid);
    //
    //     var rs = list.Generate(record);
    //     await _dbContext.BulkInsertAsync(rs);
    // }
}