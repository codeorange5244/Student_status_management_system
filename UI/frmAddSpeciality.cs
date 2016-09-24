using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.UI
{
    public partial class frmAddSpeciality : Form
    {
        public frmAddSpeciality()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSpeciality_Load(object sender, EventArgs e)
        {
            txtSpecialityName.AutoSize = false;
            txtSpecialityName.Size = new Size(182, 31); //调整文本框大小
            //加载学院
            LoadAllSpecialityByDelFlag(0);
        }
        //加载学院
        private void LoadAllSpecialityByDelFlag(int delFlag)
        {
            BLL.CollegeBLL bll = new BLL.CollegeBLL();
            var list=bll.GetAllCollegeByDelFlag(delFlag);
            cbCollege.DataSource = list;
            cbCollege.DisplayMember = "Name";
            cbCollege.ValueMember = "Id";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSpecialityName.Text))
            {
                BLL.SpecialityBLL bll = new BLL.SpecialityBLL();
                //取值
                Model.Speciality model = GetModelByUI();            
                //添加
                bool result = bll.AddSpeciality(model); 
                CCWin.MessageBoxEx.Show(result ? "添加成功!!" : "添加失败，可能该数据已存在或数据库访问异常，请重试!!");
                this.DialogResult = result ? DialogResult.OK : DialogResult.No; //设置窗体结果
                if (result)
                {
                    this.Close();   //如果添加成功则关闭窗体
                }                
            }
        }

        #region 该窗体用途：修改
        internal void FormToEdit(Speciality model)
        {
            //填值
            txtSpecialityName.Text = model.Name;
            txtRemark.Text = model.Remark;
            //卸载事件
            btnOk.Click -= this.btnOk_Click;
            //注册事件
            btnOk.Click += new EventHandler((a, b) =>
              {
                  BLL.SpecialityBLL bll = new BLL.SpecialityBLL();
                  //取值
                  Model.Speciality model_speciality = GetModelByUI();
                  model_speciality.Id = model.Id;  //传递model的Id
                  if (bll.UpdateSpecialityBySpecialityId(model))
                  {
                      CCWin.MessageBoxEx.Show("修改成功！！！");
                      this.DialogResult = DialogResult.OK;
                      this.Close();
                  }else
                  {
                      CCWin.MessageBoxEx.Show("修改失败，该数据可能已被损坏或服务器连接中断，请刷新后重试！");
                  }
              });
        }
        /// <summary>
        /// 从界面取得值，用来填充Model.Speciality
        /// </summary>
        /// <returns></returns>
        private Speciality GetModelByUI()
        {
            Model.Speciality model_speciality = new Model.Speciality();
            model_speciality.Name = txtSpecialityName.Text.Trim();
            model_speciality.College_id = (int)cbCollege.SelectedValue;
            model_speciality.Remark = txtRemark.Text;
            model_speciality.Submitter_id = frmMain.current_user.Id;
            return model_speciality;
        }
        #endregion
    }
}
