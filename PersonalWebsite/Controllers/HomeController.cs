using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public string Name = "Gerade";
        public Array Interests = new[] {
                                         ".NET", "C#", "Javascript", "Azure", "Sitefinity", "Xamarin", "Web", "Mobile" };

        public IActionResult Index()
        {
            return View();
        }
    }
}