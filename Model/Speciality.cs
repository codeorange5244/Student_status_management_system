using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 专业表
    /// </summary>
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public int College_id { get; set; }
        public DateTime Submit_date { get; set; }
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
