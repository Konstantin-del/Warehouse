

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.EntityConfigurations;

internal static class ResourceConfiguration
{
    internal static void ConfigureResource(this ModelBuilder builder)
    {
        builder.Entity<Resource>()
            .Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<Resource>()
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Entity<Resource>()
            .Property(x => x.State)
            .IsRequired();
    }
}
