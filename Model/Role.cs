using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public decimal System_manage { get; set; }
        public decimal Speciality_manage { get; set; }
        public decimal Class_manage { get; set; }
        public decimal Course_manage { get; set; }
        public decimal Score_manage { get; set; }
        public decimal Student_manage { get; set; }
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
