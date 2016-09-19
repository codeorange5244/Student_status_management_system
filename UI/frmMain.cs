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
using SelfForm;

namespace StudentStatusManageSystem.UI
{
    public partial class frmMain : CCSkinMain
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //当前登录用户
        public static User current_user;
        private bool isPressDown = false;   //标识1：是否按下了0级的某个选项

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
            Opacity = 0.3;
            Controls.Clear();
            BackgroundImage = Properties.Resources.site;           

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            int biaozhi = 0;
            timer.Interval = 20;
            EventHandler eh0 = new EventHandler((a, b) =>
            {
                this.Size = new Size(this.Size.Width - 10, this.Size.Width - 10);
                this.Radius = this.Size.Width;
                if (this.Size.Width <= 200)
                {
                    timer.Enabled = false;
                    //后续操作，比如往右下角跑
                    e.Cancel = false;
                    this.FormClosing -= frmMain_FormClosing;
                    Application.Exit();
                }
            });

            EventHandler eh = new EventHandler((a, b) =>
            {
                if (this.Size.Width - this.Size.Height > 0)
                {
                    this.Size = new Size(this.Size.Width - 45, this.Size.Height);
                }
                else
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height - 45);
                }

                if (biaozhi == 0 && Math.Abs(this.Size.Width - this.Size.Height)<50) 
                {
                    this.Size = new Size(this.Size.Width, this.Size.Width); //长宽相等
                    timer.Tick += new EventHandler(eh0);
                    biaozhi++; //让此委托只进行3次空判断
                }
            });
            timer.Tick += new EventHandler(eh);
            timer.Enabled = true;
            e.Cancel = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (current_user.current_role.System_manage!=1)
            {
                Msbox.Show("亲~ 没权限哦--");
                (sender as Control).Enabled = false;//关闭该控件
                return;
            }
            frmAddUser frm_add_user = new frmAddUser();
            frm_add_user.Show();
        }
     
    }
}
