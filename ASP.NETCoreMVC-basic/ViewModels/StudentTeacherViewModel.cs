﻿using System;
using System.Collections.Generic;
using ASP.NETCoreMVC_basic.Models;

namespace ASP.NETCoreMVC_basic.ViewModels
{
    public class StudentTeacherViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
