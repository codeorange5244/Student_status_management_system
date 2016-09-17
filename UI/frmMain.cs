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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
// 首先引用命名空间
using System.Runtime.InteropServices;

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
            User u = bll.GetUserByUserName();
        }
        //系统设置
        private void btnSystemSetting_Click(object sender, EventArgs e)
        {

        }
        //专业设置
        private void btnSpecialitySetting_Click(object sender, EventArgs e)
        {

        }
        //班级信息管理
        private void btnClassInfoManage_Click(object sender, EventArgs e)
        {

        }
        //学生信息管理
        private void btnStudentManage_Click(object sender, EventArgs e)
        {

        }
        //课程信息管理
        private void btnCourseManage_Click(object sender, EventArgs e)
        {

        }
        //成绩信息管理
        private void btnScoreManage_Click(object sender, EventArgs e)
        {

        }

        //然后声明API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SystemParametersInfo(int nAction, int nParam, ref int value, int ignore);
        // 这样就可以修改了这里我设置为1000毫秒
        int value = 5;

        private void btnAdvanced_operations_MouseEnter(object sender, EventArgs e)
        {
            //Button变大
            SkinButton current_button = sender as SkinButton;
            current_button.Size = new Size(current_button.Size.Width + 10, current_button.Size.Height + 10);
            current_button.Radius += 10;
        }

        private void btnAdvanced_operations_MouseLeave(object sender, EventArgs e)
        {
            //Button变小
            SkinButton current_button = sender as SkinButton;
            current_button.Size = new Size(current_button.Size.Width - 10, current_button.Size.Height - 10);
            current_button.Radius -= 10;
        }

        private void btnAdvanced_operations_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button_jump(sender);
            }
        }
        //Button弹弹弹
        private void Button_jump(object sender)
        {
            System.Windows.Forms.Timer timer_ = new System.Windows.Forms.Timer();
            int jump_height, jump_height_ing;  //标识：设置球总共需上升的高度
            jump_height_ing = jump_height = 165;
            bool isJump = true; //指示球是否正在往上升
            int jump_numing = 0;   //指示球已经弹起几次
            int jump_num = 2;   //指示球总共需弹起几次
            timer_.Interval = 10;
            timer_.Tag = sender;    //把引发这个事件的球对象存入Tag中
            timer_.Enabled = true;  //启用

            timer_.Tick += new EventHandler(new EventHandler((a, b) =>  //注册事件
            {
                Button current_button = (a as System.Windows.Forms.Timer).Tag as Button;    //从Tag中得到触发该事件的球对象
                switch (isJump) //决定球是即将上升还是下降
                {
                    case true:
                        current_button.Location = new Point(current_button.Location.X, current_button.Location.Y - 2);  //球上升2
                        jump_height_ing -= 2;   //标识-2
                        if (jump_height_ing < 0)    //判断球是否达到指定高度
                        {
                            isJump = false;     //球即将下降
                        }
                        break;
                    case false:
                        current_button.Location = new Point(current_button.Location.X, current_button.Location.Y + 2);  //球下降2
                        jump_height_ing += 2;   //标识+2                     
                        if (jump_height_ing == jump_height)    //判断球是否下降的原来的位置
                        {
                            if ((++jump_numing) == jump_num)    //判断球是否已经弹起够了次数
                            {
                                timer_.Enabled = false; //关闭Timer
                            }
                            isJump = true;  //还原
                        }
                        break;
                }
            }
                ));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
           
        }
    }
}
