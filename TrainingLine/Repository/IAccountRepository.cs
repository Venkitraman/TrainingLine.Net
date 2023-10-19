using Microsoft.AspNetCore.Identity;
using TrainingLine.Models;

namespace TrainingLine.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SighUpUserModel user);
        Task<IdentityResult> CreateUserAsynk(SighUpUserModel user);
    }
}