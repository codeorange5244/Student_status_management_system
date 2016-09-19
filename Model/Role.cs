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
        public int System_manage { get; set; }
        public int Speciality_manage { get; set; }
        public int Class_manage { get; set; }
        public int Course_manage { get; set; }
        public int Score_manage { get; set; }
        public int Student_manage { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 删除标识，0---未删除 1---已删除
        /// </summary>
        public int DelFlag { get; set; }
        /// <summary>
        /// 提交人Id
        /// </summary>
        public Nullable<int> Submitter_id { get; set; }
    }
}
