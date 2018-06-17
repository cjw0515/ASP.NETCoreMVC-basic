using ASP.NETCoreMVC_basic.Data;
using ASP.NETCoreMVC_basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVCbasic.Data
{
    public class DbSeeder
    {
        private MVCbasicContext _context;

        public DbSeeder(MVCbasicContext context)
        {
            _context = context;
        }

        public async Task SeedDatabase()
        {
            if (!_context.Teachers.Any())
            {
                List<Teacher> teachers = new List<Teacher>(){
                new Teacher() { Name = "세종대왕", Class = "한글"},
                new Teacher() { Name = "이순신", Class = "병법"}
            };
                await _context.AddRangeAsync(teachers);//리스트 추가
                //await _context.AddAsync(new Teacher() { Name = "", Class = "" }); //하나 추가 시
                await _context.SaveChangesAsync();
            }
        }
    }
}
