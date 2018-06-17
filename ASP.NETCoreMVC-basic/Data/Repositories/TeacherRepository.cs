using ASP.NETCoreMVC_basic.Data;
using ASP.NETCoreMVC_basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVCbasic.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MVCbasicContext _context;

        public TeacherRepository(MVCbasicContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAllTeachers() // list보다 효율성이 좋은 콜렉션
        {
            var result = _context.Teachers.ToList();

            return result;
        }

        public Teacher GetTeacher(int id)
        {
            var result = _context.Teachers.Find(id);

            return result;
        }
    }
}
