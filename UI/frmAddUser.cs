using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfForm;
using StudentStatusManageSystem.BLL;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.UI
{
    public partial class frmAddUser :Form   // CCWin.CCSkinMain
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            //从数据库中加载Role信息到下拉框
            RoleBLL bll = new RoleBLL();
            List<Role> list = bll.GetAllRoleInfoByDelFlag(0);
            cmbRole.DataSource = list;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断验证码和2次密码是否相同
            if(txtPwd1.Text!=txtPwd2.Text)
            {
                CCWin.MessageBoxEx.Show("两次密码不一样");
                return;
            }
            if (txtCode.Text.Trim().ToLower() != skinCode1.CodeStr.ToLower())
            {
                CCWin.MessageBoxEx.Show("验证码输入不正确!!");
                skinCode1.NewCode();
                return;
            }

            //处理数据
            User model = new User();
            UserBLL bll = new UserBLL();
            model.Name = txtName.Text.Trim();
            model.Pwd = txtPwd1.Text.Trim();
            model.Remark = txtRemark.Text.Trim();
            model.Role_id = (int)cmbRole.SelectedValue;
            model.Submitter_id = frmMain.current_user.Id;
            Msbox.Show(bll.AddUser(model)?"添加成功":"添加失败");
            this.Close();
        }

        private void skinCode1_Click(object sender, EventArgs e)
        {
            txtCode.Text = skinCode1.CodeStr;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {            
            msgDiv1.MsgDivShow(((Role)cmbRole.SelectedItem).Remark);
        }
    }
}
