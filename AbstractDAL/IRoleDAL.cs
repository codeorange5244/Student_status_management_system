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

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddRole(Role model);


        /// <summary>
        /// 修改角色信息根据角色Id
        /// </summary>
        /// <param name="model_role">角色对象</param>
        /// <returns></returns>
        int UpdateRoleByRoleId(Role model_role);

        /// <summary>
        /// 删除Role
        /// </summary>
        /// <param name="role_id">角色Id</param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        int DeleteRoleByRoleId(int role_id,int submitter_id,int delFlag=1);

        /// <summary>
        /// 清空所有已删除的Role
        /// </summary>
        /// <returns></returns>
        int DeleteAllDeletedRoles();

        /// <summary>
        /// 获得Roles根据RoleId（使用like查询）
        /// </summary>
        /// <param name="role_id"></param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Role> GetRolesByRoleIdAndDelFlag(int role_id, int delFlag=0);

        /// <summary>
        /// 获得Roles根据RoleName
        /// </summary>
        /// <param name="role_name"></param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Role> GetRolesByRoleNameAndDelFlag(string role_name, int delFlag=0);
    }
}
