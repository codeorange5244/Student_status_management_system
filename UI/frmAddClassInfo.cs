using StudentStatusManageSystem.BLL;
using StudentStatusManageSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStatusManageSystem.UI
{
    public partial class frmAddClassInfo : CCWin.CCSkinMain
    {  
        public frmAddClassInfo()
        {
            InitializeComponent();
        } 

        public frmAddClassInfo(Action<string> delegate_y, Func<object, ClassInfo> delegate_u) : this()
        {
            this.delegate_y = delegate_y;
            this.delegate_u = delegate_u;
        }

        /// <summary>
        /// 检查是否存在会议室
        /// </summary>
        private Action<string> delegate_y;
        /// <summary>
        /// 取值->生成model_ClassInfo
        /// </summary>
        private Func<object, ClassInfo> delegate_u;

        private void frmAddClassInfo_Load(object sender, EventArgs e)
        {
            
            ///145, 31
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.AutoSize = false;
                    ctl.Size = new Size(145, 31);
                }
            }
            ///加载所有专业
            LoadAllSpecialityByDelFlag();            
        }

        private void LoadAllSpecialityByDelFlag()
        {
            SpecialityBLL bll = new SpecialityBLL();

            cbClassInfoSpeciality.DataSource = bll.GetAllspecialityIdAndNameByDelFlag(0).ToList();
            cbClassInfoSpeciality.DisplayMember = "Value";
            cbClassInfoSpeciality.ValueMember = "Key";

          //  cbClassInfoSpeciality.DataSource = bll.GetAllSpecialityByDelFlag(0);
            //cbClassInfoSpeciality.DisplayMember = "Name";
            //cbClassInfoSpeciality.ValueMember = "Id";            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //检查用户输入
            if (CheckTxt())
            {
                if (CCWin.MessageBoxEx.Show("确认要新增该班级吗？请注意核对各项信息", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //取值生成 model对象
                    ClassInfo model = delegate_u(this);
                    ClassInfoBLL bll = new ClassInfoBLL();
                    if(bll.AddClassInfo(model))
                    {
                        CCWin.MessageBoxEx.Show("添加  " + model.Name + "  班级成功！");
                        this.Dispose();
                    }else
                    {
                        CCWin.MessageBoxEx.Show("添加失败，请检查数据后重试");
                    }
                }
            }
        }

        private bool CheckTxt()
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
        //检查是否存在会议室
        private void lbCheckRoom_Click(object sender, EventArgs e)
        {
            delegate_y(txtClassInfoName.Text);
        }
    }
}
