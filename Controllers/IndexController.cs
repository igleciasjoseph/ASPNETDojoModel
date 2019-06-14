using Microsoft.AspNetCore.Mvc;
using DojoModel.Models;
namespace DojoModel.Controllers
{
    public class IndexController : Controller {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Survey s) {
            if (ModelState.IsValid) {
                string name = s.name;
                string location = s.location;
                string language = s.language;
                string comment = s.comment;
                return View("Result", s);
            } else {
                return View("Index");
            }
        }
    }
}