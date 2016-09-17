using CCWin;
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
    public partial class frmMain : CCSkinMain
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //当前登录用户
        private User currentUser = new User();       

        private void btnAboutMe_MouseEnter(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.BackColor = Color.FromArgb(32, 191, 94);
        }

        private void btnAboutMe_MouseLeave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.BackColor = Color.Transparent;
        }
        //主窗体加载
        private void frmMain_Load(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            User u=bll.GetUserByUserName();
        }
    }
}
