using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteStudentDAL : IStudentDAL
    {
        public int AddStudent(Student model)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudentByClassInfoId(int classInfo_id, int delFlag)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByStudentId()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByStudentName()
        {
            throw new NotImplementedException();
        }

        public int SoftDeleteByStudentId(int student_id, int id)
        {
            throw new NotImplementedException();
        }
    }
}
