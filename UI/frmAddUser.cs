using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SelfForm.Msbox.Show(bll.AddUser(model)?"添加成功":"添加失败");
            this.Close();
        }

        #region 该窗体用于 修改登录用户
        /// <summary>
        /// 改变该窗体用途
        /// </summary>
        /// <param name="model"></param>
       public void AddUserToEditUser(User model)
        {            
            txtName.Text = model.Name;
            cmbRole.SelectedValue = model.Role_id;

            txtPwd2.Visible = false;    //不显示确认密码框
            label4.Visible = false;
            btnOk.Click -= btnOk_Click; //移除事件
            btnOk.Click += new EventHandler((a, b) =>   //注册事件
            {
                //判断验证码
                if (txtCode.Text.Trim().ToLower() != skinCode1.CodeStr.ToLower())
                {
                    CCWin.MessageBoxEx.Show("验证码输入不正确!!");
                    skinCode1.NewCode();
                    return;
                }
                //修改操作
                //先取值
                model.Name = txtName.Text.Trim();
                model.Pwd = txtPwd1.Text.Trim();
                model.Remark = txtRemark.Text.Trim();
                model.Role_id = (int)cmbRole.SelectedValue;
                model.Submitter_id = frmMain.current_user.Id;

                UserBLL bll = new UserBLL();
                bool result = bll.UpdateUserByUserId(model);
                SelfForm.Msbox.Show( result? "修改成功" : "修改失败");
                if (result)
                {
                    this.Close();
                    this.DialogResult = DialogResult.OK;    //修改成功，窗体的结果设为OK，给其调用者使用
                }
            });
        }
        #endregion

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
