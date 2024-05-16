using FakeApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FakeApi.Data.ConfigModelBuilder;

public class HospitalConfig : IEntityTypeConfiguration<Hospital>
{
    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        // builder.ToTable("Hospital");
        //
        // builder.HasKey(t => t.Id);
        //
        // builder.Property(t => t.Id)
        //     .IsRequired()
        //     .ValueGeneratedOnAdd();
        //
        // builder.Property(t => t.CompanyId);
        // builder.Property(t => t.CompanyCode);
        // builder.Property(t => t.CompanyNameE);
        // builder.Property(t => t.CompanyNameL);
        // builder.Property(t => t.AddressLine1E);
        // builder.Property(t => t.AddressLine1L);
        // builder.Property(t => t.AddressLine2E);
        // builder.Property(t => t.AddressLine2L);
        // builder.Property(t => t.AddressLine3E);
        // builder.Property(t => t.AddressLine3L);
        // builder.Property(t => t.City);
        // builder.Property(t => t.PostCode);
        // builder.Property(t => t.ActiveFlag);
        // builder.Property(t => t.ExternalFacilityId);
    }
}