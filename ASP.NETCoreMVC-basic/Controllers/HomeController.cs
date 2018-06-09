using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NETCoreMVC_basic.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETCoreMVC_basic.wwwroot.Controllers
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
        /*[ValidateAntiForgeryToken] */ // 유저가 서버로 폼 정보를 보낼 때 이 정보가 유저에게 제공된 폼 정보가 맞는지 토큰 비교, 크로스 사이트 스크립팅 예방책 https://docs.microsoft.com/ko-kr/aspnet/core/security/anti-request-forgery?view=aspnetcore-2.1
        public IActionResult Student(Student model)
        {
            //유효성 검사 
            if (ModelState.IsValid)
            {
                //model 데이터 저장 로직
            }
            else
            {
                //에러 로직
            }
            return View();
        }
    }
}
