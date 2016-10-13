using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteSpecialityDAL : ISpecialityDAL
    {
        public int AddSpeciality()
        {
            throw new NotImplementedException();
        }

        public int AddSpeciality(Speciality model)
        {
            throw new NotImplementedException();
        }

        public int DeleteAllDeletedSpeciality(int submitter_id)
        {
            throw new NotImplementedException();
        }

        public int DeleteSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public int DeleteSpecialityBySpecialityId(int specialityId, int submitterId, int delFlag = 1)
        {
            throw new NotImplementedException();
        }

        public List<Speciality> GetAllSpecialityByDelFlag(int delFlag)
        {
            throw new NotImplementedException();
        }

        public List<Speciality> GetAllSpecialityByDelFlagAndCollegeId(int delFlag, int college_id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> GetAllSpecialityIdAndNameByCollegeId(int college_id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> GetAllspecialityIdAndNameByDelFlag(int delFlag)
        {
            throw new NotImplementedException();
        }

        public Speciality GetSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public Speciality GetSpecialityBySpecialityId(int speciality_id)
        {
            throw new NotImplementedException();
        }

        public List<Speciality> GetSpecialityBySpecialityNameIdAndDelFlag(string specialityName, int delFlag)
        {
            throw new NotImplementedException();
        }

        public int UpdateSpecialityBySpecialityId()
        {
            throw new NotImplementedException();
        }

        public int UpdateSpecialityBySpecialityId(Speciality model)
        {
            throw new NotImplementedException();
        }
    }
}
