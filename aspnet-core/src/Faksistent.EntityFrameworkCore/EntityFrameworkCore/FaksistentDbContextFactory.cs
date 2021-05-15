using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Faksistent.Configuration;
using Faksistent.Web;

namespace Faksistent.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FaksistentDbContextFactory : IDesignTimeDbContextFactory<FaksistentDbContext>
    {
        public FaksistentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FaksistentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FaksistentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FaksistentConsts.ConnectionStringName));

            return new FaksistentDbContext(builder.Options);
        }
    }
}
