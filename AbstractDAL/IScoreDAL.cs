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

        /// <summary>
        /// 更新成绩
        /// </summary>
        /// <param name="score_value">成绩</param>
        /// <param name="submitter_id"></param>
        /// <returns></returns>
        int UpdateScore( int score_id,double score_value, int submitter_id);
    }
}
