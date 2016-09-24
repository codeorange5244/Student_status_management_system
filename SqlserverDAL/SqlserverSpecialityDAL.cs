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
    public class SqlserverSpecialityDAL : ISpecialityDAL
    {
        public int AddSpeciality(Speciality model)
        {
            string sql = "insert into SpecialityInfo(Name,College_id,Remark,Submitter_id) values(@Name,@College_id,@Remark,@Submitter_id)";
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@College_id",model.College_id),
                new SqlParameter("@Remark",model.Remark),
                new SqlParameter("@Submitter_id",model.Submitter_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public List<Speciality> GetAllSpecialityByDelFlagAndCollegeId(int delFlag,int college_id)
        {
            string sql = "SELECT [Id],[Name],[Remark],[Submitter_id],[Submit_datetime] FROM[dbo].[SpecialityInfo] where [College_id]="+college_id+" and [DelFlag]="+delFlag;
            List<Speciality> list = new List<Speciality>();
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    list.Add(RowToSpeciality(dr));
                }
            }
            return list;
        }

        private Speciality RowToSpeciality(DataRow dr)
        {
            Speciality model = new Speciality();
            model.Id = Convert.ToInt32(dr[0]);
            model.Name = Convert.ToString(dr[1]);
            model.Remark = Convert.ToString(dr[2]);
            model.Submitter_id = Convert.ToInt32(dr[3]);
            model.Submit_datetime = Convert.ToDateTime(dr[4]);
            return model;            
        }

        public Speciality GetSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public int UpdateSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public int UpdateSpecialityBySpecialityId(Speciality model)
        {
            //[Name] = <Name, varchar(50),>
            //[Remark] = <Remark, text,>
            //[Submitter_id] = <Submitter_id, int,>
            //[Submit_datetime] = <Submit_datetime, datetime,>  存的是新建时间，只在添加时赋值一次
            //[College_id] = <College_id, int,>
            //[DelFlag] = <DelFlag, numeric(1,0),>
            string sql = "Update SpecialityInfo set [Name]=@Name,[Remark]=@Remark,[Submitter_id]=@Submitter_id,[College_id]=@College_id where [Id]=" + model.Id + " and [DelFlag]=0";
            SqlParameter[] ps =
            {
                new SqlParameter ("@Name",model.Name),
                new SqlParameter("@Remark",model.Remark),
                new SqlParameter("@Submitter_id",model.Submitter_id),
                new SqlParameter ("@College_id",model.College_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
