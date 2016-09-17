using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 课程-班级-中间表
    /// </summary>
  public  class Class_Course
    {
        public int Id { get; set; }
        /// <summary>
        /// 班级Id
        /// </summary>
        public int Class_id { get; set; }
        /// <summary>
        /// 课程Id
        /// </summary>
        public int Course_id { get; set; }
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
