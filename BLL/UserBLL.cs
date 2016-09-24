using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.SimpleFactory;

namespace StudentStatusManageSystem.BLL
{
    public class UserBLL
    {
        private IUserDAL idal_user = DataBaseAccess.CreateUserDAL();

        //private IUserDAL idal_user=System.Reflection.Assembly().
        /// <summary>
        /// 获得用户对象根据用户姓名
        /// </summary>
        /// <returns></returns>
        public User GetUserByUserName()
        {
            User user = idal_user.GetUserByUserName();
            return user;
        }

        /// <summary>
        /// 获得用户对象根据用户Id
        /// </summary>
        /// <returns></returns>
        public User GetUserrByUserId(int user_id)
        {
            return  idal_user.GetUserByUserId(user_id);
        }

        /// <summary>
        /// 得到User（经处理过的）
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="delFlag"></param>
        /// <returns></returns>
        public object GetUserByUserIdUserDelFlag(int user_id,int delFlag)
        {
            return idal_user.GetUserByUserIdUserDelFlag(user_id, delFlag);
        }

        /// <summary>
        /// 获得所有User表中信息，根据删除标识
        /// </summary>
        /// <param name="delFlag">删除标识，0---未删除，1---已删除</param>
        /// <returns></returns>
        public object GetAllUsersByDelFlag(int delFlag)
        {
            return idal_user.GetAllUsersByDelFlag(delFlag);
        }

        /// <summary>
        /// 添加新登录用户
        /// </summary>
        /// <param name="model">用户对象</param>
        /// <returns></returns>
        public bool AddUser(User model)
        {
            model.Pwd = Helper_Class.GetMd5(model.Pwd);
            return idal_user.AddUser(model) > 0;
        }

        /// <summary>
        /// 更新登录用户信息
        /// </summary>
        /// <param name="model">用户对象</param>
        /// <returns></returns>
        public bool UpdateUserByUserId(User model)
        {
            //数据的检查
            //pwd不能为零之类
            return idal_user.UpdateUserByUserId(model) > 0;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user_id">用户Id</param>
        /// <param name="submitter_id">执行此操作人Id</param>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public bool DeleteUserByUserId(int user_id,int submitter_id,int delFlag=1)
        {
            return idal_user.DeleteUserByUserId(user_id,submitter_id,delFlag)>0;
        }

        /// <summary>
        /// 得到User（经处理过的）
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="delFlag"></param>
        /// <returns></returns>
        public object GetUsersByUserNameUserDelFlag(string user_name, int delFlag)
        {
            return idal_user.GetUsersByUserNameUserDelFlag(user_name, delFlag);
        }

        /// <summary>
        /// 清空所有已删除的User
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllDeletedUsers(int submitter_id)
        {
            return idal_user.DeleteAllDeletedUsers(submitter_id) > 0;
        }
    }
}
