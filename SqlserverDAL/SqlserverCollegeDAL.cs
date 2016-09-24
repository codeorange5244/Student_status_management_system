using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqlserverDAL
{
    public class SqlserverCollegeDAL : AbstractDAL.ICollegeDAL
    {
        public int AddCollege(College model)
        {
            string sql = "insert into CollegeInfo(Name,Submitter_id) values(@Name,@Submitter_id)";
            System.Data.SqlClient.SqlParameter[] ps =
            {
                new System.Data.SqlClient.SqlParameter("@Name",model.Name),
                new System.Data.SqlClient.SqlParameter("@Submitter_id",model.Submitter_id)
            };
            return SqlserverHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteCollegeByCollegeId(int college_id,int submitter_id,int delFlag=0)
        {
            string sql = "Update CollegeInfo set [DelFlag]=" + delFlag + " ,[Submitter_id]=" + submitter_id + " where Id=" + college_id;
            return SqlserverHelper.ExecuteNonQuery(sql);
        }

        public object GetAllCollegeByDelFlag(int delFlag)
        {  
            string sql = "select CollegeInfo.Id 编号 ,CollegeInfo.Name 名称,CollegeInfo.Submitter_id 提交人编号,UserInfo.Name 提交人姓名,CollegeInfo.Submit_datetime 提交时间 from CollegeInfo inner join UserInfo on CollegeInfo.Submitter_id=UserInfo.Id where CollegeInfo.delflag=" + delFlag;
            return SqlserverHelper.AdapterDataTable(sql);
        }
    }
}
