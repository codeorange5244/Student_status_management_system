using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 班级表
    /// </summary>
    public class ClassInfo
    {
        public int Id { get; set; }
        public int Specility_id { get; set; }
        public string Name { get; set; }
        public string Room_name{ get; set; }
        /// <summary>
        /// 学制
        /// </summary>
        public string School_reform { get; set; }
        /// <summary>
        /// 班主任
        /// </summary>
        public string Headteacher { get; set; }
        /// <summary>
        /// 入学时间
        /// </summary>
        public Nullable<System.DateTime> Enrolment_time { get; set; }        
        /// <summary>
        /// 删除标识，0---未删除 1---已删除
        /// </summary>
        public decimal DelFlag { get; set; }
        /// <summary>
        /// 提交人Id
        /// </summary>
        public Nullable<int> Submitter_id { get; set; }
    }
}
