using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface ISpecialityDAL
    {
        Speciality GetSpecialityBySpecialityId();

        /// <summary>
        /// SpecialityInfo表添加一条数据
        /// </summary>
        /// <param name="model">Speciality实例</param>
        /// <returns></returns>
        int AddSpeciality(Speciality model);

        int DeleteSpecialityBySpecialityId();

        int UpdateSpecialityBySpecialityId();

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="id">专业Id</param>
        /// <returns></returns>
        int UpdateSpecialityBySpecialityId(Speciality model);

        /// <summary>
        /// 获取所有"专业"数据，根据删除标识
        /// </summary>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Speciality> GetAllSpecialityByDelFlagAndCollegeId(int delFlag,int college_id);
    }
}
