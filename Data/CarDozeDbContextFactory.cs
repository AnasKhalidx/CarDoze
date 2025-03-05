using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

public class CarDozeDbContextFactory : IDesignTimeDbContextFactory<CarDozeDbContext>
{
    public CarDozeDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<CarDozeDbContext>();
        var connectionString = configuration.GetConnectionString("Default"); 
        builder.UseSqlServer(connectionString);

        return new CarDozeDbContext(builder.Options);
    }
}
