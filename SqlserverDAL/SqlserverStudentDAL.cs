using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverStudentDAL : IStudentDAL
    {
        public Student GetStudentByStudentId()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByStudentName()
        {
            throw new NotImplementedException();
        }
    }
}
