using BookStore.Domain.Contracts.Service;
using BookStore_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore_MVC.Controllers
{
    public class HomeController(IBookService bookService, ICategoryService categoryService) : Controller
    {
        public IActionResult Index()
        {
            var model = new BookCategoryVm { 
                Books=bookService.GetRecentlyBooks(5),
                Categories=categoryService.GetPopularCategories(5) };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
