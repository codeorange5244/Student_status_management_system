using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.UI
{
    public partial class dgvStudent : UserControl
    {
        public dgvStudent()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            skinDataGridView1.AutoGenerateColumns = false;
        }

        private void dgvStudent_Load(object sender, EventArgs e)
        {
            //右键菜单
            ContextMenuStrip menu = new ContextMenuStrip();
            //“添加新生”选项
            menu.Items.Add("添加新生", Properties.Resources.student2, new EventHandler((a, b) =>
            {
                Student model = new Student();
                //反射得到“专业Id”
                var obj = this.Parent.Parent.Parent;  //该自定义控件加载在ClassInfo的TabPage中，而TabPage在TabControls中,而TabControls在frmStudent中
                Type type = obj.GetType();
                var field = type.GetField("speciality_id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                model.Speciality_id = (int)field.GetValue(obj); //得到专业Id
                //由父控件得到”班级Id“           
                model.Class_id = (int)this.Parent.Tag; //得到班级Id，父容器是tbClassInfo
                frmAddStudent frm = new frmAddStudent(model);
                frm.ShowDialog();
            }));
            //菜单加入datagridview
            skinDataGridView1.ContextMenuStrip = menu;
        }
    }
}
