using _CoreDepertmanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace _CoreDepertmanWeb.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            ViewBag.baslik = "Departmanlar";
            var degerler = c.Departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            ViewBag.baslik = "Departman Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Departmanlar d)
        {
            c.Departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DepartmanSil(int id)
        {
            var dep=c.Departmanlars.Find(id);
            c.Departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
         
        }

    }
}
