using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCong fc = new frmCong();
            fc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTru ft = new frmTru();
            ft.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhan fn = new frmNhan();
            fn.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChia fc = new frmChia();
            fc.Show();
        }
    }
}
