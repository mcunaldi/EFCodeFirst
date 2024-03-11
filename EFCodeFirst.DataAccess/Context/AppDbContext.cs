using EFCodeFirst.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.DataAccess.Context;
public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<Category> Categories { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<Supplier> Suppliers { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasIndex(x => x.CategoryName);

        modelBuilder.Entity<Category>()
        .Property(e => e.Description)
        .HasColumnType("ntext");

        modelBuilder.Entity<Category>()
        .Property(e => e.Picture)
        .HasColumnType("image");



        modelBuilder.Entity<Employee>()
            .HasIndex(x => x.LastName);

        modelBuilder.Entity<Employee>()
            .HasIndex(x => x.PostalCode);

        modelBuilder.Entity<Employee>()
        .Property(e => e.BirthDate)
        .HasColumnType("datetime");

        modelBuilder.Entity<Employee>()
        .Property(e => e.HireDate)
        .HasColumnType("datetime");

        modelBuilder.Entity<Employee>()
        .Property(e => e.Notes)
        .HasColumnType("ntext");

        modelBuilder.Entity<Employee>()
        .Property(e => e.Photo)
        .HasColumnType("image");





        modelBuilder.Entity<Supplier>()
            .HasIndex(x => x.CompanyName);

        modelBuilder.Entity<Supplier>()
            .HasIndex(x => x.PostalCode);

        modelBuilder.Entity<Supplier>()
        .Property(e => e.HomePage)
        .HasColumnType("ntext");
    }
}
