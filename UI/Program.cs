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
            frmMain.current_user = new Model.User()
            {
                Role_id = 4,
                Name = "零号芯片",
                Pwd = "admin",
                Remark = "拥有所有操作权限,开发时使用",
                Submitter_id = 0,
                DelFlag = 0,
                current_role = new Model.Role()
                {
                    Id = 4,
                    Class_manage = 1,
                    Course_manage = 1,
                    DelFlag = 0,
                    Name = "SuperAdmin",
                    Score_manage = 1,
                    Speciality_manage = 1,
                    Student_manage = 1,
                    Submitter_id = 0,
                    System_manage = 1,
                     Remark = "拥有所有操作权限,开发时使用"
                }
            };
            Application.Run(new frmMain());
            //}
        }
    }
}
