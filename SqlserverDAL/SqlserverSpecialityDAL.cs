using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;
using System.Data.SqlClient;

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

        public Speciality GetSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public int UpdateSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }
    }
}
