using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
