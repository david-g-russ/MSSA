using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment4._3
{
    public partial class Form1 : Form
    {
        ArrayList studentList;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList = new ArrayList();
            cmbGradeLvl.DataSource = Enum.GetValues(typeof(GradeLevel));
            cmbGrade.DataSource = Enum.GetValues(typeof(Grade));
            cmbMonthAdm.DataSource = Enum.GetValues(typeof(MonthAdm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (txtFName.Text != String.Empty && txtLName.Text != String.Empty && txtAddr.Text != String.Empty)
            {
                studentList.Add(new Student()
                {
                    StudentId = rnd.Next(100000000, 999999999),
                    FName = txtFName.Text,
                    LName = txtLName.Text,
                    Address = txtAddr.Text,
                    GradeLevel = (GradeLevel)cmbGradeLvl.SelectedIndex,
                    Grade = (Grade)cmbGrade.SelectedIndex,
                    MonthAdm = (MonthAdm)cmbMonthAdm.SelectedIndex
                });
                MessageBox.Show($"New student {txtFName.Text} {txtLName.Text} successfully created.");
                RefreshData();
            }
            else
                MessageBox.Show($"Please ensure that you fill out all fields");
        }

        private void RefreshData()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAddr.Clear();
            studGrid.DataSource = null;
            studGrid.DataSource = studentList;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDateAdm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(GenComment((Grade)cmbGrade.SelectedIndex, txtFName.Text));
        }

        private string GenComment(Grade grade, string fname)
        {
            switch(grade)
            {
                case Grade.APlus:
                    return $"Awesome, {fname}!";
                case Grade.A:
                    return "Great work as always!";
                case Grade.AMinus:
                    return $"Great work {fname}!";
                case Grade.BPlus:
                    return "Great work!";
                case Grade.B:
                    return "Great work";
                case Grade.BMinus:
                    return "Great work..";
                case Grade.CPlus:
                    return "Good job!";
                case Grade.C:
                    return "Good job";
                case Grade.CMinus:
                    return "Good job..";
                case Grade.DPlus:
                    return "Okay job";
                case Grade.D:
                    return "Okay job..";
                case Grade.DMinus:
                    return $"{fname}, see me 1X1..";
                case Grade.F:
                    return "You disappoint me..";
                default: return null;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbGradeLvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void studGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studGrid.Refresh();
        }

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != String.Empty && txtLName.Text != String.Empty && txtAddr.Text != String.Empty)
            {
                studentList[studGrid.CurrentRow.Index] = new Student
                {
                    StudentId = Int32.Parse(studGrid.CurrentRow.Cells[0].Value.ToString()),
                    FName = txtFName.Text,
                    LName = txtLName.Text,
                    Address = txtAddr.Text,
                    GradeLevel = (GradeLevel)cmbGradeLvl.SelectedIndex,
                    Grade = (Grade)cmbGrade.SelectedIndex,
                    MonthAdm = (MonthAdm)cmbMonthAdm.SelectedIndex
                };
                MessageBox.Show($"Student {txtFName.Text} {txtLName.Text} successfully edited.");
                RefreshData();
            }
            else
                MessageBox.Show($"Please ensure that you fill out all fields");
        }

        private void btnRemStud_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Student {studGrid.CurrentRow.Cells[1].Value.ToString() + " " + studGrid.CurrentRow.Cells[2].Value.ToString()} deleted.");
            studentList.RemoveAt(studGrid.CurrentRow.Index);
            RefreshData();
        }
    }
}
