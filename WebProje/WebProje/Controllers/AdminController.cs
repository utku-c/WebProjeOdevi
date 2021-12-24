using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly WebProjeContext _db;

        public AdminController(WebProjeContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            string admn = "utku.bilgin@ogr.sakarya.edu.tr";
            ViewBag.admin = admn; 
            return View();
        }

        public IActionResult ContentIndex()
        {
            var list = _db.Content.ToList();

            return View(list);
        }
        public IActionResult KategoriIndex()
        {
            var list = _db.Kategori.ToList();

            return View(list);
        }
        [Authorize]
        public async Task<IActionResult> Delete(int Id)
        {
            var content = await _db.Content.FindAsync(Id);
            _db.Remove(content);
            await _db.SaveChangesAsync();
            // yaptığımız değişiklikleri kaydediyoruz

            return RedirectToAction(nameof(Index));
            // Bizi tekrar index sayfasına döndürecek

        }
        [Authorize]
        public async Task<IActionResult> Create(Content content)
        {
            if (content.Id == 0)
            {
                await _db.AddAsync(content);
            }
            else
            {
                _db.Update(content);
            }
            
            await _db.SaveChangesAsync();
            
            return RedirectToAction(nameof(ContentIndex));
            // Bizi tekrar index sayfasına döndürecek

        }
        [Authorize]
        public IActionResult Content(int? Id)
        {
            Content content;
            List<Kategori> categories = (from d in _db.Kategori
                                         select d).ToList();
            ViewData["categories"] = categories;

            if (Id.HasValue)
            {
                content = _db.Content.Find(Id);
            }
            else
            {
                content = new Content();
            }

            
            return View(content);
        }

        //public async Task<IActionResult> UyeDelete(int Id)
        //{
        //    //var content = await _db.Content.FindAsync(Id);
        //    //_db.Remove(content);
        //    //await _db.SaveChangesAsync();
        //    // yaptığımız değişiklikleri kaydediyoruz

        //    return RedirectToAction(nameof(Index));
        //    // Bizi tekrar index sayfasına döndürecek

        //}
        public IActionResult Kategori(int? Id)
        {
            Kategori kategori;

            

            if (Id.HasValue)
            {
                kategori = _db.Kategori.Find(Id);
            }
            else
            {
                kategori = new Kategori();
            }

            return View(kategori);
        }
        
        public async Task<IActionResult> KategoriCreate(Kategori kategori)
        {
            
            if (kategori.Id == 0)
            {
                await _db.AddAsync(kategori);
            }
            else
            {
                _db.Update(kategori);
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(KategoriIndex));
            // Bizi tekrar index sayfasına döndürecek

        }
        public async Task<IActionResult> KategoriDelete(int Id)
        {
            var user = await _db.Kategori.FindAsync(Id);
            _db.Remove(user);
            await _db.SaveChangesAsync();
            // yaptığımız değişiklikleri kaydediyoruz

            return RedirectToAction(nameof(KategoriIndex));
            // Bizi tekrar index sayfasına döndürecek

        }
        
        public IActionResult User(int? Id)
        {
            User user;

            if (Id.HasValue)
            {
                user = _db.User.Find(Id);
            }
            else
            {
                user = new User();
            }
            
            string saat = DateTime.Now.Date.ToString();
            ViewBag.saat = saat;
            
            return View(user);
        }
        public IActionResult UserrIndex()
        {
            var list = _db.User.ToList();

            

            return View(list);
        }
        public async Task<IActionResult> UserCreate(User user)
        {
            if (user.Id == 0)
            {
                await _db.AddAsync(user);
            }
            else
            {
                _db.Update(user);
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(UserrIndex));
            // Bizi tekrar index sayfasına döndürecek

        }
        public async Task<IActionResult> UserDelete(int Id)
        {
            var uye = await _db.User.FindAsync(Id);
            _db.Remove(uye);
            await _db.SaveChangesAsync();
            // yaptığımız değişiklikleri kaydediyoruz

            return RedirectToAction(nameof(UserrIndex));
            // Bizi tekrar index sayfasına döndürecek

        }
        
    }
}
