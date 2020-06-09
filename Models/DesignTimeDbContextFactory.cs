using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsft.Extensions.Configurations;
using System.IO;

namespace LibraryAPI.Models
{
    public class LibraryAPIContextFactory : IDesignTimeDbContextFactory<LibraryAPIContext>
    {
        LibraryAPIContext IDesignTimeDbContextFactory<LibraryAPIContext>.CreateDbObject(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<LibraryAPIContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new LibraryAPIContext(builder.Options)

        }
    }
}