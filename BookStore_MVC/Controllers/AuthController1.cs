using BookStore_MVC.Models;
using Domain.Contracts.Service;
using Domain.Dto;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_MVC.Controllers
{
    public class AccountController(IAuthService authService) : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegisterUserVm());
        }
        [HttpPost]
        public ActionResult Register(RegisterUserVm model)
        {
            if (model.ConfirmPassword != model.Password)
            {
                ViewBag.ConfirmPasswordError = "confirm password is not match";
                return View(model);
            }
            var newuser = new RegisterDto
            {
                Name = model.Name,
                Family = model.Family,
                Email = model.Email,
                Username = model.Username,
                Password = model.Password
            };
            authService.Register(newuser);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginUserVm());
        }
        [HttpPost]
        public ActionResult Login(LoginUserVm model)
        {
            var user = new LoginDto
            {
                Username = model.Username,
                Password = model.Password
            };
            var LogedinUser = authService.Login(user);
            if (LogedinUser == null)
            {
                ViewBag.LoginError = "Invalid Username/Password";
                return View(model);
            }
            else
            {
                if (LogedinUser.Role == Role.Admin) return RedirectToAction("Index", "Admin");
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
