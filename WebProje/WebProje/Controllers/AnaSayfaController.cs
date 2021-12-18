using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class AnaSayfaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AnaSayfaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public String AciklamaMetni = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public IActionResult Index(int? id)
        {

            List<Kategori> categories = (from d in _db.Kategori
                                         select d).ToList();
            ViewData["categories"] = categories;
            ViewBag.Selected = id;


            if (id == null)
            {
                var dep2 = from d in _db.Content
                           select d;
                return View(dep2);

            }
            else
            {
                var dep = from d in _db.Content
                          where (d.CategoryId == id)
                          select d;

                return View(dep);
            }
        }
        
        public IActionResult BlogEntries(int id)
        {
            var icerik = from p in _db.Content
                         where (p.Id == id)
                         select p;
            return View(icerik);
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult MyProject()
        {
            return View();
        }
    }
}
