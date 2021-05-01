using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Tanay",
                    Email = "tan@test.com",
                    UserName = "tan@test.com",
                    PhoneNumber = "9826648725",
                    Address = new Address
                    {
                        FirstName = "Tanay",
                        LastName = "Shah",
                        PhoneNumber = "9826648725",
                        Street = "Race Course",
                        City = "Indore",
                        State = "MP",
                        Country = "India",
                        Pincode = "452003"
                    }
                };

                await userManager.CreateAsync(user, "Test@2020");
            }
        }
    }
}