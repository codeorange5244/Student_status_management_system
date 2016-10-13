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

        public bool UpdateScore(int score_id,double score_value, int submitter_id)
        {
            return idal.UpdateScore(score_id,score_value, submitter_id) > 0;
        }
    }
}
