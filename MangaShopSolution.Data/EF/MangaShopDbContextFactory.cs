using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaShopSolution.Data.EF
{
    public class MangaShopDbContextFactory : IDesignTimeDbContextFactory<MangaShopDbContext>
    {
        public MangaShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MangaShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<MangaShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MangaShopDbContext(optionsBuilder.Options);
        }
    }
}