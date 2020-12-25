using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RepositoryPattern
{
    public class RepositoryPatternContextFactory : IDesignTimeDbContextFactory<RepositoryPatternContext>
    {
        public RepositoryPatternContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                         .SetBasePath(Directory.GetCurrentDirectory())
                                         .AddJsonFile(@Directory.GetCurrentDirectory() + "/../RepositoryPattern/appsettings.json")
                                         .Build();

            var builder = new DbContextOptionsBuilder<RepositoryPatternContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new RepositoryPatternContext(builder.Options);
        }
    }
}
