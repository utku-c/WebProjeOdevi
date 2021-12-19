using Microsoft.AspNetCore.Authorization;
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
        private readonly WebProjeContext _db;

        public AnaSayfaController(WebProjeContext db)
        {
            _db = db;
        }

        public IActionResult AnaSayfa(int? id)
        {
            List<Kategori> categories = (from d in _db.Kategori
                                         select d).ToList();
            ViewData["categories"] = categories;
            
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

        
        
        public IActionResult Index(int id)
        {


            var icerik = from p in _db.Content
                         where (p.Id == id)

                         select p;

            List<Comment> commentcontent = (from p in _db.Comment
                                            where (p.ContentId == id)
                                            select p).ToList();
            //yorumları alıyoruz
            ViewData["comment"] = commentcontent;

            // yorum sayısını alıyoruz
            ViewData["commentCount"] = commentcontent.Count();

            // yorum puanlamasını alıyoruz
            List<int> yorumPuan = (from p in _db.Comment
                                   where (p.ContentId == id)
                                   select p.YorumPuan).ToList();
            int yildizSayisi = 0;
            for (int i = 0; i < yorumPuan.Count(); i++)
            {
                yildizSayisi = yildizSayisi + yorumPuan[i];
            }
            if (yorumPuan.Count != 0)
            {
                yildizSayisi = yildizSayisi / yorumPuan.Count();
            }
            else
            {
                yildizSayisi = 0;
            }

            ViewData["yildizSayisi"] = yildizSayisi;
            ViewData["yorumPuan"] = yorumPuan;

            return View(icerik);

            
        }

        public IActionResult AboutMe()
        {
            return View();
        }
        [Authorize]
        public IActionResult Login()
        {

            return View();
        }
    }
}
