using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 登录用户表
    /// </summary>
    public class User
    {
        public int Id { get; }  //自动生成
        /// <summary>
        /// 角色Id
        /// </summary>
        public int Role_id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 删除标识，0---未删除 1---已删除
        /// </summary>
        public decimal DelFlag { get; set; }
        /// <summary>
        /// 提交人Id
        /// </summary>
        public Nullable<int> Submitter_id { get; set; }

        //以下为数据库中不存在的属性
        public Role current_role { get; set; }  
    }
}
