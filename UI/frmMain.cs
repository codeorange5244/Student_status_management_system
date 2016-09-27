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
using System.Configuration;
using System.Reflection;

namespace StudentStatusManageSystem.UI
{
    //  public delegate ClassInfo GMFUI(object sender);
    public partial class frmMain : CCSkinMain
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //当前登录用户
        public static User current_user;

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
            skinTabControl1.SelectedIndex = 6;  //初始化选中选项卡位 ”关于“
        }

        //然后声明API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SystemParametersInfo(int nAction, int nParam, ref int value, int ignore);
        // 这样就可以修改了这里我设置为1000毫秒
        //int value = 5;

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

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (current_user.current_role.System_manage != 1)
            {
                Msbox.Show("亲~ 没权限哦--");
                (sender as Control).Enabled = false;//关闭该控件
                return;
            }
            frmAddUser frm_add_user = new frmAddUser();
            frm_add_user.Show();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (current_user.current_role.System_manage != 1)
            {
                Msbox.Show("亲~ 没权限哦--");
                (sender as Control).Enabled = false;//关闭该控件
                return;
            }
            //显示
            frmAddRole frm_add_role = new frmAddRole();
            frm_add_role.Show();
        }

        private void btnAeroWallpaperChanger_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvanced_operations_Click(object sender, EventArgs e)
        {


            //显示
            frmAdvancedOperations frm = new frmAdvancedOperations();
            frm.Show();
        }

        //选择不同的选项卡
        private void skinTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (!(e.TabPage == null))
            //{

            switch (e.TabPage.Name)
            {
                case "tpSystemSetting": LoadSystemSetting(); break;
                case "tpSpecialitySetting": LoadSpecialitySetting(); break;
                case "tpClassInfoManage": LoadClassInfoManage(); break;
                case "tpStudentManage": LoadStudentManage(); break;
                case "tpCourseManage": LoadCourseManage(); break;
                case "tpScoreManage": LoadScoreManage(); break;
                case "tpAboutMe": LoadAboutMe(); break;
            }
            // }
        }
        //关于
        private void LoadAboutMe()
        {

        }
        //成绩管理
        private void LoadScoreManage()
        {

        }
        //课程管理
        private void LoadCourseManage()
        {

        }
        //学生管理
        private void LoadStudentManage()
        {

        }
        //班级信息管理
        private void LoadClassInfoManage()
        {
            //加载专业信息
            SpecialityBLL bll = new SpecialityBLL();
        }

        //专业设置
        private void LoadSpecialitySetting()
        {

        }

        //系统设置
        private void LoadSystemSetting()
        {
            if (current_user.current_role.System_manage != 1)
            {
                Msbox.Show("亲~ 没权限哦--");
            }
            else
            {
                btnAddUser.Visible = true;
                btnAddRole.Visible = true;
                btnAeroWallpaperChanger.Visible = true;
                btnAdvanced_operations.Visible = true;
            }
        }

        /// <summary>
        /// 根据用户输入界面的值得到“班级”对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        //private ClassInfo GetModelFormUI(object sender)
        //{
        //unsafe
        //{

        //Form this_form = (Form)sender;
        //ClassInfo model = new ClassInfo();
        //model.Name =this_form.txtClassInfoName.Text.Trim(); 
        //model.Room_name = this_form.txtRoomName.Text.Trim();
        //model.School_reform = this_form.txtSchollReform.Text.Trim();
        //model.Specility_id = Convert.ToInt32(this_form.cbClassInfoSpeciality.SelectedValue);
        //model.Headteacher = this_form.txtHeadTeacher.Text.Trim();
        //model.Enrolment_time = this_form.dtEnrolmentSchool.Value;
        //model.Submitter_id = frmMain.current_user.Id;
        //return model;
        //  }
        //}

        private void btnAddSpeciality_MouseEnter(object sender, EventArgs e)
        {
            ((SkinButton)sender).BaseColor = Color.FromArgb(9, 163, 220);
        }

        private void btnAddSpeciality_MouseLeave(object sender, EventArgs e)
        {
            ((SkinButton)sender).BaseColor = Color.Transparent;
        }

        private void picClearRecycleBin_Click(object sender, EventArgs e)
        {
            if (CCWin.MessageBoxEx.Show("确定要清空回收站吗？将会永久删除数据", "警告！！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SpecialityBLL bll = new SpecialityBLL();
                if (bll.DeleteAllDeletedSpeciality(frmMain.current_user.Id))
                {
                    CCWin.MessageBoxEx.Show("清空成功！！");
                }
                else
                {
                    CCWin.MessageBoxEx.Show("清空失败，请刷新后重试");
                }

            }
        }
        //查看学院
        private void btnCollege_Click(object sender, EventArgs e)
        {
            frmAddAndDeleteCollege frm = new frmAddAndDeleteCollege();
            frm.Show();
        }

        private void btnAddSpeciality_Click(object sender, EventArgs e)
        {
            frmAddSpeciality frm = new frmAddSpeciality();
            frm.Text = "新增专业";
            frm.Show();
        }

        private void btnSpeciality_Click(object sender, EventArgs e)
        {
            frmEditAndDeleteSpeciality frm = new frmEditAndDeleteSpeciality();
            frm.Show();
        }

        //专业回收站
        private void picSpecialityRecycleBin_Click(object sender, EventArgs e)
        {
            frmSpecialityRecycleBin frm = new frmSpecialityRecycleBin();
            frm.Show();
        }

        private void picClearRecycleBin_MouseEnter(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            pic.BackColor = Color.FromArgb(249, 252, 250);
            pic.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picClearRecycleBin_MouseLeave(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            pic.BackColor = Color.Transparent;
            pic.BorderStyle = BorderStyle.None;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DateTime time = DateTime.UtcNow;    //存时间            
        }
        //开设新班级
        private void btnClassInfo_Click(object sender, EventArgs e)
        {
            Action<string> delegate_y = new Action<string>(CheckRoomByRoomName);
            Func<object, ClassInfo> delegate_u = new Func<object, ClassInfo>(GetPrivateField);
            frmAddClassInfo frm = new frmAddClassInfo(delegate_y,delegate_u);
            frm.Show();
        }

        #region 效果设置

        #endregion
        //确认修改班级信息
        private void btnClassInfoOk_Click(object sender, EventArgs e)
        {
            //检查用户输入
            if (CheckTxt_classInfo())
            {
                if (CCWin.MessageBoxEx.Show("确认要新增该班级吗？请注意核对各项信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //取值生成 model对象
                    ClassInfo model = GetPrivateField(this);

                }
            }


          

            
        }    

        /// <summary>
        /// 两个窗体有相同的控件，利用反射取值建模model，共用一个该方法
        /// </summary>
        /// <param name="instance">需要从哪一个窗体取值</param>
        /// <returns>model</returns>
        public ClassInfo GetPrivateField(object instance)
        {
            ClassInfo model = new ClassInfo();  

            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;    //搜索的范围
            Type type = instance.GetType(); //获得窗体类型

            //得到6个控件
            FieldInfo txtClassInfoName = type.GetField("txtClassInfoName", flags);  //得到窗体上的控件
            FieldInfo cbClassInfoSpeciality = type.GetField("cbClassInfoSpeciality", flags);
            FieldInfo txtHeadTeacher = type.GetField("txtHeadTeacher", flags);
            FieldInfo txtRoomName = type.GetField("txtRoomName", flags);
            FieldInfo txtSchollReform = type.GetField("txtSchollReform", flags);
            FieldInfo dtEnrolmentSchool = type.GetField("dtEnrolmentSchool", flags);

            //赋值
            model.Name = (txtClassInfoName.GetValue(instance) as TextBox).Text.Trim();  //得到的控件强转、取值
            model.Specility_id = (int)(cbClassInfoSpeciality.GetValue(instance) as ComboBox).SelectedValue;
            model.Headteacher = (txtHeadTeacher.GetValue(instance) as TextBox).Text.Trim();
            model.Room_name = (txtRoomName.GetValue(instance) as TextBox).Text.Trim();
            model.School_reform = (txtSchollReform.GetValue(instance) as TextBox).Text.Trim();
            model.Enrolment_time = (dtEnrolmentSchool.GetValue(instance) as DateTimePicker).Value;

            model.Submitter_id = frmMain.current_user.Id;
            return model;   
        }

        //检查用户输入
        private bool CheckTxt_classInfo()
        {
            string msg = "";
            if (string.IsNullOrEmpty(txtClassInfoName.Text))
            {
                msg += "请输入班级名称\r\n";
            }
            if (string.IsNullOrEmpty(txtRoomName.Text))
            {
                msg += "请输入班级固定会议室地点\r\n";
            }
            if (msg == "")
            {
                return true;
            }
            else
            {
                CCWin.MessageBoxEx.Show(msg);
                return false;
            }
        }
        //校验是否存在 会议室
        private void lbCheckRoom_Click(object sender, EventArgs e)
        {
            CheckRoomByRoomName(txtRoomName.Text);
        }
        //根据会议室名检查存在性
        private void CheckRoomByRoomName(string name)
        {
            MessageBox.Show("检查会议室存在性");
        }
    }
}
