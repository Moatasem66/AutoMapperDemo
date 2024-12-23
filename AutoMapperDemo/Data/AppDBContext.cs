using AutoMapperDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AutoMapperDemo.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
     : base(options)
    {

    }
    public DbSet<Customer>Customers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
