using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.AbstractDAL
{
   public  interface IScoreDAL
    {
        DataTable GetAllScoreByTeacherId(int teacher_id);
    }
}
