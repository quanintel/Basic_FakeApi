using AutoMapper;
using FakeApi.Data;
using FakeApi.Data.Entities;
using FakeApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace FakeApi.Services;

public class WeatherForecastService
{
    // private readonly IMapper _mapper;
    // private readonly FakeContext _dbContext;
    // private readonly ILogger<WeatherForecastService> _logger;
    //
    // public WeatherForecastService(FakeContext dbContext, ILogger<WeatherForecastService> logger, IMapper mapper)
    // {
    //     _dbContext = dbContext;
    //     _logger = logger;
    //     _mapper = mapper;
    // }
    //
    // public async Task<List<WeatherForecastDto>> Get()
    // {
    //     var list = await _dbContext.WeatherForecast.ToListAsync();
    //     return _mapper.Map<List<WeatherForecastDto>>(list);
    // }
    //
    // public async Task FakeData()
    // {
    //     var summaries = new[]
    //     {
    //         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //     };
    //     var list = Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
    //         {
    //             Date = DateTime.Now.AddDays(index),
    //             TemperatureC = Random.Shared.Next(-20, 55),
    //             Summary = summaries[Random.Shared.Next(summaries.Length)]
    //         })
    //         .ToList();
    //     var listMap = _mapper.Map<List<WeatherForecast>>(list);
    //
    //     await _dbContext.AddRangeAsync(listMap);
    //     await _dbContext.SaveChangesAsync();
    // }
}