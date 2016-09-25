using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStatusManageSystem.UI
{
    public partial class frmAddAndDeleteCollege : Form
    {
        public frmAddAndDeleteCollege()
        {
            InitializeComponent();
        }

        private void btnAddCollege_Click(object sender, EventArgs e)
        {
            frmAddCollege frm = new frmAddCollege();
            frm.FormClosed += new FormClosedEventHandler((a, b) =>
            {
                LoadAllCollegeByDelFlag(0);  //刷新
            });
            frm.ShowDialog();
        }

        private void LoadAllCollegeByDelFlag(int delFalg)
        {
            BLL.CollegeBLL bll = new BLL.CollegeBLL();            
            dgvCollege.DataSource = bll.GetAllCollegeByDelFlag(delFalg, true);
            if (dgvCollege.Rows.Count > 0)
            {
                dgvCollege.Rows[0].Selected = false;
            }
        }

        private void frmAddAndDeleteCollege_Load(object sender, EventArgs e)
        {
            //加载学院信息
            LoadAllCollegeByDelFlag(0);
        }

        private void btnDeleteCollege_Click(object sender, EventArgs e)
        {
            if (dgvCollege.SelectedRows.Count > 0)
            {
                var selected_row = dgvCollege.SelectedRows[0];
                if (CCWin.MessageBoxEx.Show("是否要删除  " + selected_row.Cells[1].Value.ToString(), "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BLL.CollegeBLL bll = new BLL.CollegeBLL();
                    if (bll.DeleteCollegeByCollegeId(Convert.ToInt32(selected_row.Cells[0].Value), frmMain.current_user.Id))
                    {
                        CCWin.MessageBoxEx.Show("删除成功！");
                        LoadAllCollegeByDelFlag(0); //刷新
                    }
                    else
                    {
                        CCWin.MessageBoxEx.Show("删除失败，可能该数据已被删除或服务器异常请刷新后重试");
                    }

                }
            }
        }
    }
}
