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
    public partial class frmAddStudent : CCSkinMain
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }
        public frmAddStudent(Student model) : this()
        {
            this.student = model;
        }
        private Student student;      //存着专业和班级的Id

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            //班级、专业下拉框赋值
            SpecialityBLL bll_speciality = new SpecialityBLL();
            ClassInfoBLL bll_classinfo = new ClassInfoBLL();
            cbClassInfo.Tag = bll_classinfo.GetClassInfoByClassInfoId(student.Class_id);
            cbClassInfo.Text = ((ClassInfo)cbClassInfo.Tag).Name;
                        
            cbSpeciality.Tag = bll_speciality.GetSpecialityBySpecialityId(student.Speciality_id); 
            cbSpeciality.Text=((Speciality)cbSpeciality.Tag).Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsLegal())
            {
                //取值
                Student model = new Student();
                model.Class_id = student.Class_id;
                model.Speciality_id = student.Speciality_id;
                model.Name = txtName.Text.Trim();
                model.ID_Card = txtIDCard.Text.Trim();
                model.Sex = cbSex.SelectedIndex;
                model.Nationality = txtNationality.Text.Trim();
                model.Address = txtAddress.Text.Trim();
                model.Phone = txtPhone.Text.Trim();
                model.Political_role = txtPolitical_role.Text.Trim();
                model.Posecode = txtPosecode.Text.Trim();
                model.Remark = txtRemark.Text;
                model.Submitter_id = frmMain.current_user.Id;
               // model.Photograph = null;
                //添加的数据库
                StudentBLL bll = new StudentBLL();
                CCWin.MessageBoxEx.Show(bll.AddStudent(model) ? "录入成功！" : "录入失败，请检查数据后重试！");
            }
        }

        private bool IsLegal()
        {
            string msg = "";
            if (string.IsNullOrEmpty(txtName.Text))
            {
                msg += "姓名输入有误！\r\n";
            }
            if (msg == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg);
                return false;
            }
        }
    }
}
