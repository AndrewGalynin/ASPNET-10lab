using lab_10.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab_10.Controllers
{
    public class ConsultationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ConsultationRegistrationModel model)
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
