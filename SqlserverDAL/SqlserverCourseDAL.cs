using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using System.Data;
using System.Data.SqlClient;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverCourseDAL : ICourseDAL
    {
        public int AddCourse(Course model   )
        {
            string sql = "INSERT INTO COURSEINFO([Name],[Room_name],[Semester],[Speciality_id],[Submitter_id]) VALUES(@Name,@Room_name,@Semester,@Speciality_id,@Submitter_id) ";
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@Room_name",model.Room_name),
                new SqlParameter("@Semester",model.Semester),
                new SqlParameter("@Speciality_id",model.Speciality_id),
                new SqlParameter("@Submitter_id",model.Submitter_id)                
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteCourse()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseByCourseId()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCoursesBySpecialityId(int speciality_id, int delFlag)
        {
            string sql= "SELECT [Id],[Speciality_id],[Name],[Room_name],[Semester],[Submitter_id] FROM [dbo].[CourseInfo] WHERE [DelFlag]="+delFlag+" AND [Speciality_id]="+speciality_id;
            List<Course> list = new List<Course>();
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    list.Add(RowToCourse(dr));                   
                }
            }
            return list;
        }

        private Course RowToCourse(DataRow dr)
        {
            Course model = new Course();
            model.Id = Convert.ToInt32(dr[0]);
            model.Speciality_id = Convert.ToInt32(dr[1]);
            model.Name = dr[2].ToString();
            model.Room_name = dr[3].ToString();
            model.Semester = dr[4].ToString();
            model.Submitter_id = Convert.ToInt32(dr[5]);
            return model;
        }

        public int UpdateCourseByCourseId()
        {
            throw new NotImplementedException();
        }

        public int SoftDeleteById(int course_id, int submitter_id, int delFlag)
        {
            string sql = "Update CourseInfo set [DelFlag]=" + delFlag + " ,[Submitter_id]=" + submitter_id + " where [Id]=" + course_id;
            return SqlserverHelper.ExecuteNonQuery(sql);
        }
    }
}
