using FastEndpointsDotNet.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FastEndpointsDotNet.Infrastructure.Persistence;

public sealed class FEDbContext : DbContext
{
    public FEDbContext(DbContextOptions<FEDbContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }

    // This is for entity (configuration) reading 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}

