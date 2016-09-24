using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.BLL
{
    public class StudentBLL
    {
        private IStudentDAL idal_student = StudentStatusManageSystem.SimpleFactory.DataBaseAccess.CreateStudentDAL();

        /// <summary>
        /// 根据学生姓名获得学生集合
        /// </summary>
        /// <returns></returns>
        public  List<Student> GetStudentsByStudentName() { return null; }

        /// <summary>
        /// 获得学生对象根据学生Id
        /// </summary>
        /// <returns></returns>
        public  Student GetStudentByStudentId() { return null; }
    }
}
