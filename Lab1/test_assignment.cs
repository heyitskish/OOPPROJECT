using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class test_assignment : Form
    {
        public test_assignment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void test_assignment_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;
        }
    }
}
