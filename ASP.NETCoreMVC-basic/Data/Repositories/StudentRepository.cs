using ASP.NETCoreMVC_basic.Data;
using ASP.NETCoreMVC_basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVCbasic.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MVCbasicContext _context;

        public StudentRepository(MVCbasicContext context)
        {
            _context = context;
        }
        
        //추가
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);//
        }

        //리스트
        public IEnumerable<Student> GetAllStudents()
        {
            var result = _context.Students.ToList();

            return result;
        }
        //데이터 하나 가져오기
        public Student GetStudent(int id)
        {
            var result = _context.Students.Find(id);
 
            return result;
        }

        //업데이트
        public void Edit(Student student)
        {
            _context.Update(student);
        }

        public void Save()
        {
            _context.SaveChanges(); //엔티티의 변화를 실제 적용하는 메서드 
        }

        //삭제
        public void Delete(Student student)
        {
            _context.Remove(student);
        }

    }
}
