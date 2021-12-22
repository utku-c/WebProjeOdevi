//using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Data;
using WebProje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;

namespace WebProje.Controllers
{
    
    public class AnaSayfaController : Controller
    {

        private readonly IHtmlLocalizer<AnaSayfaController> _localizer;

        const string SessionAge = "_id";
        const string Indexx = "_id";
        private readonly WebProjeContext _db;

        public AnaSayfaController(WebProjeContext db, IHtmlLocalizer<AnaSayfaController> localizer)
        {
            _db = db;
            _localizer = localizer;
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
        public async Task<IActionResult> IndexDelete(int Id)
        {
            var comment = await _db.Comment.FindAsync(Id);
            _db.Remove(comment);
            await _db.SaveChangesAsync();
            // yaptığımız değişiklikleri kaydediyoruz

            return RedirectToAction(nameof(AnaSayfa));
            // Bizi tekrar index sayfasına döndürecek

        }
        
        
        public IActionResult YorumYap()
        {
            Comment comment = new Comment();

            /// Bu alınan bilgi 
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            
            
            string saat = DateTime.Now.Date.ToString();
            ViewBag.saat = saat;

            return View(comment);
        }
        public async Task<IActionResult> YorumCreate(Comment comment)
        {
            
            if (comment.Id == 0)
            {
                await _db.AddAsync(comment);
            }
            //else
            //{
            //    _db.Update(comment);
            //}
               

            await _db.SaveChangesAsync();

            string p = HttpContext.Session.GetInt32(SessionAge).ToString();

            return Redirect("/AnaSayfa/Index/"+p+"");
            // Bizi tekrar index sayfasına döndürecek

        }
        public IActionResult Index(int id)
        {
            var icerik = from p in _db.Content
                         where (p.Id == id)
                         select p;


            //index Sayfasının id sini Yorum sayfasına göndermeye çalışacağız
            /// Bu gönderilen Bilgi
            HttpContext.Session.SetInt32(SessionAge, id);
            HttpContext.Session.SetInt32(Indexx, id);

            //////-----



            ViewBag.YorumEkle =  new Comment();

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
            //var test = _localizer["BenKimim"];
            //ViewData["BenKimim"] = test;
            return View();
        }


        public IActionResult Index()
        {



            return View();
        }

        public IActionResult MyProject()
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
