

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.EntityConfigurations;

internal static class ShipmentDocumentConfiguration
{
    internal static void ConfigureShipmentDocument(this ModelBuilder builder)
    {
        builder.Entity<ShipmentDocument>()
            .Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<ShipmentDocument>()
            .Property(x => x.Number)
            .IsRequired();
        builder.Entity<ShipmentDocument>()
            .Property(x => x.Date)
            .IsRequired();
        builder.Entity<ShipmentDocument>()
            .Property(x => x.State)
            .IsRequired();
        builder.Entity<ShipmentDocument>()
            .Property(x => x.ClientId)
            .IsRequired();
        builder.Entity<ShipmentDocument>()
            .HasOne(x => x.Client)
            .WithMany(x => x.Document)
            .HasForeignKey(x => x.ClientId);
    }
}
