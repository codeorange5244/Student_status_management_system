using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface ISpecialityDAL
    {
        Speciality GetSpecialityBySpecialityId();

        /// <summary>
        /// SpecialityInfo表添加一条数据
        /// </summary>
        /// <param name="model">Speciality实例</param>
        /// <returns></returns>
        int AddSpeciality(Speciality model);

        int DeleteSpecialityBySpecialityId();

        int UpdateSpecialityBySpecialityId();

    }
}
