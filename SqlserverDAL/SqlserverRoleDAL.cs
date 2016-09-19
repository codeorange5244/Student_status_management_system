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
    public class SqlserverRoleDAL : IRoleDAL
    {
        public List<Role> GetAllRoleInfoByDelFlag(int delflag)
        {
            //"select 除了DelFlag以外的列 from RoleInfo";
            string sql = "SELECT [Id] ,[Name],[System_manage],[Speciality_manage],[Class_manage],[Course_manage],[Score_manage],[Student_manage],[Remark],[Submitter_id] FROM[dbo].[RoleInfo] where [DelFlag]="+delflag; 
            using(SqlDataReader reader= SqlserverHelper.ExecuteReader(sql))
            {
                List<Role> list = new List<Role>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Role model = new Role();
                        model.Id = Convert.ToInt32(reader[0]);
                        model.Name = reader[1].ToString();
                        model.System_manage = Convert.ToInt32(reader[2]);
                        model.Speciality_manage = Convert.ToInt32(reader[3]);
                        model.Class_manage = Convert.ToInt32(reader[4]);
                        model.Course_manage = Convert.ToInt32(reader[5]);
                        model.Score_manage = Convert.ToInt32(reader[6]);
                        model.Student_manage = Convert.ToInt32(reader[7]);
                        model.Remark = reader[8].ToString();
                        model.Submitter_id = Convert.ToInt32(reader[9]);

                        list.Add(model);
                    }
                }
            return list;
            }
        }

        public Role GetRoleByRoleId()
        {
            return null;
        }
    }
}
