using Microsoft.AspNetCore.Identity;

namespace BookShoppingCartMvcUI.Data
{
    public class DbSSeeder
    {
        public static void SeedDefaultData(IServiceProvider service)
        {
            var userManager = service.GetService<UserManager<IdentityUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            //adding some role to db
        }
    }
}
