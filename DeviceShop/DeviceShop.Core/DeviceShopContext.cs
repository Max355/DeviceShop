using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeviceShop.Core
{
    public class DeviceShopContext : IdentityDbContext<User>
    {
        public DeviceShopContext(DbContextOptions<DeviceShopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
    }
}