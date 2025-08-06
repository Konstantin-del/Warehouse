

using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.EntityConfigurations;

internal static class BalanceConfiguration
{
    internal static void ConfigureBalance(this ModelBuilder builder)
    {
        builder.Entity<Balance>()
            .Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Entity<Balance>()
            .Property(x => x.Amount)
            .IsRequired();
        builder.Entity<Balance>()
            .Property(x => x.ResourceId)
            .IsRequired();
        builder.Entity<Balance>()
           .Property(x => x.UnitId)
           .IsRequired();
        builder.Entity<Balance>()
            .HasOne(x => x.Resource)
            .WithOne(x => x.Balance)
            .HasForeignKey<Balance>(x => x.ResourceId);
        builder.Entity<Balance>()
            .HasOne(x => x.Unit)
            .WithMany(x => x.Balance)
            .HasForeignKey(x => x.UnitId);
    }
}
