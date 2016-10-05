using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using System.Data;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverStudentDAL : IStudentDAL
    {
        public Student GetStudentByStudentId()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByStudentName()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudentByClassInfoId(int classInfo_id,int delFlag)
        {

            //      SELECT[Student_GUID]
            //,[Id]
            //,[Class_id]
            //,[Speciality_id]
            //,[Name]
            //,[ID_Card]
            //,[Sex]
            //,[Nationality]
            //,[Address]
            //,[Phone]
            //,[Political_role]
            //,[Posecode]
            //,[Remark]
            //,[Photograph]
            //,[Submitter_id]
            //,[DelFlag]
            //  FROM[dbo].[StudentInfo]
            string sql = "SELECT [Id],[Speciality_id],[Name],[ID_Card],[Phone],[Posecode]  FROM[dbo].[StudentInfo] WHERE [DelFlag]="+delFlag+" And [Class_Id]=" + classInfo_id;
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            List<Student> list = new List<Student>();
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    list.Add(RowToStudent(dr));
                }
            }
            return list;
        }
        private Student RowToStudent(DataRow dr)
        {
            Student model = new Student();
            model.Id = Convert.ToInt32(dr[0]);
            model.Speciality_id = Convert.ToInt32(dr[1]);
            model.Name = dr[2].ToString();
            model.ID_Card = dr[3].ToString();
            model.Phone = dr[4].ToString();
            model.Posecode = dr[5].ToString();
            return model;
        }
    }
}
