
using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.Configurations;

internal static class IncomingDocumentConfiguration
{
    internal static void ConfigureIncomingDocument(this ModelBuilder builder)
    {
        builder.Entity<IncomingDocument>()
           .Property(x => x.Id)
           .IsRequired()
           .ValueGeneratedOnAdd();
        builder.Entity<IncomingDocument>()
            .Property(x => x.Number)
            .IsRequired();
        builder.Entity<IncomingDocument>()
            .Property(x => x.Date)
            .IsRequired();    
    }
}
