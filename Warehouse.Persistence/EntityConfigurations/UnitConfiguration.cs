

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.EntityConfigurations
{
    internal static class UnitConfiguration
    {
        internal static void ConfigureUnit(this ModelBuilder builder)
        {
            builder.Entity<Balance>()
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Entity<Unit>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<Unit>()
                .Property(x => x.State)
                .IsRequired();
        }
    }
}
