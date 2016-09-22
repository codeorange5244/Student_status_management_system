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

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="model">角色对象</param>
        /// <returns></returns>
        public bool AddRole(Role model)
        {
            return idal.AddRole(model) > 0;
        }

        /// <summary>
        /// 修改角色信息根据角色Id
        /// </summary>
        /// <param name="model_role">角色对象</param>
        /// <returns></returns>
        public bool UpdateRoleByRoleId(Role model_role)
        {
            return idal.UpdateRoleByRoleId(model_role) > 0;
        }

        /// <summary>
        /// 删除Role
        /// </summary>
        /// <param name="role_id">角色Id</param>
        /// <param name="submitter_id">执行操作人的Id</param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public bool DeleteRoleByRoleId(int role_id, int submitter_id, int delFlag = 1)
        {
            return idal.DeleteRoleByRoleId(role_id, submitter_id, delFlag) > 0;
        }

        /// <summary>
        /// 清空所有已删除的Role
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllDeletedRoles()
        {
            return idal.DeleteAllDeletedRoles() > 0;
        }

        /// <summary>
        /// 获得Roles根据RoleId（使用like查询）
        /// </summary>
        /// <param name="role_id"></param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Role> GetRolesByRoleIdAndDelFlag(int role_id, int delFlag = 0)
        {
            return idal.GetRolesByRoleIdAndDelFlag(role_id, delFlag);
        }

        /// <summary>
        /// 获得Roles根据RoleName
        /// </summary>
        /// <param name="role_name"></param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Role> GetRolesByRoleNameAndDelFlag(string role_name, int delFlag=0)
        {
            return idal.GetRolesByRoleNameAndDelFlag(role_name, delFlag);
        }
    }
}
