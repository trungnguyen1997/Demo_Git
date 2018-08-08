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
    public partial class frmChia : Form
    {
        public frmChia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double kq = a / b;
            if(b == 0)
            {
                MessageBox.Show("Khong chia duoc ");

            }
            textBox3.Text = kq.ToString();
        }
    }
}
