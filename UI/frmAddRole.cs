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
    public partial class frmAddRole : Form
    {
        public frmAddRole()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            //判断验证码
            if (skinCode1.CodeStr.ToLower() != txtCode.Text.ToLower())
            {
                SelfForm.Msbox.Show("验证码不正确");
                return;
            }
            //建立Role对象
            Role model = new Role();
            model.Name = txtName.Text.Trim();
            model.Submitter_id = frmMain.current_user.Id;
            model.Remark = txtRemark.Text;
            //根据反射设置role的权限
            Type type = model.GetType();
            foreach(var permission in cklbPermission.CheckedItems)
            {                
                type.GetProperty(permission.ToString()).SetValue(model, 1, null);
            }
            RoleBLL bll = new RoleBLL();
            SelfForm.Msbox.Show(bll.AddRole(model) ? "添加成功" : "添加失败请重试");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmAddRole_Load(object sender, EventArgs e)
        {
            txtName.ImeMode = ImeMode.Inherit;
            //从Role类属性中加载所有角色权限
            LoadRoleAllPermission();
        }

        //从Role类属性中加载所有角色权限
        private void LoadRoleAllPermission()
        {
            Role model = new Role();    
            Type type = model.GetType();  
            System.Reflection.PropertyInfo[] propertys = type.GetProperties();  //反射得到Role类的public属性
            List<string> list = new List<string>();
            foreach (var property in propertys)
            {
                if (property.Name.Length > 7&& property.Name.Substring(property.Name.Length - 7, 7)=="_manage")
                {
                    //根据权限名创建CheckBox
                    cklbPermission.Items.Add(property.Name);
                }
            }
        }
    }
}
