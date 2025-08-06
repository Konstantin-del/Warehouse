

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.EntityConfigurations;

internal static class IncomingResourceConfiguration
{
    internal static void ConfigureIncomingResource(this ModelBuilder builder)
    {
        builder.Entity<IncomingResource>()
            .Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<IncomingResource>()
            .Property(x => x.Amount)
            .IsRequired();
        builder.Entity<IncomingResource>()
            .Property(x => x.ResourceId)
            .IsRequired();
        builder.Entity<IncomingResource>()
           .Property(x => x.UnitId)
           .IsRequired();
        builder.Entity<IncomingResource>()
            .HasOne(x => x.Resource)
            .WithMany(x => x.IncomingResource)
            .HasForeignKey(x => x.ResourceId);
        builder.Entity<IncomingResource>()
            .HasOne(x => x.Unit)
            .WithMany(x => x.IncomingResource)
            .HasForeignKey(x => x.UnitId);
    }
}
