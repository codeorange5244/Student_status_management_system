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
        User GetUserrByUserId();

    }
}
