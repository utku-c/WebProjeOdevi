using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Data;

namespace WebProje.Controllers
{
    public class KategoriController : Controller
    {
        private readonly ApplicationDbContext _db;

        public KategoriController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var kategori = from p in _db.Kategori
                           select p;


            return View(kategori);
        }
    }
}
