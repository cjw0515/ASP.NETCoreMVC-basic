using System.Collections.Generic;
using ASP.NETCoreMVC_basic.Models;

namespace ASP.NETCoreMVCbasic.Data.Repositories
{
    //함수들이 무슨 역할을 하는지 한눈에 알아 볼 수 있음.
    //인터페이스를 상속 받으면 테스트에 용이함(실제 데이터베이스를 사용하지 않아도 됨)
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}