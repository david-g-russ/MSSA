using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class fEmployee : Form
    {

        Dictionary<int, Employee> employees;

        public fEmployee()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTime.Now.Date - dateTimePicker1.Value).Days) / 365 < 18)
                MessageBox.Show("Troopers younger than 18 cannot be entered into the system.");
            else
            {
               txtAge.Text = (((DateTime.Now.Date - dateTimePicker1.Value).Days)/365).ToString(); 
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            fMenu f1 = new fMenu();
            f1.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Employee {grdEmployees.CurrentRow.Cells[1].Value} {grdEmployees.CurrentRow.Cells[2].Value} has been destro.... I mean removed.");
            employees.Remove((int)grdEmployees.CurrentRow.Cells[0].Value);
            RefreshData();
            if (employees.Count == 0)
            {
                grdEmployees.Visible = false;
                btnRemove.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != String.Empty && txtLName.Text != String.Empty && txtAddress.Text != String.Empty && txtPhone.Text != String.Empty && cmbDepartment.Text != String.Empty && txtAge.Text != String.Empty)
            {
                Employee emp = new Employee();
                emp.GenerateID();
                emp.FName = txtFName.Text;
                emp.LName = txtLName.Text;
                emp.Address = txtAddress.Text;
                emp.Phone = Int32.Parse(txtPhone.Text);
                emp.Department = (Department)cmbDepartment.SelectedIndex;
                emp.Age = Int32.Parse(txtAge.Text);
                emp.Dob = dateTimePicker1.Value;

                employees.Add(emp.ID, emp);
                MessageBox.Show($"New employee {txtFName.Text} {txtLName.Text} successfully created.");

                grdEmployees.Visible = true;
                btnRemove.Visible = true;
                RefreshData();
            }
            else
                MessageBox.Show($"Please ensure that you fill out all fields.");
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            grpEmployeeDetails.BackColor = Color.FromArgb(200, grpEmployeeDetails.BackColor);

            grdEmployees.Visible = false;
            btnRemove.Visible = false;
            txtAge.ReadOnly = true;

            cmbDepartment.DataSource = Enum.GetValues(typeof(Department));

            employees = new Dictionary<int, Employee>();
        }

        private void RefreshData()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtAge.Clear();
            grdEmployees.DataSource = null;
            grdEmployees.DataSource = employees.Values.ToList();
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length > 100)
            {
                txtAddress.Clear();
                MessageBox.Show("Too many characters entered, max allowed length: 100");
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtPhone.Text.Trim(), out int phone) && txtPhone.Text.Length == 9)
            {
                txtPhone.Text = phone.ToString();
            }
            else
            {
                txtPhone.Clear();
                MessageBox.Show("Invalid phone number, please enter 9-digit number with no dash.");
            }
        }
    }
}