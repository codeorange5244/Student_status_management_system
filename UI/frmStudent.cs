using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.BLL;

namespace StudentStatusManageSystem.UI
{
    public partial class frmStudent : CCSkinMain
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        public frmStudent(int speciality_id) : this()
        {
            this.speciality_id = speciality_id;
        }
        private int speciality_id;

        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.Text = "加载数据中.....请稍等";
            //加载班级
            tbClassInfo.BeginInvoke(new Action(() =>
            {
                ClassInfoBLL bll = new ClassInfoBLL();
                Dictionary<int, string> dictionary = bll.GetAllClassInfoIdAndNameBySpecialityId(speciality_id);    //得到 “班级“ Id-Name键值对
                //建立tabpage
                foreach (int key in dictionary.Keys)
                {
                    TabPage tp = new TabPage(dictionary[key]);
                    tp.Tag = key;
                    tp.Controls.Add(new dgvStudent());  //添加Datagridview
                    tbClassInfo.TabPages.Add(tp);
                }
                tbClassInfo_Selecting(null, new TabControlCancelEventArgs(tbClassInfo.SelectedTab, tbClassInfo.SelectedIndex, false, TabControlAction.Selecting));  //手动调用一下选项卡改变事件
                this.Text = "数据已加载完毕";
            }));
        }
        //选择选项卡卡页时发生
        private void tbClassInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {            
            //从数据库加载学生数据
            CCWin.SkinControl.SkinDataGridView dgv = e.TabPage.Controls[0].Controls[0] as CCWin.SkinControl.SkinDataGridView;   //得到Datagridview
            StudentBLL bll = new StudentBLL();
            dgv.DataSource = bll.GetAllStudentByClassInfoId((int)e.TabPage.Tag);
        }
    }
}
