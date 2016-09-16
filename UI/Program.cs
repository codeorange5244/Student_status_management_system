using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStatusManageSystem.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin form_login = new frmLogin();
            //if (form_login.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new frmMain());
            //}
        }
    }
}
