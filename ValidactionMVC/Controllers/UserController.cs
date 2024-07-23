using Microsoft.AspNetCore.Mvc;
using ValidactionMVC.Models;

namespace ValidactionMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            { 
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
