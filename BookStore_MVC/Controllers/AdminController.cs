using BookStore_MVC.Models;
using Domain.Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BookStore_MVC.Controllers
{
    public class AdminController(IUserService context) : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ManageUserVm
            {
                Users = context.GetAllUsers(),
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = context.GetUserById(id);
            var model = new EditUserVm
            {
                Id = user.Id,
                Name = user.Name,
                Family = user.Family,
                Password = user.Password
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditUserVm model)
        {
            if (!ModelState.IsValid) return View(model);
            var user = context.GetUserById(model.Id);
            if (user == null) return NotFound();
            user.Name = model.Name;
            user.Family = model.Family;
            user.Password = model.Password;
            context.UpdateUser(user);
            return RedirectToAction("Index", "Admin");
        }
        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            bool result = context.DeleteUser(id);
            if (!result) return NotFound();

            return RedirectToAction("Index", "Admin");

        }

    }
}
