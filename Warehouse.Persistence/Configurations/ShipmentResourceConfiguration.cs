

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.Configurations;

internal static class ShipmentResourceConfiguration
{
    internal static void ConfigureShipmentResource(this ModelBuilder builder)
    {
        builder.Entity<ShipmentResource>()
            .Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<ShipmentResource>()
            .Property(x => x.ResourceId)
            .IsRequired();
        builder.Entity<ShipmentResource>()
           .Property(x => x.UnitId)
           .IsRequired();
        builder.Entity<ShipmentResource>()
            .HasOne(x => x.Resource)
            .WithMany(x => x.ShipmentResource)
            .HasForeignKey(x => x.ResourceId);
        builder.Entity<ShipmentResource>()
            .HasOne(x => x.Unit)
            .WithMany(x => x.ShipmentResource)
            .HasForeignKey(x => x.UnitId);
    }
}
