using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteRoleDAL : IRoleDAL
    {
        public int AddRole(Role model)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAllRoleInfoByDelFlag(int delFlag)
        {
            throw new NotImplementedException();
        }

        public Role GetRoleByRoleId()
        {
            throw new NotImplementedException();
        }
    }
}
