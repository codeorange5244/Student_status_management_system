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
    public class ClassInfoBLL
    {
        IClassInfoDAL idal = DataBaseAccess.CreateClassInfoDAL();

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddClassInfo(ClassInfo model)
        {
            return idal.AddClassInfo(model) > 0;
        }

        /// <summary>
        /// 根据“专业Id”查找其下所有班级(默认DelFlag=0）
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<ClassInfo> GetClassInfosBySpecialityId(int id,int delFlag=0)
        {
            return idal.GetClassInfosBySpecialityId(id,delFlag);
        }

        public ClassInfo GetClassInfoByClassInfoId(int class_id)
        {
            return idal.GetClassInfoByClassInfoId(class_id);
        }

        /// <summary>
        /// 根据专业得到班级
        /// </summary>
        /// <param name="speciality_id">专业Id</param>
        /// <returns></returns>
        public Dictionary<int, string> GetAllClassInfoIdAndNameBySpecialityId(int speciality_id)
        {
            return idal.GetAllClassInfoIdAndNameBySpecialityId(speciality_id);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateClassInfoByDelFlag(ClassInfo model)
        {
            return idal.UpdateClassInfoByDelFlag(model)>0;
        }

        public bool DeleteClassInfoByClassInfoId(int v, int id)
        {
            throw new NotImplementedException();
        }
    }
}
