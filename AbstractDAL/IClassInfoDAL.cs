using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IClassInfoDAL
    {

        int UpdateClassInfoByClassInfoId();

        int DeleteClassInfoByClassInfoId();

        ClassInfo GetClassInfoByClassInfoId();

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddClassInfo(ClassInfo model);

        /// <summary>
        /// 根据“专业Id”查找其下所有班级
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<ClassInfo> GetClassInfosBySpecialityId(int id,int delFlag);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int UpdateClassInfoByDelFlag(ClassInfo model);
    }
}
