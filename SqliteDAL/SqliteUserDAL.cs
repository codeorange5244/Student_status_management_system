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

        public int DeleteUserByUserId(int user_id, int submitter_id, int delFlag = 1)
        {
            throw new NotImplementedException();
        }

        public object GetUserByUserIdUserDelFlag(int user_id, int delFlag)
        {
            throw new NotImplementedException();
        }

        public object GetUsersByUserNameUserDelFlag(string user_name, int delFlag)
        {
            throw new NotImplementedException();
        }

        public int DeleteAllDeletedUsers(int submitter_id)
        {
            throw new NotImplementedException();
        }
    }
}
