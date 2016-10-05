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
        /// 根据“专业Id”得到对象
        /// </summary>
        /// <param name="speciality_id"></param>
        /// <returns></returns>
        public Speciality GetSpecialityBySpecialityId(int speciality_id)
        {
            return idal.GetSpecialityBySpecialityId(speciality_id);
        }

        /// <summary>
        /// 获取所有“专业”信息根据删除标识
        /// </summary>
        /// <param name="delFlag">删除标识，0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Speciality> GetAllSpecialityByDelFlag(int delFlag)
        {
            return idal.GetAllSpecialityByDelFlag(delFlag);
        }

        /// <summary>
        /// 获取某学院下的所有"专业"数据，根据删除标识
        /// </summary>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <param name="college_id">学院Id</param>
        /// <returns></returns>
        public List<Speciality> GetAllSpecialityByDelFlagAndCollegeId(int delFlag,int college_id)
        {
            return idal.GetAllSpecialityByDelFlagAndCollegeId(delFlag,college_id);
        }

        /// <summary>
        /// 删除一个专业
        /// </summary>
        ///<param name="specialityId">专业Id</param>
        ///<param name="submitterId">删除人Id</param>
        ///<param name="delFlag">删除标识默认为：1---已删除，0---未删除，2---回收站删除</param>
        /// <returns></returns>
        public bool DeleteSpecialityBySpecialityId(int specialityId, int submitterId,int delFlag)
        {
            return idal.DeleteSpecialityBySpecialityId(specialityId, submitterId,delFlag) > 0;
        }

        /// <summary>
        /// 根据专业名称和删除标识 模糊查找
        /// </summary>
        /// <param name="specialityName"></param>
        /// <param name="delFlag"></param>
        /// <returns>可能的数据</returns>
        public List<Speciality> GetSpecialityBySpecialityNameIdAndDelFlag(string specialityName, int delFlag)
        {
            return idal.GetSpecialityBySpecialityNameIdAndDelFlag(specialityName, delFlag);
        }

        /// <summary>
        /// 删除已删除的“专业”数据
        /// </summary>
        /// <param name="submitter_id">执行人Id</param>
        /// <returns></returns>
        public bool DeleteAllDeletedSpeciality(int submitter_id)
        {
            return idal.DeleteAllDeletedSpeciality(submitter_id) > 0;
        }

        /// <summary>
        ///获取所有“专业” 的Id-Name 键值对
        /// </summary>
        /// <param name="delFlag">删除标识：0---未删除，1---已删除</param>
        /// <returns></returns>
        public Dictionary<int, string> GetAllspecialityIdAndNameByDelFlag(int delFlag)
        {
            return idal.GetAllspecialityIdAndNameByDelFlag(delFlag);
        }

        /// <summary>
        /// 获得所有 “专业” Id—Name键值对，根据学院Id
        /// </summary>
        /// <param name="college_id">学院Id</param>
        /// <returns></returns>
        public Dictionary<int, string> GetAllSpecialityIdAndNameByCollegeId(int college_id)
        {
            return idal.GetAllSpecialityIdAndNameByCollegeId(college_id);
        }
    }
}
