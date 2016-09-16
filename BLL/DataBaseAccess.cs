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

        public static IUserDAL CreateUserDAL()
        {
            throw new NotImplementedException();
        }

        public IStudentDAL CreateStudentDAL()
        {
            throw new NotImplementedException();
        }

        public static IRoleDAL CreateRoleDAL()
        {
            throw new NotImplementedException();
        }

        public static IClassInfoDAL CreateClassInfoDAL()
        {
            throw new NotImplementedException();
        }

        public static ISpecialityDAL CreateSpecialityDAL()
        {
            throw new NotImplementedException();
        }

        public static ICourseDAL CreateCourseDAL()
        {
            throw new NotImplementedException();
        }

        public static IClassroomDAL CreateClassroomDAL()
        {
            throw new NotImplementedException();
        }

    }

}
