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
        private SpecialityBLL bll = new SpecialityBLL();

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
            LoadAllSpecialityByDelFlagAndCollegeId();
        }

        private void btnEditSpeciality_Click(object sender, EventArgs e)
        {
            if (dgvSepciality.SelectedRows.Count > 0)   //是否选中
            {
                Model.Speciality model = (Model.Speciality)dgvSepciality.SelectedRows[0].DataBoundItem;   //选中行转换为Model
                frmAddSpeciality frm = new frmAddSpeciality();
                frm.Text = "正在修改  " + model.Name + "   专业";
                frm.FormToEdit(model);  //更改窗体用途
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllSpecialityByDelFlagAndCollegeId();  //刷新
                }
            }
        }
        /// <summary>
        /// 根据下拉框的”学院“加载”专业“
        /// </summary>
        private void LoadAllSpecialityByDelFlagAndCollegeId()
        {
            dgvSepciality.AutoGenerateColumns = false;  //禁止自动生成列
            if (dgvSepciality.SelectedRows.Count > 0)
            {
                dgvSepciality.SelectedRows[0].Selected = false; //取消第一行自动选中
            }
            dgvSepciality.DataSource = bll.GetAllSpecialityByDelFlagAndCollegeId(0, Convert.ToInt32(cbCollege.SelectedValue));
        }
        //删除
        private void btnDeleteSpeciality_Click(object sender, EventArgs e)
        {
            if (dgvSepciality.SelectedRows.Count > 0&&CCWin.MessageBoxEx.Show("是否删除 "+dgvSepciality.SelectedRows[0].Cells[1].Value.ToString()+"  ?\r\n删除后请注意属于该专业的学生的处理","警告",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                int Id = (int)dgvSepciality.SelectedRows[0].Cells[0].Value;    //选中行的model_Id
                if (bll.DeleteSpecialityBySpecialityId(Id, frmMain.current_user.Id, 1))  //判断删除成功与否
                {
                    MessageBox.Show("删除成功！！！");
                    LoadAllSpecialityByDelFlagAndCollegeId();
                }
                else
                {
                    CCWin.MessageBoxEx.Show("删除失败，该数据可能已被删除或服务器异常，请刷新后重试");
                }
            }
        }

        //搜索
        private void btnSearchSpeciality_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSpeciality.Text))
            {
                LoadAllSpecialityByDelFlagAndCollegeId();   //刷新
            }
            else
            {
                List<Speciality> model = bll.GetSpecialityBySpecialityNameIdAndDelFlag(txtSearchSpeciality.Text.Trim(), 0);
                dgvSepciality.DataSource = model;
            }
        }
        private void txtSearchSpeciality_TextChanged(object sender, EventArgs e)
        {
            btnSearchSpeciality_Click(sender, e);
        }
    }
}
