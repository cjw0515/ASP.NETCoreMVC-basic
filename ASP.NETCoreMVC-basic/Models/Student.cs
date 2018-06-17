using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC_basic.Models
{
    public class Student
    {

        //자바와는 달리 이런식으로 해주면 자동으로 게터세터가 만들어진다.
        //prop + tab + tab
        //[BindNever] 
        //name을 바인드 하지 않음.    
        public int Id { get; set; } //db생성 시 꼭 필요함
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(15,70)]
        public int Age { get; set; }
        [Required, MinLength(5)]
        public String Country { get; set; }
    }
}
