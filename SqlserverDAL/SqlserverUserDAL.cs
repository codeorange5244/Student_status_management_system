using StudentStatusManageSystem.AbstractDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;
using System.Data.SqlClient;
using System.Data;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverUserDAL : IUserDAL
    {
        public int AddUser(User model)
        {
            string sql = "INSERT INTO [dbo].[UserInfo]([Role_id],[Name],[Pwd],[Remark],[DelFlag],[Submitter_id]) VALUES(@Role_id,@Name,@Pwd,@Remark,@DelFlag,@Submitter_id)";
            SqlParameter[] ps =
            {
                new SqlParameter("Role_id",model.Role_id),
                new SqlParameter("Name",model.Name),
                new SqlParameter("Pwd",model.Pwd),
                new SqlParameter("Remark",model.Remark),
                new SqlParameter("DelFlag",model.DelFlag),
                new SqlParameter("Submitter_id",model.Submitter_id)
            };
           return  SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public object GetAllUsersByDelFlag(int delFlag)
        {
            //一张表的内连接
            //SELECT UserInfo.Id 编号, RoleInfo.Name 角色, UserInfo.Name 名字, UserInfo.Remark 备注, U1.Name 提交人 FROM[dbo].[UserInfo]
            //inner join RoleInfo on UserInfo.Role_id = RoleInfo.Id
            //inner join UserInfo U1 on U1.Id = UserInfo.Submitter_id

            string sql = "SELECT UserInfo.Id 编号,UserInfo.Name 名字,RoleInfo.Name 角色,UserInfo.Remark 备注,U1.Name 提交人 FROM[dbo].[UserInfo] inner join RoleInfo on UserInfo.Role_id = RoleInfo.Id inner join UserInfo U1 on U1.Id = UserInfo.Submitter_id where UserInfo.DelFlag="+delFlag;
            return SqlserverHelper.AdapterDataTable(sql);
        }        

        public object GetUserByUserIdUserDelFlag(int user_id,int delFlag)
        {
            string sql = "SELECT UserInfo.Id 编号,UserInfo.Name 名字,RoleInfo.Name 角色,UserInfo.Remark 备注,U1.Name 提交人 FROM[dbo].[UserInfo] inner join RoleInfo on UserInfo.Role_id = RoleInfo.Id inner join UserInfo U1 on U1.Id = UserInfo.Submitter_id where UserInfo.DelFlag=" + delFlag + " and UserInfo.Id like '%" + user_id + "%'";
            return SqlserverHelper.AdapterDataTable(sql);
        }

        public User GetUserByUserName()
        {
            return new User()
            {
                Name = "哈哈",
                Pwd = "sss"
            };
        }

        public User GetUserByUserId(int user_id)
        {
            string sql = "SELECT [Id], [Role_id],[Name],[Pwd],[Remark],[Submitter_id] FROM [dbo].[UserInfo] where [DelFlag]=0 and [Id]="+user_id;
            DataTable dt = SqlserverHelper.AdapterDataTable(sql);
            User model = null;
            if (dt.Rows.Count > 0)
            {
                model = new User();
                model.Id = Convert.ToInt32(dt.Rows[0][0]);
                model.Role_id = Convert.ToInt32(dt.Rows[0][1]);
                model.Name = dt.Rows[0][2].ToString();
                model.Pwd = dt.Rows[0][3].ToString();
                model.Remark = dt.Rows[0][4].ToString();
                model.Submitter_id = Convert.ToInt32(dt.Rows[0][5]);
            }
            return model;
        }       

        public int UpdateUserByUserId(User model)
        {
            string sql = "Update UserInfo set Name=@Name,Role_id=@Role_id,Pwd=@Pwd,Remark=@Remark,Submitter_id=@Submitter_id where Id=" + model.Id;
            SqlParameter[] ps = {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@Role_id",model.Role_id),
                new SqlParameter("@Pwd",model.Pwd ),
                new SqlParameter("@Remark",model.Remark),
                new  SqlParameter("@Submitter_id",model.Submitter_id)                
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteUserByUserId(int user_id,int submitter_id,int delFlag=1)
        {
            string sql = "Update UserInfo set [DelFlag]="+delFlag+" , Submitter_id="+submitter_id+" where Id="+user_id;
            return SqlserverHelper.ExecuteNonQuery(sql);
        }

        public object GetUsersByUserNameUserDelFlag(string user_name, int delFlag)
        {
            string sql = "SELECT UserInfo.Id 编号,UserInfo.Name 名字,RoleInfo.Name 角色,UserInfo.Remark 备注,U1.Name 提交人 FROM[dbo].[UserInfo] inner join RoleInfo on UserInfo.Role_id = RoleInfo.Id inner join UserInfo U1 on U1.Id = UserInfo.Submitter_id where UserInfo.DelFlag=" + delFlag + " and UserInfo.Name like '%" + user_name+"%'";
            return SqlserverHelper.AdapterDataTable(sql);
        }

        public int DeleteAllDeletedUsers(int submitter_id)
        {
            string sql = "update UserInfo set [DelFlag]=2 where [DelFlag]=1";
            return SqlserverHelper.ExecuteNonQuery(sql);
        }
    }
}
