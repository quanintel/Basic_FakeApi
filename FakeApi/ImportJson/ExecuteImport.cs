using AutoMapper;
using FakeApi.Common;
using FakeApi.Data;
using FakeApi.Data.Dtos;
using FakeApi.Data.Dtos.Custom;
using Company = FakeApi.Data.Entities.Company;

namespace FakeApi.ImportJson;

public class ExecuteImport
{
    private readonly IMapper _mapper;
    private readonly FakeContext _dbContext;

    public ExecuteImport(FakeContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task ReadFile<TDto, TEntity>(string jsonFilePath)
        where TDto : class
        where TEntity : class
    {
        var jsonData = await File.ReadAllTextAsync(jsonFilePath);

        var apiResponse = jsonData.ToObject<ApiResponseOH<TDto>>(); // Sử dụng JsonConvert nếu ToObject không có sẵn
        var mappedEntities = _mapper.Map<List<TEntity>>(apiResponse.Entries.Entry);

        await _dbContext.AddRangeAsync(mappedEntities);
        await _dbContext.SaveChangesAsync();
    }
}