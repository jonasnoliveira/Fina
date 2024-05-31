using System.Reflection;
using Fina.Api.Data.Mappings;
using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Fina.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Transaction> Transactions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //calls one mapping/class at a time, specifies which model to use
        //modelBuilder.ApplyConfiguration(new CategoryMapping());
        //modelBuilder.ApplyConfiguration(new TransactionMapping());
        
        //or
        
        //calls all mappings/class that use IEntityTypeConfiguration
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
