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
    public partial class frmAddSpeciality : Form
    {
        public frmAddSpeciality()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSpeciality_Load(object sender, EventArgs e)
        {
            txtSpecialityName.AutoSize = false;
            txtSpecialityName.Size = new Size(182, 31); //调整文本框大小
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpecialityName.Text))
            {
                BLL.SpecialityBLL bll = new BLL.SpecialityBLL();
                Model.Speciality model = new Model.Speciality();
                model.Name = txtSpecialityName.Text.Trim(); 
                model.College_id = (int)cbCollege.SelectedValue;
                model.Remark = txtRemark.Text;
                model.Submitter_id = frmMain.current_user.Id;

                bool result = bll.AddSpeciality(model);
                this.DialogResult = result ? DialogResult.OK : DialogResult.No; //设置窗体结果
            }
        }
    }
}
