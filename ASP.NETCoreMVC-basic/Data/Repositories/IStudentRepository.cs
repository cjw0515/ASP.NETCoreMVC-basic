using System.Collections.Generic;
using ASP.NETCoreMVC_basic.Models;

namespace ASP.NETCoreMVCbasic.Data.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        void Edit(Student student);
        void Delete(Student student);
        void Save();
    }
}