using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CCWin;

namespace StudentStatusManageSystem.UI
{
    public partial class frmLogin : CCSkinMain
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void labForgetPwd_Click(object sender, EventArgs e)
        {
            // CCWin.MessageBoxEx.Show("dd");
            //Msbox.Show("你点击了忘记密码");
        }
        //关闭
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            //Thread th = new Thread(new ThreadStart(yuan));
            //th.Start();       
        }
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录成功
            this.DialogResult = DialogResult.OK;

        }
    }
}
