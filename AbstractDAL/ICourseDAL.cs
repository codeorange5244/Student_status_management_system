using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface ICourseDAL
    {
        int AddCourse();

        int DeleteCourse();

        int UpdateCourseByCourseId();

        Course GetCourseByCourseId();

    }
}
