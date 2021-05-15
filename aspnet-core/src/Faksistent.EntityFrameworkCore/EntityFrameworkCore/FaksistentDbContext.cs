using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Faksistent.Authorization.Roles;
using Faksistent.Authorization.Users;
using Faksistent.MultiTenancy;

namespace Faksistent.EntityFrameworkCore
{
    public class FaksistentDbContext : AbpZeroDbContext<Tenant, Role, User, FaksistentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FaksistentDbContext(DbContextOptions<FaksistentDbContext> options)
            : base(options)
        {
        }
    }
}
