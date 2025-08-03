

using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.Configurations;

internal static class ClientConfiguration
{
    internal static void ConfigureClient(this ModelBuilder builder)
    {
        builder.Entity<Client>().Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Entity<Client>().Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(200);
        builder.Entity<Client>().Property(x => x.State)
            .IsRequired();
    }
}
