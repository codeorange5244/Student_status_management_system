using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface ICourseDAL
    {
        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="model">数据实体</param>
        /// <returns></returns>
        int AddCourse(Course model);

        int DeleteCourse();

        int UpdateCourseByCourseId();

        Course GetCourseByCourseId();

        /// <summary>
        /// 根据“专业Id”得到所有所属课程,
        /// </summary>
        /// <param name="speiality_id">专业id</param>
        /// <param name="delfalg">删除标识 0---未删除，1---已删除</param>
        /// <returns></returns>
        List<Course> GetCoursesBySpecialityId(int speciality_id, int delfalg);

        /// <summary>
        /// 软删除“课程”
        /// </summary>
        /// <param name="course_id">课程Id</param>
        /// <param name="submitter_id">
        /// <returns></returns>
        int SoftDeleteById(int course_id, int submitter_id, int delFlag);
    }
}
