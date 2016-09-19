using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IRoleDAL
    {
        /// 根据Id查询角色
        Role GetRoleByRoleId();

        /// <summary>
        ///  获得所有Role数据根据删除标识
        /// </summary>
        /// <param name="delflag">0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Role> GetAllRoleInfoByDelFlag(int delflag);
    }
}
