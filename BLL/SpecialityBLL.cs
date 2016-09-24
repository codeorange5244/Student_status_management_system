using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.BLL
{
    public class SpecialityBLL
    {
        ISpecialityDAL idal = SimpleFactory.DataBaseAccess.CreateSpecialityDAL();

        /// <summary>
        /// SpecialityInfo表添加一条数据
        /// </summary>
        /// <param name="model">Speciality实例</param>
        /// <returns></returns>
        public bool AddSpeciality(Speciality model)
        {
            return idal.AddSpeciality(model) > 0;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="id">专业Id</param>
        /// <returns></returns>
        public bool UpdateSpecialityBySpecialityId(Speciality model)
        {
            return idal.UpdateSpecialityBySpecialityId(model) > 0;
        }

        /// <summary>
        /// 获取所有"专业"数据，根据删除标识
        /// </summary>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Speciality> GetAllSpecialityByDelFlag(int delFlag,int college_id)
        {
            return idal.GetAllSpecialityByDelFlagAndCollegeId(delFlag,college_id);
        }
    }
}
