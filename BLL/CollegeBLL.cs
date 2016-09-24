using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.BLL
{
    public class CollegeBLL
    {
            AbstractDAL.ICollegeDAL idal = SimpleFactory.DataBaseAccess.CreateCollegeDAL();
        /// <summary>
        /// 添加学院
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddCollege(College model)
        {
            return idal.AddCollege(model)>0;
        }

        /// <summary>
        /// 得到所有College信息根据删除标识（经处理过的）
        /// </summary>
        /// <param name="delFlag">删除标识，默认为0---未删除，1---已删除</param>
        /// <returns></returns>
        public object GetAllCollegeByDelFlag(int delFlag,bool isSpecial)
        {
            return idal.GetAllCollegeByDelFlag(delFlag);
        }

        /// <summary>
        /// 得到所有College信息根据删除标识
        /// </summary>
        /// <param name="delFlag">删除标识，默认为0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<College> GetAllCollegeByDelFlag(int delFlag)
        {
            return idal.GetAllCollegeByDelFlag(delFlag);
        }

        /// <summary>
        /// 根据collegeId进行删除
        /// </summary>
        /// <param name="college_id"></param>
        /// <param name="delFlag">删除标识，默认为1,0---未删除，1---已删除</param>
        /// <returns></returns>
        public bool DeleteCollegeByCollegeId(int college_id,int submitter_id,int delFlag=1)
        {
            return idal.DeleteCollegeByCollegeId(college_id,submitter_id,delFlag) > 0;
        }
    }
}
