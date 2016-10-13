using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteCourseDAL : ICourseDAL
    {
        public int AddCourse()
        {
            throw new NotImplementedException();
        }

        public int AddCourse(Course model)
        {
            throw new NotImplementedException();
        }

        public int DeleteCourse()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseByCourseId()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCoursesBySpecialityId(int speciality_id, int delfalg)
        {
            throw new NotImplementedException();
        }

        public int SoftDeleteById(int course_id, int submitter_id, int delFlag)
        {
            throw new NotImplementedException();
        }

        public int UpdateCourseByCourseId()
        {
            throw new NotImplementedException();
        }
    }
}
