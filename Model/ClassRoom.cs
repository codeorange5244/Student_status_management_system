using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 教室表
    /// </summary>
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
