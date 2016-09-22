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
        public int AddRole(Role model)
        {
            string sql = "INSERT INTO [dbo].[RoleInfo]([Name],[System_manage],[Speciality_manage],[Class_manage],[Course_manage],[Score_manage],[Student_manage],[Remark],[Submitter_id]) VALUES(@Name,@System_manage,@Speciality_manage,@Class_manage,@Course_manage,@Score_manage,@Student_manage,@Remark,@Submitter_id)";
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@System_manage",model.System_manage),
                new  SqlParameter("@Speciality_manage",model.Speciality_manage),
                new SqlParameter("@Class_manage",model.Class_manage),
                new SqlParameter("@Course_manage",model.Course_manage),
                new SqlParameter ("@Score_manage",model.Score_manage),
                new SqlParameter("@Student_manage",model.Student_manage),
                new SqlParameter("@Remark",model.Remark),
                new SqlParameter("@Submitter_id",model.Submitter_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteAllDeletedRoles()
        {
            string sql = "update RoleInfo set [DelFlag]=2 where [DelFlag]=1";
            return SqlserverHelper.ExecuteNonQuery(sql);
        }

        public int DeleteRoleByRoleId(int role_id,int submitter_id,int delFlag=1)
        {
            string sql = "Update RoleInfo set [DelFlag]="+delFlag+" , Submitter_id="+submitter_id+" where Id=" + role_id;
            return SqlserverHelper.ExecuteNonQuery(sql);
        }

        public List<Role> GetAllRoleInfoByDelFlag(int delflag)
        {
            //"select * from RoleInfo";
            string sql = "SELECT [Id] ,[Name],[System_manage],[Speciality_manage],[Class_manage],[Course_manage],[Score_manage],[Student_manage],[Remark],[Submitter_id],[DelFlag] FROM [dbo].[RoleInfo] where [DelFlag]="+delflag; 
            using(SqlDataReader reader= SqlserverHelper.ExecuteReader(sql))
            {
                List<Role> list = new List<Role>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(ReaderToRole(reader));                     
                    }
                }
            return list;
            }
        }

        private Role ReaderToRole(SqlDataReader reader)
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
            model.DelFlag = Convert.ToInt32(reader[10]);
            return model;
        }

        public List<string> GetAllRolePermissionBy()
        {
            return null;
        }

        public Role GetRoleByRoleId()
        {
            return null;
        }

        public List<Role> GetRolesByRoleIdAndDelFlag(int role_id, int delFlag = 0)
        {
            string sql = "SELECT [Id] ,[Name],[System_manage],[Speciality_manage],[Class_manage],[Course_manage],[Score_manage],[Student_manage],[Remark],[Submitter_id],[DelFlag] FROM [dbo].[RoleInfo] where [DelFlag]=" + delFlag + " and Id like '%" + role_id + "%'";
            using (SqlDataReader reader = SqlserverHelper.ExecuteReader(sql))
            {
                List<Role> list = new List<Role>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(ReaderToRole(reader));
                    }
                }
                return list;
            }
        }

        public int UpdateRoleByRoleId(Role model_role)
        {
            string sql = "UPDATE [dbo].[RoleInfo] SET[Name] =@Name,[System_manage] =@System_manage,[Speciality_manage] =@Speciality_manage,[Class_manage] = @Class_manage,[Course_manage] =@Course_manage,[Score_manage] =@Score_manage,[Student_manage] =@Student_manage,[Remark] =@Remark,[Submitter_id] = @Submitter_id where [DelFlag]=0 and [Id]=" + model_role.Id;
            SqlParameter[] ps =
            {
                new SqlParameter("@Name",model_role.Name    ),
                new SqlParameter("@System_manage",model_role.System_manage),
                new  SqlParameter("@Speciality_manage",model_role.Speciality_manage),
                new SqlParameter("@Class_manage",model_role.Class_manage),
                new SqlParameter("@Course_manage",model_role.Course_manage),
                new SqlParameter("@Score_manage",model_role.Score_manage),
                new SqlParameter("@Student_manage",model_role.Student_manage),
                new SqlParameter("@Remark",model_role.Remark),
                new SqlParameter("@Submitter_id",model_role.Submitter_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public List<Role> GetRolesByRoleNameAndDelFlag(string role_name, int delFlag=0)
        {
            string sql = "SELECT [Id] ,[Name],[System_manage],[Speciality_manage],[Class_manage],[Course_manage],[Score_manage],[Student_manage],[Remark],[Submitter_id],[DelFlag] FROM [dbo].[RoleInfo] where [DelFlag]=" + delFlag + " and Name like '%" + role_name + "%'";
            using (SqlDataReader reader = SqlserverHelper.ExecuteReader(sql))
            {
                List<Role> list = new List<Role>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(ReaderToRole(reader));
                    }
                }
                return list;
            }
        }
    }
}
