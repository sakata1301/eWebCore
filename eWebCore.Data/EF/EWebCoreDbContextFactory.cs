using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWebCore.Data.EF
{
    class EWebCoreDbContextFactory : IDesignTimeDbContextFactory<EWebCoreDbContext>
    {
        public EWebCoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopCoreDB");

            var optionsBuilder = new DbContextOptionsBuilder<EWebCoreDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EWebCoreDbContext(optionsBuilder.Options);
        }
    }
}
