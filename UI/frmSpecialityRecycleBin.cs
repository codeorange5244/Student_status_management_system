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
    public partial class frmSpecialityRecycleBin : Form
    {
        public frmSpecialityRecycleBin()
        {
            InitializeComponent();
        }

        private void frmSpecialityRecycleBin_Load(object sender, EventArgs e)
        {
            dgvSepciality.BeginInvoke(new Action(() =>
            {
                BLL.SpecialityBLL bll = new BLL.SpecialityBLL();
                dgvSepciality.AutoGenerateColumns = false;    //自动生成列取消
                var list = bll.GetAllSpecialityByDelFlag(1).Select(model => new
                {
                    model.Id,
                    model.Name,
                    Model_college_name = model.Model_college.Name,
                    model.Remark,
                    model.Submitter_id,
                    model.Submit_datetime
                });
                dgvSepciality.DataSource = list.ToList();
            }));
        }

        private void dgvSepciality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSepciality.Rows.Count > 0)
            {
                var selected_row = dgvSepciality.Rows[e.RowIndex];
                int id = Convert.ToInt32(selected_row.Cells[0].Value);
                BLL.SpecialityBLL bll = new BLL.SpecialityBLL();
                if (bll.DeleteSpecialityBySpecialityId(id, frmMain.current_user.Id, 0))
                {                    
                 CCWin.MessageBoxEx.Show("恢复成功！");  //这里莫名有时会报出异常：剪贴板啥啥啥异常
                    frmSpecialityRecycleBin_Load(sender, e);    //刷新
                }
                else
                {
                    CCWin.MessageBoxEx.Show("恢复失败，可能数据已损坏或数据库异常，请重试！！");
                }
            }
        }
    }
}
