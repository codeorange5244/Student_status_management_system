using StudentStatusManageSystem.AbstractDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverUserDAL : IUserDAL
    {
        public User GetUserByUserName()
        {
            return new User()
            {
                Id = 11,
                Name = "哈哈",
                Pwd = "sss"
            };
        }

        public User GetUserrByUserId()
        {
            throw new NotImplementedException();
        }
    }
}
