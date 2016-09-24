using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.BLL
{
    public class SpecialityBLL
    {
        ISpecialityDAL idal = SimpleFactory.DataBaseAccess.CreateSpecialityDAL();

        /// <summary>
        /// SpecialityInfo表添加一条数据
        /// </summary>
        /// <param name="model">Speciality实例</param>
        /// <returns></returns>
        public bool AddSpeciality(Speciality model)
        {
            return idal.AddSpeciality(model) > 0;
        }
    }
}
