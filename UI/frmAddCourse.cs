using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentStatusManageSystem.BLL;
using CCWin;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.UI
{
    public partial class frmAddCourse : CCSkinMain
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            //160, 30
            txtCourseName.AutoSize = false;
            txtRoomName.AutoSize = false;
            txtSemester.AutoSize = false;
            txtCourseName.Size = new Size(160, 30);
            txtRoomName.Size = new Size(160, 30);
            txtSemester.Size = new Size(160, 30);

            //加载专业
            SpecialityBLL bll = new SpecialityBLL();
            Dictionary<int, string> dictionary = bll.GetAllspecialityIdAndNameByDelFlag(0);
            cbSpeciality.DataSource = dictionary.ToList();
            cbSpeciality.DisplayMember = "Value";
            cbSpeciality.ValueMember = "Key";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("确认开设此课程吗？请注意填写信息", "提示~", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }
            CourseBLL bll = new CourseBLL();
            Course model = new Course();    //建立数据对象
            model.Name = txtCourseName.Text.Trim();
            model.Room_name = txtRoomName.Text.Trim();
            model.Semester = txtSemester.Text;
            model.Speciality_id =(int) cbSpeciality.SelectedValue;
            model.Submitter_id = frmMain.current_user.Id;

            if (bll.AddCourse(model))
            {
                MessageBoxEx.Show("添加成功！！！");
                btnCancel_Click(sender, e); //关闭窗口
            }
            else
            {
                MessageBoxEx.Show("添加失败，请检查信息后重试");
            }
        }
    }
}
