using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 成绩表
    /// </summary>
    public class Score
    {
        public int Id { get; set; }
        /// <summary>
        /// 课程Id
        /// </summary>
        public int Course_id { get; set; }
        /// <summary>
        /// 学生Id
        /// </summary>
        public int Student_id { get; set; }
        /// <summary>
        /// 分数
        /// </summary>
        public decimal Course_score { get; set; }
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
