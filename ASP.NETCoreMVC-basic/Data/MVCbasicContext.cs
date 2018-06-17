using ASP.NETCoreMVC_basic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC_basic.Data
{
    public class MVCbasicContext : DbContext
    {
        public MVCbasicContext(DbContextOptions options) : base(options){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
 