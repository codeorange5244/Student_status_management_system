using StudentStatusManageSystem.BLL;
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

        //加载所有登录用户根据删除标识 0----未删除，1----已删除
        private void LoadAllUsersByDelFlag(int delFlag)
        {
            UserBLL bll = new UserBLL();
            dgvUser.DataSource = bll.GetAllUsersByDelFlag(delFlag);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchUser2_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
