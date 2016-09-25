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
        public int College_id   //逻辑上存值，实际不存值，指向model_college
        {
            get { return Model_college.Id; }
            set { Model_college.Id = value; }
        }
        public DateTime Submit_datetime { get; set; }
        /// <summary>
        /// 删除标识，0---未删除 1---已删除
        /// </summary>
        public decimal DelFlag { get; set; }
        /// <summary>
        /// 提交人Id
        /// </summary>
        public Nullable<int> Submitter_id { get; set; }

        #region 数据库中不存在的属性
        public College Model_college = new College();     
        #endregion
    }
}
