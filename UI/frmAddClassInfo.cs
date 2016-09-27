using StudentStatusManageSystem.Model;
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
    public partial class frmAddClassInfo : CCWin.CCSkinMain
    {
        public frmAddClassInfo()
        {
            InitializeComponent();
        }
        public frmAddClassInfo(Action<string> delegate_y):this()
        {
            this.delegate_y = delegate_y;
        }

        private Action<string> delegate_y;

        private void frmAddClassInfo_Load(object sender, EventArgs e)
        {
            
            //145, 31
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.AutoSize = false;
                    ctl.Size = new Size(145, 31);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //检查用户输入
            if (CheckTxt())
            {
                if (CCWin.MessageBoxEx.Show("确认要新增该班级吗？请注意核对各项信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //取值生成 model对象
                    ClassInfo model = new ClassInfo();
                    model.Name = txtClassInfoName.Text.Trim();
                    model.Room_name = txtRoomName.Text.Trim();
                    model.School_reform = txtSchollReform.Text.Trim();
                    model.Specility_id = Convert.ToInt32(cbClassInfoSpeciality.SelectedValue);
                    model.Headteacher = txtHeadTeacher.Text.Trim();
                    model.Enrolment_time = dtEnrolmentSchool.Value;
                    model.Submitter_id = frmMain.current_user.Id;
                }
            }
        }

        private bool CheckTxt()
        {
            string msg = "";
            if (string.IsNullOrEmpty(txtClassInfoName.Text))
            {
                msg += "请输入班级名称\r\n";
            }
            if (string.IsNullOrEmpty(txtRoomName.Text))
            {
                msg += "请输入班级固定会议室地点\r\n";
            }
            
            if (msg == "")
            {
                return true;
            }
            else
            {
                CCWin.MessageBoxEx.Show(msg);
                return false;
            }
        }
        //检查是否存在会议室
        private void lbCheckRoom_Click(object sender, EventArgs e)
        {
            delegate_y(txtClassInfoName.Text);
        }
    }
}
