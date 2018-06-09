using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Student()
        {
            return View();
        }


        //bind키워드로 원하는 값만 받을 수 있다.
        //public IActionResult Student([Bind("Name, Age")] Student model)
        //{
        //    return View();
        //}

        //http post 값을 받는 역할을 한다.
        [HttpPost] 
        public IActionResult Student(Student model)
        {
            return View();
        }
    }
}
