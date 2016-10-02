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
        /// 获取“某学院下”的所有"专业"数据，根据删除标识
        /// </summary>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <param name="college_id">学院Id</param>
        /// <returns></returns>
        List<Speciality> GetAllSpecialityByDelFlagAndCollegeId(int delFlag,int college_id);


        /// <summary>
        /// 获取所有“专业”信息根据删除标识
        /// </summary>
        /// <param name="delFlag">删除标识，0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Speciality> GetAllSpecialityByDelFlag(int delFlag);

        /// <summary>
        /// 删除一个专业
        /// </summary>
        ///<param name="specialityId">专业Id</param>
        ///<param name="submitterId">删除人Id</param>
        ///<param name="delFlag">删除标识默认为：1---已删除，0---未删除，2---回收站删除</param>
        /// <returns>受影响的行数</returns>
        int DeleteSpecialityBySpecialityId(int specialityId, int submitterId,int delFlag=1);

        /// <summary>
        /// 根据专业名称和删除标识 模糊查找
        /// </summary>
        /// <param name="specialityName"></param>
        /// <param name="delFlag"></param>
        /// <returns>可能的数据</returns>
        List<Speciality> GetSpecialityBySpecialityNameIdAndDelFlag(string specialityName, int delFlag);

        /// <summary>
        /// 删除已删除的“专业”数据
        /// </summary>
        /// <param name="submitter_id">执行人Id</param>
        /// <returns></returns>
        int DeleteAllDeletedSpeciality(int submitter_id);

        /// <summary>
        ///获取所有“专业” 的Id-Name 键值对
        /// </summary>
        /// <param name="delFlag">删除标识：0---未删除，1---已删除</param>
        /// <returns></returns>
        Dictionary<int, string> GetAllspecialityIdAndNameByDelFlag(int delFlag);
    }
}
