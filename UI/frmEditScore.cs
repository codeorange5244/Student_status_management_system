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
        bool IsLoading = true;   //是否正在加载窗体
        private void frmEditScore_Load(object sender, EventArgs e)
        {
            this.Text += frmMain.current_user.Name;
            //加载数据
            Load_dgcScore();            
            IsLoading = false;
        }

        private void Load_dgcScore()
        {
            ScoreBLL bll = new ScoreBLL();
            dgvCourse.DataSource = bll.GetAllScoreByTeacherId(frmMain.current_user.Id);
            //每行后面添加一个“确认添加”按钮
            DataGridViewButtonColumn col_Ok = new DataGridViewButtonColumn();
            col_Ok.Text = "确认修改";
            col_Ok.HeaderText = "操作";
            col_Ok.Width = 100;
            col_Ok.UseColumnTextForButtonValue = true;
            dgvCourse.Columns.Add(col_Ok);
            dgvCourse.Columns[4].Width = 80;
            dgvCourse.Columns[0].ReadOnly = true;    //课程号不能改
            dgvCourse.Columns[1].ReadOnly = true;   //课程名不能改
        }

        //单元格内容改变
        private void dgvCourse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {          
        }
        //添加新行
        private void dgvCourse_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (IsLoading)
            {
                return;
            }
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void frmEditScore_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //点击“确认修改”Button
        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //是否是点击了”确认修改“Button
            {
                if (CCWin.MessageBoxEx.Show("是否修改改名学生的成绩？", "系统提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    double score_value = Convert.ToDouble(dgvCourse.Rows[e.RowIndex].Cells[3].Value);
                    int score_id = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells[3].Value);
                    ScoreBLL bll = new ScoreBLL();
                    MessageBox.Show(bll.UpdateScore(score_id, score_value, frmMain.current_user.Id) ? "修改成功！" : "更新失败，请重试！！");
                    frmEditScore_Load(null, null);  //刷新
                }
            }
        }
    }
}