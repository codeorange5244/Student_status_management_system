using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.AbstractDAL;

namespace StudentStatusManageSystem.BLL
{
    public class DataBaseAccess
    {
        private static readonly string assemblyName;
        private static readonly string dbName;

        public IUserDAL CreateUserDAL()
        {
            throw new NotImplementedException();
        }

        public IStudentDAL CreateStudentDAL()
        {
            throw new NotImplementedException();
        }

        public IRoleDAL CreateRoleDAL()
        {
            throw new NotImplementedException();
        }

        public IClassInfoDAL CreateClassInfoDAL()
        {
            throw new NotImplementedException();
        }

        public ISpecialityDAL CreateSpecialityDAL()
        {
            throw new NotImplementedException();
        }

        public ICourseDAL CreateCourseDAL()
        {
            throw new NotImplementedException();
        }

        public IClassroomDAL CreateClassroomDAL()
        {
            throw new NotImplementedException();
        }

    }

}
