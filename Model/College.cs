using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    /// <summary>
    /// 学院
    /// </summary>
    public class College
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// false---未删除，true---已删除
        /// </summary>
        public bool DelFalg { get; set; }        
        public int Submitter_id { get; set; }   
        public DateTime Submit_date { get; set; }
    }
}
