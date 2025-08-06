using Microsoft.EntityFrameworkCore;
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.EntityConfigurations;

namespace Warehouse.Persistence;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    { 
        Database.EnsureCreated();
    }

    public DbSet<Resource> Resources { get; set; }
    public DbSet<Balance> Balances { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<IncomingDocument> IncomingDocuments { get; set; }
    public DbSet<IncomingResource> IncomingResource { get; set; }
    public DbSet<ShipmentDocument> ShipmentDocument { get; set; }
    public DbSet<ShipmentResource> ShipmentResource { get; set; }
    public DbSet<Unit> Units { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigureBalance();
        modelBuilder.ConfigureClient();
        modelBuilder.ConfigureIncomingDocument();
        modelBuilder.ConfigureIncomingResource();
        modelBuilder.ConfigureResource();
        modelBuilder.ConfigureShipmentDocument();
        modelBuilder.ConfigureShipmentResource();
        modelBuilder.ConfigureUnit();
    }
}
