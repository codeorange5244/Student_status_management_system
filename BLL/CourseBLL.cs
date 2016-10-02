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
    public class CourseBLL
    {
        ICourseDAL idal = DataBaseAccess.CreateCourseDAL();

        /// <summary>
        /// 根据“专业Id”得到所有所属课程,
        /// </summary>
        /// <param name="speiality_id">专业id</param>
        /// <param name="delfalg">删除标识 0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Course> GetCoursesBySpecialityId(int speciality_id,int delFlag = 0)
        {
            return idal.GetCoursesBySpecialityId(speciality_id, delFlag);
        }

        /// <summary>
        /// 软删除“课程”
        /// </summary>
        /// <param name="course_id">课程Id</param>
        /// <param name="submitter_id">执行人Id</param>
        /// <returns></returns>
        public bool SoftDeleteById(int course_id, int submitter_id,int delFlag=1)
        {
            return idal.SoftDeleteById(course_id, submitter_id, delFlag)>0;
        }

        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="model">数据实体</param>
        /// <returns></returns>
        public bool AddCourse(Course model)
        {
            return idal.AddCourse(model) > 0;
        }
    }
}
