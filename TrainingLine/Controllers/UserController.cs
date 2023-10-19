using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TrainingLine.Models;
using TrainingLine.Repository;

namespace TrainingLine.Controllers
{
    public class UserController : Controller
    {
        public readonly UserRepository _userRepository = null;
        public UserController()
        {
                _userRepository = new UserRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            var res = _userRepository.Validate(login.UserName,login.Password);
            if (res)
            {
                return RedirectToAction("GetAllBooks", "Book");
            }
            else
            {
                return Content("UserNotFound");
            }
        }
    }
}
