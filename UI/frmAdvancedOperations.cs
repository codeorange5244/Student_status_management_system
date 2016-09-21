using StudentStatusManageSystem.BLL;
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
    public partial class frmAdvancedOperations : Form
    {
        public frmAdvancedOperations()
        {
            InitializeComponent();
        }

        private void frmAdvancedOperations_Load(object sender, EventArgs e)
        {
            //加载所有登录用户根据删除标识 0----未删除，1----已删除
            LoadAllUsersByDelFlag(0);
            //加载所有角色信息根据删除标识 0----未删除，1---一已删除
            LoadAllRolesByDelFlag(0);
        }
        //加载所有角色信息根据删除标识 0----未删除，1---一已删除
        private void LoadAllRolesByDelFlag(int v)
        {
            RoleBLL bll = new RoleBLL();
            dgvRole.AutoGenerateColumns = false;    //不自动创建列
            dgvRole.DataSource = bll.GetAllRoleInfoByDelFlag(0);
        }

        /// <summary>
        ///加载所有登录用户到dgv中，根据删除标识 0----未删除，1----已删除 
        /// </summary>
        /// <param name="delFlag"></param>
        private void LoadAllUsersByDelFlag(int delFlag)
        {
            UserBLL bll = new UserBLL();
            dgvUser.DataSource = bll.GetAllUsersByDelFlag(delFlag);
        }

        private void txtSearchUser2_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvUser.SelectedRows.Count <= 0)
            {
                return;
            }
            //获取选中行 修改操作
            frmAddUser frm_edit_user = new frmAddUser();
            UserBLL bll = new UserBLL();

            User model = bll.GetUserrByUserId(Convert.ToInt32(dgvUser.SelectedRows[0].Cells[0].Value));
            if (model != null)
            {
                //查找到了该用户
                frm_edit_user.AddUserToEditUser(model);
                if (frm_edit_user.ShowDialog() == DialogResult.OK)  //判断是否修改成功
                {                   
                        LoadAllUsersByDelFlag(0); //刷新                                 
                }
            }
            else
            {
                //未查找到该用户，可能已被其它用户删除
                SelfForm.Msbox.Show("该用户可能已被删除，请重试");
                LoadAllUsersByDelFlag(0);   //刷新
            }

        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvUser.SelectedRows.Count <= 0)
            {
                return;
            }
            //获取选中行 修改操作
            frmAddRole frm_add_role = new frmAddRole();
            UserBLL bll = new UserBLL();
            Role model =(Role)dgvRole.SelectedRows[0].DataBoundItem;
            frm_add_role.AddRoleToEditRole(model);
            if(frm_add_role.ShowDialog()== DialogResult.OK)
            {
                LoadAllRolesByDelFlag(0);   //修改成功，刷新
            }
        }
    }
}
