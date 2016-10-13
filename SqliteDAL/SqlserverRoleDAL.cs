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

        public int DeleteAllDeletedRoles()
        {
            throw new NotImplementedException();
        }

        public int DeleteRoleByRoleId(int role_id, int submitter_id, int delFlag = 1)
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

        public List<Role> GetRolesByRoleIdAndDelFlag(int role_id, int delFlag = 0)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRolesByRoleNameAndDelFlag(string role_name, int delFlag = 0)
        {
            throw new NotImplementedException();
        }

        public int UpdateRoleByRoleId(Role model_role)
        {
            throw new NotImplementedException();
        }
    }
}
