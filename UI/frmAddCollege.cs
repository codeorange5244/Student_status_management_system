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
    public partial class frmAddCollege : Form
    {
        public frmAddCollege()
        {
            InitializeComponent();
        }

        private void frmAddCollege_Load(object sender, EventArgs e)
        {
            txtAddCollegeName.Size = new Size(181, 27);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddCollegeName.Text))
            {
                Model.College model = new Model.College();
                model.Name = txtAddCollegeName.Text.Trim();
                model.Submitter_id = frmMain.current_user.Id;
                BLL.CollegeBLL bll = new BLL.CollegeBLL();
                MessageBox.Show(bll.AddCollege(model)? "开设成功!!!" : "开设失败，请检查后重试!!!");
                txtAddCollegeName.Text = "";
            }
        }
    }
}
