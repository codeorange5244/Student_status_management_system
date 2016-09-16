using CCWin;
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
    public partial class frmMain : CCSkinMain
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAboutMe_MouseEnter(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.BackColor = Color.FromArgb(32, 191, 94);
        }

        private void btnAboutMe_MouseLeave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.BackColor = Color.Transparent;
        }
    }
}
