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
        private void LoadAllRolesByDelFlag(int delFlag)
        {
            RoleBLL bll = new RoleBLL();
            dgvRole.AutoGenerateColumns = false;    //不自动创建列
            dgvRole.DataSource = bll.GetAllRoleInfoByDelFlag(delFlag);
        }

        /// <summary>
        ///加载所有登录用户到dgv中 根据删除标识 0----未删除，1----已删除 
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
            //判断是否被删除
            if (Convert.ToInt32(dgvRole.SelectedRows[0].Cells["RoleDelFlag"].Value) != 0)
            {
                MessageBox.Show("该数据已被删除");
                return;
            }
            //获取选中行 修改操作
            frmAddRole frm_add_role = new frmAddRole();
            UserBLL bll = new UserBLL();
            Role model = (Role)dgvRole.SelectedRows[0].DataBoundItem;
            frm_add_role.AddRoleToEditRole(model);
            if (frm_add_role.ShowDialog() == DialogResult.OK)
            {
                LoadAllRolesByDelFlag(0);   //修改成功，刷新
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvUser.SelectedRows.Count <= 0)
            {
                return;
            }
            //操作
            UserBLL bll = new UserBLL();
            bool result = bll.DeleteUserByUserId(Convert.ToInt32(dgvUser.SelectedRows[0].Cells[0].Value), frmMain.current_user.Id);
            CCWin.MessageBoxEx.Show(result ? "删除  " + dgvUser.SelectedRows[0].Cells[1].Value.ToString() + "  成功!" : "删除失败，该数据可能已被损坏，请刷新列表后重试");
            LoadAllUsersByDelFlag(0);   //刷新
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvRole.SelectedRows.Count <= 0)
            {
                return;
            }
            //操作
            RoleBLL bll = new RoleBLL();
            bool result = bll.DeleteRoleByRoleId(Convert.ToInt32(dgvRole.SelectedRows[0].Cells[0].Value), frmMain.current_user.Id);
            CCWin.MessageBoxEx.Show(result ? "删除  " + dgvRole.SelectedRows[0].Cells[1].Value.ToString() + "   成功!" : "删除失败，该数据可能已被损坏，请刷新列表后重试");
            LoadAllRolesByDelFlag(0);   //刷新
        }

        private void btnUserRecycleBin_Click(object sender, EventArgs e)
        {
            LoadAllUsersByDelFlag(1);   //加载User回收站
            IsShowingDeletedUser = true;    //正在显示已删除User
            skinButton1.Visible = true;     //退出回收站Button可用
            skinButton3.Visible = true;     //清空回收站Button可用
            btnRestoreUser.Visible = true;  //还原选中项Button可用
        }

        private void btnRoleRecycleBin_Click(object sender, EventArgs e)
        {
            LoadAllRolesByDelFlag(1);   //加载Role回收站
            skinButton2.Visible = true; //退出回收站Button可用
            skinButton4.Visible = true;     //清空回收站Button可用
            btnRestoreRole.Visible = true;  //还原选中项可用
        }

        //根据用户编号查找
        private bool IsShowingDeletedUser = false;  //是否界面显示的是已删除的User
        private void btnSearchUser1_Click(object sender, EventArgs e)
        {
            LoadUserByUserId(IsShowingDeletedUser ? 1 : 0);
        }
        /// <summary>
        ///根据用户编号和删除标识查找
        /// <param name="delFlag">0---未删除，1---已删除</param>
        /// </summary>
        private void LoadUserByUserId(int delFlag)
        {
            //检查值
            if (!string.IsNullOrEmpty(txtSearchUser1.Text))
            {
                UserBLL bll = new UserBLL();
                dgvUser.DataSource = bll.GetUserByUserIdUserDelFlag(Convert.ToInt32(txtSearchUser1.Text), delFlag);
            }
        }

        //根据用户姓名查找
        private void btnSearchUser2_Click(object sender, EventArgs e)
        {
            LoadUserByUserName(IsShowingDeletedUser ? 1 : 0);
        }
        /// <summary>
        /// 根据用户姓名和删除标识查找
        /// </summary>
        /// <param name="delFlag"></param>
        private void LoadUserByUserName(int delFlag)
        {
            if (!string.IsNullOrEmpty(txtSearchUser2.Text))
            {
                UserBLL bll = new UserBLL();
                dgvUser.DataSource = bll.GetUsersByUserNameUserDelFlag(txtSearchUser2.Text, delFlag);
            }
        }

        private void txtSearchUser1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchUser1.Text))
            {
                LoadAllUsersByDelFlag(IsShowingDeletedUser ? 1 : 0);
            }
            else
            {
                btnSearchUser1_Click(sender, e);
            }
        }

        private void txtSearchUser2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchUser2.Text))
            {
                LoadAllUsersByDelFlag(IsShowingDeletedUser ? 1 : 0);
            }
            else
            {
                btnSearchUser2_Click(sender, e);
            }
        }
        //只能输数字
        private void txtSearchUser1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //退出回收站
        private void skinButton1_Click(object sender, EventArgs e)
        {
            LoadAllUsersByDelFlag(0);
            IsShowingDeletedUser = false;
            skinButton1.Visible = false;    //退出回收站Button不可用
            skinButton3.Visible = false;     //清空回收站Button不可用
            btnRestoreUser.Visible = false;  //还原选中项Button不可用
        }

        //退出回收站
        private void skinButton2_Click(object sender, EventArgs e)
        {
            LoadAllRolesByDelFlag(0);
            IsShowingDeletedRole = false;
            skinButton2.Visible = false;    //退出回收站Button不可用
            skinButton4.Visible = false;     //清空回收站Button不可用
            btnRestoreRole.Visible = false;  //还原选中项不可用
        }

        //清空回收站
        private void skinButton3_Click(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            CCWin.MessageBoxEx.Show(bll.DeleteAllDeletedUsers(frmMain.current_user.Id) ? "清空成功!" : "清空失败，请重试");
        }
        //清空回收站
        private void skinButton4_Click(object sender, EventArgs e)
        {
            RoleBLL bll = new RoleBLL();
            CCWin.MessageBoxEx.Show(bll.DeleteAllDeletedRoles() ? "清空成功!" : "清空失败，请重试");
        }

        //根据角色Id查找
        private bool IsShowingDeletedRole = false;  //是否界面显示的是已删除的Role
        private void btnSearchRole1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchRole1.Text))
            {
                RoleBLL bll = new RoleBLL();
                dgvRole.DataSource = bll.GetRolesByRoleIdAndDelFlag(Convert.ToInt32(txtSearchRole1.Text), IsShowingDeletedRole ? 1 : 0);
            }
        }
        //根据角色Name查找
        private void btnSearchRole2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchRole2.Text))
            {
                RoleBLL bll = new RoleBLL();
                dgvRole.DataSource = bll.GetRolesByRoleNameAndDelFlag(txtSearchRole2.Text, IsShowingDeletedRole ? 1 : 0);
            }
        }

        //还原已删除的User
        private void btnRestoreUser_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvUser.SelectedRows.Count <= 0)
            {
                return;
            }
            //获取选中行 修改操作
            UserBLL bll = new UserBLL();
            SelfForm.Msbox.Show(bll.DeleteUserByUserId(Convert.ToInt32(dgvUser.SelectedRows[0].Cells["编号"].Value), frmMain.current_user.Id, 0) ? "还原成功!!!" : "该用户可能已被其它用户永久删除，请重试");  //还原已删除的User
            LoadAllUsersByDelFlag(1);   //刷新
        }
        //还原已删除的Role
        private void btnRestoreRole_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgvUser.SelectedRows.Count <= 0)
            {
                return;
            }
            //获取选中行 修改操作
            RoleBLL bll = new RoleBLL();
            SelfForm.Msbox.Show(bll.DeleteRoleByRoleId(Convert.ToInt32(dgvRole.SelectedRows[0].Cells["Role_id"].Value), frmMain.current_user.Id, 0) ? "还原成功!!!" : "该角色可能已被其它用户永久删除，请重试");  //还原
            LoadAllRolesByDelFlag(1);   //刷新
        }

        private void txtSearchRole1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchRole1.Text))
            {
                //搜索框为空，则加载全部
                LoadAllRolesByDelFlag(IsShowingDeletedRole ? 1 : 0);
            }
            else
            {
                btnSearchRole1_Click(sender, e);
            }
        }

        private void txtSearchRole2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchRole2.Text))
            {
                //搜索框为空，则加载全部
                LoadAllRolesByDelFlag(IsShowingDeletedRole ? 1 : 0);
            }
            else
            {
                btnSearchRole2_Click(sender, e);
            }
        }

        //改变显示的文本
        private void dgvRole_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //2-7
            if (e.ColumnIndex >= 2 && e.ColumnIndex <= 7)
            {
                e.Value = (int)e.Value == 1 ? "是" : "否";
            }
        }
    }
}
