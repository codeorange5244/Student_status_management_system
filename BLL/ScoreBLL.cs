using StudentStatusManageSystem.AbstractDAL;
using StudentStatusManageSystem.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.BLL
{
    public class ScoreBLL
    {
        IScoreDAL idal = DataBaseAccess.CreateScoreInfoDAL();
        public object GetAllScoreByTeacherId(int teacher_id)
        {
            return idal.GetAllScoreByTeacherId(teacher_id);
        }
    }
}
