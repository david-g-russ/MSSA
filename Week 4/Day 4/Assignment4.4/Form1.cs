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
    public partial class Form1 : Form
    {
        List<Coffee> coffeeList;
        List<Soda> sodaList;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grpBevDetails.BackColor = Color.FromArgb(200, grpBevDetails.BackColor);
            lblSodaGrid.BackColor = Color.FromArgb(200, lblSodaGrid.BackColor);
            lblCoffeeGrid.BackColor = Color.FromArgb(200, lblCoffeeGrid.BackColor);

            lblCoffeeGrid.Visible = false;
            lblSodaGrid.Visible = false;
            grdCoffee.Visible = false;
            grdSoda.Visible = false;
            txtCaffeineContent.Visible = false;
            lblCaffeineContent.Visible = false;
            cmbTemp.Visible = false;
            lblTemp.Visible = false;
            chkHighSugar.Visible = false;
            lblHasHighSugar.Visible = false;
            lblCoffeeGrid.Visible = false;
            lblSodaGrid.Visible = false;
            btnRemoveSoda.Visible = false;
            btnRemoveCoffee.Visible = false;

            cmbSize.DataSource = Enum.GetValues(typeof(Size));
            cmbTemp.DataSource = Enum.GetValues(typeof(Temp));

            coffeeList = new List<Coffee>();
            sodaList = new List<Soda>();
        }

        private void btnCreateCoffee_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtPrice.Text != String.Empty && txtPrice.Text != String.Empty && txtCalories.Text != String.Empty && txtCaffeineContent.Text != String.Empty && cmbTemp.Text != String.Empty)
            {
                coffeeList.Add(new Coffee()
                {
                    Name = txtName.Text,
                    Price = Double.Parse(txtPrice.Text),
                    Calories = Int32.Parse(txtCalories.Text),
                    Size = (Size)cmbSize.SelectedIndex,
                    CaffeineContent = Int32.Parse(txtCaffeineContent.Text),
                    Temp = (Temp)cmbTemp.SelectedIndex
                });
                MessageBox.Show($"New coffee \"{txtName.Text}\" successfully created.");
                grdCoffee.Visible = true;
                lblCoffeeGrid.Visible = true;
                btnRemoveCoffee.Visible = true;
                RefreshDataCoffee();
            }
            else if(txtCaffeineContent.Visible == false)
            {
                txtCaffeineContent.Visible = true;
                lblCaffeineContent.Visible = true;
                cmbTemp.Visible = true;
                lblTemp.Visible = true;
            }
            else
                MessageBox.Show($"Please ensure that you fill out all fields.");
        }



        private void RefreshDataCoffee()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCalories.Clear();
            txtCaffeineContent.Clear();
            txtCaffeineContent.Visible = false;
            lblCaffeineContent.Visible= false;
            cmbTemp.Visible = false;
            lblTemp.Visible= false;
            grdCoffee.DataSource = null;
            grdCoffee.DataSource = coffeeList;
        }

        private void btnCreateSoda_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtPrice.Text != String.Empty && txtPrice.Text != String.Empty && txtCalories.Text != String.Empty && chkHighSugar.Visible != false)
            {
                sodaList.Add(new Soda()
                {
                    Name = txtName.Text,
                    Price = Double.Parse(txtPrice.Text),
                    Calories = Int32.Parse(txtCalories.Text),
                    Size = (Size)cmbSize.SelectedIndex,
                    HasHighSugar = chkHighSugar.Checked
                });
                MessageBox.Show($"New soda \"{txtName.Text}\" successfully created.");
                grdSoda.Visible = true;
                lblSodaGrid.Visible = true;
                btnRemoveSoda.Visible = true;
                RefreshDataSoda();
            }
            else if (chkHighSugar.Visible == false)
            {
                lblHasHighSugar.Visible = true;
                chkHighSugar.Visible = true;
            }
            else
                MessageBox.Show($"Please ensure that you fill out all fields.");
        }
        private void RefreshDataSoda()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCalories.Clear();
            chkHighSugar.Checked = false;
            chkHighSugar.Visible = false;
            lblHasHighSugar.Visible = false;
            grdSoda.DataSource = null;
            grdSoda.DataSource = sodaList;
        }

        private void btnRemoveCoffee_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Coffee \"{grdCoffee.CurrentRow.Cells[2].Value}\" removed.");
            coffeeList.RemoveAt(grdCoffee.CurrentRow.Index);
            RefreshDataCoffee();
            if (coffeeList.Count == 0)
            {
                grdCoffee.Visible = false;
                lblCoffeeGrid.Visible = false;
                btnRemoveCoffee.Visible = false;
            }
        }

        private void btnRemoveSoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Soda \"{grdSoda.CurrentRow.Cells[2].Value}\" removed.");
            sodaList.RemoveAt(grdSoda.CurrentRow.Index);
            RefreshDataSoda();
            if (sodaList.Count == 0)
            {
                grdSoda.Visible = false;
                lblSodaGrid.Visible = false;
                btnRemoveSoda.Visible=false;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
