using FakeApi.Data.ConfigModelBuilder;
using FakeApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FakeApi.Data;

public class FakeContext : DbContext
{
    public FakeContext(DbContextOptions options) : base(options)
    {
    }

    // public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }
    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<Hospital> Hospital { get; set; }

    public virtual DbSet<Warehouse> WareHouse { get; set; }

    public virtual DbSet<WarehouseProduct> WarehouseProduct { get; set; }

    public virtual DbSet<Unit> Unit { get; set; }

    public virtual DbSet<Company> Company { get; set; }
    
    public virtual DbSet<MomentType> MomentType { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.ApplyConfiguration(new WeatherForecastConfig());
    //     modelBuilder.ApplyConfiguration(new ProductConfig());
    // }
}