using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceShop.Core
{
    public static class DeviceShopDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new IdentityRole
                {
                    Id = USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER"
                }
                );

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@deviceshop.com",
                Email = "admin@deviceshop.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@deviceshop.com".ToUpper(),
                NormalizedUserName = "admin@deviceshop.com".ToUpper()
            };

            var user = new User
            {
                Id = USER_ID,
                UserName = "user@deviceshop.com",
                Email = "user@deviceshop.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@deviceshop.com".ToUpper(),
                NormalizedUserName = "user@deviceshop.com".ToUpper()
            };
            
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "admin$Pass1");
            user.PasswordHash = hasher.HashPassword(user, "user$Pass1");

            builder.Entity<User>().HasData(admin, user);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID
                }
                );
                
        }
    }
}
