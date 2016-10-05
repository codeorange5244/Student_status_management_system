using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using System.Data.SqlClient;
using System.Data;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverClassInfoDAL : IClassInfoDAL
    {
        public int AddClassInfo(ClassInfo model)
        {
            string sql = "INSERT INTO[dbo].[ClassInfo]([Name],[Specility_id],[Room_name],[School_reform],[Headteacher],[Enrolment_time],[Submitter_id]) VALUES(@Name,@Specility_id,@Room_name,@School_reform,@Headteacher,@Enrolment_time,@Submitter_id)";
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@Specility_id",model.Specility_id),
                new SqlParameter("@Room_name",model.Room_name),
                new SqlParameter("@School_reform",model.School_reform),
                new SqlParameter ("@Headteacher",model.Headteacher),
                new SqlParameter("@Enrolment_time",model.Enrolment_time),
                new SqlParameter ("@Submitter_id",model.Submitter_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public ClassInfo GetClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public List<ClassInfo> GetClassInfosBySpecialityId(int id, int delFlag)
        {
            string sql = "SELECT [Id],[Name],[Speciality_id],[Room_name],[School_reform],[Headteacher],[Enrolment_time],[Submitter_id]  FROM[dbo].[ClassInfo] where [DelFlag]=" + delFlag + " and [Speciality_id]=" + id;
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            List<ClassInfo> list = new List<ClassInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToClassInfo(dr));
                }
            }
            return list;
        }

        private ClassInfo RowToClassInfo(DataRow dr)
        {
            ClassInfo model = new ClassInfo();
            model.Id = Convert.ToInt32(dr[0]);
            model.Name = dr[1].ToString();
            model.Specility_id = Convert.ToInt32(dr[2]);
            model.Room_name = dr[3].ToString();
            model.School_reform = dr[4].ToString();
            model.Headteacher = dr[5].ToString();
            model.Enrolment_time = Convert.ToDateTime(dr[6]);
            model.Submitter_id = Convert.ToInt32(dr[7]);
            return model;
        }

        public int UpdateClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public int UpdateClassInfoByDelFlag(ClassInfo model)
        {
            string sql = " UPDATE [dbo].[ClassInfo] SET[Speciality_id] = @Speciality_id,[Name] = @Name,[Room_name] =@Room_name,[School_reform] =@School_reform,[Headteacher] =@Headteacher,[Enrolment_time] =@Enrolment_time,[Submitter_id] = @Submitter_id WHERE [Id]=" + model.Id;
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter ("@Room_name",model.Room_name),
                new SqlParameter("@School_reform",model.School_reform),
                new SqlParameter("@Specility_id",model.Specility_id),
                new SqlParameter ("@Enrolment_time",model.Enrolment_time),
                new SqlParameter("@Submitter_id",model.Submitter_id),
                new SqlParameter("@Headteacher",model.Headteacher)
            };
            return SqlserverHelper.ExecuteNonQuery(sql,ps);
        }

        public Dictionary<int, string> GetAllClassInfoIdAndNameBySpecialityId(int speciality_id)
        {
            string sql= "SELECT [Id],[Name]  FROM[dbo].[ClassInfo] where [DelFlag]=0 and [Speciality_id]=" + speciality_id;
            Dictionary<int, string> dictonary = new Dictionary<int, string>();
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    dictonary.Add(Convert.ToInt32(dr[0]), dr[1].ToString());
                }
            }
            return dictonary;
        }
    }
}
