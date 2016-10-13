using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.SqliteDAL
{
    public class SqliteClassInfoDAL : IClassInfoDAL
    {
        public int AddClassInfo()
        {
            throw new NotImplementedException();
        }

        public int AddClassInfo(ClassInfo model)
        {
            throw new NotImplementedException();
        }

        public int DeleteClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> GetAllClassInfoIdAndNameBySpecialityId(int speciality_id)
        {
            throw new NotImplementedException();
        }

        public ClassInfo GetClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public ClassInfo GetClassInfoByClassInfoId(int class_id)
        {
            throw new NotImplementedException();
        }

        public List<ClassInfo> GetClassInfosBySpecialityId(int id, int delFlag)
        {
            throw new NotImplementedException();
        }

        public int UpdateClassInfoByClassInfoId()
        {
            throw new NotImplementedException();
        }

        public int UpdateClassInfoByDelFlag(ClassInfo model)
        {
            throw new NotImplementedException();
        }
    }
}
