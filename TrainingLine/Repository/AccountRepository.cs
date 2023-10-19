using Microsoft.AspNetCore.Identity;
using TrainingLine.Models;

namespace TrainingLine.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateUserAsync(SighUpUserModel user)
        {
            var users = new IdentityUser()
            {
                Email = user.Email,
                UserName = user.Password
            };
            var result = await _userManager.CreateAsync(users,user.Password);
            return result;
        }

        public Task<IdentityResult> CreateUserAsynk(SighUpUserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
