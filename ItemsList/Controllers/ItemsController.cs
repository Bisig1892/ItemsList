using ItemsList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemsList.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "bat" };
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}
