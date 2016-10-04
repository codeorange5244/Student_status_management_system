using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.BLL;

namespace StudentStatusManageSystem.UI
{
    public partial class frmEditScore : CCSkinMain
    {
        public frmEditScore()
        {
            InitializeComponent();
        }

        private void frmEditScore_Load(object sender, EventArgs e)
        {
            ScoreBLL bll = new ScoreBLL();
            dgvCourse.DataSource = bll.GetAllScoreByTeacherId(frmMain.current_user.Id);
        }
        //单元格内容改变
        private void dgvCourse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var da = dgvCourse.Rows[e.RowIndex];
            
        }
        //添加新行
        private void dgvCourse_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
