using StudentStatusManageSystem.AbstractDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;
using System.Data.SqlClient;

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

        public User GetUserByUserName()
        {
            return new User()
            {
                Name = "哈哈",
                Pwd = "sss"
            };
        }

        public User GetUserrByUserId()
        {
            throw new NotImplementedException();
        }
    }
}
