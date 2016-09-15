using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IClassInfoDAL
    {
        int AddClassInfo();

        int UpdateClassInfoByClassInfoId();

        int DeleteClassInfoByClassInfoId();

        ClassInfo GetClassInfoByClassInfoId();

    }
}
