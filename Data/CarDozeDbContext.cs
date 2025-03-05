using System;
using System.Collections.Generic;
using System.Text.Json;
using CarDoze.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CarDozeDbContext : IdentityDbContext
{
    public CarDozeDbContext(DbContextOptions<CarDozeDbContext> options) : base(options) { }

    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<CompareCar> CompareCars { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Partnership> Partnerships { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ShippingAddress> ShippingAddresses { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<CarFeature> CarFeatures { get; set; }
    public DbSet<CarCarFeature> CarCarFeatures { get; set; }
    public DbSet<CarModels> carModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<IdentityUser>();

        modelBuilder.Entity<IdentityUser>()
            .HasData(
                new IdentityUser { Id = "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA", UserName = "AdminA", NormalizedUserName = "ADMINA", Email = "Asem@gmail.com", NormalizedEmail = "ASEM@GMAIL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "admin123") },
                new IdentityUser { Id = "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508", UserName = "AdminB", NormalizedUserName = "ADMINB", Email = "Asem2@gmail.com", NormalizedEmail = "ASEM2@GMAIL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "admin123") },
                new IdentityUser { Id = "32986053-7EB3-4D44-9612-6AF63933353E", UserName = "AdminC", NormalizedUserName = "ADMINC", Email = "Asem3@gmail.com", NormalizedEmail = "ASEM3@GMAIL.COM", EmailConfirmed = true, PasswordHash = hasher.HashPassword(null, "admin123") }
            );

        modelBuilder.Entity<IdentityRole>()
            .HasData(new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" });

        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(
                new IdentityUserRole<string> { UserId = "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "32986053-7EB3-4D44-9612-6AF63933353E", RoleId = "1" });

        modelBuilder.Entity<CarModels>().HasKey(m => m.ModelsID);

        modelBuilder.Entity<Manufacturer>().HasKey(m => m.ManufacturerID);
        modelBuilder.Entity<Manufacturer>().Property(m => m.Name).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Manufacturer>().Property(m => m.Logo).IsRequired();
        modelBuilder.Entity<Manufacturer>().Property(m => m.Description).IsRequired().HasMaxLength(500);

        modelBuilder.Entity<Car>().HasKey(c => c.CarID);
        modelBuilder.Entity<Car>().Property(c => c.Name).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Car>().Property(c => c.Year).IsRequired();
        modelBuilder.Entity<Car>().Property(c => c.Price).IsRequired();
        modelBuilder.Entity<Car>().Property(c => c.FuelType).IsRequired().HasMaxLength(50);

        var converter = new ValueConverter<List<string>, string>(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>());

        modelBuilder.Entity<Car>()
            .Property(c => c.ImageURLs)
            .HasConversion(converter)
            .IsRequired()
            .HasColumnType("nvarchar(max)");
        modelBuilder.Entity<Car>().Property(c => c.Description).IsRequired().HasMaxLength(500);

        modelBuilder.Entity<CarFeature>().HasKey(cf => cf.CarFeatureID);
        modelBuilder.Entity<CarFeature>().Property(cf => cf.FeatureName).IsRequired().HasMaxLength(100);

        modelBuilder.Entity<CarCarFeature>()
            .HasKey(c => new { c.CarID, c.FeatureID });

        modelBuilder.Entity<CarCarFeature>()
            .HasOne(ccf => ccf.Car)
            .WithMany(c => c.CarFeatures)
            .HasForeignKey(ccf => ccf.CarID);

        modelBuilder.Entity<CarCarFeature>()
            .HasOne(ccf => ccf.CarFeature)
            .WithMany(cf => cf.CarCarFeatures)
            .HasForeignKey(ccf => ccf.FeatureID);

        modelBuilder.Entity<Wishlist>().HasKey(w => w.WishlistID);
        modelBuilder.Entity<Wishlist>().Property(w => w.CarID).IsRequired();

        modelBuilder.Entity<Order>().HasKey(o => o.OrderID);
        modelBuilder.Entity<Order>().Property(o => o.CarID).IsRequired();
        modelBuilder.Entity<Order>().Property(o => o.OrderDate).IsRequired();
        modelBuilder.Entity<Order>().Property(o => o.Status).HasMaxLength(50);
        modelBuilder.Entity<Order>().HasOne(o => o.ShippingAddress).WithMany().HasForeignKey(o => o.ShippingAddressID).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CompareCar>().HasKey(cc => cc.CompareID);
        modelBuilder.Entity<CompareCar>().Property(cc => cc.CarID).IsRequired();
        modelBuilder.Entity<CompareCar>().Property(cc => cc.ComparisonResult).HasMaxLength(255);
        modelBuilder.Entity<CompareCar>().HasOne(cc => cc.Car).WithMany(c => c.CompareCars).HasForeignKey(cc => cc.CarID).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Notification>().HasKey(n => n.NotificationID);
        modelBuilder.Entity<Notification>().Property(n => n.CarID).IsRequired();
        modelBuilder.Entity<Notification>().Property(n => n.Message).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Notification>().Property(n => n.Timestamp).IsRequired();
        modelBuilder.Entity<Notification>().Property(n => n.Status).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Notification>().HasOne(n => n.Car).WithMany().HasForeignKey(n => n.CarID).OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}
