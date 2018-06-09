using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Student
    {

        //자바와는 달리 이런식으로 해주면 자동으로 게터세터가 만들어진다.
        //prop + tab + tab
        [BindNever] //name을 바인드 하지 않음.
        public string Name { get; set; }
        public int Age { get; set; }
        public String Country { get; set; }
    }
}
