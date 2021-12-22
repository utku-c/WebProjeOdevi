using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;

        public UserController(IStringLocalizer<UserController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {


            var nameSurnameValue = _localizer["nameSurname"];


            return View();
        }

        public IActionResult Create()
        {



            return View();
        }

        [HttpPost]
        public IActionResult Create(UserCreateRequestModel request)
        {



            return View(request);
        }


    }
}
