using Microsoft.AspNetCore.Mvc;
using TrainingLine.Models;
using TrainingLine.Repository;

namespace TrainingLine.Controllers
{
    public class AccountController : Controller
    {
        public readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("signup")]
        public IActionResult signup()
        {
            return View();
        }
        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> signup(SighUpUserModel sighUpUser)
        {
            if(ModelState.IsValid)
            {
                var result = await _accountRepository.CreateUserAsync(sighUpUser);
                if (!result.Succeeded)
                {
                    foreach(var errorMessage  in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(sighUpUser); 
                }
                ModelState.Clear();
            }
            return View();
        }
        [Route("login")]
        public IActionResult login()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public IActionResult login(signIn signIn)
        {
            return View();
        }
    }
}
