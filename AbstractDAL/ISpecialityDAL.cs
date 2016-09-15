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

        int AddSpeciality();

        int DeleteSpecialityBySpecialityId();

        int UpdateSpecialityBySpecialityId();

    }
}
