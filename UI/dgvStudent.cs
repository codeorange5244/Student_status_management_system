using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
    }
}
