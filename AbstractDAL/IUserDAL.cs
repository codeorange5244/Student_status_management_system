using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IUserDAL
    {
        /// <summary>
        /// 获得用户对象根据用户姓名
        /// </summary>
        /// <returns></returns>
        User GetUserByUserName();


        /// <summary>
        /// 获得用户对象根据用户Id
        /// </summary>
        /// <returns></returns>
        User GetUserByUserId(int user_id);

        /// <summary>
        /// 添加新登录用户
        /// </summary>
        /// <param name="model">用户对象</param>
        /// <returns></returns>
        int AddUser(User model);

        /// <summary>
        /// 获得所有User表信息（经过处理的）
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns></returns>
       object GetAllUsersByDelFlag(int delFlag);

        /// <summary>
        /// 更新登录用户信息
        /// </summary>
        /// <param name="model">用户对象</param>
        /// <returns></returns>
        int UpdateUserByUserId(User model);
    }
}
