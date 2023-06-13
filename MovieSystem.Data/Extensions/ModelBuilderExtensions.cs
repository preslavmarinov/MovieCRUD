using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var pwd = "P@$$w0rd";
            var passwordHasher = new PasswordHasher<IdentityUser>();

            //Seed Roles
            var adminRole = new IdentityRole("Admin");
            adminRole.NormalizedName = adminRole.Name.ToUpper();

            var userRole = new IdentityRole("User");
            userRole.NormalizedName = userRole.Name.ToUpper();

            List<IdentityRole> roles = new List<IdentityRole>() { adminRole, userRole };

            builder.Entity<IdentityRole>().HasData(roles);

            //Seed Users
            var adminUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            var user = new IdentityUser
            {
                UserName = "user",
                Email = "user@gmail.com",
                EmailConfirmed = true,
            };
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            user.PasswordHash = passwordHasher.HashPassword(user, pwd);

            List<IdentityUser> users = new List<IdentityUser>() { adminUser, user };
            builder.Entity<IdentityUser>().HasData(users);

            //Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(x => x.Name == "Admin").Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(x => x.Name == "User").Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
