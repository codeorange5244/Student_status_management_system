using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.BLL
{
    public class RoleBLL
    {
        IRoleDAL idal = SimpleFactory.DataBaseAccess.CreateRoleDAL();
        /// <summary>
        ///  获得所有Role数据根据删除标识
        /// </summary>
        /// <param name="delflag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Role> GetAllRoleInfoByDelFlag(int delFlag)
        {
            return idal.GetAllRoleInfoByDelFlag(delFlag);
        }
    }
}
