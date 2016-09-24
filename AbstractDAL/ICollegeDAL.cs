using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface ICollegeDAL
    {
        /// <summary>
        /// 添加一条College数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddCollege(College model);

        /// <summary>
        /// 得到所有College信息根据删除标识(经处理过的)
        /// </summary>
        /// <param name="delFlag">删除标识，默认为0---未删除，1---已删除</param>
        /// <returns></returns>
        object GetAllCollegeByDelFlag(int delFlag,bool isSpecial);

        /// <summary>
        /// 得到所有College信息根据删除标识
        /// </summary>
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// <returns></returns>
        List<College> GetAllCollegeByDelFlag(int delFlag);

        /// <summary>
        /// 根据collegeId进行删除
        /// </summary>
        /// <param name="college_id"></param>
        /// <returns></returns>
        int DeleteCollegeByCollegeId(int college_id,int submitter_id,int delFlag=1);
    }
}
