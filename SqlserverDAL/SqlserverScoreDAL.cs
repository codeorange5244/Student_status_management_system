using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverScoreDAL : IScoreDAL
    {
        public DataTable GetAllScoreByTeacherId(int teacher_id)
        {
            string sql = "select CourseInfo.Name as 课程名,CourseInfo.Id 课程编号, ScoreInfo.Student_id 学生编号,ScoreInfo.Score 分数 from ScoreInfo  inner join CourseInfo on CourseInfo.Id = ScoreInfo.Course_id inner join StudentInfo on StudentInfo.Id = ScoreInfo.Student_id inner join UserInfo on UserInfo.Id = CourseInfo.Heather_id where UserInfo.Id = " + teacher_id;
            return SqlserverHelper.AdapterDataTable(sql);
        }
    }
}
