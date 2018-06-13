using System;
using System.Collections.Generic;
using ASP.NETCoreMVC_basic.Models;
using ASP.NETCoreMVCbasic.Models;

namespace ASP.NETCoreMVCbasic.ViewModels
{
    public class StudentTeacherViewModel
    {
        public Student Student { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
