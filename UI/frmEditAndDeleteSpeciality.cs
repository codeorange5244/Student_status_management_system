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
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.UI
{
    public partial class frmEditAndDeleteSpeciality : Form
    {
        public frmEditAndDeleteSpeciality()
        {
            InitializeComponent();
        }

        private void EditAndDeleteSpeciality_Load(object sender, EventArgs e)
        {
            //加载学院
            LoadAllCollegeByDelFlag(0);
        }
        //加载学院
        private void LoadAllCollegeByDelFlag(int delFlag)
        {
            CollegeBLL bll = new CollegeBLL();
            cbCollege.DisplayMember = "Name";       //必须在DataSource前面
            cbCollege.ValueMember = "Id";           //必须在DataSource前面
            cbCollege.DataSource = bll.GetAllCollegeByDelFlag(delFlag);
        }
        //“学院”下拉框选择项更改
        private void cbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllSpecialityByDelFlagAndCollegeId(0, Convert.ToInt32(cbCollege.SelectedValue));
        }

        private void btnEditSpeciality_Click(object sender, EventArgs e)
        {
            if (dgvSepciality.SelectedRows.Count > 0)   //是否选中
            {
                Model.Speciality model = (Model.Speciality)dgvSepciality.SelectedRows[0].DataBoundItem;   //选中行转换为Model
                frmAddSpeciality frm = new frmAddSpeciality();
                frm.Text = "正在修改  " + model.Name + "   专业";
                frm.FormToEdit(model);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllSpecialityByDelFlagAndCollegeId(0, Convert.ToInt32(cbCollege.SelectedValue));  //刷新
                }
            }
        }
        //dgv加载专业信息
        private void LoadAllSpecialityByDelFlagAndCollegeId(int delFlag, int college_id)
        {
            BLL.SpecialityBLL bll = new SpecialityBLL();
            dgvSepciality.AutoGenerateColumns = false;  //禁止自动生成列
            dgvSepciality.DataSource = bll.GetAllSpecialityByDelFlag(delFlag, college_id);
        }


    }
}
