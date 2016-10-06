using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IStudentDAL
    {
        List<Student> GetStudentsByStudentName();
        Student GetStudentByStudentId();

        /// <summary>
        /// 根据班级Id和删除标识获得学生集合
        /// </summary>
        /// <param name="classInfo_id">班级Id</param>
        /// <param name="delFlag">删除标识：0---未删除，1---已删除</param>
        /// <returns></returns>
         List<Student> GetAllStudentByClassInfoId(int classInfo_id, int delFlag);

        /// <summary>
        /// 添加“学生”
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddStudent(Student model);

        /// <summary>
        /// 删除一个”学生“
        /// </summary>
        /// <param name="student_id">学生Id</param>
        /// <param name="id">执行人Id</param>
        /// <returns></returns>
        int SoftDeleteByStudentId(int student_id, int id);
    }
}
