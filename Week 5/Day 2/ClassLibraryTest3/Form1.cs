using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTest2;

namespace ClassLibraryTest3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            Espresso espresso = new Espresso();
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox1.Text == "1111")
                {
                    MessageBox.Show("Valid card");
                }
                else
                {
                    throw new LoyaltyCardNotFound();
                }
            }
            catch (LoyaltyCardNotFound ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
                e.Cancel = true;
            }
        }
    }
}