using Microsoft.AspNetCore.Mvc;

namespace BookStore_MVC.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
