using FakeApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FakeApi.Data.ConfigModelBuilder;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // builder.ToTable("Product");
        //
        // builder.HasKey(t => t.Id);
        //
        // builder.Property(t => t.Id)
        //     .IsRequired()
        //     .ValueGeneratedOnAdd();
        //
        // builder.Property(t => t.ItemId).IsRequired();
        // builder.Property(t => t.ItemGroupId).IsRequired();
        // builder.Property(t => t.LastedUpdated).IsRequired();
        // builder.Property(t => t.UserChargeableFlag).IsRequired();
        // builder.Property(t => t.VariablePriceFlag).IsRequired();
        // builder.Property(t => t.MandatoryCaregiverFlat).IsRequired();
        // builder.Property(t => t.IpdChargeableFlag).IsRequired();
        // builder.Property(t => t.OpdChargeableFlag).IsRequired();
        //
        // builder.Property(t => t.ItemCode).HasMaxLength(200);
        // builder.Property(t => t.ItemNameE).HasMaxLength(200);
        // builder.Property(t => t.ItemNameL).HasMaxLength(200);
        // builder.Property(t => t.Uom).HasMaxLength(200);
        // builder.Property(t => t.ItemTypeRcd).HasMaxLength(200);
        // builder.Property(t => t.SubItemTypeRcd).HasMaxLength(200);

    }
}