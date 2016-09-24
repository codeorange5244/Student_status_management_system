using StudentStatusManageSystem.AbstractDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteUserDAL : IUserDAL
    {
        public int AddUser(User model)
        {
            return 0;
        }

        public object GetAllUsersByDelFlag(int delFlag)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserName()
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserId(int user_id)
        {
            throw new NotImplementedException();
        }

        public int UpdateUserByUserId(User model)
        {
            throw new NotImplementedException();
        }
    }
}
