﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.SimpleFactory;

namespace StudentStatusManageSystem.BLL
{
    public class StudentBLL
    {
        private IStudentDAL idal_student = DataBaseAccess.CreateStudentDAL();

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

        /// <summary>
        /// 根据班级Id和删除标识获得学生集合
        /// </summary>
        /// <param name="classInfo_id">班级Id</param>
        /// <param name="delFlag">删除标识：0---未删除，1---已删除</param>
        /// <returns></returns>
        public List<Student> GetAllStudentByClassInfoId(int classInfo_id, int delFlag=0)
        {
            return idal_student.GetAllStudentByClassInfoId(classInfo_id, delFlag);
        }

        /// <summary>
        /// 添加“学生”
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddStudent(Student model)
        {
            return idal_student.AddStudent(model) > 0;
        }

        /// <summary>
        /// 删除一个”学生“
        /// </summary>
        /// <param name="student_id">学生Id</param>
        /// <param name="id">执行人Id</param>
        /// <returns></returns>
        public bool SoftDeleteByStudentId(int student_id, int id)
        {
            return idal_student.SoftDeleteByStudentId(student_id, id)>0;
        }
    }
}
